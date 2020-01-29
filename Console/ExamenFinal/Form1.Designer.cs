namespace ExamenFinal
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
            this.components = new System.ComponentModel.Container();
            this.DatosPersonales = new System.Windows.Forms.GroupBox();
            this.gbsexo = new System.Windows.Forms.GroupBox();
            this.rbotro = new System.Windows.Forms.RadioButton();
            this.rbmasculino = new System.Windows.Forms.RadioButton();
            this.Femenino = new System.Windows.Forms.RadioButton();
            this.rtxtdireccion = new System.Windows.Forms.RichTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.dtpfechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEdicion = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.gbdatosbancarios = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.tbnejecutar = new System.Windows.Forms.Button();
            this.gboperacion = new System.Windows.Forms.GroupBox();
            this.rbconsulta = new System.Windows.Forms.RadioButton();
            this.rbretiro = new System.Windows.Forms.RadioButton();
            this.rbdeposito = new System.Windows.Forms.RadioButton();
            this.dtpFechaEjecucion = new System.Windows.Forms.DateTimePicker();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblFechaEjecucion = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.DatosPersonales.SuspendLayout();
            this.gbsexo.SuspendLayout();
            this.gbdatosbancarios.SuspendLayout();
            this.gboperacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatosPersonales
            // 
            this.DatosPersonales.Controls.Add(this.gbsexo);
            this.DatosPersonales.Controls.Add(this.rtxtdireccion);
            this.DatosPersonales.Controls.Add(this.lblDireccion);
            this.DatosPersonales.Controls.Add(this.dtpfechaNacimiento);
            this.DatosPersonales.Controls.Add(this.txtApellido);
            this.DatosPersonales.Controls.Add(this.txtNombre);
            this.DatosPersonales.Controls.Add(this.lblFechaNacimiento);
            this.DatosPersonales.Controls.Add(this.lblApellido);
            this.DatosPersonales.Controls.Add(this.lblNombre);
            this.DatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.DatosPersonales.Name = "DatosPersonales";
            this.DatosPersonales.Size = new System.Drawing.Size(657, 168);
            this.DatosPersonales.TabIndex = 0;
            this.DatosPersonales.TabStop = false;
            this.DatosPersonales.Text = "Datos Personales";
            // 
            // gbsexo
            // 
            this.gbsexo.Controls.Add(this.rbotro);
            this.gbsexo.Controls.Add(this.rbmasculino);
            this.gbsexo.Controls.Add(this.Femenino);
            this.gbsexo.Location = new System.Drawing.Point(9, 109);
            this.gbsexo.Name = "gbsexo";
            this.gbsexo.Size = new System.Drawing.Size(324, 44);
            this.gbsexo.TabIndex = 2;
            this.gbsexo.TabStop = false;
            this.gbsexo.Text = "Sexo";
            // 
            // rbotro
            // 
            this.rbotro.AutoSize = true;
            this.rbotro.Location = new System.Drawing.Point(187, 20);
            this.rbotro.Name = "rbotro";
            this.rbotro.Size = new System.Drawing.Size(45, 17);
            this.rbotro.TabIndex = 2;
            this.rbotro.TabStop = true;
            this.rbotro.Text = "Otro";
            this.rbotro.UseVisualStyleBackColor = true;
            // 
            // rbmasculino
            // 
            this.rbmasculino.AutoSize = true;
            this.rbmasculino.Location = new System.Drawing.Point(97, 20);
            this.rbmasculino.Name = "rbmasculino";
            this.rbmasculino.Size = new System.Drawing.Size(73, 17);
            this.rbmasculino.TabIndex = 1;
            this.rbmasculino.TabStop = true;
            this.rbmasculino.Text = "Masculino";
            this.rbmasculino.UseVisualStyleBackColor = true;
            // 
            // Femenino
            // 
            this.Femenino.AutoSize = true;
            this.Femenino.Checked = true;
            this.Femenino.Location = new System.Drawing.Point(7, 20);
            this.Femenino.Name = "Femenino";
            this.Femenino.Size = new System.Drawing.Size(68, 17);
            this.Femenino.TabIndex = 0;
            this.Femenino.TabStop = true;
            this.Femenino.Text = "femenino";
            this.Femenino.UseVisualStyleBackColor = true;
            this.Femenino.CheckedChanged += new System.EventHandler(this.Femenino_CheckedChanged);
            // 
            // rtxtdireccion
            // 
            this.rtxtdireccion.Location = new System.Drawing.Point(437, 19);
            this.rtxtdireccion.Name = "rtxtdireccion";
            this.rtxtdireccion.Size = new System.Drawing.Size(164, 115);
            this.rtxtdireccion.TabIndex = 7;
            this.rtxtdireccion.Text = "";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(386, 19);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion";
            // 
            // dtpfechaNacimiento
            // 
            this.dtpfechaNacimiento.Location = new System.Drawing.Point(140, 83);
            this.dtpfechaNacimiento.Name = "dtpfechaNacimiento";
            this.dtpfechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpfechaNacimiento.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(106, 49);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(234, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(0, 83);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 2;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 52);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnEdicion
            // 
            this.btnEdicion.Location = new System.Drawing.Point(696, 20);
            this.btnEdicion.Name = "btnEdicion";
            this.btnEdicion.Size = new System.Drawing.Size(75, 23);
            this.btnEdicion.TabIndex = 2;
            this.btnEdicion.Text = "Edicion";
            this.btnEdicion.UseVisualStyleBackColor = true;
            this.btnEdicion.Click += new System.EventHandler(this.btnEdicion_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(696, 53);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // gbdatosbancarios
            // 
            this.gbdatosbancarios.Controls.Add(this.btnlimpiar);
            this.gbdatosbancarios.Controls.Add(this.tbnejecutar);
            this.gbdatosbancarios.Controls.Add(this.gboperacion);
            this.gbdatosbancarios.Controls.Add(this.dtpFechaEjecucion);
            this.gbdatosbancarios.Controls.Add(this.txtsaldo);
            this.gbdatosbancarios.Controls.Add(this.txtcantidad);
            this.gbdatosbancarios.Controls.Add(this.lblSaldo);
            this.gbdatosbancarios.Controls.Add(this.lblFechaEjecucion);
            this.gbdatosbancarios.Controls.Add(this.lblcantidad);
            this.gbdatosbancarios.Location = new System.Drawing.Point(15, 207);
            this.gbdatosbancarios.Name = "gbdatosbancarios";
            this.gbdatosbancarios.Size = new System.Drawing.Size(654, 184);
            this.gbdatosbancarios.TabIndex = 4;
            this.gbdatosbancarios.TabStop = false;
            this.gbdatosbancarios.Text = "Datos Bancarios";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(473, 63);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 22);
            this.btnlimpiar.TabIndex = 8;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // tbnejecutar
            // 
            this.tbnejecutar.Location = new System.Drawing.Point(473, 27);
            this.tbnejecutar.Name = "tbnejecutar";
            this.tbnejecutar.Size = new System.Drawing.Size(75, 23);
            this.tbnejecutar.TabIndex = 7;
            this.tbnejecutar.Text = "Ejecutar";
            this.tbnejecutar.UseVisualStyleBackColor = true;
            this.tbnejecutar.Click += new System.EventHandler(this.tbnejecutar_Click);
            // 
            // gboperacion
            // 
            this.gboperacion.Controls.Add(this.rbconsulta);
            this.gboperacion.Controls.Add(this.rbretiro);
            this.gboperacion.Controls.Add(this.rbdeposito);
            this.gboperacion.Location = new System.Drawing.Point(6, 132);
            this.gboperacion.Name = "gboperacion";
            this.gboperacion.Size = new System.Drawing.Size(317, 46);
            this.gboperacion.TabIndex = 6;
            this.gboperacion.TabStop = false;
            this.gboperacion.Text = "Operacion";
            // 
            // rbconsulta
            // 
            this.rbconsulta.AutoSize = true;
            this.rbconsulta.Location = new System.Drawing.Point(170, 19);
            this.rbconsulta.Name = "rbconsulta";
            this.rbconsulta.Size = new System.Drawing.Size(66, 17);
            this.rbconsulta.TabIndex = 7;
            this.rbconsulta.TabStop = true;
            this.rbconsulta.Text = "Consulta";
            this.rbconsulta.UseVisualStyleBackColor = true;
            // 
            // rbretiro
            // 
            this.rbretiro.AutoSize = true;
            this.rbretiro.Location = new System.Drawing.Point(97, 19);
            this.rbretiro.Name = "rbretiro";
            this.rbretiro.Size = new System.Drawing.Size(53, 17);
            this.rbretiro.TabIndex = 8;
            this.rbretiro.TabStop = true;
            this.rbretiro.Text = "Retiro";
            this.rbretiro.UseVisualStyleBackColor = true;
            // 
            // rbdeposito
            // 
            this.rbdeposito.AutoSize = true;
            this.rbdeposito.Checked = true;
            this.rbdeposito.Location = new System.Drawing.Point(7, 19);
            this.rbdeposito.Name = "rbdeposito";
            this.rbdeposito.Size = new System.Drawing.Size(67, 17);
            this.rbdeposito.TabIndex = 9;
            this.rbdeposito.TabStop = true;
            this.rbdeposito.Text = "Deposito";
            this.rbdeposito.UseVisualStyleBackColor = true;
            // 
            // dtpFechaEjecucion
            // 
            this.dtpFechaEjecucion.Location = new System.Drawing.Point(137, 90);
            this.dtpFechaEjecucion.Name = "dtpFechaEjecucion";
            this.dtpFechaEjecucion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEjecucion.TabIndex = 5;
            // 
            // txtsaldo
            // 
            this.txtsaldo.Location = new System.Drawing.Point(76, 56);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(196, 20);
            this.txtsaldo.TabIndex = 4;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(76, 20);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(196, 20);
            this.txtcantidad.TabIndex = 3;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(10, 63);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblFechaEjecucion
            // 
            this.lblFechaEjecucion.AutoSize = true;
            this.lblFechaEjecucion.Location = new System.Drawing.Point(10, 96);
            this.lblFechaEjecucion.Name = "lblFechaEjecucion";
            this.lblFechaEjecucion.Size = new System.Drawing.Size(105, 13);
            this.lblFechaEjecucion.TabIndex = 1;
            this.lblFechaEjecucion.Text = "Fecha de Ejecucion:";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(10, 27);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(52, 13);
            this.lblcantidad.TabIndex = 0;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbdatosbancarios);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnEdicion);
            this.Controls.Add(this.DatosPersonales);
            this.Name = "Form1";
            this.Text = "Servicios Financieros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DatosPersonales.ResumeLayout(false);
            this.DatosPersonales.PerformLayout();
            this.gbsexo.ResumeLayout(false);
            this.gbsexo.PerformLayout();
            this.gbdatosbancarios.ResumeLayout(false);
            this.gbdatosbancarios.PerformLayout();
            this.gboperacion.ResumeLayout(false);
            this.gboperacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DatosPersonales;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.DateTimePicker dtpfechaNacimiento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox gbsexo;
        private System.Windows.Forms.RadioButton rbotro;
        private System.Windows.Forms.RadioButton rbmasculino;
        private System.Windows.Forms.RadioButton Femenino;
        private System.Windows.Forms.RichTextBox rtxtdireccion;
        private System.Windows.Forms.Button btnEdicion;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.GroupBox gbdatosbancarios;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button tbnejecutar;
        private System.Windows.Forms.GroupBox gboperacion;
        private System.Windows.Forms.RadioButton rbconsulta;
        private System.Windows.Forms.RadioButton rbretiro;
        private System.Windows.Forms.RadioButton rbdeposito;
        private System.Windows.Forms.DateTimePicker dtpFechaEjecucion;
        private System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblFechaEjecucion;
        private System.Windows.Forms.Label lblcantidad;
    }
}

