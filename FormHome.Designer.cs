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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.bReadMedicament = new System.Windows.Forms.Button();
            this.bReadMedecin = new System.Windows.Forms.Button();
            this.bDisconnection = new System.Windows.Forms.Button();
            this.bReadCR = new System.Windows.Forms.Button();
            this.bWriteCR = new System.Windows.Forms.Button();
            this.bReadVisiteur = new System.Windows.Forms.Button();
            this.logo_gsb = new System.Windows.Forms.PictureBox();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.panelSideTopRight = new System.Windows.Forms.Panel();
            this.bTopRight = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_gsb)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelLeft.Controls.Add(this.bReadMedicament);
            this.panelLeft.Controls.Add(this.bReadMedecin);
            this.panelLeft.Controls.Add(this.bDisconnection);
            this.panelLeft.Controls.Add(this.bReadCR);
            this.panelLeft.Controls.Add(this.bWriteCR);
            this.panelLeft.Controls.Add(this.bReadVisiteur);
            this.panelLeft.Controls.Add(this.logo_gsb);
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(257, 706);
            this.panelLeft.TabIndex = 0;
            // 
            // bReadMedicament
            // 
            this.bReadMedicament.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bReadMedicament.FlatAppearance.BorderSize = 0;
            this.bReadMedicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReadMedicament.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReadMedicament.ForeColor = System.Drawing.Color.White;
            this.bReadMedicament.Image = ((System.Drawing.Image)(resources.GetObject("bReadMedicament.Image")));
            this.bReadMedicament.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReadMedicament.Location = new System.Drawing.Point(24, 365);
            this.bReadMedicament.Name = "bReadMedicament";
            this.bReadMedicament.Size = new System.Drawing.Size(233, 65);
            this.bReadMedicament.TabIndex = 13;
            this.bReadMedicament.Text = "        Consultation          Medicament";
            this.bReadMedicament.UseVisualStyleBackColor = true;
            this.bReadMedicament.Click += new System.EventHandler(this.bReadMedicament_Click);
            // 
            // bReadMedecin
            // 
            this.bReadMedecin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bReadMedecin.FlatAppearance.BorderSize = 0;
            this.bReadMedecin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReadMedecin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReadMedecin.ForeColor = System.Drawing.Color.White;
            this.bReadMedecin.Image = ((System.Drawing.Image)(resources.GetObject("bReadMedecin.Image")));
            this.bReadMedecin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReadMedecin.Location = new System.Drawing.Point(24, 294);
            this.bReadMedecin.Name = "bReadMedecin";
            this.bReadMedecin.Size = new System.Drawing.Size(233, 65);
            this.bReadMedecin.TabIndex = 12;
            this.bReadMedecin.Text = "        Consultation                Medecin";
            this.bReadMedecin.UseVisualStyleBackColor = true;
            this.bReadMedecin.Click += new System.EventHandler(this.bReadMedecin_Click);
            // 
            // bDisconnection
            // 
            this.bDisconnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bDisconnection.FlatAppearance.BorderSize = 0;
            this.bDisconnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDisconnection.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDisconnection.ForeColor = System.Drawing.Color.White;
            this.bDisconnection.Image = ((System.Drawing.Image)(resources.GetObject("bDisconnection.Image")));
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
            this.bReadCR.Image = ((System.Drawing.Image)(resources.GetObject("bReadCR.Image")));
            this.bReadCR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReadCR.Location = new System.Drawing.Point(24, 436);
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
            this.bWriteCR.Image = ((System.Drawing.Image)(resources.GetObject("bWriteCR.Image")));
            this.bWriteCR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bWriteCR.Location = new System.Drawing.Point(24, 152);
            this.bWriteCR.Name = "bWriteCR";
            this.bWriteCR.Size = new System.Drawing.Size(233, 65);
            this.bWriteCR.TabIndex = 7;
            this.bWriteCR.Text = "                Saisie compte-rendu";
            this.bWriteCR.UseVisualStyleBackColor = true;
            this.bWriteCR.Click += new System.EventHandler(this.bWriteCR_Click);
            // 
            // bReadVisiteur
            // 
            this.bReadVisiteur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bReadVisiteur.FlatAppearance.BorderSize = 0;
            this.bReadVisiteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReadVisiteur.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReadVisiteur.ForeColor = System.Drawing.Color.White;
            this.bReadVisiteur.Image = ((System.Drawing.Image)(resources.GetObject("bReadVisiteur.Image")));
            this.bReadVisiteur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReadVisiteur.Location = new System.Drawing.Point(24, 223);
            this.bReadVisiteur.Name = "bReadVisiteur";
            this.bReadVisiteur.Size = new System.Drawing.Size(233, 65);
            this.bReadVisiteur.TabIndex = 5;
            this.bReadVisiteur.Text = "        Consultation                  Visiteur";
            this.bReadVisiteur.UseVisualStyleBackColor = true;
            this.bReadVisiteur.Click += new System.EventHandler(this.bReadVisiteur_Click);
            // 
            // logo_gsb
            // 
            this.logo_gsb.ErrorImage = null;
            this.logo_gsb.Image = ((System.Drawing.Image)(resources.GetObject("logo_gsb.Image")));
            this.logo_gsb.InitialImage = null;
            this.logo_gsb.Location = new System.Drawing.Point(38, 28);
            this.logo_gsb.Margin = new System.Windows.Forms.Padding(2);
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
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.panelTop.Controls.Add(this.panelTopRight);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(257, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(953, 72);
            this.panelTop.TabIndex = 1;
            // 
            // panelTopRight
            // 
            this.panelTopRight.BackColor = System.Drawing.Color.Transparent;
            this.panelTopRight.Controls.Add(this.panelSideTopRight);
            this.panelTopRight.Controls.Add(this.bTopRight);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopRight.Location = new System.Drawing.Point(731, 0);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(222, 72);
            this.panelTopRight.TabIndex = 0;
            // 
            // panelSideTopRight
            // 
            this.panelSideTopRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelSideTopRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideTopRight.Location = new System.Drawing.Point(0, 0);
            this.panelSideTopRight.Name = "panelSideTopRight";
            this.panelSideTopRight.Size = new System.Drawing.Size(222, 15);
            this.panelSideTopRight.TabIndex = 4;
            // 
            // bTopRight
            // 
            this.bTopRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bTopRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bTopRight.FlatAppearance.BorderSize = 0;
            this.bTopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTopRight.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTopRight.ForeColor = System.Drawing.Color.White;
            this.bTopRight.Image = ((System.Drawing.Image)(resources.GetObject("bTopRight.Image")));
            this.bTopRight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bTopRight.Location = new System.Drawing.Point(0, 12);
            this.bTopRight.Name = "bTopRight";
            this.bTopRight.Size = new System.Drawing.Size(222, 60);
            this.bTopRight.TabIndex = 12;
            this.bTopRight.Text = "SOULIER Titouan";
            this.bTopRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTopRight.UseVisualStyleBackColor = true;
            this.bTopRight.Click += new System.EventHandler(this.buttonTopRight_Click);
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
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1210, 706);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_gsb)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox logo_gsb;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button bReadCR;
        private System.Windows.Forms.Button bWriteCR;
        private System.Windows.Forms.Button bReadVisiteur;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Button bDisconnection;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Panel panelSideTopRight;
        private System.Windows.Forms.Button bReadMedicament;
        private System.Windows.Forms.Button bReadMedecin;
        private System.Windows.Forms.Button bTopRight;
    }
}