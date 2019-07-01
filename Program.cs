using System;
using System.Windows.Forms;

namespace Interfaz
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación. main del software
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}
