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
            EkliOgeler = new Dictionary<string, List<Control>>();
        }

        private Dictionary<string, List<Control>> EkliOgeler;


        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString().ToLower())
            {
                case "button": Ekle<Button>("button", groupBox1);break;
                case "label": Ekle<Label>("label", groupBox2); break;
                case "radio": Ekle<RadioButton>("radio", groupBox3); break;
                case "check": Ekle<CheckBox>("check", panel1); break;
                default:
                    break;
            }
        }

        private void RadioEkle()
        {
            if (!EkliOgeler.ContainsKey("radio"))
            {
                EkliOgeler.Add("radio", new List<Control>());
            }


            int top = (EkliOgeler["radio"].Count > 0) ? EkliOgeler["radio"][EkliOgeler["radio"].Count - 1].Top : -10;
            var radio = new RadioButton
            {
                Size = new Size(120, 20),
                Text = (EkliOgeler["radio"].Count + 1).ToString(),
                Location = new Point(20, top + 30)
            };

            EkliOgeler["radio"].Add(radio);

            groupBox3.Controls.Add(radio);
        }

        private void ButonEkle()
        {
            if (!EkliOgeler.ContainsKey("button"))
            {
                EkliOgeler.Add("button", new List<Control>());
            }


            int top = (EkliOgeler["button"].Count > 0) ? EkliOgeler["button"][EkliOgeler["button"].Count - 1].Top : -10;
            var button = new Button
            {
                Size = new Size(120, 20),
                Text = (EkliOgeler["button"].Count + 1).ToString(),
                Location = new Point(20, top+30)
            };

            EkliOgeler["button"].Add(button);

            groupBox1.Controls.Add(button);
        }

        private void Ekle<T> (string key, Control control) where T :  Control, new()
        {
            if (!EkliOgeler.ContainsKey(key))
            {
                EkliOgeler.Add(key, new List<Control>());
            }

            int top = (EkliOgeler[key].Count > 0) ? EkliOgeler[key][EkliOgeler[key].Count - 1].Top : -10;
            var label = new T
            {
                Size = new Size(120, 20),
                Text = (EkliOgeler[key].Count + 1).ToString(),
                Location = new Point(20, top + 30)
            };

            EkliOgeler[key].Add(label);

            control.Controls.Add(label);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var color = new Color();

            string selectedColor = comboBox2.SelectedItem.ToString().ToLower();

            switch (selectedColor)
            {
                case "kırmızı": color = Color.FromArgb(255, 0, 0);break;
                case "yeşil": color = Color.FromArgb( 0,255, 0);break;
                case "mavi": color = Color.FromArgb(0, 0,255);break;
                default:
                    break;
            }

            foreach (var item in EkliOgeler[comboBox1.SelectedItem.ToString().ToLower()])
            {
                item.BackColor = color;
            }
        }
    }
}
