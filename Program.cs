using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romana_Vendimia
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        static Mutex _mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");

        [STAThread]
        static void Main()
        {
            if (_mutex.WaitOne(TimeSpan.Zero, true)) {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Romanero_Vista());
            }
            else
            {
                MessageBox.Show("LA APLICACIÓN YA SE ENCUENTRA ABIERTA.", "ALERTA",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}

