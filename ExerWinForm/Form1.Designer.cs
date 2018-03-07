namespace ExerWinForm
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCartePhysique = new System.Windows.Forms.TabPage();
            this.textBoxInfos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabMachineLocale = new System.Windows.Forms.TabPage();
            this.groupBoxCommandesÀDistance = new System.Windows.Forms.GroupBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.textBoxEntreeAdresse = new System.Windows.Forms.TextBox();
            this.tabPageAutre = new System.Windows.Forms.TabPage();
            this.groupBoxInformations = new System.Windows.Forms.GroupBox();
            this.textBoxInfosCommandes = new System.Windows.Forms.TextBox();
            this.btnPingAsync = new System.Windows.Forms.Button();
            this.dumpRoute = new System.Windows.Forms.Button();
            this.btnTestFTP = new System.Windows.Forms.Button();
            this.btnTestHTTP = new System.Windows.Forms.Button();
            this.btnTraceRoute = new System.Windows.Forms.Button();
            this.btnTestDNS = new System.Windows.Forms.Button();
            this.btnTachePingAsync = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCartePhysique.SuspendLayout();
            this.tabMachineLocale.SuspendLayout();
            this.groupBoxCommandesÀDistance.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCartePhysique);
            this.tabControl1.Controls.Add(this.tabMachineLocale);
            this.tabControl1.Controls.Add(this.tabPageAutre);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 536);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCartePhysique
            // 
            this.tabCartePhysique.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.tabCartePhysique.Controls.Add(this.textBoxInfos);
            this.tabCartePhysique.Controls.Add(this.button1);
            this.tabCartePhysique.Location = new System.Drawing.Point(4, 25);
            this.tabCartePhysique.Name = "tabCartePhysique";
            this.tabCartePhysique.Padding = new System.Windows.Forms.Padding(3);
            this.tabCartePhysique.Size = new System.Drawing.Size(887, 507);
            this.tabCartePhysique.TabIndex = 0;
            this.tabCartePhysique.Text = "Carte Physique";
            this.tabCartePhysique.UseVisualStyleBackColor = true;
            // 
            // textBoxInfos
            // 
            this.textBoxInfos.Location = new System.Drawing.Point(7, 36);
            this.textBoxInfos.Multiline = true;
            this.textBoxInfos.Name = "textBoxInfos";
            this.textBoxInfos.ReadOnly = true;
            this.textBoxInfos.Size = new System.Drawing.Size(874, 452);
            this.textBoxInfos.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Obtenir Informations ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabMachineLocale
            // 
            this.tabMachineLocale.Controls.Add(this.groupBoxCommandesÀDistance);
            this.tabMachineLocale.Location = new System.Drawing.Point(4, 25);
            this.tabMachineLocale.Name = "tabMachineLocale";
            this.tabMachineLocale.Padding = new System.Windows.Forms.Padding(3);
            this.tabMachineLocale.Size = new System.Drawing.Size(887, 507);
            this.tabMachineLocale.TabIndex = 1;
            this.tabMachineLocale.Text = "Machine Locale";
            this.tabMachineLocale.UseVisualStyleBackColor = true;
            // 
            // groupBoxCommandesÀDistance
            // 
            this.groupBoxCommandesÀDistance.Controls.Add(this.btnTachePingAsync);
            this.groupBoxCommandesÀDistance.Controls.Add(this.btnTestDNS);
            this.groupBoxCommandesÀDistance.Controls.Add(this.btnTraceRoute);
            this.groupBoxCommandesÀDistance.Controls.Add(this.btnTestHTTP);
            this.groupBoxCommandesÀDistance.Controls.Add(this.btnTestFTP);
            this.groupBoxCommandesÀDistance.Controls.Add(this.dumpRoute);
            this.groupBoxCommandesÀDistance.Controls.Add(this.btnPingAsync);
            this.groupBoxCommandesÀDistance.Controls.Add(this.btnPing);
            this.groupBoxCommandesÀDistance.Controls.Add(this.textBoxInfosCommandes);
            this.groupBoxCommandesÀDistance.Controls.Add(this.textBoxEntreeAdresse);
            this.groupBoxCommandesÀDistance.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCommandesÀDistance.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCommandesÀDistance.Name = "groupBoxCommandesÀDistance";
            this.groupBoxCommandesÀDistance.Size = new System.Drawing.Size(881, 494);
            this.groupBoxCommandesÀDistance.TabIndex = 0;
            this.groupBoxCommandesÀDistance.TabStop = false;
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(6, 62);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(156, 26);
            this.btnPing.TabIndex = 0;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxEntreeAdresse
            // 
            this.textBoxEntreeAdresse.Location = new System.Drawing.Point(6, 32);
            this.textBoxEntreeAdresse.Name = "textBoxEntreeAdresse";
            this.textBoxEntreeAdresse.Size = new System.Drawing.Size(672, 22);
            this.textBoxEntreeAdresse.TabIndex = 1;
            // 
            // tabPageAutre
            // 
            this.tabPageAutre.Location = new System.Drawing.Point(4, 25);
            this.tabPageAutre.Name = "tabPageAutre";
            this.tabPageAutre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutre.Size = new System.Drawing.Size(887, 507);
            this.tabPageAutre.TabIndex = 2;
            this.tabPageAutre.Text = "Autres";
            this.tabPageAutre.UseVisualStyleBackColor = true;
            // 
            // groupBoxInformations
            // 
            this.groupBoxInformations.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxInformations.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInformations.Name = "groupBoxInformations";
            this.groupBoxInformations.Size = new System.Drawing.Size(919, 556);
            this.groupBoxInformations.TabIndex = 1;
            this.groupBoxInformations.TabStop = false;
            // 
            // textBoxInfosCommandes
            // 
            this.textBoxInfosCommandes.Location = new System.Drawing.Point(6, 127);
            this.textBoxInfosCommandes.Multiline = true;
            this.textBoxInfosCommandes.Name = "textBoxInfosCommandes";
            this.textBoxInfosCommandes.ReadOnly = true;
            this.textBoxInfosCommandes.Size = new System.Drawing.Size(869, 367);
            this.textBoxInfosCommandes.TabIndex = 1;
            // 
            // btnPingAsync
            // 
            this.btnPingAsync.Location = new System.Drawing.Point(168, 62);
            this.btnPingAsync.Name = "btnPingAsync";
            this.btnPingAsync.Size = new System.Drawing.Size(156, 26);
            this.btnPingAsync.TabIndex = 2;
            this.btnPingAsync.Text = "Ping Async";
            this.btnPingAsync.UseVisualStyleBackColor = true;
            this.btnPingAsync.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dumpRoute
            // 
            this.dumpRoute.Location = new System.Drawing.Point(492, 62);
            this.dumpRoute.Name = "dumpRoute";
            this.dumpRoute.Size = new System.Drawing.Size(156, 26);
            this.dumpRoute.TabIndex = 2;
            this.dumpRoute.Text = "Vider informations";
            this.dumpRoute.UseVisualStyleBackColor = true;
            this.dumpRoute.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnTestFTP
            // 
            this.btnTestFTP.Location = new System.Drawing.Point(6, 94);
            this.btnTestFTP.Name = "btnTestFTP";
            this.btnTestFTP.Size = new System.Drawing.Size(156, 26);
            this.btnTestFTP.TabIndex = 2;
            this.btnTestFTP.Text = "Test FTP";
            this.btnTestFTP.UseVisualStyleBackColor = true;
            this.btnTestFTP.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnTestHTTP
            // 
            this.btnTestHTTP.Location = new System.Drawing.Point(168, 94);
            this.btnTestHTTP.Name = "btnTestHTTP";
            this.btnTestHTTP.Size = new System.Drawing.Size(156, 26);
            this.btnTestHTTP.TabIndex = 2;
            this.btnTestHTTP.Text = "Test HTTP";
            this.btnTestHTTP.UseVisualStyleBackColor = true;
            this.btnTestHTTP.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnTraceRoute
            // 
            this.btnTraceRoute.Location = new System.Drawing.Point(330, 95);
            this.btnTraceRoute.Name = "btnTraceRoute";
            this.btnTraceRoute.Size = new System.Drawing.Size(156, 26);
            this.btnTraceRoute.TabIndex = 2;
            this.btnTraceRoute.Text = "Trace Route";
            this.btnTraceRoute.UseVisualStyleBackColor = true;
            this.btnTraceRoute.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnTestDNS
            // 
            this.btnTestDNS.Location = new System.Drawing.Point(492, 94);
            this.btnTestDNS.Name = "btnTestDNS";
            this.btnTestDNS.Size = new System.Drawing.Size(156, 26);
            this.btnTestDNS.TabIndex = 2;
            this.btnTestDNS.Text = "Test DNS";
            this.btnTestDNS.UseVisualStyleBackColor = true;
            this.btnTestDNS.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnTachePingAsync
            // 
            this.btnTachePingAsync.Location = new System.Drawing.Point(330, 62);
            this.btnTachePingAsync.Name = "btnTachePingAsync";
            this.btnTachePingAsync.Size = new System.Drawing.Size(156, 26);
            this.btnTachePingAsync.TabIndex = 2;
            this.btnTachePingAsync.Text = "Tâche Ping Async";
            this.btnTachePingAsync.UseVisualStyleBackColor = true;
            this.btnTachePingAsync.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 586);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBoxInformations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabCartePhysique.ResumeLayout(false);
            this.tabCartePhysique.PerformLayout();
            this.tabMachineLocale.ResumeLayout(false);
            this.groupBoxCommandesÀDistance.ResumeLayout(false);
            this.groupBoxCommandesÀDistance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCartePhysique;
        private System.Windows.Forms.TabPage tabMachineLocale;
        private System.Windows.Forms.TabPage tabPageAutre;
        private System.Windows.Forms.TextBox textBoxInfos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxCommandesÀDistance;
        private System.Windows.Forms.TextBox textBoxEntreeAdresse;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.GroupBox groupBoxInformations;
        private System.Windows.Forms.Button btnPingAsync;
        private System.Windows.Forms.TextBox textBoxInfosCommandes;
        private System.Windows.Forms.Button btnTachePingAsync;
        private System.Windows.Forms.Button btnTestDNS;
        private System.Windows.Forms.Button btnTraceRoute;
        private System.Windows.Forms.Button btnTestHTTP;
        private System.Windows.Forms.Button btnTestFTP;
        private System.Windows.Forms.Button dumpRoute;
    }
}

