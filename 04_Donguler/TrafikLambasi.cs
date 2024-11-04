using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Donguler
{
    public partial class TrafikLambasi : Form
    {
        int kirmiziSayac = 10, yesilSayac = 6, sayac=0;

        public TrafikLambasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panel2.BackColor = Color.Gray;
            panel3.BackColor = Color.Gray;
            label1.Visible = true;
            label2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            
            if (sayac<=10)
            {
                kirmiziSayac--;
                label1.Text = kirmiziSayac.ToString();
                
                if (kirmiziSayac == 0)
                {
                    label1.Visible = false;
                    panel2.BackColor = Color.Yellow;
                }
            }

            if (sayac >= 12 && sayac <= 19)
            {
                panel1.BackColor = Color.Gray;
                panel2.BackColor = Color.Gray;
                panel3.BackColor = Color.Green;
                yesilSayac--;
                label2.Visible = true;
                label2.Text = yesilSayac.ToString();

                if (yesilSayac == 0)
                {               
                    label2.Visible = false;
                    panel3.BackColor = Color.Gray;
                    panel1.BackColor = Color.Red;                                       
                    sayac = 0;                   
                    yesilSayac = 5;
                    kirmiziSayac = 10;
                    label1.Visible = true;
                }
            }              
        }
    }
}
