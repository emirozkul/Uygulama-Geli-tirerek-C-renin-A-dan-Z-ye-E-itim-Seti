using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_KararYapilari
{
    public partial class Ogrenci_Not_Hesaplama : Form
    {
        public Ogrenci_Not_Hesaplama()
        {
            InitializeComponent();
            labelGecmeDurumu.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            int vize = Convert.ToInt32(textBoxVize.Text);
            int proje = Convert.ToInt32(textBoxProje.Text);
            int final = Convert.ToInt32(textBoxFinal.Text);

            double ortalama = (vize * 0.4) + (proje * 0.2) + (final * 0.4);

            textBoxSonuc.Text = ortalama.ToString();

            labelGecmeDurumu.Visible = true;

            if (ortalama >= 90)
            {
                textBoxHarfNotu.Text = "AA";
                labelGecmeDurumu.Text = "Geçti";
                textBoxHarfNotu.BackColor = Color.Green;
                labelGecmeDurumu.BackColor = Color.Green;
            }
            else if (ortalama >= 85 && ortalama <= 89)
            {
                textBoxHarfNotu.Text = "BA";
                labelGecmeDurumu.Text = "Geçti";
                textBoxHarfNotu.BackColor = Color.Green;
                labelGecmeDurumu.BackColor = Color.Green;
            }
            else if (ortalama >= 80 && ortalama <= 84)
            {
                textBoxHarfNotu.Text = "BB";
                labelGecmeDurumu.Text = "Geçti";
                textBoxHarfNotu.BackColor = Color.Green;
                labelGecmeDurumu.BackColor = Color.Green;
            }
            else if (ortalama >= 70 && ortalama <= 79)
            {
                textBoxHarfNotu.Text = "CB";
                labelGecmeDurumu.Text = "Geçti";
                textBoxHarfNotu.BackColor = Color.Green;
                labelGecmeDurumu.BackColor = Color.Green;
            }
            else if (ortalama >= 60 && ortalama <= 69)
            {
                textBoxHarfNotu.Text = "CC";
                labelGecmeDurumu.Text = "Geçti";
                textBoxHarfNotu.BackColor = Color.Green;
                labelGecmeDurumu.BackColor = Color.Green;
            }
            else if (ortalama >= 50 && ortalama <= 59)
            {
                textBoxHarfNotu.Text = "DC";
                labelGecmeDurumu.Text = "Geçti";
                textBoxHarfNotu.BackColor = Color.Green;
                labelGecmeDurumu.BackColor = Color.Green;
            }
            else if (ortalama >= 45 && ortalama <= 49)
            {
                textBoxHarfNotu.Text = "DD";
                labelGecmeDurumu.Text = "Geçti";
                textBoxHarfNotu.BackColor = Color.Green;
                labelGecmeDurumu.BackColor = Color.Green;
            }
            else
            {
                textBoxHarfNotu.Text = "FF";
                labelGecmeDurumu.Text = "Kaldı";
                textBoxHarfNotu.BackColor = Color.Red;
                labelGecmeDurumu.BackColor = Color.Red;
            }
            
                
           
        }
    }
}
