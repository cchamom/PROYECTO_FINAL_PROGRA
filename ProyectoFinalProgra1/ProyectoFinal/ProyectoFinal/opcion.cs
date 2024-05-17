using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class opcion : Form
    {
        public opcion()
        {
            InitializeComponent();
        }
        //este metodo abre el fromulario de Gestiondepasciente
        private void btnpasciente_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDePasientes gestionDePasientes = new GestionDePasientes();
            gestionDePasientes.Show();
            Console.WriteLine("se abrio correctamente");
        }
        //este metodo abre el fromulario de empleados
        private void btnempleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            empleados Empleados = new empleados();
            Empleados.Show();
            Console.WriteLine("se abrio correctamente");
        }
    }
}
