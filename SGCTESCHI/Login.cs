﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SGCTESCHI
{
    public partial class Login : Form
    {
        // 🔹 Cadena de conexión (ajústala si tu instancia/localdb es diferente)
        string connectionString = @"Server=.\SQLEXPRESS;Database=SGCTESCHI;Trusted_Connection=True;";

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Obtiene los valores de los TextBox (suponiendo txtUsuario y txtContrasena)
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContraseña.Text.Trim();

            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show("Por favor, ingresa usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT u.idUsuario, tu.dTipoUsuario 
                                     FROM Usuario u
                                     INNER JOIN TipoUsuario tu ON u.idTipoUsuario = tu.idTipoUsuario
                                     WHERE u.idUsuario = @idUsuario AND u.contrasena = @contrasena";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idUsuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string tipoUsuario = reader["dTipoUsuario"].ToString();

                        MessageBox.Show("Bienvenido " + tipoUsuario, "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Abrir formulario Menu
                        Menu menu = new Menu();
                        menu.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
