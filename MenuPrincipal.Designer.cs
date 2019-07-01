namespace Interfaz
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPlato = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarPlato = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarPlato = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPlato = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDiario = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteSemanal = new System.Windows.Forms.ToolStripMenuItem();
            this.prediccionDiaria = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarClienteMásFrecuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostratPlatosMásVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirBalanceDeCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdminSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeParámetrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonPlatos = new System.Windows.Forms.Button();
            this.buttonEstadistica = new System.Windows.Forms.Button();
            this.buttonTieckets = new System.Windows.Forms.Button();
            this.buttonAdministración = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuPlato,
            this.menuEstadisticas,
            this.menuTickets,
            this.menuAdminSistema});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(343, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuClientes
            // 
            this.menuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarCliente,
            this.actualizarCliente,
            this.consultarCliente,
            this.darDeBajaToolStripMenuItem1});
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(56, 20);
            this.menuClientes.Text = "Cliente";
            this.menuClientes.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // ingresarCliente
            // 
            this.ingresarCliente.Name = "ingresarCliente";
            this.ingresarCliente.Size = new System.Drawing.Size(161, 22);
            this.ingresarCliente.Text = "Ingresar";
            this.ingresarCliente.Click += new System.EventHandler(this.IngresarCliente_Click);
            // 
            // actualizarCliente
            // 
            this.actualizarCliente.Name = "actualizarCliente";
            this.actualizarCliente.Size = new System.Drawing.Size(161, 22);
            this.actualizarCliente.Text = "Actualizar";
            this.actualizarCliente.Click += new System.EventHandler(this.ActualizarCliente_Click);
            // 
            // consultarCliente
            // 
            this.consultarCliente.Name = "consultarCliente";
            this.consultarCliente.Size = new System.Drawing.Size(161, 22);
            this.consultarCliente.Text = "Consultar";
            this.consultarCliente.Click += new System.EventHandler(this.ConsultarCliente_Click);
            // 
            // darDeBajaToolStripMenuItem1
            // 
            this.darDeBajaToolStripMenuItem1.Name = "darDeBajaToolStripMenuItem1";
            this.darDeBajaToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.darDeBajaToolStripMenuItem1.Text = "Dar de baja | alta";
            this.darDeBajaToolStripMenuItem1.Click += new System.EventHandler(this.DarDeBajaToolStripMenuItem1_Click);
            // 
            // menuPlato
            // 
            this.menuPlato.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarPlato,
            this.actualizarPlato,
            this.consultarPlato,
            this.darDeAltaToolStripMenuItem,
            this.darDeBajaToolStripMenuItem,
            this.ingresientesToolStripMenuItem});
            this.menuPlato.Name = "menuPlato";
            this.menuPlato.Size = new System.Drawing.Size(46, 20);
            this.menuPlato.Text = "Plato";
            // 
            // ingresarPlato
            // 
            this.ingresarPlato.Name = "ingresarPlato";
            this.ingresarPlato.Size = new System.Drawing.Size(180, 22);
            this.ingresarPlato.Text = "Ingresar";
            this.ingresarPlato.Click += new System.EventHandler(this.IngresarPlato_Click);
            // 
            // actualizarPlato
            // 
            this.actualizarPlato.Name = "actualizarPlato";
            this.actualizarPlato.Size = new System.Drawing.Size(180, 22);
            this.actualizarPlato.Text = "Actualizar";
            this.actualizarPlato.Click += new System.EventHandler(this.ActualizarPlato_Click);
            // 
            // consultarPlato
            // 
            this.consultarPlato.Name = "consultarPlato";
            this.consultarPlato.Size = new System.Drawing.Size(180, 22);
            this.consultarPlato.Text = "Consultar";
            this.consultarPlato.Click += new System.EventHandler(this.ConsultarPlato_Click);
            // 
            // darDeAltaToolStripMenuItem
            // 
            this.darDeAltaToolStripMenuItem.Name = "darDeAltaToolStripMenuItem";
            this.darDeAltaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darDeAltaToolStripMenuItem.Text = "Dar de alta";
            // 
            // darDeBajaToolStripMenuItem
            // 
            this.darDeBajaToolStripMenuItem.Name = "darDeBajaToolStripMenuItem";
            this.darDeBajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darDeBajaToolStripMenuItem.Text = "Dar de baja";
            // 
            // ingresientesToolStripMenuItem
            // 
            this.ingresientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.ingresientesToolStripMenuItem.Name = "ingresientesToolStripMenuItem";
            this.ingresientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresientesToolStripMenuItem.Text = "Ingredientes";
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarToolStripMenuItem.Text = "Ingresar";
            this.ingresarToolStripMenuItem.Click += new System.EventHandler(this.IngresarToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.ConsultarToolStripMenuItem_Click);
            // 
            // menuEstadisticas
            // 
            this.menuEstadisticas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDiario,
            this.reporteSemanal,
            this.prediccionDiaria,
            this.mostrarClienteMásFrecuenteToolStripMenuItem,
            this.mostratPlatosMásVendidosToolStripMenuItem,
            this.emitirBalanceDeCuentasToolStripMenuItem});
            this.menuEstadisticas.Name = "menuEstadisticas";
            this.menuEstadisticas.Size = new System.Drawing.Size(79, 20);
            this.menuEstadisticas.Text = "Estadisticas";
            // 
            // reporteDiario
            // 
            this.reporteDiario.Name = "reporteDiario";
            this.reporteDiario.Size = new System.Drawing.Size(243, 22);
            this.reporteDiario.Text = "Predecir plato más vendido";
            this.reporteDiario.Click += new System.EventHandler(this.ReporteDiario_Click);
            // 
            // reporteSemanal
            // 
            this.reporteSemanal.Name = "reporteSemanal";
            this.reporteSemanal.Size = new System.Drawing.Size(237, 22);
            this.reporteSemanal.Text = "Mostrat tickets emitidos";
            this.reporteSemanal.Click += new System.EventHandler(this.ReporteSemanal_Click);
            // 
            // prediccionDiaria
            // 
            this.prediccionDiaria.Name = "prediccionDiaria";
            this.prediccionDiaria.Size = new System.Drawing.Size(231, 22);
            this.prediccionDiaria.Text = "Predecir plato favorito";
            this.prediccionDiaria.Click += new System.EventHandler(this.PrediccionDiaria_Click);
            // 
            // mostrarClienteMásFrecuenteToolStripMenuItem
            // 
            this.mostrarClienteMásFrecuenteToolStripMenuItem.Name = "mostrarClienteMásFrecuenteToolStripMenuItem";
            this.mostrarClienteMásFrecuenteToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.mostrarClienteMásFrecuenteToolStripMenuItem.Text = "Mostrar cliente más frecuente";
            this.mostrarClienteMásFrecuenteToolStripMenuItem.Click += new System.EventHandler(this.MostrarClienteMásFrecuenteToolStripMenuItem_Click);
            // 
            // mostratPlatosMásVendidosToolStripMenuItem
            // 
            this.mostratPlatosMásVendidosToolStripMenuItem.Name = "mostratPlatosMásVendidosToolStripMenuItem";
            this.mostratPlatosMásVendidosToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.mostratPlatosMásVendidosToolStripMenuItem.Text = "Mostrat platos más vendidos";
            this.mostratPlatosMásVendidosToolStripMenuItem.Click += new System.EventHandler(this.MostratPlatosMásVendidosToolStripMenuItem_Click);
            // 
            // emitirBalanceDeCuentasToolStripMenuItem
            // 
            this.emitirBalanceDeCuentasToolStripMenuItem.Name = "emitirBalanceDeCuentasToolStripMenuItem";
            this.emitirBalanceDeCuentasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.emitirBalanceDeCuentasToolStripMenuItem.Text = "Emitir Balance de Cuentas";
            this.emitirBalanceDeCuentasToolStripMenuItem.Click += new System.EventHandler(this.EmitirBalanceDeCuentasToolStripMenuItem_Click);
            // 
            // menuTickets
            // 
            this.menuTickets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPedido,
            this.eliminarPedido,
            this.consultarPedido});
            this.menuTickets.Name = "menuTickets";
            this.menuTickets.Size = new System.Drawing.Size(56, 20);
            this.menuTickets.Text = "Tickets";
            // 
            // nuevoPedido
            // 
            this.nuevoPedido.Name = "nuevoPedido";
            this.nuevoPedido.Size = new System.Drawing.Size(165, 22);
            this.nuevoPedido.Text = "Nuevo Pedido";
            this.nuevoPedido.Click += new System.EventHandler(this.NuevoPedido_Click);
            // 
            // eliminarPedido
            // 
            this.eliminarPedido.Name = "eliminarPedido";
            this.eliminarPedido.Size = new System.Drawing.Size(165, 22);
            this.eliminarPedido.Text = "Anular Pedido";
            this.eliminarPedido.Click += new System.EventHandler(this.EliminarPedido_Click);
            // 
            // consultarPedido
            // 
            this.consultarPedido.Name = "consultarPedido";
            this.consultarPedido.Size = new System.Drawing.Size(165, 22);
            this.consultarPedido.Text = "Consultar Pedido";
            this.consultarPedido.Click += new System.EventHandler(this.ConsultarPedido_Click);
            // 
            // menuAdminSistema
            // 
            this.menuAdminSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónDeSistemaToolStripMenuItem,
            this.administraciónDeParámetrosToolStripMenuItem});
            this.menuAdminSistema.Name = "menuAdminSistema";
            this.menuAdminSistema.Size = new System.Drawing.Size(100, 20);
            this.menuAdminSistema.Text = "Administración";
            // 
            // administraciónDeSistemaToolStripMenuItem
            // 
            this.administraciónDeSistemaToolStripMenuItem.Name = "administraciónDeSistemaToolStripMenuItem";
            this.administraciónDeSistemaToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.administraciónDeSistemaToolStripMenuItem.Text = "Administración de Sistema";
            // 
            // administraciónDeParámetrosToolStripMenuItem
            // 
            this.administraciónDeParámetrosToolStripMenuItem.Name = "administraciónDeParámetrosToolStripMenuItem";
            this.administraciónDeParámetrosToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.administraciónDeParámetrosToolStripMenuItem.Text = "Administración de Parámetros";
            // 
            // buttonClientes
            // 
            this.buttonClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonClientes.Location = new System.Drawing.Point(4, 335);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(161, 34);
            this.buttonClientes.TabIndex = 3;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonPlatos
            // 
            this.buttonPlatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPlatos.Location = new System.Drawing.Point(171, 335);
            this.buttonPlatos.Name = "buttonPlatos";
            this.buttonPlatos.Size = new System.Drawing.Size(165, 34);
            this.buttonPlatos.TabIndex = 4;
            this.buttonPlatos.Text = "Plato";
            this.buttonPlatos.UseVisualStyleBackColor = true;
            // 
            // buttonEstadistica
            // 
            this.buttonEstadistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEstadistica.Location = new System.Drawing.Point(4, 375);
            this.buttonEstadistica.Name = "buttonEstadistica";
            this.buttonEstadistica.Size = new System.Drawing.Size(161, 32);
            this.buttonEstadistica.TabIndex = 5;
            this.buttonEstadistica.Text = "Estadística";
            this.buttonEstadistica.UseVisualStyleBackColor = true;
            // 
            // buttonTieckets
            // 
            this.buttonTieckets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonTieckets.Location = new System.Drawing.Point(171, 375);
            this.buttonTieckets.Name = "buttonTieckets";
            this.buttonTieckets.Size = new System.Drawing.Size(165, 32);
            this.buttonTieckets.TabIndex = 6;
            this.buttonTieckets.Text = "Tickets";
            this.buttonTieckets.UseVisualStyleBackColor = true;
            // 
            // buttonAdministración
            // 
            this.buttonAdministración.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAdministración.Location = new System.Drawing.Point(4, 413);
            this.buttonAdministración.Name = "buttonAdministración";
            this.buttonAdministración.Size = new System.Drawing.Size(161, 30);
            this.buttonAdministración.TabIndex = 7;
            this.buttonAdministración.Text = "Adminsitración";
            this.buttonAdministración.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSalir.Location = new System.Drawing.Point(171, 413);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(165, 30);
            this.buttonSalir.TabIndex = 8;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 56);
            this.label1.TabIndex = 9;
            this.label1.Text = "Encebollados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 56);
            this.label2.TabIndex = 10;
            this.label2.Text = "Los de Solanda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Aqui información de lo que hace cada modulo al presionar un boton";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 455);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonAdministración);
            this.Controls.Add(this.buttonTieckets);
            this.Controls.Add(this.buttonEstadistica);
            this.Controls.Add(this.buttonPlatos);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem ingresarCliente;
        private System.Windows.Forms.ToolStripMenuItem actualizarCliente;
        private System.Windows.Forms.ToolStripMenuItem consultarCliente;
        private System.Windows.Forms.ToolStripMenuItem menuPlato;
        private System.Windows.Forms.ToolStripMenuItem ingresarPlato;
        private System.Windows.Forms.ToolStripMenuItem actualizarPlato;
        private System.Windows.Forms.ToolStripMenuItem consultarPlato;
        private System.Windows.Forms.ToolStripMenuItem menuEstadisticas;
        private System.Windows.Forms.ToolStripMenuItem reporteDiario;
        private System.Windows.Forms.ToolStripMenuItem reporteSemanal;
        private System.Windows.Forms.ToolStripMenuItem prediccionDiaria;
        private System.Windows.Forms.ToolStripMenuItem menuTickets;
        private System.Windows.Forms.ToolStripMenuItem nuevoPedido;
        private System.Windows.Forms.ToolStripMenuItem eliminarPedido;
        private System.Windows.Forms.ToolStripMenuItem consultarPedido;
        private System.Windows.Forms.ToolStripMenuItem menuAdminSistema;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeParámetrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaToolStripMenuItem1;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonPlatos;
        private System.Windows.Forms.Button buttonEstadistica;
        private System.Windows.Forms.Button buttonTieckets;
        private System.Windows.Forms.Button buttonAdministración;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mostrarClienteMásFrecuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostratPlatosMásVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirBalanceDeCuentasToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}