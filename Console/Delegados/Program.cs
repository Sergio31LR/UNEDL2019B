using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Delegados
{
    //delegate int met(List<int> li);

    delegate int re(int r);

    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            met hacer = new met(Metodos.Suma);
            met hacer2 = new met(Metodos.Myor);
            //met hacer2 = new met();
            Metodos es = new Metodos();
            List<int> mm = new List<int>();
            int ss = es.getsuma();
            int capturar = 0;
            for (int p = 0; p < 5; p++)
            {
                Console.Write("Ingrese un dato  ");
                capturar = int.Parse(Console.ReadLine());
                mm.Add(capturar);
            }
            hacer(mm);
            hacer2(mm);

            Console.WriteLine();
            Console.WriteLine("suma="+es.getsuma()) ;
            Console.WriteLine("promedio=" + es.getpromedio());
            Console.WriteLine("mayor=" +es.getmayor ());
        }
    }
}