namespace SinavApp
{
    partial class frmSinavEkrani
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
            this.lblSinavAdi = new System.Windows.Forms.Label();
            this.lblSinavAciklama = new System.Windows.Forms.Label();
            this.prgCevapOrani = new System.Windows.Forms.ProgressBar();
            this.pnlSorular = new System.Windows.Forms.Panel();
            this.lblKalanZaman = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnBitir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSinavAdi
            // 
            this.lblSinavAdi.AutoSize = true;
            this.lblSinavAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinavAdi.Location = new System.Drawing.Point(282, 39);
            this.lblSinavAdi.Name = "lblSinavAdi";
            this.lblSinavAdi.Size = new System.Drawing.Size(112, 25);
            this.lblSinavAdi.TabIndex = 0;
            this.lblSinavAdi.Text = "Sınav Adı";
            // 
            // lblSinavAciklama
            // 
            this.lblSinavAciklama.AutoSize = true;
            this.lblSinavAciklama.Location = new System.Drawing.Point(46, 78);
            this.lblSinavAciklama.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblSinavAciklama.Name = "lblSinavAciklama";
            this.lblSinavAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblSinavAciklama.TabIndex = 1;
            this.lblSinavAciklama.Text = "Açıklama";
            this.lblSinavAciklama.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prgCevapOrani
            // 
            this.prgCevapOrani.Location = new System.Drawing.Point(12, 175);
            this.prgCevapOrani.Name = "prgCevapOrani";
            this.prgCevapOrani.Size = new System.Drawing.Size(680, 23);
            this.prgCevapOrani.Step = 1;
            this.prgCevapOrani.TabIndex = 2;
            // 
            // pnlSorular
            // 
            this.pnlSorular.AutoScroll = true;
            this.pnlSorular.Location = new System.Drawing.Point(12, 204);
            this.pnlSorular.Name = "pnlSorular";
            this.pnlSorular.Size = new System.Drawing.Size(680, 283);
            this.pnlSorular.TabIndex = 3;
            // 
            // lblKalanZaman
            // 
            this.lblKalanZaman.AutoSize = true;
            this.lblKalanZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanZaman.ForeColor = System.Drawing.Color.Green;
            this.lblKalanZaman.Location = new System.Drawing.Point(568, 9);
            this.lblKalanZaman.Name = "lblKalanZaman";
            this.lblKalanZaman.Size = new System.Drawing.Size(128, 31);
            this.lblKalanZaman.TabIndex = 4;
            this.lblKalanZaman.Text = "00:00:00";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(21, 13);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 5;
            this.lblAdSoyad.Text = "Ad Soyad";
            this.lblAdSoyad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(267, 135);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 23);
            this.btnBaslat.TabIndex = 6;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.Location = new System.Drawing.Point(348, 135);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(75, 23);
            this.btnBitir.TabIndex = 7;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // frmSinavEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 499);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblKalanZaman);
            this.Controls.Add(this.pnlSorular);
            this.Controls.Add(this.prgCevapOrani);
            this.Controls.Add(this.lblSinavAciklama);
            this.Controls.Add(this.lblSinavAdi);
            this.Name = "frmSinavEkrani";
            this.Text = "frmSinavEkrani";
            this.Load += new System.EventHandler(this.frmSinavEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSinavAdi;
        private System.Windows.Forms.Label lblSinavAciklama;
        private System.Windows.Forms.ProgressBar prgCevapOrani;
        private System.Windows.Forms.Panel pnlSorular;
        private System.Windows.Forms.Label lblKalanZaman;
        public System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnBitir;
    }
}