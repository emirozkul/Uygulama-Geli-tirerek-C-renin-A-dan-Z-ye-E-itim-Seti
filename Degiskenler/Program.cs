using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
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

            basitHesapMakinesi form1 = new basitHesapMakinesi();
            form1.Show();

            hesaplayici form2 = new hesaplayici();
            form2.Show();

            KayitFormu form3 = new KayitFormu();
            form3.Show();

            sinema_bufe_satis_paneli form4 = new sinema_bufe_satis_paneli();
            Application.Run(new sinema_bufe_satis_paneli());
        }
    }
}
