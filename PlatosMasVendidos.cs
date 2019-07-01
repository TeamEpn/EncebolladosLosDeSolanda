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
    public partial class PlatosMasVendidos : Form
    {
        public PlatosMasVendidos()
        {
            InitializeComponent();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ButtonMostrarPlatos_Click(object sender, EventArgs e)
        {
            if (verificarFechas(this.dateTimePickerFInicio.Value, this.dateTimePickerFFin.Value))
            {
                MessageBox.Show("Los platos (en orden de venta) que más se vendieron en esas fechas son:\n1. Plato 1\n2. Plato 2\nn. Plato n");
            }
            else
            {
                MessageBox.Show("Fecha inválida");

            }

        }

        private bool verificarFechas(DateTime inicio, DateTime fin)
        {
            return true;
        }
    }
}
