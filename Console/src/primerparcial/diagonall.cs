using System;

namespace diferenciadiagonal
{

    class Program
    {

        static void Main(string[] args)
        {    
            int result=0;
            int tamaño=0;
            int dii=0;
            int di2=0;
            int[,] a;
            String captura;
            Console.Write("Ingrese el tamaño de la matriz ");
            captura = Console.ReadLine();
            tamaño = int.Parse(captura);
            a = new int[tamaño, tamaño];
            for (int p = 0; p < tamaño; p++)
            {
                for (int i = 0; i < tamaño; i++)
                {
                    Console.Write("Ingrese el valor de la posicion " + p + "," + i + " ");
                    a[p, i] = int.Parse(Console.ReadLine());
                }
            }
            for (int p = 0; p < tamaño; p++)
            {
                for (int i = 0; i < tamaño; i++)
                {
                    Console.Write(a[p, i]);
                }
                Console.WriteLine("\n");
            }
            //diagonal principal 
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        dii =dii+a[i, j];
                    }
                }
            }
            //suma diagonal secundaria 
            for (int i = tamaño - 1; i >= 0; i--)
            {
                for (int j = 0; j < tamaño; j++)
                    if (tamaño - 1 - i == j)
                    {
                        di2 =di2+ a[i,j];
                    }
            }

            //resultado
            //Console.WriteLine("dia"+dii);
            //Console.WriteLine("diaa" + di2);
             result = dii-di2;
            /*if(result<0) {
                result=result*(-1);
                System.out.println(result);
            }else {
                System.out.println(result);
            }
           //& System.out.println(di+" "+di2);
              */
            // System.out.println(Math.abs(result));
            Console.Write(Math.Abs(result));

    }
    }
}