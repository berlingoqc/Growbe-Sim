namespace growbe_sim
{
    partial class SimTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbDef = new System.Windows.Forms.RadioButton();
            this.rbCur = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.lblThreadState = new System.Windows.Forms.Label();
            this.txtShowConnected = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbSTA = new System.Windows.Forms.RadioButton();
            this.rbAPDHCP = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMultiCon = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.cbTCP = new System.Windows.Forms.CheckBox();
            this.btnStartThread = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAuth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCanal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChangeIP = new System.Windows.Forms.Button();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.cbAP = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtSSID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(20, 32);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(32, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Port :";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(61, 29);
            this.txtPort.Name = "txtPort";
            this.txtPort.ReadOnly = true;
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(646, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 362);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valeur simulé";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblThreadState);
            this.groupBox2.Controls.Add(this.txtShowConnected);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnStartThread);
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtMAC);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblNom);
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Location = new System.Drawing.Point(22, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 362);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbDef);
            this.groupBox5.Controls.Add(this.rbCur);
            this.groupBox5.Location = new System.Drawing.Point(205, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(144, 76);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Changement Config";
            // 
            // rbDef
            // 
            this.rbDef.AutoSize = true;
            this.rbDef.Location = new System.Drawing.Point(23, 42);
            this.rbDef.Name = "rbDef";
            this.rbDef.Size = new System.Drawing.Size(46, 17);
            this.rbDef.TabIndex = 14;
            this.rbDef.TabStop = true;
            this.rbDef.Text = "DEF";
            this.rbDef.UseVisualStyleBackColor = true;
            this.rbDef.CheckedChanged += new System.EventHandler(this.rbCur_CheckedChanged);
            // 
            // rbCur
            // 
            this.rbCur.AutoSize = true;
            this.rbCur.Checked = true;
            this.rbCur.Location = new System.Drawing.Point(23, 21);
            this.rbCur.Name = "rbCur";
            this.rbCur.Size = new System.Drawing.Size(48, 17);
            this.rbCur.TabIndex = 13;
            this.rbCur.TabStop = true;
            this.rbCur.Text = "CUR";
            this.rbCur.UseVisualStyleBackColor = true;
            this.rbCur.CheckedChanged += new System.EventHandler(this.rbCur_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "États :";
            // 
            // lblThreadState
            // 
            this.lblThreadState.AutoSize = true;
            this.lblThreadState.ForeColor = System.Drawing.Color.Red;
            this.lblThreadState.Location = new System.Drawing.Point(423, 333);
            this.lblThreadState.Name = "lblThreadState";
            this.lblThreadState.Size = new System.Drawing.Size(38, 13);
            this.lblThreadState.TabIndex = 11;
            this.lblThreadState.Text = "Arrêter";
            // 
            // txtShowConnected
            // 
            this.txtShowConnected.Location = new System.Drawing.Point(366, 278);
            this.txtShowConnected.Name = "txtShowConnected";
            this.txtShowConnected.Size = new System.Drawing.Size(157, 23);
            this.txtShowConnected.TabIndex = 10;
            this.txtShowConnected.Text = "Afficher client connecté AP";
            this.txtShowConnected.UseVisualStyleBackColor = true;
            this.txtShowConnected.Click += new System.EventHandler(this.txtShowConnected_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.rbSTA);
            this.groupBox4.Controls.Add(this.rbAPDHCP);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cbMultiCon);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.numPort);
            this.groupBox4.Controls.Add(this.cbTCP);
            this.groupBox4.Location = new System.Drawing.Point(23, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 110);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serveur";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(177, 21);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(66, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "AP+STA";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.rbAP_CheckedChanged);
            // 
            // rbSTA
            // 
            this.rbSTA.AutoSize = true;
            this.rbSTA.Location = new System.Drawing.Point(125, 21);
            this.rbSTA.Name = "rbSTA";
            this.rbSTA.Size = new System.Drawing.Size(46, 17);
            this.rbSTA.TabIndex = 10;
            this.rbSTA.Text = "STA";
            this.rbSTA.UseVisualStyleBackColor = true;
            this.rbSTA.CheckedChanged += new System.EventHandler(this.rbAP_CheckedChanged);
            // 
            // rbAPDHCP
            // 
            this.rbAPDHCP.AutoSize = true;
            this.rbAPDHCP.Location = new System.Drawing.Point(80, 21);
            this.rbAPDHCP.Name = "rbAPDHCP";
            this.rbAPDHCP.Size = new System.Drawing.Size(39, 17);
            this.rbAPDHCP.TabIndex = 8;
            this.rbAPDHCP.Text = "AP";
            this.rbAPDHCP.UseVisualStyleBackColor = true;
            this.rbAPDHCP.CheckedChanged += new System.EventHandler(this.rbAP_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "DHCP";
            // 
            // cbMultiCon
            // 
            this.cbMultiCon.AutoSize = true;
            this.cbMultiCon.Location = new System.Drawing.Point(23, 77);
            this.cbMultiCon.Name = "cbMultiCon";
            this.cbMultiCon.Size = new System.Drawing.Size(105, 17);
            this.cbMultiCon.TabIndex = 4;
            this.cbMultiCon.Text = "Multi Connection";
            this.cbMultiCon.UseVisualStyleBackColor = true;
            this.cbMultiCon.CheckedChanged += new System.EventHandler(this.cbMultiCon_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Port :";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(160, 53);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(56, 20);
            this.numPort.TabIndex = 2;
            this.numPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // cbTCP
            // 
            this.cbTCP.AutoSize = true;
            this.cbTCP.Location = new System.Drawing.Point(23, 54);
            this.cbTCP.Name = "cbTCP";
            this.cbTCP.Size = new System.Drawing.Size(87, 17);
            this.cbTCP.TabIndex = 1;
            this.cbTCP.Text = "TCP Serveur";
            this.cbTCP.UseVisualStyleBackColor = true;
            this.cbTCP.CheckedChanged += new System.EventHandler(this.cbTCP_CheckedChanged);
            // 
            // btnStartThread
            // 
            this.btnStartThread.Location = new System.Drawing.Point(366, 307);
            this.btnStartThread.Name = "btnStartThread";
            this.btnStartThread.Size = new System.Drawing.Size(157, 23);
            this.btnStartThread.TabIndex = 10;
            this.btnStartThread.Text = "Démarrer Serveur";
            this.btnStartThread.UseVisualStyleBackColor = true;
            this.btnStartThread.Click += new System.EventHandler(this.btnStartThread_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(366, 246);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(157, 23);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "Restorer";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAuth);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtMask);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtGW);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCanal);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnChangeIP);
            this.groupBox3.Controls.Add(this.lblIP);
            this.groupBox3.Controls.Add(this.txtIP);
            this.groupBox3.Controls.Add(this.cbAP);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnAppliquer);
            this.groupBox3.Controls.Add(this.txtPW);
            this.groupBox3.Controls.Add(this.txtSSID);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(23, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 139);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode AP";
            // 
            // txtAuth
            // 
            this.txtAuth.Location = new System.Drawing.Point(286, 58);
            this.txtAuth.Name = "txtAuth";
            this.txtAuth.ReadOnly = true;
            this.txtAuth.Size = new System.Drawing.Size(83, 20);
            this.txtAuth.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mask :";
            // 
            // txtMask
            // 
            this.txtMask.Location = new System.Drawing.Point(413, 84);
            this.txtMask.Name = "txtMask";
            this.txtMask.ReadOnly = true;
            this.txtMask.Size = new System.Drawing.Size(100, 20);
            this.txtMask.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "GW :";
            // 
            // txtGW
            // 
            this.txtGW.Location = new System.Drawing.Point(413, 58);
            this.txtGW.Name = "txtGW";
            this.txtGW.ReadOnly = true;
            this.txtGW.Size = new System.Drawing.Size(100, 20);
            this.txtGW.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Auth :";
            // 
            // txtCanal
            // 
            this.txtCanal.Location = new System.Drawing.Point(286, 32);
            this.txtCanal.Name = "txtCanal";
            this.txtCanal.ReadOnly = true;
            this.txtCanal.Size = new System.Drawing.Size(83, 20);
            this.txtCanal.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Canal :";
            // 
            // btnChangeIP
            // 
            this.btnChangeIP.Location = new System.Drawing.Point(425, 110);
            this.btnChangeIP.Name = "btnChangeIP";
            this.btnChangeIP.Size = new System.Drawing.Size(75, 23);
            this.btnChangeIP.TabIndex = 12;
            this.btnChangeIP.Text = "Changer IP";
            this.btnChangeIP.UseVisualStyleBackColor = true;
            this.btnChangeIP.Click += new System.EventHandler(this.btnChangeIP_Click);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(384, 35);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(23, 13);
            this.lblIP.TabIndex = 11;
            this.lblIP.Text = "IP :";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(413, 32);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 9;
            // 
            // cbAP
            // 
            this.cbAP.AutoSize = true;
            this.cbAP.Location = new System.Drawing.Point(23, 34);
            this.cbAP.Name = "cbAP";
            this.cbAP.Size = new System.Drawing.Size(40, 17);
            this.cbAP.TabIndex = 0;
            this.cbAP.Text = "AP";
            this.cbAP.UseVisualStyleBackColor = true;
            this.cbAP.CheckedChanged += new System.EventHandler(this.cbAP_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SSID :";
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.Location = new System.Drawing.Point(89, 84);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(138, 23);
            this.btnAppliquer.TabIndex = 8;
            this.btnAppliquer.Text = "Appliquer";
            this.btnAppliquer.UseVisualStyleBackColor = true;
            this.btnAppliquer.Click += new System.EventHandler(this.btnAppliquer_Click);
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(123, 58);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(99, 20);
            this.txtPW.TabIndex = 7;
            this.txtPW.UseSystemPasswordChar = true;
            // 
            // txtSSID
            // 
            this.txtSSID.Location = new System.Drawing.Point(122, 31);
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.ReadOnly = true;
            this.txtSSID.Size = new System.Drawing.Size(100, 20);
            this.txtSSID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PW :";
            // 
            // txtMAC
            // 
            this.txtMAC.Location = new System.Drawing.Point(61, 60);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.ReadOnly = true;
            this.txtMAC.Size = new System.Drawing.Size(100, 20);
            this.txtMAC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAC :";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(22, 371);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(403, 207);
            this.txtLog.TabIndex = 4;
            // 
            // SimTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SimTab";
            this.Size = new System.Drawing.Size(1219, 595);
            this.Load += new System.EventHandler(this.SimTab_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnAppliquer;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSSID;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbAP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCanal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChangeIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGW;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.CheckBox cbTCP;
        private System.Windows.Forms.CheckBox cbMultiCon;
        private System.Windows.Forms.TextBox txtAuth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnStartThread;
        private System.Windows.Forms.Label lblThreadState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button txtShowConnected;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbDef;
        private System.Windows.Forms.RadioButton rbCur;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rbSTA;
        private System.Windows.Forms.RadioButton rbAPDHCP;
    }
}
