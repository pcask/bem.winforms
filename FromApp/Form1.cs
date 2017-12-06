using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isUpdate;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // ListBox için yazılan kontrol
            //var kisi = (isUpdate) ? (Kisi)lstKisi.SelectedItem : new Kisi();
            //kisi.Ad = txtAd.Text;
            //kisi.Soyad = txtSoyad.Text;
            //kisi.TcKimlikNo = txtKimlikNo.Text;
            //kisi.Uzmanlik = txtUzmanlik.Text;

            if (progressBar1.Value != 100)
            {
                MessageBox.Show("Lütfen Bütün Alanları Doldurunuz!!");
                return;
            }

            ListViewItem li = new ListViewItem(new string[] { "", txtAd.Text, txtSoyad.Text, txtKimlikNo.Text, txtUzmanlik.Text });

            ımageList1.Images.Add(pctBox.Image);

            li.ImageIndex = ımageList1.Images.Count - 1;

            // ListBox için yazılan kontrol
            //if (!isUpdate)
            //{
            //    lstKisi.Items.Add(kisi);
            //}
            //else
            //{
            //    lstKisi.Items[lstKisi.SelectedIndex] = kisi;
            //}

            if (!isUpdate)
            {
                lstWKisi.Items.Add(li);
            }
            else
            {
                lstWKisi.Items[selectedRowIndex] = li;
            }

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtKimlikNo.Text = "";
            txtUzmanlik.Text = "";

            pctBox.Image = null;
            progressBar1.Value =0;
            isUpdate = false;
        }

        private void lstKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisi.SelectedItem is null)
            {
                return;
            }

            Kisi gelenKisi = lstKisi.SelectedItem as Kisi;

            txtAd.Text = gelenKisi.Ad;
            txtSoyad.Text = gelenKisi.Soyad;
            txtKimlikNo.Text = gelenKisi.TcKimlikNo;
            txtUzmanlik.Text = gelenKisi.Uzmanlik;

            isUpdate = true;
        }

        private void lstKisi_DrawItem(object sender, DrawItemEventArgs e)
        {
            //if (!cbAktif.Checked)
            //{
            //    e.DrawBackground();
            //    Graphics g = e.Graphics;

            //    g.FillRectangle(new SolidBrush(Color.Silver), e.Bounds);

            //    e.DrawFocusRectangle();
            //}
        }

        private void lstWKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lstWKisi.SelectedItems is null)
            //{
            //    return;
            //}

            //txtAd.Text = lstWKisi.SelectedItems[0].Text;
            //txtSoyad.Text = lstWKisi.SelectedItems[0].SubItems[0].Text;
            //txtKimlikNo.Text = lstWKisi.SelectedItems[0].SubItems[1].Text;
            //txtUzmanlik.Text = lstWKisi.SelectedItems[0].SubItems[2].Text;

            //isUpdate = true;
        }

        private int selectedRowIndex;

        private void lstWKisi_DoubleClick(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            //ListView lv = (ListView)sender;

            if (lv is null)
            {
                return;
            }

            ListViewItem selectedItem = lv.SelectedItems[0];

            txtAd.Text = selectedItem.SubItems[1].Text;
            txtSoyad.Text = selectedItem.SubItems[2].Text;
            txtKimlikNo.Text = selectedItem.SubItems[3].Text;
            txtUzmanlik.Text = selectedItem.SubItems[4].Text;

            pctBox.Image = ımageList1.Images[selectedItem.ImageIndex];
            progressBar1.Value += 20;

            isUpdate = true;

            selectedRowIndex = lv.SelectedIndices[0];
        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap img = new Bitmap(openFileDialog1.FileName);

                pctBox.Image = img;

                progressBar1.Value += 20;
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            textBoxChangeProgressBar(sender);
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            textBoxChangeProgressBar(sender);
        }

        private void txtKimlikNo_TextChanged(object sender, EventArgs e)
        {
            textBoxChangeProgressBar(sender);
        }

        private void txtUzmanlik_TextChanged(object sender, EventArgs e)
        {
            textBoxChangeProgressBar(sender);
        }

        private void textBoxChangeProgressBar(object sender)
        {
            TextBox txt = sender as TextBox;
            if (txt.Tag == null)
            {
                progressBar1.Value += 20;
                txt.Tag = "dolu";
            }

            if (txt.Text == "")
            {
                txt.Tag = null;
                progressBar1.Value -= 20;
            }
        }
    }
}
