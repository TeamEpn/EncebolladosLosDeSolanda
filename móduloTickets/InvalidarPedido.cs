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
    public partial class formIvalidarPedido : Form
    {
        public formIvalidarPedido()
        {
            InitializeComponent();
            this.BackColor = Color.LightGray;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEliminarPedido_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (Validacion.existePedido(this.textBoxIdPedido.Text))
            {
                MessageBox.Show("INFORMACIÓN DEL TICKET ASOCIADO A UN PEDIDO...\n..\n...");
            }
            else
            {
                MessageBox.Show("Pedido no encontrado en a base datos");
            }

        }
    }
}
