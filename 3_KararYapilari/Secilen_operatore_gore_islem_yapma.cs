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
    public partial class Secilen_operatore_gore_islem_yapma : Form
    {
        public Secilen_operatore_gore_islem_yapma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            string operator_ = textBox3.Text;

            switch (operator_)
            {
                case "+":
                    textBox4.Text = (sayi1 + sayi2).ToString();
                    break;
                case "-":
                    textBox4.Text = (sayi1 - sayi2).ToString();
                    break;
                case "*":
                    textBox4.Text = (sayi1 * sayi2).ToString();
                    break;
                case "/":
                    textBox4.Text = (sayi1 / sayi2).ToString();
                    break;
                default:
                    textBox4.Text = "Hatalı operatör girdiniz.";
                    break;
            }
        }
    }
}
