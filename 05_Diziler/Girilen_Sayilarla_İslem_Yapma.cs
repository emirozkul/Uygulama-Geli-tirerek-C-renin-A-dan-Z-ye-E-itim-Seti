using System;
using System.Windows.Forms;

namespace _05_Diziler
{
    public partial class Girilen_Sayilarla_İslem_Yapma : Form
    {
        int boyut;
        int[] sayilarDizisi;
        int index = 0;

        public Girilen_Sayilarla_İslem_Yapma()
        {
            InitializeComponent();
            label3.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            boyut = Convert.ToInt32(textBox1.Text);
            sayilarDizisi = new int[boyut];
            button3.Enabled = false;
            button1.Enabled = true;
            label3.Visible = true;
            label3.Text = "1. Sayıyı giriniz: ";
            textBox2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eleman = Convert.ToInt32(textBox2.Text); 
            sayilarDizisi[index] = eleman;
            index++;
            textBox2.Clear();

            if (index < boyut)
            {
                label3.Text = (index + 1) + ". Sayıyı giriniz: ";
            }
            else
            {
                label3.Text = "Tüm sayılar girildi.";
                button1.Enabled = false;
                button2.Enabled = true;
            }

            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double carpim = 1;
            double aritmetikOrtalama;
            double geometrikOrtalama;

            listBox1.Items.Clear(); 

            for (int i = 0; i < sayilarDizisi.Length; i++)
            {
                listBox1.Items.Add((i + 1) + ". sayı: " + sayilarDizisi[i]);
            }

            for (int i = 0; i < sayilarDizisi.Length; i++)
            {
                toplam += sayilarDizisi[i]; 
                carpim *= sayilarDizisi[i]; 
            }

            aritmetikOrtalama = (double)toplam / sayilarDizisi.Length;
            geometrikOrtalama = Math.Pow(carpim, 1.0 / sayilarDizisi.Length);

            
            label8.Text =Convert.ToString(toplam);
            label9.Text = geometrikOrtalama.ToString("F2"); 
            label10.Text = aritmetikOrtalama.ToString("F2");

            
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
        }
    }
}
