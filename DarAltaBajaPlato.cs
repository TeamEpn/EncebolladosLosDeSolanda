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
    public partial class EliminarPlato : Form
    {
        public EliminarPlato()
        {
            InitializeComponent();
            this.BackColor = Color.LightGreen;
        }

        private void BotonCancelarEliCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
