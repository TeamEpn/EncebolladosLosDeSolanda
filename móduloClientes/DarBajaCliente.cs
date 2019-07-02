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
    public partial class DarAltaBajaCliente : Form
    {
        public DarAltaBajaCliente()
        {
            InitializeComponent();
            this.BackColor = Color.SkyBlue;
        }

        private void BotonCancelarEliCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonEliminarEliCli_Click(object sender, EventArgs e)
        {


            if (Validacion.existeCliente(this.textBoxCedula.Text))
            {

                bool clienteDadoBaja = false; //esto se busca en la base de datos

                if (clienteDadoBaja)
                {
                    MessageBox.Show("El cliente ya se encuentra dado de baja");
                }
                else
                {
                    MessageBox.Show("El cliente ha sido dado de baja en el sistema");
                }
            }
            else
            {
                MessageBox.Show("El cliente no existe en el Sistema");
            }

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
