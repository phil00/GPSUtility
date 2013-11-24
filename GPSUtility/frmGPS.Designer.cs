namespace GPSUtility
{
    partial class frmGPS
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
            this.components = new System.ComponentModel.Container();
            this.mnuOption = new System.Windows.Forms.MenuStrip();
            this.portsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vitesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.paritéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aucuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.octetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spGPS = new System.IO.Ports.SerialPort(this.components);
            this.txtRec = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.lblLong = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.mnuOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuOption
            // 
            this.mnuOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portsToolStripMenuItem,
            this.vitesseToolStripMenuItem,
            this.paritéToolStripMenuItem,
            this.arrêtToolStripMenuItem,
            this.octetToolStripMenuItem});
            this.mnuOption.Location = new System.Drawing.Point(0, 0);
            this.mnuOption.Name = "mnuOption";
            this.mnuOption.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuOption.Size = new System.Drawing.Size(789, 28);
            this.mnuOption.TabIndex = 1;
            this.mnuOption.Text = "menuStrip1";
            // 
            // portsToolStripMenuItem
            // 
            this.portsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOM1ToolStripMenuItem,
            this.cOM2ToolStripMenuItem,
            this.cOM3ToolStripMenuItem,
            this.cOM4ToolStripMenuItem});
            this.portsToolStripMenuItem.Name = "portsToolStripMenuItem";
            this.portsToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.portsToolStripMenuItem.Text = "Ports";
            // 
            // cOM1ToolStripMenuItem
            // 
            this.cOM1ToolStripMenuItem.Name = "cOM1ToolStripMenuItem";
            this.cOM1ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.cOM1ToolStripMenuItem.Text = "COM1";
            this.cOM1ToolStripMenuItem.Click += new System.EventHandler(this.cOM1ToolStripMenuItem_Click);
            // 
            // cOM2ToolStripMenuItem
            // 
            this.cOM2ToolStripMenuItem.Name = "cOM2ToolStripMenuItem";
            this.cOM2ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.cOM2ToolStripMenuItem.Text = "COM2";
            this.cOM2ToolStripMenuItem.Click += new System.EventHandler(this.cOM2ToolStripMenuItem_Click);
            // 
            // cOM3ToolStripMenuItem
            // 
            this.cOM3ToolStripMenuItem.Name = "cOM3ToolStripMenuItem";
            this.cOM3ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.cOM3ToolStripMenuItem.Text = "COM3";
            this.cOM3ToolStripMenuItem.Click += new System.EventHandler(this.cOM3ToolStripMenuItem_Click);
            // 
            // cOM4ToolStripMenuItem
            // 
            this.cOM4ToolStripMenuItem.Name = "cOM4ToolStripMenuItem";
            this.cOM4ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.cOM4ToolStripMenuItem.Text = "COM4";
            this.cOM4ToolStripMenuItem.Click += new System.EventHandler(this.cOM4ToolStripMenuItem_Click);
            // 
            // vitesseToolStripMenuItem
            // 
            this.vitesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem2,
            this.toolStripMenuItem7});
            this.vitesseToolStripMenuItem.Name = "vitesseToolStripMenuItem";
            this.vitesseToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.vitesseToolStripMenuItem.Text = "Vitesse";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 24);
            this.toolStripMenuItem3.Text = "150";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 24);
            this.toolStripMenuItem4.Text = "300";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 24);
            this.toolStripMenuItem5.Text = "600";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(152, 24);
            this.toolStripMenuItem6.Text = "1200";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 24);
            this.toolStripMenuItem2.Text = "9600";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(152, 24);
            this.toolStripMenuItem7.Text = "38400";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // paritéToolStripMenuItem
            // 
            this.paritéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aucuneToolStripMenuItem,
            this.pairToolStripMenuItem,
            this.impaireToolStripMenuItem});
            this.paritéToolStripMenuItem.Name = "paritéToolStripMenuItem";
            this.paritéToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.paritéToolStripMenuItem.Text = "Parité";
            this.paritéToolStripMenuItem.Click += new System.EventHandler(this.aucuneToolStripMenuItem_Click);
            // 
            // aucuneToolStripMenuItem
            // 
            this.aucuneToolStripMenuItem.Name = "aucuneToolStripMenuItem";
            this.aucuneToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.aucuneToolStripMenuItem.Text = "Aucune";
            // 
            // pairToolStripMenuItem
            // 
            this.pairToolStripMenuItem.Name = "pairToolStripMenuItem";
            this.pairToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.pairToolStripMenuItem.Text = "Pair";
            this.pairToolStripMenuItem.Click += new System.EventHandler(this.pairToolStripMenuItem_Click);
            // 
            // impaireToolStripMenuItem
            // 
            this.impaireToolStripMenuItem.Name = "impaireToolStripMenuItem";
            this.impaireToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.impaireToolStripMenuItem.Text = "Impaire";
            this.impaireToolStripMenuItem.Click += new System.EventHandler(this.impaireToolStripMenuItem_Click);
            // 
            // arrêtToolStripMenuItem
            // 
            this.arrêtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.arrêtToolStripMenuItem.Name = "arrêtToolStripMenuItem";
            this.arrêtToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.arrêtToolStripMenuItem.Text = "Arrêt";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(152, 24);
            this.toolStripMenuItem8.Text = "1 bits";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(152, 24);
            this.toolStripMenuItem9.Text = "2 bits";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // octetToolStripMenuItem
            // 
            this.octetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitsToolStripMenuItem,
            this.bitsToolStripMenuItem1});
            this.octetToolStripMenuItem.Name = "octetToolStripMenuItem";
            this.octetToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.octetToolStripMenuItem.Text = "Octet";
            // 
            // bitsToolStripMenuItem
            // 
            this.bitsToolStripMenuItem.Name = "bitsToolStripMenuItem";
            this.bitsToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.bitsToolStripMenuItem.Text = "7 bits";
            this.bitsToolStripMenuItem.Click += new System.EventHandler(this.bitsToolStripMenuItem_Click);
            // 
            // bitsToolStripMenuItem1
            // 
            this.bitsToolStripMenuItem1.Name = "bitsToolStripMenuItem1";
            this.bitsToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.bitsToolStripMenuItem1.Text = "8 bits";
            this.bitsToolStripMenuItem1.Click += new System.EventHandler(this.bitsToolStripMenuItem1_Click);
            // 
            // spGPS
            // 
            this.spGPS.BaudRate = 38400;
            this.spGPS.PortName = "COM3";
            this.spGPS.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spGPS_DataReceived);
            // 
            // txtRec
            // 
            this.txtRec.Location = new System.Drawing.Point(12, 31);
            this.txtRec.Multiline = true;
            this.txtRec.Name = "txtRec";
            this.txtRec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRec.Size = new System.Drawing.Size(765, 267);
            this.txtRec.TabIndex = 2;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(12, 304);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(117, 37);
            this.btnParse.TabIndex = 3;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(240, 311);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(537, 22);
            this.txtLong.TabIndex = 4;
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Location = new System.Drawing.Point(153, 314);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(71, 17);
            this.lblLong.TabIndex = 5;
            this.lblLong.Text = "Longitude";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Location = new System.Drawing.Point(153, 352);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(59, 17);
            this.lblLat.TabIndex = 6;
            this.lblLat.Text = "Latitude";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(240, 349);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(537, 22);
            this.txtLat.TabIndex = 7;
            // 
            // frmGPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 460);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.lblLong);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.txtRec);
            this.Controls.Add(this.mnuOption);
            this.Name = "frmGPS";
            this.Text = "GPS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGPS_FormClosing);
            this.mnuOption.ResumeLayout(false);
            this.mnuOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOption;
        private System.Windows.Forms.ToolStripMenuItem portsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vitesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem paritéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aucuneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrêtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem octetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitsToolStripMenuItem1;
        private System.IO.Ports.SerialPort spGPS;
        private System.Windows.Forms.TextBox txtRec;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.TextBox txtLat;
    }
}

