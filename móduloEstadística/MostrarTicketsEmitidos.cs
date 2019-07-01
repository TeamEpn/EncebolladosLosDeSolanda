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
    public partial class MostrarTicketsEmitidos : Form
    {
        public MostrarTicketsEmitidos()
        {
            InitializeComponent();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonMostrar_Click(object sender, EventArgs e)
        {
            if (this.dateTimePickerFechaTickets.Value.Year <= 2019) {
                
                MessageBox.Show("Ese dia se emitieron: n tickets");
            }
            else
            {
                MessageBox.Show("Fecha inválida");
            }
        }
    }
}
