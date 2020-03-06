namespace compte_rendu
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.logo_gsb = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.bmtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bmtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.bConnection = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.labelInfo = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_gsb)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelLeft.Controls.Add(this.logo_gsb);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(424, 510);
            this.panelLeft.TabIndex = 0;
            // 
            // logo_gsb
            // 
            this.logo_gsb.Image = global::compte_rendu.Properties.Resources.logo_gsb;
            this.logo_gsb.Location = new System.Drawing.Point(53, 130);
            this.logo_gsb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo_gsb.Name = "logo_gsb";
            this.logo_gsb.Size = new System.Drawing.Size(305, 218);
            this.logo_gsb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_gsb.TabIndex = 1;
            this.logo_gsb.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelTitle.Location = new System.Drawing.Point(443, 52);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(104, 37);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Log in";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelUsername.Location = new System.Drawing.Point(445, 155);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(106, 23);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Identifiant";
            // 
            // bmtUsername
            // 
            this.bmtUsername.BackColor = System.Drawing.SystemColors.Control;
            this.bmtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmtUsername.HintForeColor = System.Drawing.Color.Transparent;
            this.bmtUsername.HintText = "";
            this.bmtUsername.isPassword = false;
            this.bmtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bmtUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bmtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bmtUsername.LineThickness = 3;
            this.bmtUsername.Location = new System.Drawing.Point(451, 172);
            this.bmtUsername.Margin = new System.Windows.Forms.Padding(5);
            this.bmtUsername.Name = "bmtUsername";
            this.bmtUsername.Size = new System.Drawing.Size(371, 44);
            this.bmtUsername.TabIndex = 3;
            this.bmtUsername.Text = "identifiant";
            this.bmtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bmtPassword
            // 
            this.bmtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.bmtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bmtPassword.HintText = "";
            this.bmtPassword.isPassword = true;
            this.bmtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bmtPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bmtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bmtPassword.LineThickness = 3;
            this.bmtPassword.Location = new System.Drawing.Point(451, 278);
            this.bmtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.bmtPassword.Name = "bmtPassword";
            this.bmtPassword.Size = new System.Drawing.Size(371, 44);
            this.bmtPassword.TabIndex = 5;
            this.bmtPassword.Text = "motdepasse";
            this.bmtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelPassword.Location = new System.Drawing.Point(445, 261);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(143, 23);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Mot de passe";
            // 
            // bConnection
            // 
            this.bConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConnection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConnection.ForeColor = System.Drawing.Color.White;
            this.bConnection.Location = new System.Drawing.Point(451, 411);
            this.bConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bConnection.Name = "bConnection";
            this.bConnection.Size = new System.Drawing.Size(371, 42);
            this.bConnection.TabIndex = 6;
            this.bConnection.Text = "Connexion";
            this.bConnection.UseVisualStyleBackColor = false;
            this.bConnection.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelLeft;
            this.bunifuDragControl1.Vertical = true;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.Red;
            this.labelInfo.Location = new System.Drawing.Point(451, 457);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(371, 42);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.Text = "Le couple identifiant / mot de passe\r\nest incorrecte.";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bClose
            // 
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(787, -2);
            this.bClose.Margin = new System.Windows.Forms.Padding(4);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(63, 66);
            this.bClose.TabIndex = 12;
            this.bClose.Text = "x";
            this.bClose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 510);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.bConnection);
            this.Controls.Add(this.bmtPassword);
            this.Controls.Add(this.bmtUsername);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion - Galaxy Swiss-Bourdin";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_gsb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox logo_gsb;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmtUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmtPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button bConnection;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button bClose;
    }
}

