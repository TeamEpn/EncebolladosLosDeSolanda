namespace Interfaz
{
    partial class MostrarTicketsEmitidos
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
            this.dateTimePickerFechaTickets = new System.Windows.Forms.DateTimePicker();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerFechaTickets
            // 
            this.dateTimePickerFechaTickets.Location = new System.Drawing.Point(86, 30);
            this.dateTimePickerFechaTickets.Name = "dateTimePickerFechaTickets";
            this.dateTimePickerFechaTickets.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaTickets.TabIndex = 0;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(86, 75);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrar.TabIndex = 1;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.ButtonMostrar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(211, 75);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // MostrarTicketsEmitidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 144);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.dateTimePickerFechaTickets);
            this.Name = "MostrarTicketsEmitidos";
            this.Text = "MostrarTicketsEmitidos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFechaTickets;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonSalir;
    }
}