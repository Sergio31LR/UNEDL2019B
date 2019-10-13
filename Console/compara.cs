using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaLosTrillizos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 3];
            int[]resultado= new int[2];
            for(int p = 0;p< 2; p++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (p == 0)
                    {
                        Console.Write("Ingrese los valores de bob");
                        a[p, i] = int.Parse(Console.ReadLine());
                    }
                    if (p == 1)
                    {
                        Console.Write("ingrse los valores de alice");
                        a[p, i] = int.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine();
            for (int p = 0; p < 2; p++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(a[p,i]);
                    
                }
                Console.WriteLine();
            }

            
                if (a[0, 0] > a[1, 0])
                {
                    resultado[0] += 1;
                }else if (a[0,0]<a[1,0]) {
                    resultado[1] += 1;
                        }
                if (a[0, 1] > a[1, 1])
                {
                    resultado[0] += 1;
                }
                else if (a[0, 1] < a[1, 1])
                {
                    resultado[1] += 1;
                }

                if (a[0, 2] > a[1, 2])
                {
                    resultado[0] += 1;
                }
                else if (a[0, 2] < a[1, 2])
                {
                    resultado[1] += 1;
                }
            
            for (int p = 0; p < resultado.Length; p++) {
                Console.Write(resultado[p]);
                    }
            Console.WriteLine();
        }
    }
}
