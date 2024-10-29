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
    public partial class basitHesapMakinesi : Form
    {
        double sayi1, sayi2, sonuc=0;
       
        public basitHesapMakinesi()
        {
            InitializeComponent();
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            sonuc = sayi1 + sayi2;         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            sonuc = sayi1 - sayi2;         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            sonuc = sayi1 * sayi2;          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            sonuc = sayi1 / sayi2;            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = sonuc.ToString();
            label4.Visible = true;
        }
    }
}
