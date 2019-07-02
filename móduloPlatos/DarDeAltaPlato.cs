using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.móduloClientes
{
    public partial class DarDeAltaPlato : Form
    {
        public DarDeAltaPlato()
        {
            InitializeComponent();
        }

        private void BotonDarAltaPlato_Click(object sender, EventArgs e)
        {
            if (Validacion.estaPlatoRegistrado(this.textBoxNombrePlato.Text))
            {

                bool platoDadoAlta = false; //esto se busca en la base de datos

                if (platoDadoAlta)
                {
                    MessageBox.Show("El plato ya se encuentra dado de alta");
                }
                else
                {
                    MessageBox.Show("El plato ha sido dado de alta en el sistema");
                }
            }
            else
            {
                MessageBox.Show("El plato no existe en el Sistema");
            }
        }

        private void BotonCancelarEliCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
