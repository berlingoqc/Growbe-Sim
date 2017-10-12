using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace growbe_sim
{
    public partial class frmMain : Form
    {

        private static readonly string[] BraudRates = new[] { "115200" };
        private static readonly string[] Chips = new[] { "ESP8266" };


        public frmMain()
        {
            InitializeComponent();

            // get les serials ports disponible
            cbCOM.Items.AddRange(SerialPort.GetPortNames());
            cbBraud.Items.AddRange(BraudRates);
            cbChip.Items.AddRange(Chips);
            cbBraud.SelectedIndex = 0;
            cbChip.SelectedIndex = 0;
            if (cbCOM.Items.Count > 0)
            {
                cbCOM.SelectedIndex = 0;
                btnAddSim_Click(null, null);
            }
        }

        private void btnAddSim_Click(object sender, EventArgs e)
        {
            // valide qu'un COM est bien selectionner
            var text = cbCOM.SelectedItem.ToString();
            var braud = cbBraud.SelectedItem.ToString();
            if(String.IsNullOrEmpty(text) || String.IsNullOrEmpty(braud))
            {
                MessageBox.Show("Selectionner un COM et une vitesse avant d'ajouter à la simulation");
                return;
            }

            // assure qu'un tab n'existe pas deja pour ce COM
            foreach(TabPage i in tabSim.TabPages)
                if(i.Text == text)
                {
                    MessageBox.Show("Une simulation existe déjà pour ce COM!");
                    return;
                }


            // Crée un nouveau tab pour le COM
            TabPage tab = new TabPage(text);
            

            // déclaration de mon user control et ajout dans le tab
            SimTab simTab = new SimTab(text, Int32.Parse(braud));
            simTab.Dock = DockStyle.Fill;
            tab.Controls.Add(simTab);

            tabSim.TabPages.Add(tab);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // supprime le tab selectionner s'il en n'a un
            var tab = tabSim.SelectedTab;
            if (tab != null)
            {
                DialogResult res = MessageBox.Show($"Êtes vous sur de vouloir supprimer la simulation {tab.Text} ?",
                    "Attention !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    tabSim.TabPages.Remove(tab);
                    // dans le remove du tab il va falloir assurer que l'object com soit dispose
                }
            }
            else
                MessageBox.Show("Sélectionner un tab pour le supprimer");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
