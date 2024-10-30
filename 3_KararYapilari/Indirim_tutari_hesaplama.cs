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
    public partial class Indirim_tutari_hesaplama : Form
    {
        public Indirim_tutari_hesaplama()
        {
            InitializeComponent();
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            int kitapAdet = Convert.ToInt32(textBoxKitapAdeti.Text);
            
            if (kitapAdet > 0 && kitapAdet <= 20)
            {
                textBoxIndirimMiktari.Text = "%20";
                textBoxFiyat.Text = ((kitapAdet * 10) * 0.8).ToString() + " TL";
            }

            if (kitapAdet >= 21 && kitapAdet <= 40)
            {
                textBoxIndirimMiktari.Text = "%40";
                textBoxFiyat.Text = ((kitapAdet * 10) * 0.6).ToString() + " TL";
            }

            if (kitapAdet >= 41)
            {
                textBoxIndirimMiktari.Text = "%50";
                textBoxFiyat.Text = ((kitapAdet * 10) * 0.5).ToString() + " TL";
            }
        }

        
    }
}
