using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DortIslem
{
    static class Program
    {

        public static void sescal(string x)
        {
            SoundPlayer cal = new SoundPlayer();
            cal.SoundLocation = "ses//" + x;
            cal.LoadAsync();
            cal.Play();
        }

        public static string isim;
        public static int sure;
        public static int skor;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new anaMenu());
        }
    }
}
