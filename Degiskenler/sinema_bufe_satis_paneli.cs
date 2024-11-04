using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class sinema_bufe_satis_paneli : Form
    {
        public sinema_bufe_satis_paneli()
        {
            InitializeComponent();
            toplamFiyat.Visible = false;
            lblMisirFiyat.Visible = false;
            lblSuFiyat.Visible = false;
            lblCayFiyat.Visible = false;
            LblBiletFiyat.Visible = false;

        }



        int misir, su, cay, bilet, toplam, kasa=0, siparisNumarasi = 1;

        private void fis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama Kapatılmıştır");
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxmisirAdet.Text = "";
            textBoxSuAdet.Text = "";
            textBoxCayAdet.Text = "";
            textBoxBiletAdet.Text = "";
            textBox1.Text = "";

            toplamFiyat.Text = "0 TL";

            textBoxmisirAdet.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int misirAdet = Convert.ToInt32(textBoxmisirAdet.Text);
            int suAdet = Convert.ToInt32(textBoxSuAdet.Text);
            int cayAdet = Convert.ToInt32(textBoxCayAdet.Text);
            int biletAdet = Convert.ToInt32(textBoxBiletAdet.Text);
            string isim = textBox1.Text;


            fis.Items.Add("İsim: " + isim);
            fis.Items.Add(" ");
            fis.Items.Add("Mısır x " + misirAdet);
            fis.Items.Add(Convert.ToString(misirAdet * misir) + " TL");
            fis.Items.Add("Su x " + suAdet);
            fis.Items.Add(Convert.ToString(suAdet * su) + " TL");
            fis.Items.Add("Çay x " + cayAdet);
            fis.Items.Add(Convert.ToString(cayAdet * cay) + " TL");
            fis.Items.Add("Bilet x " + biletAdet);
            fis.Items.Add(Convert.ToString(biletAdet * bilet) + " TL");
            fis.Items.Add(" ");
            
            toplam = misirAdet * misir + suAdet * su + cayAdet * cay + biletAdet * bilet;

            toplamFiyat.Text = toplam.ToString() + " TL";

            kasa += toplam;

            kasaToplam.Text = kasa.ToString() + " TL";

            toplamFiyat.Visible = true;

            fis.Items.Add("Toplam Tutar: " + toplam.ToString() + " TL");
            fis.Items.Add("------------------------------------------");
        }

        private void sinema_bufe_satis_paneli_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttnGuncelle_Click(object sender, EventArgs e)
        {
            misir = Convert.ToInt32(txtBmisirFiyatSet.Text);
            su = Convert.ToInt32(txtBSuFiyatSet.Text);
            cay = Convert.ToInt32(txtBCayFiyatSet.Text);
            bilet = Convert.ToInt32(txtBBiletFiyatSet.Text);

            lblMisirFiyat.Visible = true;
            lblSuFiyat.Visible = true;
            lblCayFiyat.Visible = true;
            LblBiletFiyat.Visible = true;

            lblMisirFiyat.Text = misir.ToString() + " TL";
            lblSuFiyat.Text = su.ToString() + " TL";
            lblCayFiyat.Text = cay.ToString() + " TL";
            LblBiletFiyat.Text = bilet.ToString() + " TL";

            txtBmisirFiyatSet.Text = "";
            txtBSuFiyatSet.Text = "";
            txtBCayFiyatSet.Text = "";
            txtBBiletFiyatSet.Text = "";

            textBoxmisirAdet.Focus();

        }     
    }
}
