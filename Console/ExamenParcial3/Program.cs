using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial3
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma=0;
            int cantidad;
            int x = 0;
            int[] elementos = { 2, 10, 20, 50, 100,200,500, 1000,2500,};
            Console.Write("Ingrese una cantidad  ");
            cantidad = int.Parse(Console.ReadLine());
            //Console.WriteLine(cantidad);
            //Console.WriteLine("zise" + elementos.Length);
            for (int p = 0; p < elementos.Length; p++)
            { 
                suma = suma + elementos[p];
                Console.WriteLine("suma =" + suma);
                if (suma <cantidad)
                {
                    x++;
                }
                
            }

            Console.WriteLine("la cantidad de elementos que puede adquisir es:" + x);

        }
    }
}
