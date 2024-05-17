using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace ProyectoFinal
{ 
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //para que el usuario pueda iniciar sesion
        private void btn_Acceder_Click(object sender, EventArgs e)
        {
            string usuario = txt_Usuario.Text.Trim();
            string contraseña = txt_Contraseña.Text.Trim();
            if (usuario == "keily02" && contraseña == "lopez2024")
                this.Hide();
            //te abre el formulario de opcion
                opcion Opcion = new opcion();
                Opcion.Show();
            Console.WriteLine("se abrio correctamente");

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PQBRDPK\\SQLEXPRESS;Initial Catalog=Usuarios;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {

                    MessageBox.Show("Inicio de sesión exitoso.");
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                }
            }


            }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Usuario.Text = " ";
            txt_Contraseña.Text = " ";

        } 

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
          
        }
    }
}
