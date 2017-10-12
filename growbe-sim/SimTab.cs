using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace growbe_sim
{
    public partial class SimTab : UserControl
    {

        private GrowbeCOM _growbe;

        public SimTab(string conname, int braudrate)
        {
            InitializeComponent();

            _growbe = new GrowbeCOM(conname, braudrate,txtLog);

            SetTextBox();
            
        }

        private void SetTextBox()
        {
            txtPort.Text = _growbe.COMport;
            txtMAC.Text = _growbe.MacAdresse;
            if (_growbe.Mode == CWMODE.AP)
            {
                if(cbAP.Checked==false)
                    cbAP.Checked = true;
                txtCanal.Text = _growbe.ApNetwork.Canal.ToString();
                txtAuth.Text = _growbe.ApNetwork.AuthMode.ToString();
                txtSSID.Text = _growbe.ApNetwork.SSID;
                txtPW.Text = _growbe.ApNetwork.Password;
                txtIP.Text = _growbe.ApNetwork.Network.IPAdresse;
                txtMask.Text = _growbe.ApNetwork.Network.Mask;
                txtGW.Text = _growbe.ApNetwork.Network.Gateway;
                cbSTA.Checked = _growbe.DHCPMode == DHCPMode.STA || _growbe.DHCPMode == DHCPMode.STA;
                cbTCP.Checked = _growbe.TcpEnable > 0;
                numPort.Value = _growbe.TcpEnable;
                cbMultiCon.Checked = _growbe.MuxEnable;
            }
        }

        private void cbDHCP_CheckedChanged(object sender, EventArgs e)
        {
            var mode = DHCPMode.AP;
            if (!cbAP.Checked && cbSTA.Checked)
            {
                mode = DHCPMode.STA;
            }
            else if (cbAP.Checked && cbSTA.Checked)
            {
                mode = DHCPMode.AP_STA;
            }
            _growbe.SetDHCPMode(mode);

        }

        private void cbAP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAP.Checked)
            {
                _growbe.SetAPMode(CWMODE.AP);
                SetTextBox();
            }
            if (!cbAP.Checked && _growbe.Mode != CWMODE.SoftAP)
            {
                _growbe.SetAPMode(CWMODE.SoftAP);
                txtSSID.Clear();
                txtPW.Clear();
                txtIP.Clear();
                txtMask.Clear();
                txtGW.Clear();
                txtCanal.Clear();
                txtAuth.Clear();
                
            }
            
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Êtes vous sur de vouloir restorer la flash ?",
                    "Attention !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                _growbe.Restore();
                SetTextBox();
                txtLog.Clear();
            }
        }

        private void btnAppliquer_Click(object sender, EventArgs e)
        {
            if (cbAP.Checked)
            {
                var ret = new APNetwork(" GrowBe",_growbe.MacAdresse,txtPW.Text);
                if (_growbe.SetApNetwork(ret))
                {
                    MessageBox.Show("Changement effectué avec succès");
                    SetTextBox();
                }
            }
        }

        private void btnChangeIP_Click(object sender, EventArgs e)
        {
            var t = txtIP.Text;
            if (String.IsNullOrEmpty(t)) return;
            if (cbAP.Checked)
            {
                System.Net.IPAddress ip;
                if(System.Net.IPAddress.TryParse(t, out ip))
                {
                    if (_growbe.SetApNetworkAdresse(new APNetworkAdresse { IPAdresse = t, Gateway = t, Mask = "255.255.255.0" }))
                    {
                        MessageBox.Show("Adresse IP changé pour le mode AP !");
                        txtGW.Text = t;
                    }
                } 
            }
        }

        private void cbTCP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTCP.Checked && _growbe.TcpEnable == 0)
            {
                if(_growbe.SetTcpServeur((int)numPort.Value))
                {
                    MessageBox.Show($"Le serveur TCP est démarré à {_growbe.ApNetwork.Network.IPAdresse}:{numPort.Value} démarrer la thread de simulation pour commencé l'écoute !");
                }
            }
            else
            {

            }
        }

        private void cbMultiCon_CheckedChanged(object sender, EventArgs e)
        {
            _growbe.SetMutlCon(cbMultiCon.Checked);
        }

        private void SimTab_Load(object sender, EventArgs e)
        {

        }

        private void btnStartThread_Click(object sender, EventArgs e)
        {

        }

        private void txtShowConnected_Click(object sender, EventArgs e)
        {
            var s = _growbe.GetConnectedStations();
            if (s.Length == 0) return; 
            var msg = "";
            foreach (var i in s)
                msg += $"IP : {i.Item1} MAC : {i.Item2}" + Environment.NewLine;
            MessageBox.Show(msg, $"Stations Connecté : {s.Length}");
        }
    }
}
