namespace Interfaz
{
    partial class PrediccionPlato
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
            this.dateTimePickerFechaPrediccion = new System.Windows.Forms.DateTimePicker();
            this.buttonPredecir = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerFechaPrediccion
            // 
            this.dateTimePickerFechaPrediccion.Location = new System.Drawing.Point(81, 38);
            this.dateTimePickerFechaPrediccion.Name = "dateTimePickerFechaPrediccion";
            this.dateTimePickerFechaPrediccion.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaPrediccion.TabIndex = 0;
            // 
            // buttonPredecir
            // 
            this.buttonPredecir.Location = new System.Drawing.Point(81, 92);
            this.buttonPredecir.Name = "buttonPredecir";
            this.buttonPredecir.Size = new System.Drawing.Size(75, 23);
            this.buttonPredecir.TabIndex = 1;
            this.buttonPredecir.Text = "Predecir";
            this.buttonPredecir.UseVisualStyleBackColor = true;
            this.buttonPredecir.Click += new System.EventHandler(this.ButtonPredecir_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(206, 92);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // PrediccionPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 136);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonPredecir);
            this.Controls.Add(this.dateTimePickerFechaPrediccion);
            this.Name = "PrediccionPlato";
            this.Text = "PrediccionPlato";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFechaPrediccion;
        private System.Windows.Forms.Button buttonPredecir;
        private System.Windows.Forms.Button buttonSalir;
    }
}