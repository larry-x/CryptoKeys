using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoKeys
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string FP = Path.Combine(Environment.CurrentDirectory, "secret.txt");
            Hasher hasher = new Hasher(FP);
            FileInteraction fi = new FileInteraction(FP, hasher);
            Application.Run(new Open(fi));
        }
    }
}
