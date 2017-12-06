namespace FromApp
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
            this.components = new System.ComponentModel.Container();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyAd = new System.Windows.Forms.Label();
            this.lblKimlikNo = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtKimlikNo = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstKisi = new System.Windows.Forms.ListBox();
            this.txtUzmanlik = new System.Windows.Forms.TextBox();
            this.lblUzmanlik = new System.Windows.Forms.Label();
            this.cbAktif = new System.Windows.Forms.CheckBox();
            this.lstWKisi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.btnResimYukle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(13, 31);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyAd
            // 
            this.lblSoyAd.AutoSize = true;
            this.lblSoyAd.Location = new System.Drawing.Point(13, 62);
            this.lblSoyAd.Name = "lblSoyAd";
            this.lblSoyAd.Size = new System.Drawing.Size(37, 13);
            this.lblSoyAd.TabIndex = 1;
            this.lblSoyAd.Text = "Soyad";
            // 
            // lblKimlikNo
            // 
            this.lblKimlikNo.AutoSize = true;
            this.lblKimlikNo.Location = new System.Drawing.Point(12, 93);
            this.lblKimlikNo.Name = "lblKimlikNo";
            this.lblKimlikNo.Size = new System.Drawing.Size(74, 13);
            this.lblKimlikNo.TabIndex = 2;
            this.lblKimlikNo.Text = "T.C. Kimlik No";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(112, 24);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(104, 20);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextChanged += new System.EventHandler(this.textBoxChangeProgressBar);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(112, 55);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(104, 20);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.TextChanged += new System.EventHandler(this.textBoxChangeProgressBar);
            // 
            // txtKimlikNo
            // 
            this.txtKimlikNo.Location = new System.Drawing.Point(112, 86);
            this.txtKimlikNo.Name = "txtKimlikNo";
            this.txtKimlikNo.Size = new System.Drawing.Size(104, 20);
            this.txtKimlikNo.TabIndex = 3;
            this.txtKimlikNo.TextChanged += new System.EventHandler(this.textBoxChangeProgressBar);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(112, 198);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(104, 32);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Kaydet";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstKisi
            // 
            this.lstKisi.FormattingEnabled = true;
            this.lstKisi.Location = new System.Drawing.Point(12, 487);
            this.lstKisi.Name = "lstKisi";
            this.lstKisi.Size = new System.Drawing.Size(484, 56);
            this.lstKisi.TabIndex = 7;
            this.lstKisi.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstKisi_DrawItem);
            this.lstKisi.SelectedIndexChanged += new System.EventHandler(this.lstKisi_SelectedIndexChanged);
            // 
            // txtUzmanlik
            // 
            this.txtUzmanlik.Location = new System.Drawing.Point(112, 122);
            this.txtUzmanlik.Name = "txtUzmanlik";
            this.txtUzmanlik.Size = new System.Drawing.Size(104, 20);
            this.txtUzmanlik.TabIndex = 4;
            this.txtUzmanlik.TextChanged += new System.EventHandler(this.textBoxChangeProgressBar);
            // 
            // lblUzmanlik
            // 
            this.lblUzmanlik.AutoSize = true;
            this.lblUzmanlik.Location = new System.Drawing.Point(13, 129);
            this.lblUzmanlik.Name = "lblUzmanlik";
            this.lblUzmanlik.Size = new System.Drawing.Size(50, 13);
            this.lblUzmanlik.TabIndex = 9;
            this.lblUzmanlik.Text = "Uzmanlık";
            // 
            // cbAktif
            // 
            this.cbAktif.AutoSize = true;
            this.cbAktif.Checked = true;
            this.cbAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAktif.Location = new System.Drawing.Point(112, 165);
            this.cbAktif.Name = "cbAktif";
            this.cbAktif.Size = new System.Drawing.Size(47, 17);
            this.cbAktif.TabIndex = 10;
            this.cbAktif.Text = "Aktif";
            this.cbAktif.UseVisualStyleBackColor = true;
            // 
            // lstWKisi
            // 
            this.lstWKisi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstWKisi.FullRowSelect = true;
            this.lstWKisi.Location = new System.Drawing.Point(12, 256);
            this.lstWKisi.Name = "lstWKisi";
            this.lstWKisi.Size = new System.Drawing.Size(484, 158);
            this.lstWKisi.SmallImageList = this.ımageList1;
            this.lstWKisi.TabIndex = 11;
            this.lstWKisi.UseCompatibleStateImageBehavior = false;
            this.lstWKisi.View = System.Windows.Forms.View.Details;
            this.lstWKisi.SelectedIndexChanged += new System.EventHandler(this.lstWKisi_SelectedIndexChanged);
            this.lstWKisi.DoubleClick += new System.EventHandler(this.lstWKisi_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "T.C. Kimlik No";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Uzmanlık";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pctBox
            // 
            this.pctBox.Location = new System.Drawing.Point(272, 24);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(224, 158);
            this.pctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBox.TabIndex = 12;
            this.pctBox.TabStop = false;
            // 
            // btnResimYukle
            // 
            this.btnResimYukle.Location = new System.Drawing.Point(272, 198);
            this.btnResimYukle.Name = "btnResimYukle";
            this.btnResimYukle.Size = new System.Drawing.Size(224, 32);
            this.btnResimYukle.TabIndex = 13;
            this.btnResimYukle.Text = "Resim Yükle";
            this.btnResimYukle.UseVisualStyleBackColor = true;
            this.btnResimYukle.Click += new System.EventHandler(this.btnResimYukle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 434);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(484, 34);
            this.progressBar1.Step = 5;
            this.progressBar1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 555);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnResimYukle);
            this.Controls.Add(this.pctBox);
            this.Controls.Add(this.lstWKisi);
            this.Controls.Add(this.cbAktif);
            this.Controls.Add(this.lblUzmanlik);
            this.Controls.Add(this.txtUzmanlik);
            this.Controls.Add(this.lstKisi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtKimlikNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblKimlikNo);
            this.Controls.Add(this.lblSoyAd);
            this.Controls.Add(this.lblAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyAd;
        private System.Windows.Forms.Label lblKimlikNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtKimlikNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstKisi;
        private System.Windows.Forms.TextBox txtUzmanlik;
        private System.Windows.Forms.Label lblUzmanlik;
        private System.Windows.Forms.CheckBox cbAktif;
        private System.Windows.Forms.ListView lstWKisi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.Button btnResimYukle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

