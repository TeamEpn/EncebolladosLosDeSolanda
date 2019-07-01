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
    public partial class PrediccionPlatoFavorito : Form
    {
        public PrediccionPlatoFavorito()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            bool clienteExiste = true;  //se verificará en la base de datos
            if(clienteExiste)
            {
                MessageBox.Show("El plato favorito del cliente con cédula " + this.textBoxCedulaCliente.Text + "es:\n\n XXXXX");
            }
            else
            {
                MessageBox.Show("Cliente no registrado");
            }
        }
    }
}
