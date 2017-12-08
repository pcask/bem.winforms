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
        public int SinavSuresi { get; private set; }
        public double SinavSuresiUyariYuzdesi { get; set; }

        public frmSinavEkrani()
        {
            InitializeComponent();

            //var frmGiris = this.Owner as frmGiris;
            //this.lblAdSoyad.Text = frmGiris.txtAdSoyad.Text;
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

            Timer t = new Timer();
            t.Tick += T_Tick;
            t.Interval = 1000;
            t.Start();

            using (StreamReader st = new StreamReader(sinavYol))
            {
                lblSinavAdi.Text = st.ReadLine();
                lblSinavAciklama.Text = st.ReadLine();
                SinavSuresi = int.Parse(st.ReadLine());
                SinavSuresiUyariYuzdesi = SinavSuresi * 0.1;

                int gbX = 0;
                int gbY = -210;
                byte soruSayisi = 0;

                string gelenSatir = "";
                while (!string.IsNullOrWhiteSpace((gelenSatir = st.ReadLine())))
                {
                    soruSayisi++;

                    if (soruSayisi % 2 == 1)
                    {
                        gbY += 210;
                        gbX = 0;
                    }
                    else
                    {
                        gbX += 340;
                    }

                    GroupBox gb = new GroupBox();
                    gb.Width = 330;
                    gb.Height = 200;
                    gb.Location = new Point(gbX, gbY);
                    pnlSorular.Controls.Add(gb);

                    string [] items = gelenSatir.Split('|');

                    Label lbl = new Label();
                    lbl.Width = 330;
                    lbl.Location = new Point(10, 10);
                    lbl.AutoSize = true;
                    lbl.Text = items[0];

                    gb.Controls.Add(lbl);

                    int rbY = lbl.Location.Y + lbl.PreferredHeight + 15;
                    for (int i = 1; i < items.Length - 1; i++)
                    {
                        RadioButton rb = new RadioButton();
                        rb.Text = items[i];
                        rb.Location = new Point(10, rbY);
                        rbY += 20;
                        gb.Controls.Add(rb);
                    }
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
                ((Timer)sender).Stop();
        }
    }
}
