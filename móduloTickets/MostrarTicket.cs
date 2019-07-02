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
    public partial class ConsultarPedido : Form
    {
        public ConsultarPedido()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonMostrarTicket_Click(object sender, EventArgs e)
        {
            if (Validacion.existeTicket(this.textBoxIdPedido.Text))
            {
                MessageBox.Show("Pedido invalidado");
            }
            else
            {
                MessageBox.Show("El ticket no existe");
            }
        }
    }
}
