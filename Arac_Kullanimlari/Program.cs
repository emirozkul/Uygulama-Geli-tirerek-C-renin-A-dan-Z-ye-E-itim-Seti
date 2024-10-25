using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();
            form1.Show();

            Form2 form2 = new Form2();
            form2.Show();

            Form3 form3 = new Form3();
            form3.Show();

            Form4 form4 = new Form4();
            form4.Show();

            Form5 form5 = new Form5();
            Application.Run(form5); 
        }
    }
}
