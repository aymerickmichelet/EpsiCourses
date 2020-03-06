namespace compte_rendu
{
    partial class UCProfile
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.bunifuCards = new Bunifu.Framework.UI.BunifuCards();
            this.labelRegion = new System.Windows.Forms.Label();
            this.labelRegionText = new System.Windows.Forms.Label();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelBirthdayText = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelNameText = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelLastnameText = new System.Windows.Forms.Label();
            this.imgProfile = new System.Windows.Forms.PictureBox();
            this.bunifuCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.labelTitle.Location = new System.Drawing.Point(544, 31);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(147, 75);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Profil";
            // 
            // bunifuCards
            // 
            this.bunifuCards.AutoScroll = true;
            this.bunifuCards.BackColor = System.Drawing.Color.White;
            this.bunifuCards.BorderRadius = 5;
            this.bunifuCards.BottomSahddow = true;
            this.bunifuCards.color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.bunifuCards.Controls.Add(this.labelRegion);
            this.bunifuCards.Controls.Add(this.labelRegionText);
            this.bunifuCards.Controls.Add(this.labelStatusText);
            this.bunifuCards.Controls.Add(this.labelStatus);
            this.bunifuCards.Controls.Add(this.labelBirthdayText);
            this.bunifuCards.Controls.Add(this.labelBirthday);
            this.bunifuCards.Controls.Add(this.labelNameText);
            this.bunifuCards.Controls.Add(this.labelName);
            this.bunifuCards.Controls.Add(this.labelLastname);
            this.bunifuCards.Controls.Add(this.labelLastnameText);
            this.bunifuCards.Controls.Add(this.imgProfile);
            this.bunifuCards.LeftSahddow = false;
            this.bunifuCards.Location = new System.Drawing.Point(117, 121);
            this.bunifuCards.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards.Name = "bunifuCards";
            this.bunifuCards.RightSahddow = true;
            this.bunifuCards.ShadowDepth = 20;
            this.bunifuCards.Size = new System.Drawing.Size(1029, 373);
            this.bunifuCards.TabIndex = 5;
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelRegion.Location = new System.Drawing.Point(697, 284);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(210, 37);
            this.labelRegion.TabIndex = 26;
            this.labelRegion.Text = "Ile-de-France";
            // 
            // labelRegionText
            // 
            this.labelRegionText.AutoSize = true;
            this.labelRegionText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelRegionText.Location = new System.Drawing.Point(569, 296);
            this.labelRegionText.Name = "labelRegionText";
            this.labelRegionText.Size = new System.Drawing.Size(81, 23);
            this.labelRegionText.TabIndex = 25;
            this.labelRegionText.Text = "Région:";
            // 
            // labelStatusText
            // 
            this.labelStatusText.AutoSize = true;
            this.labelStatusText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelStatusText.Location = new System.Drawing.Point(577, 238);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(73, 23);
            this.labelStatusText.TabIndex = 24;
            this.labelStatusText.Text = "Status:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelStatus.Location = new System.Drawing.Point(697, 228);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(120, 37);
            this.labelStatus.TabIndex = 23;
            this.labelStatus.Text = "Visiteur";
            // 
            // labelBirthdayText
            // 
            this.labelBirthdayText.AutoSize = true;
            this.labelBirthdayText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelBirthdayText.Location = new System.Drawing.Point(452, 177);
            this.labelBirthdayText.Name = "labelBirthdayText";
            this.labelBirthdayText.Size = new System.Drawing.Size(200, 23);
            this.labelBirthdayText.TabIndex = 22;
            this.labelBirthdayText.Text = "Date de naissance:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelBirthday.Location = new System.Drawing.Point(697, 167);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(179, 37);
            this.labelBirthday.TabIndex = 21;
            this.labelBirthday.Text = "19/08/2000";
            // 
            // labelNameText
            // 
            this.labelNameText.AutoSize = true;
            this.labelNameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelNameText.Location = new System.Drawing.Point(564, 118);
            this.labelNameText.Name = "labelNameText";
            this.labelNameText.Size = new System.Drawing.Size(90, 23);
            this.labelNameText.TabIndex = 20;
            this.labelNameText.Text = "Prenom:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelName.Location = new System.Drawing.Point(697, 107);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(152, 37);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Aymerick";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelLastname.Location = new System.Drawing.Point(697, 52);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(157, 37);
            this.labelLastname.TabIndex = 18;
            this.labelLastname.Text = "MICHELET";
            // 
            // labelLastnameText
            // 
            this.labelLastnameText.AutoSize = true;
            this.labelLastnameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastnameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelLastnameText.Location = new System.Drawing.Point(592, 62);
            this.labelLastnameText.Name = "labelLastnameText";
            this.labelLastnameText.Size = new System.Drawing.Size(62, 23);
            this.labelLastnameText.TabIndex = 17;
            this.labelLastnameText.Text = "Nom:";
            // 
            // imgProfile
            // 
            this.imgProfile.Location = new System.Drawing.Point(49, 52);
            this.imgProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgProfile.Name = "imgProfile";
            this.imgProfile.Size = new System.Drawing.Size(397, 271);
            this.imgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProfile.TabIndex = 16;
            this.imgProfile.TabStop = false;
            // 
            // UCProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.bunifuCards);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCProfile";
            this.Size = new System.Drawing.Size(1269, 855);
            this.bunifuCards.ResumeLayout(false);
            this.bunifuCards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private Bunifu.Framework.UI.BunifuCards bunifuCards;
        private System.Windows.Forms.PictureBox imgProfile;
        private System.Windows.Forms.Label labelLastnameText;
        private System.Windows.Forms.Label labelNameText;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelBirthdayText;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.Label labelRegionText;
    }
}
