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
    public partial class ClientesMasFrecuentes : Form
    {
        public ClientesMasFrecuentes()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            if (verificarFechas(this.dateTimePickerFInicio.Value, this.dateTimePickerFFin.Value))
            {
                MessageBox.Show("Los clientes (en orden de frecuencia) más frecuentes en esas fechas son:\n1. Cliente 1\n2. Cliente 2\nn. Cliente 3 ") ;
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
