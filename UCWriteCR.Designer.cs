namespace compte_rendu
{
    partial class UCWriteCR
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.bunifuCards = new Bunifu.Framework.UI.BunifuCards();
            this.bEditSample = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bddDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bddPatern = new Bunifu.Framework.UI.BunifuDropdown();
            this.labelListSample = new System.Windows.Forms.Label();
            this.bddProduct2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.labelProduct2 = new System.Windows.Forms.Label();
            this.bddProduct1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.labelSample = new System.Windows.Forms.Label();
            this.labelProduct1 = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPatern = new System.Windows.Forms.Label();
            this.labelPractitionerName = new System.Windows.Forms.Label();
            this.bmtPractitionerName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelPractitionerLastname = new System.Windows.Forms.Label();
            this.bmtPractitionerLastname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelPractitioner = new System.Windows.Forms.Label();
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.labelTitle.Location = new System.Drawing.Point(351, 29);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(552, 75);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Saisie de compte rendu";
            // 
            // bunifuCards
            // 
            this.bunifuCards.AutoScroll = true;
            this.bunifuCards.BackColor = System.Drawing.Color.White;
            this.bunifuCards.BorderRadius = 5;
            this.bunifuCards.BottomSahddow = true;
            this.bunifuCards.color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.bunifuCards.Controls.Add(this.bEditSample);
            this.bunifuCards.Controls.Add(this.bSave);
            this.bunifuCards.Controls.Add(this.bddDate);
            this.bunifuCards.Controls.Add(this.bddPatern);
            this.bunifuCards.Controls.Add(this.labelListSample);
            this.bunifuCards.Controls.Add(this.bddProduct2);
            this.bunifuCards.Controls.Add(this.labelProduct2);
            this.bunifuCards.Controls.Add(this.bddProduct1);
            this.bunifuCards.Controls.Add(this.labelSample);
            this.bunifuCards.Controls.Add(this.labelProduct1);
            this.bunifuCards.Controls.Add(this.labelProduct);
            this.bunifuCards.Controls.Add(this.labelDate);
            this.bunifuCards.Controls.Add(this.labelPatern);
            this.bunifuCards.Controls.Add(this.labelPractitionerName);
            this.bunifuCards.Controls.Add(this.bmtPractitionerName);
            this.bunifuCards.Controls.Add(this.labelPractitionerLastname);
            this.bunifuCards.Controls.Add(this.bmtPractitionerLastname);
            this.bunifuCards.Controls.Add(this.labelPractitioner);
            this.bunifuCards.LeftSahddow = false;
            this.bunifuCards.Location = new System.Drawing.Point(106, 125);
            this.bunifuCards.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards.Name = "bunifuCards";
            this.bunifuCards.RightSahddow = true;
            this.bunifuCards.ShadowDepth = 20;
            this.bunifuCards.Size = new System.Drawing.Size(1029, 674);
            this.bunifuCards.TabIndex = 7;
            // 
            // bEditSample
            // 
            this.bEditSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bEditSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditSample.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bEditSample.ForeColor = System.Drawing.Color.White;
            this.bEditSample.Location = new System.Drawing.Point(583, 373);
            this.bEditSample.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEditSample.Name = "bEditSample";
            this.bEditSample.Size = new System.Drawing.Size(379, 45);
            this.bEditSample.TabIndex = 51;
            this.bEditSample.Text = "Modifier";
            this.bEditSample.UseVisualStyleBackColor = false;
            this.bEditSample.Click += new System.EventHandler(this.bEditSample_Click);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.ForeColor = System.Drawing.Color.White;
            this.bSave.Location = new System.Drawing.Point(52, 588);
            this.bSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(910, 45);
            this.bSave.TabIndex = 49;
            this.bSave.Text = "Enregistrer";
            this.bSave.UseVisualStyleBackColor = false;
            // 
            // bddDate
            // 
            this.bddDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddDate.BorderRadius = 0;
            this.bddDate.ForeColor = System.Drawing.Color.White;
            this.bddDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bddDate.FormatCustom = null;
            this.bddDate.Location = new System.Drawing.Point(583, 209);
            this.bddDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bddDate.Name = "bddDate";
            this.bddDate.Size = new System.Drawing.Size(379, 44);
            this.bddDate.TabIndex = 48;
            this.bddDate.Value = new System.DateTime(2020, 3, 2, 14, 17, 8, 979);
            // 
            // bddPatern
            // 
            this.bddPatern.BackColor = System.Drawing.Color.Transparent;
            this.bddPatern.BorderRadius = 3;
            this.bddPatern.Cursor = System.Windows.Forms.Cursors.Default;
            this.bddPatern.DisabledColor = System.Drawing.Color.Gray;
            this.bddPatern.ForeColor = System.Drawing.Color.White;
            this.bddPatern.Items = new string[] {
        "Hola",
        "Quetal",
        "Como",
        "Esta",
        "Wesh",
        "Alors"};
            this.bddPatern.Location = new System.Drawing.Point(583, 124);
            this.bddPatern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bddPatern.Name = "bddPatern";
            this.bddPatern.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddPatern.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddPatern.selectedIndex = -1;
            this.bddPatern.Size = new System.Drawing.Size(379, 43);
            this.bddPatern.TabIndex = 47;
            // 
            // labelListSample
            // 
            this.labelListSample.AutoSize = true;
            this.labelListSample.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelListSample.Location = new System.Drawing.Point(579, 344);
            this.labelListSample.Name = "labelListSample";
            this.labelListSample.Size = new System.Drawing.Size(196, 23);
            this.labelListSample.TabIndex = 46;
            this.labelListSample.Text = "Liste d\'échantillons:";
            // 
            // bddProduct2
            // 
            this.bddProduct2.BackColor = System.Drawing.Color.Transparent;
            this.bddProduct2.BorderRadius = 3;
            this.bddProduct2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bddProduct2.DisabledColor = System.Drawing.Color.Gray;
            this.bddProduct2.ForeColor = System.Drawing.Color.White;
            this.bddProduct2.Items = new string[] {
        "Hola",
        "Quetal",
        "Como",
        "Esta",
        "Wesh",
        "Alors"};
            this.bddProduct2.Location = new System.Drawing.Point(63, 465);
            this.bddProduct2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bddProduct2.Name = "bddProduct2";
            this.bddProduct2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddProduct2.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddProduct2.selectedIndex = -1;
            this.bddProduct2.Size = new System.Drawing.Size(379, 43);
            this.bddProduct2.TabIndex = 45;
            // 
            // labelProduct2
            // 
            this.labelProduct2.AutoSize = true;
            this.labelProduct2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelProduct2.Location = new System.Drawing.Point(59, 436);
            this.labelProduct2.Name = "labelProduct2";
            this.labelProduct2.Size = new System.Drawing.Size(101, 23);
            this.labelProduct2.TabIndex = 44;
            this.labelProduct2.Text = "produit 2:";
            // 
            // bddProduct1
            // 
            this.bddProduct1.BackColor = System.Drawing.Color.Transparent;
            this.bddProduct1.BorderRadius = 3;
            this.bddProduct1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bddProduct1.DisabledColor = System.Drawing.Color.Gray;
            this.bddProduct1.ForeColor = System.Drawing.Color.White;
            this.bddProduct1.Items = new string[] {
        "Hola",
        "Quetal",
        "Como",
        "Esta",
        "Wesh",
        "Alors"};
            this.bddProduct1.Location = new System.Drawing.Point(63, 373);
            this.bddProduct1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bddProduct1.Name = "bddProduct1";
            this.bddProduct1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddProduct1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddProduct1.selectedIndex = -1;
            this.bddProduct1.Size = new System.Drawing.Size(379, 43);
            this.bddProduct1.TabIndex = 43;
            // 
            // labelSample
            // 
            this.labelSample.AutoSize = true;
            this.labelSample.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelSample.Location = new System.Drawing.Point(576, 289);
            this.labelSample.Name = "labelSample";
            this.labelSample.Size = new System.Drawing.Size(209, 37);
            this.labelSample.TabIndex = 41;
            this.labelSample.Text = "Echantillon(s)";
            // 
            // labelProduct1
            // 
            this.labelProduct1.AutoSize = true;
            this.labelProduct1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelProduct1.Location = new System.Drawing.Point(59, 344);
            this.labelProduct1.Name = "labelProduct1";
            this.labelProduct1.Size = new System.Drawing.Size(101, 23);
            this.labelProduct1.TabIndex = 37;
            this.labelProduct1.Text = "produit 1:";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelProduct.Location = new System.Drawing.Point(56, 289);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(154, 37);
            this.labelProduct.TabIndex = 36;
            this.labelProduct.Text = "Produit(s)";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelDate.Location = new System.Drawing.Point(579, 182);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(63, 23);
            this.labelDate.TabIndex = 34;
            this.labelDate.Text = "date:";
            // 
            // labelPatern
            // 
            this.labelPatern.AutoSize = true;
            this.labelPatern.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatern.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelPatern.Location = new System.Drawing.Point(579, 97);
            this.labelPatern.Name = "labelPatern";
            this.labelPatern.Size = new System.Drawing.Size(63, 23);
            this.labelPatern.TabIndex = 32;
            this.labelPatern.Text = "motif:";
            // 
            // labelPractitionerName
            // 
            this.labelPractitionerName.AutoSize = true;
            this.labelPractitionerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPractitionerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelPractitionerName.Location = new System.Drawing.Point(59, 182);
            this.labelPractitionerName.Name = "labelPractitionerName";
            this.labelPractitionerName.Size = new System.Drawing.Size(92, 23);
            this.labelPractitionerName.TabIndex = 29;
            this.labelPractitionerName.Text = "prenom:";
            // 
            // bmtPractitionerName
            // 
            this.bmtPractitionerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmtPractitionerName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmtPractitionerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmtPractitionerName.HintForeColor = System.Drawing.Color.Empty;
            this.bmtPractitionerName.HintText = "";
            this.bmtPractitionerName.isPassword = false;
            this.bmtPractitionerName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bmtPractitionerName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bmtPractitionerName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bmtPractitionerName.LineThickness = 3;
            this.bmtPractitionerName.Location = new System.Drawing.Point(63, 198);
            this.bmtPractitionerName.Margin = new System.Windows.Forms.Padding(4);
            this.bmtPractitionerName.Name = "bmtPractitionerName";
            this.bmtPractitionerName.Size = new System.Drawing.Size(379, 33);
            this.bmtPractitionerName.TabIndex = 30;
            this.bmtPractitionerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelPractitionerLastname
            // 
            this.labelPractitionerLastname.AutoSize = true;
            this.labelPractitionerLastname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPractitionerLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelPractitionerLastname.Location = new System.Drawing.Point(59, 97);
            this.labelPractitionerLastname.Name = "labelPractitionerLastname";
            this.labelPractitionerLastname.Size = new System.Drawing.Size(59, 23);
            this.labelPractitionerLastname.TabIndex = 27;
            this.labelPractitionerLastname.Text = "nom:";
            // 
            // bmtPractitionerLastname
            // 
            this.bmtPractitionerLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmtPractitionerLastname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmtPractitionerLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmtPractitionerLastname.HintForeColor = System.Drawing.Color.Empty;
            this.bmtPractitionerLastname.HintText = "";
            this.bmtPractitionerLastname.isPassword = false;
            this.bmtPractitionerLastname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bmtPractitionerLastname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bmtPractitionerLastname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bmtPractitionerLastname.LineThickness = 3;
            this.bmtPractitionerLastname.Location = new System.Drawing.Point(63, 113);
            this.bmtPractitionerLastname.Margin = new System.Windows.Forms.Padding(4);
            this.bmtPractitionerLastname.Name = "bmtPractitionerLastname";
            this.bmtPractitionerLastname.Size = new System.Drawing.Size(379, 33);
            this.bmtPractitionerLastname.TabIndex = 28;
            this.bmtPractitionerLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelPractitioner
            // 
            this.labelPractitioner.AutoSize = true;
            this.labelPractitioner.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPractitioner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelPractitioner.Location = new System.Drawing.Point(56, 40);
            this.labelPractitioner.Name = "labelPractitioner";
            this.labelPractitioner.Size = new System.Drawing.Size(144, 37);
            this.labelPractitioner.TabIndex = 18;
            this.labelPractitioner.Text = "Praticien";
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = null;
            this.bunifuDragControl.Vertical = true;
            // 
            // UCWriteCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.bunifuCards);
            this.Name = "UCWriteCR";
            this.Size = new System.Drawing.Size(1269, 855);
            this.bunifuCards.ResumeLayout(false);
            this.bunifuCards.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private Bunifu.Framework.UI.BunifuCards bunifuCards;
        private System.Windows.Forms.Label labelPractitioner;
        private System.Windows.Forms.Label labelPractitionerLastname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmtPractitionerLastname;
        private System.Windows.Forms.Label labelPractitionerName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmtPractitionerName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPatern;
        private System.Windows.Forms.Label labelSample;
        private System.Windows.Forms.Label labelProduct;
        private Bunifu.Framework.UI.BunifuDatepicker bddDate;
        private Bunifu.Framework.UI.BunifuDropdown bddPatern;
        private Bunifu.Framework.UI.BunifuDropdown bddProduct2;
        private System.Windows.Forms.Label labelProduct2;
        private Bunifu.Framework.UI.BunifuDropdown bddProduct1;
        private System.Windows.Forms.Label labelProduct1;
        private System.Windows.Forms.Button bSave;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private System.Windows.Forms.Button bEditSample;
        private System.Windows.Forms.Label labelListSample;
    }
}
