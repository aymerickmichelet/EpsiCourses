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
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bibClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.textboxPraticienLastname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bmtSampleText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.bibClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = null;
            this.bunifuDragControl.Vertical = true;
            // 
            // bibClose
            // 
            this.bibClose.BackColor = System.Drawing.Color.Transparent;
            this.bibClose.Image = global::compte_rendu.Properties.Resources.icons8_delete_521;
            this.bibClose.ImageActive = null;
            this.bibClose.Location = new System.Drawing.Point(247, 4);
            this.bibClose.Margin = new System.Windows.Forms.Padding(2);
            this.bibClose.Name = "bibClose";
            this.bibClose.Size = new System.Drawing.Size(34, 29);
            this.bibClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bibClose.TabIndex = 0;
            this.bibClose.TabStop = false;
            this.bibClose.Zoom = 10;
            this.bibClose.Click += new System.EventHandler(this.bibClose_Click);
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
            this.textboxPraticienLastname.Location = new System.Drawing.Point(3, 3);
            this.textboxPraticienLastname.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPraticienLastname.Name = "textboxPraticienLastname";
            this.textboxPraticienLastname.Size = new System.Drawing.Size(228, 27);
            this.textboxPraticienLastname.TabIndex = 29;
            this.textboxPraticienLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bmtSampleText
            // 
            this.bmtSampleText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmtSampleText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmtSampleText.ForeColor = System.Drawing.Color.White;
            this.bmtSampleText.HintForeColor = System.Drawing.Color.Empty;
            this.bmtSampleText.HintText = "";
            this.bmtSampleText.isPassword = false;
            this.bmtSampleText.LineFocusedColor = System.Drawing.Color.Empty;
            this.bmtSampleText.LineIdleColor = System.Drawing.Color.Empty;
            this.bmtSampleText.LineMouseHoverColor = System.Drawing.Color.Empty;
            this.bmtSampleText.LineThickness = 3;
            this.bmtSampleText.Location = new System.Drawing.Point(4, 3);
            this.bmtSampleText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bmtSampleText.Name = "bmtSampleText";
            this.bmtSampleText.Size = new System.Drawing.Size(227, 29);
            this.bmtSampleText.TabIndex = 30;
            this.bmtSampleText.Text = "hola quetal";
            this.bmtSampleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UCSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.bmtSampleText);
            this.Controls.Add(this.textboxPraticienLastname);
            this.Controls.Add(this.bibClose);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCSample";
            this.Size = new System.Drawing.Size(283, 35);
            ((System.ComponentModel.ISupportInitialize)(this.bibClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private Bunifu.Framework.UI.BunifuImageButton bibClose;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxPraticienLastname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmtSampleText;
    }
}
