using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Padres
    {
        String padreee = "cabello negro";
        public void Padre()
        {
            String padre1 = "cabello negro";
            String padre2 = "Estatura promedio 170-180cm";
            Console.WriteLine(padre1 + " y " + padre2);
            Console.WriteLine("");

        }
        public void Madre()
        {
            String madre1 = "Ojos negros";
            String madre2="mas cosas";
            Console.WriteLine(madre1 + " y " + madre2);
        }
    }
}
