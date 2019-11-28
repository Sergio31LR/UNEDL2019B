using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    delegate int met(List<int> li);
    class Metodos
    {
   

        static int suma = 0;
        static int div = 0;
        static int s = suma;
        static float promedio = 0;
        static int mayor = 0;
      //  int ar[] = new ar[5];
        public static int Suma(List<int> li)
          
        {

            for (int p = 0; p < 5; p++)
            {                
                div++;
                suma += li[p];
            }
            // Console.WriteLine(suma);
            s = suma;
            promedio = s / div;
            return suma;

        }
       public  static int  Myor(List<int> li)
        {
            /*List<int> apero = new List<int>();
            int aux = 0;
            for(int p = 0; p < 5; p++)
            {
                aux = li[p];
                apero.Add(aux);
            }
            Console.WriteLine(apero);
            apero.Sort();
            mayor = apero[div];*/
            mayor= li.Max();
            return mayor;
        }

        public int getmayor()
        {
            return mayor;
        }
        

        public  float getpromedio(){
            return promedio;
            }



        public  int getsuma()
        {
            return s;
        }

       

     

       
    }
}
