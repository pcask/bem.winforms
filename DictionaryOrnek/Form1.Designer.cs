namespace DictionaryOrnek
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
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.gbLabel = new System.Windows.Forms.GroupBox();
            this.gbRadio = new System.Windows.Forms.GroupBox();
            this.cbControls = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbRenkler = new System.Windows.Forms.ComboBox();
            this.btnBoya = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gbButton
            // 
            this.gbButton.Location = new System.Drawing.Point(12, 64);
            this.gbButton.Name = "gbButton";
            this.gbButton.Size = new System.Drawing.Size(163, 415);
            this.gbButton.TabIndex = 0;
            this.gbButton.TabStop = false;
            this.gbButton.Text = "Button";
            // 
            // gbLabel
            // 
            this.gbLabel.Location = new System.Drawing.Point(202, 64);
            this.gbLabel.Name = "gbLabel";
            this.gbLabel.Size = new System.Drawing.Size(163, 415);
            this.gbLabel.TabIndex = 0;
            this.gbLabel.TabStop = false;
            this.gbLabel.Text = "Label";
            // 
            // gbRadio
            // 
            this.gbRadio.Location = new System.Drawing.Point(392, 64);
            this.gbRadio.Name = "gbRadio";
            this.gbRadio.Size = new System.Drawing.Size(163, 415);
            this.gbRadio.TabIndex = 0;
            this.gbRadio.TabStop = false;
            this.gbRadio.Text = "Radio";
            // 
            // cbControls
            // 
            this.cbControls.FormattingEnabled = true;
            this.cbControls.Items.AddRange(new object[] {
            "Button",
            "Label",
            "Radio"});
            this.cbControls.Location = new System.Drawing.Point(12, 22);
            this.cbControls.Name = "cbControls";
            this.cbControls.Size = new System.Drawing.Size(121, 21);
            this.cbControls.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(139, 20);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbRenkler
            // 
            this.cbRenkler.FormattingEnabled = true;
            this.cbRenkler.Items.AddRange(new object[] {
            "Kırmızı",
            "Mavi",
            "Yeşil"});
            this.cbRenkler.Location = new System.Drawing.Point(350, 20);
            this.cbRenkler.Name = "cbRenkler";
            this.cbRenkler.Size = new System.Drawing.Size(121, 21);
            this.cbRenkler.TabIndex = 3;
            // 
            // btnBoya
            // 
            this.btnBoya.Location = new System.Drawing.Point(477, 20);
            this.btnBoya.Name = "btnBoya";
            this.btnBoya.Size = new System.Drawing.Size(75, 23);
            this.btnBoya.TabIndex = 4;
            this.btnBoya.Text = "BOYA";
            this.btnBoya.UseVisualStyleBackColor = true;
            this.btnBoya.Click += new System.EventHandler(this.btnBoya_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 491);
            this.Controls.Add(this.btnBoya);
            this.Controls.Add(this.cbRenkler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbControls);
            this.Controls.Add(this.gbLabel);
            this.Controls.Add(this.gbRadio);
            this.Controls.Add(this.gbButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbButton;
        private System.Windows.Forms.GroupBox gbLabel;
        private System.Windows.Forms.GroupBox gbRadio;
        private System.Windows.Forms.ComboBox cbControls;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cbRenkler;
        private System.Windows.Forms.Button btnBoya;
    }
}

