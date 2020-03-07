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
            this.bmtComment = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelVisit = new System.Windows.Forms.Label();
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
            this.labelCoefficientTrust = new System.Windows.Forms.Label();
            this.bddCoefficientTrust = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.labelTitle.Location = new System.Drawing.Point(263, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(441, 61);
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
            this.bunifuCards.Controls.Add(this.bddCoefficientTrust);
            this.bunifuCards.Controls.Add(this.labelCoefficientTrust);
            this.bunifuCards.Controls.Add(this.bmtComment);
            this.bunifuCards.Controls.Add(this.labelComment);
            this.bunifuCards.Controls.Add(this.labelVisit);
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
            this.bunifuCards.Location = new System.Drawing.Point(83, 101);
            this.bunifuCards.Name = "bunifuCards";
            this.bunifuCards.RightSahddow = true;
            this.bunifuCards.ShadowDepth = 20;
            this.bunifuCards.Size = new System.Drawing.Size(772, 577);
            this.bunifuCards.TabIndex = 7;
            // 
            // bmtComment
            // 
            this.bmtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmtComment.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmtComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmtComment.HintForeColor = System.Drawing.Color.Empty;
            this.bmtComment.HintText = "";
            this.bmtComment.isPassword = false;
            this.bmtComment.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bmtComment.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bmtComment.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bmtComment.LineThickness = 8;
            this.bmtComment.Location = new System.Drawing.Point(429, 461);
            this.bmtComment.Margin = new System.Windows.Forms.Padding(4);
            this.bmtComment.Name = "bmtComment";
            this.bmtComment.Size = new System.Drawing.Size(284, 37);
            this.bmtComment.TabIndex = 42;
            this.bmtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelComment.Location = new System.Drawing.Point(424, 401);
            this.labelComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(181, 30);
            this.labelComment.TabIndex = 53;
            this.labelComment.Text = "Commentaire";
            // 
            // labelVisit
            // 
            this.labelVisit.AutoSize = true;
            this.labelVisit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelVisit.Location = new System.Drawing.Point(34, 162);
            this.labelVisit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVisit.Name = "labelVisit";
            this.labelVisit.Size = new System.Drawing.Size(76, 30);
            this.labelVisit.TabIndex = 52;
            this.labelVisit.Text = "Visite";
            // 
            // bEditSample
            // 
            this.bEditSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bEditSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditSample.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bEditSample.ForeColor = System.Drawing.Color.White;
            this.bEditSample.Location = new System.Drawing.Point(39, 461);
            this.bEditSample.Margin = new System.Windows.Forms.Padding(2);
            this.bEditSample.Name = "bEditSample";
            this.bEditSample.Size = new System.Drawing.Size(284, 37);
            this.bEditSample.TabIndex = 40;
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
            this.bSave.Location = new System.Drawing.Point(39, 525);
            this.bSave.Margin = new System.Windows.Forms.Padding(2);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(682, 37);
            this.bSave.TabIndex = 44;
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
            this.bddDate.Location = new System.Drawing.Point(429, 222);
            this.bddDate.Name = "bddDate";
            this.bddDate.Size = new System.Drawing.Size(284, 36);
            this.bddDate.TabIndex = 34;
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
            this.bddPatern.Location = new System.Drawing.Point(39, 222);
            this.bddPatern.Name = "bddPatern";
            this.bddPatern.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddPatern.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddPatern.selectedIndex = -1;
            this.bddPatern.Size = new System.Drawing.Size(284, 35);
            this.bddPatern.TabIndex = 32;
            // 
            // labelListSample
            // 
            this.labelListSample.AutoSize = true;
            this.labelListSample.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelListSample.Location = new System.Drawing.Point(36, 436);
            this.labelListSample.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelListSample.Name = "labelListSample";
            this.labelListSample.Size = new System.Drawing.Size(158, 21);
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
            this.bddProduct2.Location = new System.Drawing.Point(429, 338);
            this.bddProduct2.Name = "bddProduct2";
            this.bddProduct2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddProduct2.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddProduct2.selectedIndex = -1;
            this.bddProduct2.Size = new System.Drawing.Size(284, 35);
            this.bddProduct2.TabIndex = 38;
            // 
            // labelProduct2
            // 
            this.labelProduct2.AutoSize = true;
            this.labelProduct2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelProduct2.Location = new System.Drawing.Point(426, 316);
            this.labelProduct2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProduct2.Name = "labelProduct2";
            this.labelProduct2.Size = new System.Drawing.Size(84, 21);
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
            this.bddProduct1.Location = new System.Drawing.Point(39, 338);
            this.bddProduct1.Name = "bddProduct1";
            this.bddProduct1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddProduct1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddProduct1.selectedIndex = -1;
            this.bddProduct1.Size = new System.Drawing.Size(284, 35);
            this.bddProduct1.TabIndex = 36;
            // 
            // labelSample
            // 
            this.labelSample.AutoSize = true;
            this.labelSample.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelSample.Location = new System.Drawing.Point(34, 401);
            this.labelSample.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSample.Name = "labelSample";
            this.labelSample.Size = new System.Drawing.Size(172, 30);
            this.labelSample.TabIndex = 41;
            this.labelSample.Text = "Echantillon(s)";
            // 
            // labelProduct1
            // 
            this.labelProduct1.AutoSize = true;
            this.labelProduct1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelProduct1.Location = new System.Drawing.Point(36, 316);
            this.labelProduct1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProduct1.Name = "labelProduct1";
            this.labelProduct1.Size = new System.Drawing.Size(84, 21);
            this.labelProduct1.TabIndex = 37;
            this.labelProduct1.Text = "produit 1:";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelProduct.Location = new System.Drawing.Point(34, 276);
            this.labelProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(122, 30);
            this.labelProduct.TabIndex = 36;
            this.labelProduct.Text = "Produit(s)";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelDate.Location = new System.Drawing.Point(426, 200);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(53, 21);
            this.labelDate.TabIndex = 34;
            this.labelDate.Text = "date:";
            // 
            // labelPatern
            // 
            this.labelPatern.AutoSize = true;
            this.labelPatern.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatern.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelPatern.Location = new System.Drawing.Point(36, 200);
            this.labelPatern.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPatern.Name = "labelPatern";
            this.labelPatern.Size = new System.Drawing.Size(54, 21);
            this.labelPatern.TabIndex = 32;
            this.labelPatern.Text = "motif:";
            // 
            // labelPractitionerName
            // 
            this.labelPractitionerName.AutoSize = true;
            this.labelPractitionerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPractitionerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelPractitionerName.Location = new System.Drawing.Point(426, 64);
            this.labelPractitionerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPractitionerName.Name = "labelPractitionerName";
            this.labelPractitionerName.Size = new System.Drawing.Size(75, 21);
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
            this.bmtPractitionerName.LineThickness = 8;
            this.bmtPractitionerName.Location = new System.Drawing.Point(429, 76);
            this.bmtPractitionerName.Margin = new System.Windows.Forms.Padding(4);
            this.bmtPractitionerName.Name = "bmtPractitionerName";
            this.bmtPractitionerName.Size = new System.Drawing.Size(284, 31);
            this.bmtPractitionerName.TabIndex = 30;
            this.bmtPractitionerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelPractitionerLastname
            // 
            this.labelPractitionerLastname.AutoSize = true;
            this.labelPractitionerLastname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPractitionerLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelPractitionerLastname.Location = new System.Drawing.Point(36, 64);
            this.labelPractitionerLastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPractitionerLastname.Name = "labelPractitionerLastname";
            this.labelPractitionerLastname.Size = new System.Drawing.Size(49, 21);
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
            this.bmtPractitionerLastname.LineThickness = 8;
            this.bmtPractitionerLastname.Location = new System.Drawing.Point(39, 76);
            this.bmtPractitionerLastname.Margin = new System.Windows.Forms.Padding(4);
            this.bmtPractitionerLastname.Name = "bmtPractitionerLastname";
            this.bmtPractitionerLastname.Size = new System.Drawing.Size(284, 31);
            this.bmtPractitionerLastname.TabIndex = 28;
            this.bmtPractitionerLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelPractitioner
            // 
            this.labelPractitioner.AutoSize = true;
            this.labelPractitioner.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPractitioner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelPractitioner.Location = new System.Drawing.Point(34, 27);
            this.labelPractitioner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPractitioner.Name = "labelPractitioner";
            this.labelPractitioner.Size = new System.Drawing.Size(117, 30);
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
            // labelCoefficientTrust
            // 
            this.labelCoefficientTrust.AutoSize = true;
            this.labelCoefficientTrust.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoefficientTrust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelCoefficientTrust.Location = new System.Drawing.Point(35, 126);
            this.labelCoefficientTrust.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCoefficientTrust.Name = "labelCoefficientTrust";
            this.labelCoefficientTrust.Size = new System.Drawing.Size(205, 21);
            this.labelCoefficientTrust.TabIndex = 54;
            this.labelCoefficientTrust.Text = "coefficient de confiance:";
            // 
            // bddCoefficientTrust
            // 
            this.bddCoefficientTrust.BackColor = System.Drawing.Color.Transparent;
            this.bddCoefficientTrust.BorderRadius = 3;
            this.bddCoefficientTrust.Cursor = System.Windows.Forms.Cursors.Default;
            this.bddCoefficientTrust.DisabledColor = System.Drawing.Color.Gray;
            this.bddCoefficientTrust.ForeColor = System.Drawing.Color.White;
            this.bddCoefficientTrust.Items = new string[] {
        "",
        "0.1",
        "0.2",
        "0.3",
        "0.4",
        "0.5",
        "0.6",
        "0.7",
        "0.8",
        "0.9",
        "1.0"};
            this.bddCoefficientTrust.Location = new System.Drawing.Point(248, 120);
            this.bddCoefficientTrust.Name = "bddCoefficientTrust";
            this.bddCoefficientTrust.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddCoefficientTrust.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddCoefficientTrust.selectedIndex = -1;
            this.bddCoefficientTrust.Size = new System.Drawing.Size(75, 35);
            this.bddCoefficientTrust.TabIndex = 55;
            // 
            // UCWriteCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.bunifuCards);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCWriteCR";
            this.Size = new System.Drawing.Size(952, 695);
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmtComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelVisit;
        private System.Windows.Forms.Label labelCoefficientTrust;
        private Bunifu.Framework.UI.BunifuDropdown bddCoefficientTrust;
    }
}
