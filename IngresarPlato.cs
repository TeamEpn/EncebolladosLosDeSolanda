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
    public partial class IngresarPlato : Form
    {
        public IngresarPlato(){
            InitializeComponent();
            this.BackColor = Color.LightGreen;
            camposBlancos();
        }
        private void camposError() {
            labelError.Visible = true;
            textBoxNombre.BackColor = Color.Pink;
            textBoxPrecio.BackColor = Color.Pink;
        }
        private void camposBlancos() {
            labelError.Visible = false;
            labelOk.Visible = false;
            textBoxNombre.BackColor = Color.White;
            textBoxPrecio.BackColor = Color.White;
        }
        private void camposvacios() {   
            textBoxNombre.Text = "";
            textBoxPrecio.Text = "";
        }
        private bool validarCampos() {
            return textBoxNombre.Text == "" || textBoxPrecio.Text == ""; 
        }
        private void ButtonIngresar_Click(object sender, EventArgs e)
        {
            if (validarCampos()) {
                camposError();
            }else{
                labelOk.Visible = true;
                camposvacios();
            }
        }

        private void TextBoxNombre_KeyDown(object sender, KeyEventArgs e){
            camposBlancos();
        }

        private void TextBoxPrecio_KeyDown(object sender, KeyEventArgs e){
            camposBlancos();

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
