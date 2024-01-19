namespace PresentationLayer
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
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAtrist = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonInsertAlbum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(23, 10);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(655, 186);
            this.listBoxAlbums.TabIndex = 0;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(48, 246);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(43, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Naslov:";
            // 
            // labelAtrist
            // 
            this.labelAtrist.AutoSize = true;
            this.labelAtrist.Location = new System.Drawing.Point(298, 252);
            this.labelAtrist.Name = "labelAtrist";
            this.labelAtrist.Size = new System.Drawing.Size(49, 13);
            this.labelAtrist.TabIndex = 2;
            this.labelAtrist.Text = "Umetnik:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(502, 251);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 13);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Cena:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(127, 245);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(124, 20);
            this.textBoxTitle.TabIndex = 4;
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(369, 246);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(107, 20);
            this.textBoxArtist.TabIndex = 5;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(569, 248);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(109, 20);
            this.textBoxPrice.TabIndex = 6;
            // 
            // buttonInsertAlbum
            // 
            this.buttonInsertAlbum.Location = new System.Drawing.Point(60, 293);
            this.buttonInsertAlbum.Name = "buttonInsertAlbum";
            this.buttonInsertAlbum.Size = new System.Drawing.Size(124, 23);
            this.buttonInsertAlbum.TabIndex = 7;
            this.buttonInsertAlbum.Text = "Kreiraj";
            this.buttonInsertAlbum.UseVisualStyleBackColor = true;
            this.buttonInsertAlbum.Click += new System.EventHandler(this.buttonInsertAlbum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInsertAlbum);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxArtist);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelAtrist);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listBoxAlbums);
            this.Name = "Form1";
            this.Text = "Albumi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAtrist;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonInsertAlbum;
    }
}

