using Interfaz.móduloPlatos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz{
    public partial class MenuPrincipal : Form {

        Form formPadre;


        public MenuPrincipal(Form padre) {
            InitializeComponent();
            this.BackColor = Color.Yellow;
            //Ocultar información antes de presionar algún boton boton grande
            formPadre = padre;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void Clientes_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void IngresarCliente_Click(object sender, EventArgs e)
        {
            Form ingresarCliente = new IngresarCliente();
            ingresarCliente.Show();

        }


        private void EliminarCliente_Click(object sender, EventArgs e)
        {
            Form eliminarCliente = new DarAltaBajaCliente();
            eliminarCliente.Show();
        }

        private void ActualizarCliente_Click(object sender, EventArgs e)
        {
            Form actualizarCliente = new ActualizarCliente();
            actualizarCliente.Show();
        }

        private void ConsultarCliente_Click(object sender, EventArgs e)
        {
            Form consultarCliente = new ConsultarCliente();
            consultarCliente.Show();
        }

        private void IngresarPlato_Click(object sender, EventArgs e)
        {
            Form ingresarPlato = new IngresarPlato();
            ingresarPlato.Show();
        }

        private void ActualizarPlato_Click(object sender, EventArgs e)
        {
            Form actualizarPlato = new ActualizarPlato();
            actualizarPlato.Show();
        }

        private void EliminarPlato_Click(object sender, EventArgs e)
        {
            Form eliminarPlato = new EliminarPlato();
            eliminarPlato.Show();
        }

        private void ConsultarPlato_Click(object sender, EventArgs e)
        {
            Form consultarPlato = new ConsultarPlato();
            consultarPlato.Show();
        }

        private void NuevoPedido_Click(object sender, EventArgs e)
        {
            Form nuevoPedido = new NuevoPedido();
            nuevoPedido.Show();
        }


        private void EliminarPedido_Click(object sender, EventArgs e)
        {
            Form eliminarPedido = new formIvalidarPedido();
            eliminarPedido.Show();
        }

        private void ConsultarPedido_Click(object sender, EventArgs e)
        {
            Form consultarPedido = new ConsultarPedido();
            consultarPedido.Show();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.formPadre.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.labelDescripcion.Text = "Descripcion del módulo Clientes";
        }

        private void DarDeBajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form activarDesactivarliente = new DarAltaBajaCliente();
            activarDesactivarliente.Show();
        }

        private void ConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarIngrediente consuling = new ConsultarIngrediente();
            consuling.Show();

        }

        private void IngresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarIngrediente ingresarIng = new IngresarIngrediente();
            ingresarIng.Show();

        }

        private void ReporteDiario_Click(object sender, EventArgs e)
        {
            PrediccionPlato ventanaPrediccionPlato = new PrediccionPlato();
            ventanaPrediccionPlato.Show();

        }

        private void ReporteSemanal_Click(object sender, EventArgs e)
        {
            MostrarTicketsEmitidos mostrarTicketsEmitidos = new MostrarTicketsEmitidos();
            mostrarTicketsEmitidos.Show();
        }

        private void PrediccionDiaria_Click(object sender, EventArgs e)
        {
            PrediccionPlatoFavorito prediccionPlatoFavorito = new PrediccionPlatoFavorito();
            prediccionPlatoFavorito.Show();
        }

        private void MostrarClienteMásFrecuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesMasFrecuentes clientesMasFrecuentes = new ClientesMasFrecuentes();
            clientesMasFrecuentes.Show();
        }

        private void MostratPlatosMásVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlatosMasVendidos platosMasVendidos = new PlatosMasVendidos();
            platosMasVendidos.Show();
        }

        private void EmitirBalanceDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            balance.Show();
        }

        private void ButtonPlatos_Click(object sender, EventArgs e)
        {
            this.labelDescripcion.Text = "Descripcion del módulo Platos";
        }

        private void ButtonEstadistica_Click(object sender, EventArgs e)
        {
            this.labelDescripcion.Text = "Descripcion del módulo Estadística";
        }

        private void ButtonTieckets_Click(object sender, EventArgs e)
        {
            this.labelDescripcion.Text = "Descripcion del módulo Tickets";
        }

        private void ButtonAdministración_Click(object sender, EventArgs e)
        {
            this.labelDescripcion.Text = "Descripcion del módulo Administración";
        }

        private void EmitirFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmisionFactura emisionFactura = new EmisionFactura();
            emisionFactura.Show();
        }

        private void DarDeAltaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DarDeAlta darDeAlta = new DarDeAlta();
            darDeAlta.Show();
        }

        private void DarDeAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.móduloClientes.DarDeAltaPlato darDeAltaPlato = new móduloClientes.DarDeAltaPlato();
            darDeAltaPlato.Show();
        }

        private void DarDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarPlato eliminarPlato = new EliminarPlato();
            eliminarPlato.Show();
        }

        private void ActualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarIngrediente acutaliing = new ActualizarIngrediente();
            acutaliing.Show();
        }

        private void DarDeAltaIngredienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DarDeAltaIngrediente daraltaing = new DarDeAltaIngrediente();
            daraltaing.Show();
        }

        private void DarDeBajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DarBajaIngrediente darbajaing = new DarBajaIngrediente();
            darbajaing.Show();
        }

        private void ResetearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form resetear = new Resetear();
            resetear.Show();
        }
    }
}
