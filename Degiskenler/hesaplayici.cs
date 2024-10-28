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
    public partial class hesaplayici : Form
    {
        public hesaplayici()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenar1, kenar2, alan;
            kenar1 = Convert.ToInt32(textBox1.Text);
            kenar2 = Convert.ToInt32(textBox2.Text);

            alan = kenar1 * kenar2;

            label8.Text = textBox1.Text;
            label9.Text = textBox2.Text;
            label10.Text = alan.ToString();
            label12.Text = alan.ToString(); 

            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label12.Visible = true;
                

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int not, proje, final;
            float ortalama;

            not = Convert.ToInt32(textBox3.Text);
            proje = Convert.ToInt32(textBox4.Text);
            final = Convert.ToInt32(textBox5.Text);

            ortalama = (not * 0.3f) + (proje * 0.3f) + (final * 0.4f);

            label11.Text = ortalama.ToString();
            label11.Visible = true;

        }
    }
}
