using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Clinica_SanPablo
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static string usuario = "";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Logo());
        }
    }
}
