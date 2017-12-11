using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavApp
{
    public partial class frmSinavEkrani : Form
    {
        public string AdSoyad { get; set; }
        public string SinavDosyaYolu { get; set; }
        public string SinavAdi { get; set; }
        public int SinavSuresi { get; private set; }
        public double SinavSuresiUyariYuzdesi { get; set; }
        public byte SoruSayisi { get; set; }
        public byte VerilenCevap { get; set; }
        public string CevaplarYol { get; set; }

        Timer t;
        byte[] soruCevapKontrol;

        public frmSinavEkrani()
        {
            InitializeComponent();
        }

        public frmSinavEkrani(string adSoyad, string sinavDosyaYolu) : this()
        {
            AdSoyad = adSoyad;
            lblAdSoyad.Text = adSoyad;
            SinavDosyaYolu = sinavDosyaYolu;
        }


        private void frmSinavEkrani_Load(object sender, EventArgs e)
        {
            Form frmGiris = this.Owner as frmGiris;

            lblAdSoyad.Text = frmGiris.Controls.Find("txtAdSoyad", true)[0].Text;

            string sinavYol = frmGiris.Controls.Find("lblSinavDosyaYolu", true)[0].Text;

            using (StreamReader st = new StreamReader(sinavYol))
            {
                lblSinavAdi.Text = SinavAdi = st.ReadLine();
                lblSinavAciklama.Text = st.ReadLine();
                SinavSuresi = int.Parse(st.ReadLine());
                SinavSuresi = 160;
                SinavSuresiUyariYuzdesi = SinavSuresi * 0.1;

                int gbX = 0;
                int gbY = 0;
                SoruSayisi = 0;
                int enBuyukSatirYuksekligi = 0;

                string gelenSatir = "";
                while (!string.IsNullOrWhiteSpace((gelenSatir = st.ReadLine())))
                {
                    SoruSayisi++;

                    if (SoruSayisi % 2 == 1)
                    {
                        gbY += enBuyukSatirYuksekligi;
                        gbX = 0;
                    }
                    else
                    {
                        gbX += 340;
                    }

                    GroupBox gb = new GroupBox();
                    gb.AutoSize = true;
                    gb.Width = 330;
                    gb.MaximumSize = new Size(330, 0);
                    gb.Location = new Point(gbX, gbY);
                    pnlSorular.Controls.Add(gb);

                    string[] items = gelenSatir.Split('|');

                    Label lbl = new Label();
                    lbl.Location = new Point(10, 10);
                    lbl.MaximumSize = new Size(330, 0);
                    lbl.AutoSize = true;
                    lbl.Text = SoruSayisi + ".  " + items[0];

                    gb.Controls.Add(lbl);

                    int rbY = lbl.Location.Y + lbl.PreferredHeight + 15;
                    for (int i = 1; i < items.Length - 1; i++)
                    {
                        RadioButton rb = new RadioButton();
                        rb.Text = items[i];
                        rb.Location = new Point(10, rbY);
                        rbY += 20;
                        rb.Enabled = false;
                        rb.AutoSize = true;
                        rb.CheckedChanged += Rb_CheckedChanged;
                        gb.Controls.Add(rb);
                    }

                    if (SoruSayisi % 2 ==1)
                    {
                        enBuyukSatirYuksekligi = gb.PreferredSize.Height;
                    }
                    else
                    {
                        if (gb.PreferredSize.Height > enBuyukSatirYuksekligi)
                        {
                            enBuyukSatirYuksekligi = gb.PreferredSize.Height;
                        }
                    }
                }
            }

            prgCevapOrani.Maximum = SoruSayisi;
            soruCevapKontrol = new byte[SoruSayisi];
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton secilen = sender as RadioButton;

            foreach (Control item in secilen.Parent.Controls)
            {
                if (item is Label)
                {
                    SoruSayisi = byte.Parse(((Label)item).Text.Split('.')[0]);
                    break;
                }
            }

            if (soruCevapKontrol[SoruSayisi - 1] == 0)
            {
                prgCevapOrani.Value++;
                soruCevapKontrol[SoruSayisi - 1] = 1;
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            btnBaslat.Enabled = false;

            t = new Timer();
            t.Tick += T_Tick;
            t.Interval = 1000;
            t.Start();

            foreach (Control groupBox in pnlSorular.Controls)
            {
                foreach (Control radioBtn in groupBox.Controls)
                {
                    if (radioBtn is RadioButton)
                        radioBtn.Enabled = true;
                }
            }
        }


        private void T_Tick(object sender, EventArgs e)
        {
            if (SinavSuresi > 0)
            {
                if (SinavSuresi <= SinavSuresiUyariYuzdesi)
                    lblKalanZaman.ForeColor = Color.Red;

                SinavSuresi--;

                TimeSpan ts = TimeSpan.FromSeconds(SinavSuresi);
                lblKalanZaman.Text = ts.ToString(@"hh\:mm\:ss");
            }
            else
            {
                SinavBitir();
            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            SinavBitir();
        }


        private void SinavBitir()
        {
            btnBaslat.Enabled = false;

            CevaplarYol = Path.Combine(Application.StartupPath.Replace("\\bin\\Debug", ""), "Cevaplar", (SinavAdi + "-" + AdSoyad + ".txt").Replace(" ", "-"));

            if (!File.Exists(CevaplarYol))
            {
                File.Create(CevaplarYol).Close();
            }
            else
            {
                FileStream temizle = new FileStream(CevaplarYol, FileMode.Truncate);
                temizle.Close();
                temizle.Dispose();
            }

            using (StreamWriter sw = new StreamWriter(CevaplarYol))
            {
                sw.WriteLine(SinavAdi);

                SoruSayisi = 0;

                foreach (Control groupBox in pnlSorular.Controls)
                {
                    if (groupBox is GroupBox)
                    {
                        SoruSayisi++;
                        byte sayac = 0;

                        foreach (Control radioBtn in groupBox.Controls)
                        {
                            if (radioBtn is RadioButton)
                            {
                                sayac++;
                                radioBtn.Enabled = false;

                                if (((RadioButton)radioBtn).Checked)
                                    VerilenCevap = sayac;
                            }
                        }

                        sw.WriteLine(SoruSayisi + " " + VerilenCevap);
                        VerilenCevap = 0;
                    }
                }
            }

            t.Stop();
            btnBitir.Enabled = false;
        }
    }
}
