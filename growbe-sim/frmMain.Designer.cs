namespace growbe_sim
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbAjout = new System.Windows.Forms.GroupBox();
            this.btnAddSim = new System.Windows.Forms.Button();
            this.lblBraud = new System.Windows.Forms.Label();
            this.cbBraud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCOM = new System.Windows.Forms.ComboBox();
            this.tabSim = new System.Windows.Forms.TabControl();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChip = new System.Windows.Forms.ComboBox();
            this.gbAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAjout
            // 
            this.gbAjout.Controls.Add(this.label2);
            this.gbAjout.Controls.Add(this.cbChip);
            this.gbAjout.Controls.Add(this.btnAddSim);
            this.gbAjout.Controls.Add(this.lblBraud);
            this.gbAjout.Controls.Add(this.cbBraud);
            this.gbAjout.Controls.Add(this.label1);
            this.gbAjout.Controls.Add(this.cbCOM);
            this.gbAjout.Location = new System.Drawing.Point(12, 12);
            this.gbAjout.Name = "gbAjout";
            this.gbAjout.Size = new System.Drawing.Size(743, 79);
            this.gbAjout.TabIndex = 1;
            this.gbAjout.TabStop = false;
            this.gbAjout.Text = "Ajout d\'un simulateur";
            // 
            // btnAddSim
            // 
            this.btnAddSim.Location = new System.Drawing.Point(639, 34);
            this.btnAddSim.Name = "btnAddSim";
            this.btnAddSim.Size = new System.Drawing.Size(75, 23);
            this.btnAddSim.TabIndex = 4;
            this.btnAddSim.Text = "Ajouter";
            this.btnAddSim.UseVisualStyleBackColor = true;
            this.btnAddSim.Click += new System.EventHandler(this.btnAddSim_Click);
            // 
            // lblBraud
            // 
            this.lblBraud.AutoSize = true;
            this.lblBraud.Location = new System.Drawing.Point(202, 39);
            this.lblBraud.Name = "lblBraud";
            this.lblBraud.Size = new System.Drawing.Size(61, 13);
            this.lblBraud.TabIndex = 3;
            this.lblBraud.Text = "Braud Rate";
            // 
            // cbBraud
            // 
            this.cbBraud.FormattingEnabled = true;
            this.cbBraud.Location = new System.Drawing.Point(269, 36);
            this.cbBraud.Name = "cbBraud";
            this.cbBraud.Size = new System.Drawing.Size(121, 21);
            this.cbBraud.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMs";
            // 
            // cbCOM
            // 
            this.cbCOM.FormattingEnabled = true;
            this.cbCOM.Location = new System.Drawing.Point(75, 36);
            this.cbCOM.Name = "cbCOM";
            this.cbCOM.Size = new System.Drawing.Size(121, 21);
            this.cbCOM.TabIndex = 0;
            // 
            // tabSim
            // 
            this.tabSim.Location = new System.Drawing.Point(13, 144);
            this.tabSim.Name = "tabSim";
            this.tabSim.SelectedIndex = 0;
            this.tabSim.Size = new System.Drawing.Size(1219, 629);
            this.tabSim.TabIndex = 2;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(36, 115);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer ";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(133, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear all";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chip Model";
            // 
            // cbChip
            // 
            this.cbChip.FormattingEnabled = true;
            this.cbChip.Location = new System.Drawing.Point(474, 36);
            this.cbChip.Name = "cbChip";
            this.cbChip.Size = new System.Drawing.Size(121, 21);
            this.cbChip.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 785);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.tabSim);
            this.Controls.Add(this.gbAjout);
            this.Name = "frmMain";
            this.Text = "Simulateur Growbe";
            this.gbAjout.ResumeLayout(false);
            this.gbAjout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAjout;
        private System.Windows.Forms.ComboBox cbCOM;
        private System.Windows.Forms.Button btnAddSim;
        private System.Windows.Forms.Label lblBraud;
        private System.Windows.Forms.ComboBox cbBraud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabSim;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChip;
    }
}

