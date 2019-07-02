using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class ActualizarCliente : Form
    {
        public ActualizarCliente()
        {
            InitializeComponent();
            this.BackColor = Color.SkyBlue;
        }

        private void BotonActualizarActCli_Click(object sender, EventArgs e)
        {

            if (!Validacion.cedulaRepetida(this.textBoxCedula.Text))
            {
                ///////reemplazo de datos en la base de datos/////
                MessageBox.Show("El cliente ha sido actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Número de cédula ya existente en el sistema ");
            }


        }

        private void BotonCancelarActCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
