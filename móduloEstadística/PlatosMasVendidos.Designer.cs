namespace Interfaz
{
    partial class PlatosMasVendidos
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
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonMostrarPlatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFInicio = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(252, 179);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 11;
            this.buttonSalir.Text = "Cancelar";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // buttonMostrarPlatos
            // 
            this.buttonMostrarPlatos.Location = new System.Drawing.Point(59, 179);
            this.buttonMostrarPlatos.Name = "buttonMostrarPlatos";
            this.buttonMostrarPlatos.Size = new System.Drawing.Size(146, 23);
            this.buttonMostrarPlatos.TabIndex = 10;
            this.buttonMostrarPlatos.Text = "Mostrar Platos";
            this.buttonMostrarPlatos.UseVisualStyleBackColor = true;
            this.buttonMostrarPlatos.Click += new System.EventHandler(this.ButtonMostrarPlatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha inicio";
            // 
            // dateTimePickerFFin
            // 
            this.dateTimePickerFFin.Location = new System.Drawing.Point(127, 108);
            this.dateTimePickerFFin.Name = "dateTimePickerFFin";
            this.dateTimePickerFFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFFin.TabIndex = 7;
            // 
            // dateTimePickerFInicio
            // 
            this.dateTimePickerFInicio.Location = new System.Drawing.Point(127, 51);
            this.dateTimePickerFInicio.Name = "dateTimePickerFInicio";
            this.dateTimePickerFInicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFInicio.TabIndex = 6;
            // 
            // PlatosMasVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 252);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonMostrarPlatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFFin);
            this.Controls.Add(this.dateTimePickerFInicio);
            this.Name = "PlatosMasVendidos";
            this.Text = "PlatosMasVendidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonMostrarPlatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFInicio;
    }
}