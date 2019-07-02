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
    public partial class EliminarPlato : Form
    {
        public EliminarPlato()
        {
            InitializeComponent();
            this.BackColor = Color.LightGreen;
        }

        private void BotonCancelarEliCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonEliminarEliCli_Click(object sender, EventArgs e)
        {
            if (Validacion.estaPlatoRegistrado(this.textBoxNombrePlato.Text))
            {

                bool platoDadoBaja = false; //esto se busca en la base de datos

                if (platoDadoBaja)
                {
                    MessageBox.Show("El plato ya se encuentra dado de baja");
                }
                else
                {
                    MessageBox.Show("El plato ha sido dado de baja en el sistema");
                }
            }
            else
            {
                MessageBox.Show("El plato no existe en el Sistema");
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

        private void TextBoxNombrePlato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
