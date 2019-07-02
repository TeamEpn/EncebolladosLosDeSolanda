namespace Interfaz
{
    partial class ConsultarPedido
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
            this.textBoxIdPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonMostrarTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIdPedido
            // 
            this.textBoxIdPedido.Location = new System.Drawing.Point(211, 24);
            this.textBoxIdPedido.Name = "textBoxIdPedido";
            this.textBoxIdPedido.Size = new System.Drawing.Size(102, 20);
            this.textBoxIdPedido.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Número de ticket";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(282, 238);
            this.listBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(198, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // buttonMostrarTicket
            // 
            this.buttonMostrarTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonMostrarTicket.Location = new System.Drawing.Point(43, 321);
            this.buttonMostrarTicket.Name = "buttonMostrarTicket";
            this.buttonMostrarTicket.Size = new System.Drawing.Size(133, 27);
            this.buttonMostrarTicket.TabIndex = 5;
            this.buttonMostrarTicket.Text = "Mostrar Ticket";
            this.buttonMostrarTicket.UseVisualStyleBackColor = true;
            this.buttonMostrarTicket.Click += new System.EventHandler(this.ButtonMostrarTicket_Click);
            // 
            // ConsultarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 355);
            this.Controls.Add(this.textBoxIdPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonMostrarTicket);
            this.Name = "ConsultarPedido";
            this.Text = "Consultar Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIdPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonMostrarTicket;
    }
}