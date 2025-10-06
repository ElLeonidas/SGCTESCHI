    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCTESCHI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar el SplashScreen antes del login
            SplashScreen splash = new SplashScreen();
            splash.Show();
            Application.DoEvents(); // Permite que se renderice el splash

            System.Threading.Thread.Sleep(2000); // Muestra 2 segundos (ajusta según quieras)
            splash.Close();

            Application.Run(new Login());
        }
    }
}
