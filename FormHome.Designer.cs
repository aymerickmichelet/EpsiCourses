namespace compte_rendu
{
    partial class FormHome
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.bDisconnection = new System.Windows.Forms.Button();
            this.bReadCR = new System.Windows.Forms.Button();
            this.bWriteCR = new System.Windows.Forms.Button();
            this.bProfile = new System.Windows.Forms.Button();
            this.logo_gsb = new System.Windows.Forms.PictureBox();
            this.panelSide = new System.Windows.Forms.Panel();
            this.bHome = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ucWriteCR = new compte_rendu.UCWriteCR();
            this.ucProfile = new compte_rendu.UCProfile();
            this.ucHome = new compte_rendu.UCHome();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_gsb)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelLeft.Controls.Add(this.bDisconnection);
            this.panelLeft.Controls.Add(this.bReadCR);
            this.panelLeft.Controls.Add(this.bWriteCR);
            this.panelLeft.Controls.Add(this.bProfile);
            this.panelLeft.Controls.Add(this.logo_gsb);
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.bHome);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(257, 706);
            this.panelLeft.TabIndex = 0;
            // 
            // bDisconnection
            // 
            this.bDisconnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bDisconnection.FlatAppearance.BorderSize = 0;
            this.bDisconnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDisconnection.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDisconnection.ForeColor = System.Drawing.Color.White;
            this.bDisconnection.Image = global::compte_rendu.Properties.Resources.icons8_alarme_de_porte_50;
            this.bDisconnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDisconnection.Location = new System.Drawing.Point(24, 629);
            this.bDisconnection.Name = "bDisconnection";
            this.bDisconnection.Size = new System.Drawing.Size(233, 65);
            this.bDisconnection.TabIndex = 11;
            this.bDisconnection.Text = "  Déconnexion";
            this.bDisconnection.UseVisualStyleBackColor = true;
            this.bDisconnection.Click += new System.EventHandler(this.bDisconnection_Click);
            // 
            // bReadCR
            // 
            this.bReadCR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bReadCR.FlatAppearance.BorderSize = 0;
            this.bReadCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReadCR.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReadCR.ForeColor = System.Drawing.Color.White;
            this.bReadCR.Image = global::compte_rendu.Properties.Resources.icons8_page_vue_d_ensemble_90;
            this.bReadCR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReadCR.Location = new System.Drawing.Point(24, 365);
            this.bReadCR.Name = "bReadCR";
            this.bReadCR.Size = new System.Drawing.Size(233, 65);
            this.bReadCR.TabIndex = 10;
            this.bReadCR.Text = "    Consultation compte-rendu";
            this.bReadCR.UseVisualStyleBackColor = true;
            this.bReadCR.Click += new System.EventHandler(this.bReadCR_Click);
            // 
            // bWriteCR
            // 
            this.bWriteCR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bWriteCR.FlatAppearance.BorderSize = 0;
            this.bWriteCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bWriteCR.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bWriteCR.ForeColor = System.Drawing.Color.White;
            this.bWriteCR.Image = global::compte_rendu.Properties.Resources.icons8_stylo_à_bille_100;
            this.bWriteCR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bWriteCR.Location = new System.Drawing.Point(24, 294);
            this.bWriteCR.Name = "bWriteCR";
            this.bWriteCR.Size = new System.Drawing.Size(233, 65);
            this.bWriteCR.TabIndex = 7;
            this.bWriteCR.Text = "                Saisie compte-rendu";
            this.bWriteCR.UseVisualStyleBackColor = true;
            this.bWriteCR.Click += new System.EventHandler(this.bWriteCR_Click);
            // 
            // bProfile
            // 
            this.bProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bProfile.FlatAppearance.BorderSize = 0;
            this.bProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProfile.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProfile.ForeColor = System.Drawing.Color.White;
            this.bProfile.Image = global::compte_rendu.Properties.Resources._25;
            this.bProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bProfile.Location = new System.Drawing.Point(24, 223);
            this.bProfile.Name = "bProfile";
            this.bProfile.Size = new System.Drawing.Size(233, 65);
            this.bProfile.TabIndex = 5;
            this.bProfile.Text = "                  Profil";
            this.bProfile.UseVisualStyleBackColor = true;
            this.bProfile.Click += new System.EventHandler(this.bProfile_Click);
            // 
            // logo_gsb
            // 
            this.logo_gsb.Image = global::compte_rendu.Properties.Resources.logo_gsb;
            this.logo_gsb.Location = new System.Drawing.Point(38, 28);
            this.logo_gsb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo_gsb.Name = "logo_gsb";
            this.logo_gsb.Size = new System.Drawing.Size(170, 99);
            this.logo_gsb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_gsb.TabIndex = 3;
            this.logo_gsb.TabStop = false;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.panelSide.Location = new System.Drawing.Point(-2, 152);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(14, 65);
            this.panelSide.TabIndex = 3;
            // 
            // bHome
            // 
            this.bHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bHome.FlatAppearance.BorderSize = 0;
            this.bHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHome.ForeColor = System.Drawing.Color.White;
            this.bHome.Image = global::compte_rendu.Properties.Resources.icons8_clinique_50;
            this.bHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bHome.Location = new System.Drawing.Point(24, 152);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(233, 65);
            this.bHome.TabIndex = 3;
            this.bHome.Text = "             Accueil";
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(257, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(953, 10);
            this.panelTop.TabIndex = 1;
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 25;
            this.bunifuElipse.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelLeft;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panelTop;
            this.bunifuDragControl2.Vertical = true;
            // 
            // ucWriteCR
            // 
            this.ucWriteCR.Location = new System.Drawing.Point(257, 12);
            this.ucWriteCR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucWriteCR.Name = "ucWriteCR";
            this.ucWriteCR.Size = new System.Drawing.Size(952, 695);
            this.ucWriteCR.TabIndex = 14;
            // 
            // ucProfile
            // 
            this.ucProfile.Location = new System.Drawing.Point(257, 12);
            this.ucProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucProfile.Name = "ucProfile";
            this.ucProfile.Size = new System.Drawing.Size(952, 695);
            this.ucProfile.TabIndex = 13;
            // 
            // ucHome
            // 
            this.ucHome.Location = new System.Drawing.Point(257, 11);
            this.ucHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucHome.Name = "ucHome";
            this.ucHome.Size = new System.Drawing.Size(952, 695);
            this.ucHome.TabIndex = 12;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 706);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.ucWriteCR);
            this.Controls.Add(this.ucProfile);
            this.Controls.Add(this.ucHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_gsb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox logo_gsb;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button bReadCR;
        private System.Windows.Forms.Button bWriteCR;
        private System.Windows.Forms.Button bProfile;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Button bDisconnection;
        private UCHome ucHome;
        private UCProfile ucProfile;
        private UCWriteCR ucWriteCR;
    }
}