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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (verificarFechas(this.dateTimePickerFInicio.Value, this.dateTimePickerFFin.Value))
            {
                int totalIngresos = 0;

                for (int i = 0; i < this.listBoxIngresos.Items.Count; i++)
                {
                    totalIngresos += Convert.ToInt32(this.listBoxIngresos.Items[i].ToString());
                }

                int totalEgresos = 0;

                for (int i = 0; i < this.listBoxEgresos.Items.Count; i++)
                {
                    totalEgresos += Convert.ToInt32(this.listBoxEgresos.Items[i].ToString());
                }


                MessageBox.Show("TOTAL ingresos: " + totalIngresos + "\nTOTAL egresos: " + totalEgresos);
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

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
