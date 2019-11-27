namespace TV2doparcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblpalabra = new System.Windows.Forms.Label();
            this.txtcaptura = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpalabra
            // 
            this.lblpalabra.AutoSize = true;
            this.lblpalabra.Location = new System.Drawing.Point(29, 82);
            this.lblpalabra.Name = "lblpalabra";
            this.lblpalabra.Size = new System.Drawing.Size(101, 13);
            this.lblpalabra.TabIndex = 0;
            this.lblpalabra.Text = "Ingresa una palabra";
            this.lblpalabra.Click += new System.EventHandler(this.lblpalabra_Click);
            // 
            // txtcaptura
            // 
            this.txtcaptura.Location = new System.Drawing.Point(152, 79);
            this.txtcaptura.Name = "txtcaptura";
            this.txtcaptura.Size = new System.Drawing.Size(248, 20);
            this.txtcaptura.TabIndex = 1;
            this.txtcaptura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "capturar palabra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcaptura);
            this.Controls.Add(this.lblpalabra);
            this.Name = "Form1";
            this.Text = "Examen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpalabra;
        private System.Windows.Forms.TextBox txtcaptura;
        private System.Windows.Forms.Button button1;
    }
}

