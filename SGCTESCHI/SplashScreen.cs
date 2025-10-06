using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCTESCHI
{
    public partial class SplashScreen : Form
    {
        private Timer timer;    

        public SplashScreen()
        {
            InitializeComponent();

            // Configurar temporizador
            timer = new Timer();
            timer.Interval = 3000; // Duración del splash en milisegundos (3 segundos)
            timer.Tick += Timer_Tick;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar splash
            timer.Start(); // Iniciar temporizador
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); // Detener temporizador
            this.Hide();  // Ocultar splash

            // Abrir formulario principal
            Login mainForm = new Login();
            mainForm.Show();
        }

    }
}
