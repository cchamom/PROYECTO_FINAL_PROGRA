using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal
{
    class ConexionBaseDeDatos : IDisposable
    {
        SqlConnection cnx;

        public ConexionBaseDeDatos()
        {
            try
            {
                cnx = new SqlConnection("Data Source=DESKTOP-PQBRDPK\\SQLEXPRESS;Initial Catalog=Usuarios;Integrated Security=True;");
                cnx.Open();

                MessageBox.Show("Se conectó correctamente", "Exito al conectar", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error inesperado", MessageBoxButtons.OK);
                throw; 
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return cnx;
        }

        public void Dispose()
        {
            if (cnx != null)
            {
                cnx.Close();
                cnx.Dispose();
            }
        }
    }
}
