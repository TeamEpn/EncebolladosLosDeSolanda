﻿using System;
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
    public partial class NuevoPedido : Form
    {
        public NuevoPedido()
        {
            InitializeComponent();
            this.BackColor = Color.LightGray;
        }

        private void FormNuevoPedido_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool camposValidos()
        {
            return true;
        }


        private void ButtonIngresar_Click(object sender, EventArgs e)
        {
            if (camposValidos())
            {
                MessageBox.Show("Pedido creado exitosamente y Ticket creado");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
