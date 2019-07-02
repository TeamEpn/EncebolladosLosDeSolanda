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
    public partial class EmisionFactura : Form
    {
        public EmisionFactura()
        {
            InitializeComponent();
        }

        private bool camposValidos()
        {
            return true;
        }

        private void ButtonIngresar_Click(object sender, EventArgs e)
        {
            if (camposValidos())
            {
                if (Validacion.existeCliente(this.textBox1.Text))
                {
                    MessageBox.Show("Factura emitida satisfactoriamente");
                }
                else
                {
                    MessageBox.Show("El cliente no existe en la base de datos");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }

            


        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
