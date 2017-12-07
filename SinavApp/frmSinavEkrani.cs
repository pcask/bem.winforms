﻿using System;
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

        public frmSinavEkrani()
        {
            InitializeComponent();

            //var frmGiris = this.Owner as frmGiris;
            //this.lblAdSoyad.Text = frmGiris.txtAdSoyad.Text;
        }

        public frmSinavEkrani(string adSoyad, string sinavDosyaYolu) :this()
        {
            AdSoyad = adSoyad;
            lblAdSoyad.Text = adSoyad;
            SinavDosyaYolu = sinavDosyaYolu;
        }


        private void frmSinavEkrani_Load(object sender, EventArgs e)
        {
            using (var streamReader = new StreamReader(SinavDosyaYolu))
            {
                lblSinavAdi.Text = streamReader.ReadLine();
                lblSinavAciklama.Text = streamReader.ReadLine();
            }
        }

        private void frmSinavEkrani_Load(object sender, EventArgs e)
        {
            Form frmGiris = this.Owner as frmGiris;

            lblAdSoyad.Text = frmGiris.Controls.Find("txtAdSoyad", true)[0].Text;


            string sinavYol = frmGiris.Controls.Find("lblSinavDosyaYolu", true)[0].Text;

            using (StreamReader st = new StreamReader(sinavYol))
            {
                lblSinavAdi.Text = st.ReadLine();
                lblSinavAciklama.Text = st.ReadLine();

                do
                {




                } while (st.ReadLine() != null);

            }
        }
    }
}
