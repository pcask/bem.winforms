namespace SinavApp
{
    partial class frmGiris
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.btnSinavSec = new System.Windows.Forms.Button();
            this.lblSinavDosyaYolu = new System.Windows.Forms.Label();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDevamEt);
            this.panel1.Controls.Add(this.btnSinavSec);
            this.panel1.Controls.Add(this.lblSinavDosyaYolu);
            this.panel1.Controls.Add(this.lblAdSoyad);
            this.panel1.Controls.Add(this.txtAdSoyad);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 245);
            this.panel1.TabIndex = 1;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(37, 34);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(59, 13);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Ad Soyad :";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(105, 31);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(150, 20);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // btnSinavSec
            // 
            this.btnSinavSec.Location = new System.Drawing.Point(35, 69);
            this.btnSinavSec.Name = "btnSinavSec";
            this.btnSinavSec.Size = new System.Drawing.Size(75, 23);
            this.btnSinavSec.TabIndex = 4;
            this.btnSinavSec.Text = "Sınav Seç";
            this.btnSinavSec.UseVisualStyleBackColor = true;
            this.btnSinavSec.Click += new System.EventHandler(this.btnSinavSec_Click);
            // 
            // lblSinavDosyaYolu
            // 
            this.lblSinavDosyaYolu.AutoSize = true;
            this.lblSinavDosyaYolu.Location = new System.Drawing.Point(126, 75);
            this.lblSinavDosyaYolu.Name = "lblSinavDosyaYolu";
            this.lblSinavDosyaYolu.Size = new System.Drawing.Size(0, 13);
            this.lblSinavDosyaYolu.TabIndex = 5;
            this.lblSinavDosyaYolu.Visible = false;
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.Location = new System.Drawing.Point(35, 112);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(220, 23);
            this.btnDevamEt.TabIndex = 6;
            this.btnDevamEt.Text = "DEVAM >>";
            this.btnDevamEt.UseVisualStyleBackColor = true;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 273);
            this.Controls.Add(this.panel1);
            this.Name = "frmGiris";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Button btnSinavSec;
        private System.Windows.Forms.Label lblSinavDosyaYolu;
        private System.Windows.Forms.Button btnDevamEt;
    }
}

