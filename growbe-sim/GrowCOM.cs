using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace growbe_sim
{
    public enum CWMODE { AP=3,SoftAP=2}
    public enum AUTHAP { Open=0,WPA_PSK=2,WPA2_PSK=3,WPA_WPA2_PSK=4}
    public enum DHCPMode { AP=1,STA=2,AP_STA=3}
    public enum CONFIGMode { CUR=1,DEF=2}

    public class ReturnValue
    {
        public string Module { get; set; }
        public string Command { get; set; }
        public string Result { get; set; }
        public string[] Values { get; set; }
    }

    public class APNetworkAdresse
    {
        public string IPAdresse { get; set; }
        public string Mask { get; set; }
        public string Gateway { get; set; }

        public override string ToString()
        {
            return $"\"{IPAdresse}\",\"{Gateway}\",\"{Mask}\"";
        }
    }

    public class APNetwork
    {
        public string SSID { get; set; }
        public string Password { get; set; }
        public int Canal { get; set; }
        public AUTHAP AuthMode { get; set; }
        public APNetworkAdresse Network { get; set; }

        public APNetwork(string nom,string macaddr,string password)
        {
            SSID = $"{nom}-{String.Concat(macaddr.Split(':').Skip(3)).ToUpper()}";
            Password = password;
            Canal = 11;
            AuthMode = AUTHAP.WPA2_PSK;
        }

        public APNetwork(string str)
        {
            var split = str.Split(',');
            SSID = split[0].Trim('"');
            Password = split[1].Trim('"');
            Canal = Int32.Parse(split[2]);
            AuthMode = (AUTHAP)Int32.Parse(split[3]);
        }

        public override string ToString()
        {
            return $"\"{SSID}\",\"{Password}\",{Canal},{(int)AuthMode}";
        }
    }

    class GrowbeCOM
    {
        private SerialPortExample _com;
        
        public string COMport { get; set; }

        public string MacAdresse { get; set; }

        public CWMODE Mode { get; set; }

        public APNetwork ApNetwork { get; set; }

        public bool MuxEnable { get; set; }

        public int TcpEnable { get; set; }

        public DHCPMode DHCPMode { get; set; }

        public CONFIGMode ConfigMode { get; set; } = CONFIGMode.CUR;

        private TextBox _logbox;


        public GrowbeCOM(string com, int braudrate, TextBox logbox)
        {
            _logbox = logbox;
            COMport = com;
            _com = new SerialPortExample(COMport,"\r\n",2500);
            _com.Open();
            var ret = SendCommand("AT");
            // si la connection fonctionne
            if(ret.Result == "OK")
            {
                GetInfoData();
            }
        }

        public DHCPMode GetDHCPMode()
        {
            var r = SendCommand("AT+CWDHCP_CUR?");
            if (r.Result == "OK")
            {
                var i = Int32.Parse(r.Values[0].Split(':').Last());
                DHCPMode = (DHCPMode)i;
            }
            return DHCPMode;
        }

        public bool SetDHCPMode(DHCPMode mode)
        {
            var str = "";
            if (mode == DHCPMode.AP_STA)
                str = "2,1";
            else
                str = ((int)mode).ToString();
            var r = SendCommand($"AT+CWDHCP_{ConfigMode}={str}");
            if (r.Result == "OK")
            {
                DHCPMode = mode;
                return true;
            }
            return false;

        }

        public bool SetTcpServeur(bool state,int port)
        {
            var intv = state ? 1 : 0;
            var r = SendCommand($"AT+CIPSERVER={intv},{port}");
            if(r.Result == "OK")
            {
                TcpEnable = port;
                return true;
            }
            return false;
        }

        public bool SetApNetwork(APNetwork net)
        {
            var ret = SendCommand($"AT+CWSAP_{ConfigMode}={net.ToString()}");
            if(ret.Result == "OK")
            {
                return true;
            }
            return false;
        }
        public bool SetApNetworkAdresse(APNetworkAdresse adr)
        {
            var ret = SendCommand($"AT+CIPAP_{ConfigMode}="+adr.ToString());
            if(ret.Result == "OK")
            {
                ApNetwork.Network = adr;
                return true;
            }
            return false;
        }

        public void Restore()
        {
            // envoye la commande qui restore la flash du chip
            var r = _com.Send("AT+RESTORE",waitForResponse:false);
            Thread.Sleep(1000);
            GetInfoData();
        }

        public bool SetAPMode(CWMODE mode)
        {
            var ret = SendCommand($"AT+CWMODE_{ConfigMode}={(int)mode}");
            
            if (ret.Result == "OK")
            {
                this.Mode = mode;
                GetInfoData();
                return true;
            }
            return false;
        }
        public bool SetMutlCon(bool state)
        {
            var s = state ? 1 : 0;
            var r = SendCommand($"AT+CIPMUX={s}");
            if (r.Result == "OK")
            {
                MuxEnable = true;
            }
            return MuxEnable;
        }

        public Tuple<string,string>[] GetConnectedStations()
        {
            var r = SendCommand("AT+CWLIF");
            if(r.Result == "OK")
            {
                return r.Values.Select(x => {
                    var split = x.Split(',');
                    return  split.Length > 0 ? new Tuple<string, string>(split[0], split[1]) : null;
                }).Where(x=>x!=null).ToArray();
            }
            return null;
        }

        public APNetwork GetApNetork()
        {
            var r = SendCommand("AT+CWSAP_DEF?");
            var str = r.Values[0].Split(':').Last();
            return new APNetwork(str);
        }

        public APNetworkAdresse GetApNetworkAdresse()
        {
            var r = SendCommand("AT+CIPAP_CUR?");
            APNetworkAdresse ret = null;
            if (r.Result == "OK")
            {
                var splitstr = r.Values.SelectMany(x => x.Split(':')).Select(x=>x.Trim('"','"')).ToArray();
                ret = new APNetworkAdresse { IPAdresse = splitstr[2], Gateway = splitstr[5], Mask = splitstr[8] };
                ApNetwork.Network = ret;

            }
            return ret;
        }

        public CWMODE GetMode()
        {
            var r = SendCommand("AT+CWMODE_CUR?");
            return (CWMODE)Int32.Parse(r.Values[0].Split(':').Last());
        }
        public string GetMac()
        {
            var r = SendCommand("AT+CIPSTAMAC_CUR?");
            var strrep = r.Values[0].Split('"','"');
            return strrep[1];

        }

        private ReturnValue SendCommand(string cmd)
        {
            var r = _com.Send(cmd);
            var ret = ParseData(r);
            AddToLog(ret);
            return ret;

        }

        private ReturnValue ParseData(string data)
        {
            var strarray = data.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            ReturnValue v = new ReturnValue();
            v.Command = strarray[0];
            v.Result = strarray[strarray.Length - 1];
            v.Values = strarray.Skip(1).Take(strarray.Length - 2).ToArray();
            return v;
        }

        private void AddToLog(ReturnValue v)
        {
            _logbox.Text += $"Commande : {v.Command}" + Environment.NewLine;
            foreach (var i in v.Values)
                _logbox.Text += i + Environment.NewLine;
            _logbox.Text += $"Result : {v.Result}" + Environment.NewLine;
        }

        private void GetInfoData()
        {
            // get la MAC adresse et le nom du SSID en ce moment
            MacAdresse = GetMac();
            // regarde si le mode AP est Activer
            Mode = GetMode();
            if (Mode == CWMODE.AP)
            {
                ApNetwork = GetApNetork();
                ApNetwork.Network = GetApNetworkAdresse();
            }
            // regarde en qu'elle mode DHCP il est configurer
            DHCPMode = GetDHCPMode();

        }


        public void ThreadTCPServeur(SerialPort serialport)
        {

        }

    }
}
