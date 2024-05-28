using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class GestionDePasientes : Form
    {
        // Método para abrir la Base de Datos
        private SqlConnection cnx;

        public GestionDePasientes()
        {
            InitializeComponent();
            cnx = new SqlConnection("Data Source=DESKTOP-PQBRDPK\\SQLEXPRESS;Initial Catalog=Usuarios;Integrated Security=True;");
        }

        private void Abrir_Conexion()
        {
            if (cnx.State != ConnectionState.Open)
            {
                cnx.Open();
            }
        }

        private void Cerrar_Conexion()
        {
            if (cnx.State != ConnectionState.Closed)
            {
                cnx.Close();
            }
        }

        private void Agregar_Paciente(string nombre, string apellidos, int edad, DateTime fechaNacimiento, string genero, string direccion, string telefono, string email)
        {
            try
            {
                Abrir_Conexion();
                string query = "INSERT INTO bd_Pacientes (Nombre, Apellido, Edad, FechaNacimiento, Genero, Direccion, Telefono, Email) VALUES (@Nombre, @Apellido, @Edad, @FechaNacimiento, @Genero, @Direccion, @Telefono, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellidos);
                    cmd.Parameters.AddWithValue("@Edad", edad);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    cmd.Parameters.AddWithValue("@Genero", genero);
                    cmd.Parameters.AddWithValue("@Direccion", direccion);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Email", email);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Paciente agregado correctamente.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al agregar paciente en la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
            finally
            {
                Cerrar_Conexion();
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tn_Historrial_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void GestionDePasientes_Load(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        // CRUD
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de entrada de datos
            string nombre = txt_Nombre.Text;
            string apellidos = txt_Apellidos.Text;
            int edad;
            if (!int.TryParse(txt_Edad.Text, out edad))
            {
                MessageBox.Show("Por favor, ingrese una edad válida.");
                return;
            }

            DateTime fechaNacimiento = dateTimePicker.Value;
            string genero = comboBox.SelectedItem?.ToString();
            if (genero == null)
            {
                MessageBox.Show("Por favor, seleccione un género.");
                return;
            }

            string direccion = txt_Direccion.Text;
            string telefono = txt_Telefono.Text;
            string email = txt_Email.Text;

            // Llamar al método para agregar paciente con los valores obtenidos
            Agregar_Paciente(nombre, apellidos, edad, fechaNacimiento, genero, direccion, telefono, email);
        }
    }
}
