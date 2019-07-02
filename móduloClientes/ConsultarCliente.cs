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
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
            this.BackColor = Color.SkyBlue;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (Validacion.existeCliente(this.textBoxCedula.Text))
            {
                for (int i = 0; i < 5; i++)
                {
                    this.listBox1.Items.Add("DATOS " + i + " CLIENTE");
                }
            }
            else
            {
                MessageBox.Show("Los datos ingresados no existen en el sistema");
            }


        }
    }
}
