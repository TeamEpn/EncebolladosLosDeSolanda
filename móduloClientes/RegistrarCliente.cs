using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz{
    public partial class IngresarCliente : Form{
        public IngresarCliente(){
            InitializeComponent();
            this.BackColor = Color.SkyBlue;
            camposblancos();
        }

        private void FormIngresarCliente_Load(object sender, EventArgs e){
            
        }

        private void camposblancos() {
            labelErrorCliente.Visible = false;
            labelOk.Visible = false;
            textBoxDocumento.BackColor = Color.White;
            textBoxDireccion.BackColor = Color.White;
            textBoxNombreCli.BackColor = Color.White;
            textBoxApellidoCli.BackColor = Color.White;
        }
        private void camposError() {
            labelErrorCliente.Visible = true;
            textBoxDireccion.BackColor = Color.Pink;
            textBoxNombreCli.BackColor = Color.Pink;
            textBoxApellidoCli.BackColor = Color.Pink;
            textBoxDocumento.BackColor = Color.Pink;
        }
        private void camposvacios() {
            textBoxNombreCli.Text = "";
            textBoxApellidoCli.Text = "";
            textBoxDireccion.Text = "";
            textBoxDocumento.Text = "";
        }
        private bool contieneCaracteresRaros() {
            return textBoxNombreCli.Text.Contains("?")
                || textBoxNombreCli.Text.Contains("\\")
                || textBoxApellidoCli.Text.Contains("_")
                || textBoxNombreCli.Text.Contains("+")
                || textBoxNombreCli.Text.Contains("-")
                || textBoxNombreCli.Text.Contains("@")
                || textBoxNombreCli.Text.Contains("#")
                || textBoxNombreCli.Text.Contains("$")
                || textBoxNombreCli.Text.Contains("*")
                || textBoxNombreCli.Text == ""
                || textBoxApellidoCli.Text == ""
                || textBoxDireccion.Text == ""
                || textBoxDocumento.Text == "";
        }

        private void BotonCancelarIngCli_Click(object sender, EventArgs e){
            this.Close();
        }

        private void TextBoxDocumento_KeyDown(object sender, KeyEventArgs e){
            camposblancos();

        }

        private void TextBoxNombreCli_KeyDown(object sender, KeyEventArgs e){
            camposblancos();
        }

        private void TextBoxApellidoCli_KeyDown(object sender, KeyEventArgs e){
            camposblancos();
        }

        private void TextBoxDireccion_KeyDown(object sender, KeyEventArgs e){
            camposblancos();
        }

        private void BotonIngresarIngCli_Click(object sender, EventArgs e){
            if (contieneCaracteresRaros()){ //da true cuando no se ha podido validar los campos

                MessageBox.Show("El cliente no se ha podido registrar, verifique la información");
                camposError();
            }
            else
            {

                if (Validacion.esCedulaValida(this.textBoxDocumento.Text))
                {
                    //conexion de base de datos aqui para registrar cliente
                    MessageBox.Show("El cliente se ha registrado exitosamente");
                    labelOk.Visible = true;
                    camposvacios();
                }
                else
                {
                    MessageBox.Show("El cliente no se ha podido registrar, verifique la información");
                }
                

            }
        }
    }
}
