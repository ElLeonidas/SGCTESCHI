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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Puedes cargar el Lobby por defecto si quieres
            // LoadPanel(new LobbyControl());
        }

        // 👉 Método para cargar un UserControl dentro de Categorias
        private void LoadPanel(UserControl control)
        {
            Categorias.Controls.Clear();       // Limpia el panel derecho
            control.Dock = DockStyle.Fill;     // Se ajusta al tamaño del panel
            Categorias.Controls.Add(control);  // Agrega el nuevo control
        }

        // 👉 Botón que carga el UserControl "Registros"
        private void btnRegistros_Click(object sender, EventArgs e)
        {
            LoadPanel(new Registros());   // "Registros" es tu UserControl
        }

        // 👉 Botón que carga el UserControl "Lobby"
        private void btnLobby_Click(object sender, EventArgs e)
        {
            LoadPanel(new Lobby());   // "LobbyControl" es tu UserControl nuevo
        }

        // ❌ Este evento Paint no lo necesitas para cargar cosas
        private void Categorias_Paint(object sender, PaintEventArgs e)
        {
            // No cargar nada aquí
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //Funcion para cerrar sesión
            Login menu = new Login();
            menu.Show();
            this.Hide();
        }

        private void MenuControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
