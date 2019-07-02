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
    public partial class DarDeAlta : Form
    {
        public DarDeAlta()
        {
            InitializeComponent();
            this.BackColor = Color.SkyBlue;
        }

        private void BotonEliminarEliCli_Click(object sender, EventArgs e)
        {
            if (Validacion.existeCliente(this.textBoxCedula.Text))
            {

                bool clienteDadoAlta = false; //esto se busca en la base de datos

                if (clienteDadoAlta)
                {
                    MessageBox.Show("El cliente ya se encuentra dado de alta");
                }
                else
                {
                    MessageBox.Show("El cliente ha sido dado de alta en el sistema");
                }
            }
            else
            {
                MessageBox.Show("El cliente no existe en el Sistema");
            }
        }

        private void BotonCancelarEliCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
