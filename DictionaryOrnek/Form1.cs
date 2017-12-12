using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Dictionary<string, Control> Kontroller = new Dictionary<string, Control>();

        int buttonY = 0;
        int LabelY = 0;
        int radioY = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string seciliKontrol = cbControls.SelectedItem.ToString();

            switch (seciliKontrol)
            {
                case "Button":
                    Button btn = new Button();
                    btn.Text = "Button";
                    btn.Location = new Point(0, buttonY);
                    buttonY += btn.PreferredSize.Height + 10;
                    Kontroller.Add("Button-" + buttonY, btn);
                    gbButton.Controls.Add(btn);
                    break;
                case "Label":
                    Label lbl = new Label();
                    lbl.Text = "Label";
                    lbl.Location = new Point(0, LabelY);
                    LabelY += lbl.PreferredSize.Height + 10;
                    Kontroller.Add("Label-"+ LabelY, lbl);
                    gbLabel.Controls.Add(lbl);
                    break;
                case "Radio":
                    RadioButton rb = new RadioButton();
                    rb.Text = "Radio Button";
                    rb.Location = new Point(0, radioY);
                    radioY += rb.PreferredSize.Height + 10;
                    Kontroller.Add("Radio-" + radioY, rb);
                    gbRadio.Controls.Add(rb);
                    break;
                default:
                    break;
            }
        }

        private void btnBoya_Click(object sender, EventArgs e)
        {
            string seciliKontrol = cbControls.SelectedItem.ToString();

            string seciliRenk = cbRenkler.SelectedItem.ToString();

            //foreach (var item in Kontroller)
            //{
            //    if (seciliKontrol == item.Key.Split('-')[0])
            //    {
            //        switch (seciliRenk)
            //        {
            //            case "Kırmızı": item.Value.BackColor = Color.Red;
            //                break;
            //            case "Yeşil":
            //                item.Value.BackColor = Color.Green;
            //                break;
            //            case "Mavi":
            //                item.Value.BackColor = Color.Blue;
            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //}

            foreach (var item in Kontroller)
            {
                if (seciliKontrol == "Button")
                {
                    if (item.Value is Button)
                    {
                        Boya(item.Value, seciliRenk);
                    }
                }
                else if (seciliKontrol == "Label")
                {
                    if (item.Value is Label)
                    {
                        Boya(item.Value, seciliRenk);
                    }
                }
                else if(seciliKontrol == "Radio")
                {
                    if (item.Value is RadioButton)
                    {
                        Boya(item.Value, seciliRenk);
                    }
                }
                
            }
        }

        private void Boya(Control control, string renk)
        {
            switch (renk)
            {
                case "Kırmızı":
                    control.BackColor = Color.Red;
                    break;
                case "Yeşil":
                    control.BackColor = Color.Green;
                    break;
                case "Mavi":
                    control.BackColor = Color.Blue;
                    break;
                default:
                    break;
            }
        }
    }
}
