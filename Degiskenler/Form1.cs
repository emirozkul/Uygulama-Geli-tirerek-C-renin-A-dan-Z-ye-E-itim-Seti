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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim, soyisim, yas, cinsiyet, meslek;

            isim = textBox1.Text;
            soyisim = textBox2.Text;
            yas = maskedTextBox1.Text;
            meslek = textBox3.Text;
            cinsiyet = radioButton1.Checked ? "Erkek" : "Kadın";

            listBox1.Items.Add("İsim: " + isim);
            listBox1.Items.Add("Soyisim: " + soyisim);
            listBox1.Items.Add("Yaş: " + yas);
            listBox1.Items.Add("Meslek: " + meslek);
            listBox1.Items.Add("Cinsiyet: " + cinsiyet);
            listBox1.Items.Add("-------------------------------");
            
        }
    }
}
