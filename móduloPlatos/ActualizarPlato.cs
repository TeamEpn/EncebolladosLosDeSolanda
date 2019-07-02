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
    public partial class ActualizarPlato : Form
    {
        public ActualizarPlato()
        {
            InitializeComponent();
            this.BackColor = Color.LightGreen;

        }

        private bool validarCampos()
        {
            return this.textBox1.Text == "" || textBox2.Text == "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (validarCampos())
            {

                MessageBox.Show("Error al actualizar el plato");
            }
            else
            {

                if (Validacion.estaPlatoRegistrado(this.textBox1.Text))
                {
                    //se actualiza en la base de datos
                    MessageBox.Show("Plato actualizado exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al actualizar el plato");
                }

            }



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
