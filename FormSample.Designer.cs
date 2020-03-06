namespace compte_rendu
{
    partial class FormSample
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelListSample = new System.Windows.Forms.Panel();
            this.ucSample = new compte_rendu.UCSample();
            this.bddSample = new Bunifu.Framework.UI.BunifuDropdown();
            this.bibAddSample = new Bunifu.Framework.UI.BunifuImageButton();
            this.bClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelListSample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibAddSample)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(407, 16);
            this.panelTop.TabIndex = 0;
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.panelTop;
            this.bunifuDragControl.Vertical = true;
            // 
            // panelListSample
            // 
            this.panelListSample.Controls.Add(this.ucSample);
            this.panelListSample.Location = new System.Drawing.Point(0, 85);
            this.panelListSample.Name = "panelListSample";
            this.panelListSample.Size = new System.Drawing.Size(407, 385);
            this.panelListSample.TabIndex = 51;
            // 
            // ucSample
            // 
            this.ucSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.ucSample.Location = new System.Drawing.Point(15, 4);
            this.ucSample.Name = "ucSample";
            this.ucSample.Size = new System.Drawing.Size(377, 43);
            this.ucSample.TabIndex = 0;
            // 
            // bddSample
            // 
            this.bddSample.BackColor = System.Drawing.Color.Transparent;
            this.bddSample.BorderRadius = 3;
            this.bddSample.Cursor = System.Windows.Forms.Cursors.Default;
            this.bddSample.DisabledColor = System.Drawing.Color.Gray;
            this.bddSample.ForeColor = System.Drawing.Color.White;
            this.bddSample.Items = new string[] {
        "Hola",
        "Quetal",
        "Como",
        "Esta",
        "Wesh",
        "Alors"};
            this.bddSample.Location = new System.Drawing.Point(13, 489);
            this.bddSample.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bddSample.Name = "bddSample";
            this.bddSample.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddSample.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.bddSample.selectedIndex = -1;
            this.bddSample.Size = new System.Drawing.Size(316, 43);
            this.bddSample.TabIndex = 50;
            // 
            // bibAddSample
            // 
            this.bibAddSample.BackColor = System.Drawing.Color.Transparent;
            this.bibAddSample.Image = global::compte_rendu.Properties.Resources.icons8_add_96;
            this.bibAddSample.ImageActive = null;
            this.bibAddSample.Location = new System.Drawing.Point(336, 476);
            this.bibAddSample.Name = "bibAddSample";
            this.bibAddSample.Size = new System.Drawing.Size(71, 71);
            this.bibAddSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bibAddSample.TabIndex = 49;
            this.bibAddSample.TabStop = false;
            this.bibAddSample.Zoom = 10;
            this.bibAddSample.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.Transparent;
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(371, 1);
            this.bClose.Margin = new System.Windows.Forms.Padding(4);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(45, 53);
            this.bClose.TabIndex = 52;
            this.bClose.Text = "x";
            this.bClose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(211)))));
            this.labelTitle.Location = new System.Drawing.Point(111, 33);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(187, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Echantillons";
            // 
            // FormSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 543);
            this.ControlBox = false;
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.panelListSample);
            this.Controls.Add(this.bddSample);
            this.Controls.Add(this.bibAddSample);
            this.Name = "FormSample";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelListSample.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bibAddSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private System.Windows.Forms.Panel panelListSample;
        private Bunifu.Framework.UI.BunifuDropdown bddSample;
        private Bunifu.Framework.UI.BunifuImageButton bibAddSample;
        private UCSample ucSample;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label labelTitle;
    }
}