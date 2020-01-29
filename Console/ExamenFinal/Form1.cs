using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExamenFinal
{
    public partial class Form1 : Form
    {
        StreamWriter archivo=new StreamWriter("DatosBancarios.txt",true);
        public Form1()
        {
            InitializeComponent();
        }

        String nombre = "";
        String apellido="";
        String Fechanaci = "";
        String direccion = "";
        String sexo = "";
        int cantidad = 0;
        int Saldo = 0;
        String fechaEje = "";
        string operacion = "";
        Boolean si = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            dtpfechaNacimiento.Enabled = false;
            txtcantidad.Enabled = false;
            txtsaldo.Enabled = false;
            dtpFechaEjecucion.Enabled = false;
            rtxtdireccion.Enabled = false;
        }

        private void btnEdicion_Click(object sender, EventArgs e)
        {
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            dtpfechaNacimiento.Enabled = true;
            txtcantidad.Enabled = true;
            txtsaldo.Enabled = true;
            dtpFechaEjecucion.Enabled = true;
            rtxtdireccion.Enabled = true;
            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            dtpfechaNacimiento.Text = "";
            txtcantidad.Text = "";
            txtsaldo.Text = "";
            dtpFechaEjecucion.Text = "";
            rtxtdireccion.Text = "";
        }

        private void tbnejecutar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            Fechanaci = dtpfechaNacimiento.Text;
            cantidad = int.Parse(txtcantidad.Text);
            Saldo = int.Parse(txtsaldo.Text);
            direccion = rtxtdireccion.Text;
            fechaEje = dtpFechaEjecucion.Text;

            //sexo
            if (Femenino.Checked == true)
            {
                sexo = Femenino.Text;
            }


            if (rbmasculino.Checked == true)
            {
                sexo =rbmasculino.Text;
            }
            if (rbotro.Checked == true)
            {
                sexo = rbotro.Text;
            }

            //operacion
            if (rbdeposito.Checked == true)
            {
                operacion = rbdeposito.Text;
            }
            if (rbretiro.Checked == true)
            {
                operacion = rbretiro.Text;
            }
            if (rbconsulta.Checked == true)
            {
                operacion= rbconsulta.Text;
            }
            si = true;
            
                archivo.Write(nombre + "," + apellido + "," + Fechanaci + "," + sexo + "," + direccion + "," + cantidad +
                    "," + Saldo + "," + fechaEje + "," + operacion);
                archivo.WriteLine("hola");
                archivo.WriteLine(nombre);
            
            MessageBox.Show(nombre);
            MessageBox.Show(apellido);
            MessageBox.Show(direccion);
            MessageBox.Show(fechaEje);
        }

        public void sii()
        {
            //NO me deja escribir en el archvio aaaaaaaaaaah
            /*archivo.Write(nombre + "," + apellido + "," + Fechanaci + "," + sexo + "," + direccion + "," + cantidad +
                  "," + Saldo + "," + fechaEje + "," + operacion);
            archivo.WriteLine("hola");
            archivo.WriteLine(nombre);*/
        }
        
        private void Femenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            dtpfechaNacimiento.Enabled = false;
            txtcantidad.Enabled = false;
            txtsaldo.Enabled = false;
            dtpFechaEjecucion.Enabled = false;
            rtxtdireccion.Enabled = false;
        }
    }
}
