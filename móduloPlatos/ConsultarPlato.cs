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
    public partial class ConsultarPlato : Form
    {
        public ConsultarPlato()
        {
            InitializeComponent();
            this.BackColor = Color.LightGreen;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool validarCampos()
        {
            return true;
        }


        private void ButtonConsultar_Click(object sender, EventArgs e)
        {

            if (validarCampos()) { 
                if (Validacion.estaPlatoRegistrado(this.textBoxNombre.Text))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        this.listBox1.Items.Add("DATOS e INGREDIENTES " + i + " Plato");
                    }
                }
                else
                {
                    MessageBox.Show("Plato no encontrado");
                }
            }
            else
            {
                MessageBox.Show("Error de consulta");
            }
        }
    }
}
