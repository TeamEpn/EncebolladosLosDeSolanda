using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.móduloPlatos
{
    public partial class IngresarIngrediente : Form
    {
        public IngresarIngrediente()
        {
            InitializeComponent();
            this.BackColor = Color.LightGreen;
            camposVacios();
            
        }
        private void camposVacios() {
            labelOk.Visible = false;
            labelError.Visible = false;
            textBoxNombre.Text = "";
            textBoxPrecio.Text = "";
        }
        private void camposError() {
            labelError.Visible = true;
            textBoxNombre.BackColor = Color.Pink;
            textBoxPrecio.BackColor = Color.Pink;
        }
        private void camposBlancos() {
            textBoxNombre.BackColor = Color.White;
            textBoxPrecio.BackColor = Color.White;
        }
        private bool validarCampos() {
            return textBoxNombre.Text == "" || textBoxPrecio.Text == "";
        }
        private void ButtonIngresar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                camposError();
            }
            else
            {
                camposVacios();
                labelOk.Visible = true;
            }
        }
    }
}
