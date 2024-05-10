using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            string nombre = txt_Nombre_Registro.Text;
            string usuario = txt_Usuario_Registro.Text;
            string Tipo_Empleado = txt_Tipo_Empleado.Text;
            string contraseña = txt_Contraseña_Registro.Text;

            using (ConexionBaseDeDatos conexion = new ConexionBaseDeDatos())
            {
                SqlConnection cnx = conexion.ObtenerConexion();

                string query = "INSERT INTO Usuarios (Nombre, Usuario, Contraseña, Tipo_Usuario) VALUES (@Nombre, @Usuario, @Contraseña, @TipoUsuario)";
                SqlCommand command = new SqlCommand(query, cnx);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);
                command.Parameters.AddWithValue("@TipoUsuario", Tipo_Empleado);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
