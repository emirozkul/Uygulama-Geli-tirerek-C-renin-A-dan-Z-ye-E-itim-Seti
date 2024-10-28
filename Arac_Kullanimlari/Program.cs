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

            KullaniciKayitFormu form1 = new KullaniciKayitFormu();
            form1.Show();

            KisiKayitFormu form2 = new KisiKayitFormu();
            form2.Show();

            resimliKayitFormu form3 = new resimliKayitFormu();
            form3.Show();

            onlineDersGirisPaneli form4 = new onlineDersGirisPaneli();
            form4.Show();

            Form5 form5 = new Form5();
            Application.Run(form5); 
        }
    }
}
