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
            // Opcional: aquí puedes cargar un control por defecto
            // LoadPanel(new InicioControl());
        }

        // 👉 Método para cargar un UserControl dentro de Categorias
        private void LoadPanel(UserControl control)
        {
            Categorias.Controls.Clear();       // Limpia el panel derecho
            control.Dock = DockStyle.Fill;     // Se ajusta al tamaño del panel
            Categorias.Controls.Add(control);  // Agrega el nuevo control
        }

        // 👉 Ejemplo de botón que carga el UserControl "Registros"
        private void button2_Click(object sender, EventArgs e)
        {
            LoadPanel(new Registros());   // "Registros" es tu UserControl
        }

        // ❌ Este evento Paint no lo necesitas para cargar cosas
        // Lo puedes dejar vacío o eliminarlo del diseñador
        private void Categorias_Paint(object sender, PaintEventArgs e)
        {
            // No cargar nada aquí
        }
    }
}
