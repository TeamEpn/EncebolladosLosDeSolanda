using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.BackColor = Color.Yellow;
            buttonIngresar.Enabled = false;

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text  == "USER" && textBoxContrasenia.Text == "12345") { //validar autenticacion con la base de datos y md5
                buttonIngresar.Enabled = false;
                new MenuPrincipal(this).Show();
                this.Hide();
            } else {
                textBoxUsuario.BackColor = Color.Pink;
                textBoxContrasenia.BackColor = Color.Pink;
                textBoxContrasenia.Text = "";
                labelError.Visible = true;
            }
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxUsuario.BackColor = Color.White;
            textBoxUsuario.BackColor = Color.White;
            labelError.Visible = false;
            buttonIngresar.Enabled = true;
        }

        private void TextBoxContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar== Convert.ToChar(Keys.Enter)) {
            //    buttonIngresar.Enabled = false;
            //    new MenuPrincipal().Show();
            //    this.Hide();
            //}
        }
    }
}
