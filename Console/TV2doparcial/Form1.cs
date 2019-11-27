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

namespace TV2doparcial
{
    public partial class Form1 : Form
    {
       DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();
           // using (StreamWriter sw = new StreamWriter("arcExamen.txt"));

        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblpalabra_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String x = "";
            List<String> a = new List<string>();
            String pal = txtcaptura.Text;
            a.Add(pal);
            contador++;
            foreach(String ele in a)
            {
               // x=a.Generic
                //if (pal ==) { 
                //}
            }
            MessageBox.Show("cont=" + contador);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
