namespace compte_rendu
{
    partial class UCSample
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
            this.components = new System.ComponentModel.Container();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.textboxPraticienLastname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::compte_rendu.Properties.Resources.icons8_delete_521;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(329, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(45, 36);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // textboxPraticienLastname
            // 
            this.textboxPraticienLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxPraticienLastname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxPraticienLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxPraticienLastname.HintForeColor = System.Drawing.Color.Empty;
            this.textboxPraticienLastname.HintText = "";
            this.textboxPraticienLastname.isPassword = false;
            this.textboxPraticienLastname.LineFocusedColor = System.Drawing.Color.Transparent;
            this.textboxPraticienLastname.LineIdleColor = System.Drawing.Color.Transparent;
            this.textboxPraticienLastname.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.textboxPraticienLastname.LineThickness = 3;
            this.textboxPraticienLastname.Location = new System.Drawing.Point(4, 4);
            this.textboxPraticienLastname.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPraticienLastname.Name = "textboxPraticienLastname";
            this.textboxPraticienLastname.Size = new System.Drawing.Size(304, 33);
            this.textboxPraticienLastname.TabIndex = 29;
            this.textboxPraticienLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(5, 4);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(303, 36);
            this.bunifuMaterialTextbox1.TabIndex = 30;
            this.bunifuMaterialTextbox1.Text = "hola quetal";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UserControlEchantillon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.textboxPraticienLastname);
            this.Controls.Add(this.bunifuImageButton1);
            this.Name = "UserControlEchantillon";
            this.Size = new System.Drawing.Size(377, 43);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxPraticienLastname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
    }
}
