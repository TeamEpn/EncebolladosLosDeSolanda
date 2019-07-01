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
    public partial class PrediccionPlato : Form
    {
        public PrediccionPlato()
        {
            InitializeComponent();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonPredecir_Click(object sender, EventArgs e)
        {


            int dia = this.dateTimePickerFechaPrediccion.Value.Day;
            int mes = this.dateTimePickerFechaPrediccion.Value.Month;
            int anio = this.dateTimePickerFechaPrediccion.Value.Year;

            if(anio < 2019){
                MessageBox.Show("Fecha inválida");
            }
            else{
                MessageBox.Show("Según las compras de la última semana, los tres platos con más probabilidad de venderse son son:\n1. Plato 1\n2. Plato 2\n3. Plato 3");
                Console.WriteLine(dia + " " + mes + " " + anio);
            }

        }
    }
}
