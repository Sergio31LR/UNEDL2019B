using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV2doparcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont1 = 0;
            int cont2 = 0;
            int cont3 = 0;
            String dato = "";
            Stack<String> s = new Stack<string>();
            for (int p = 0; p < 3; p++)
            {
                Console.Write("Ingrese algo ");
                //dato = Console.ReadLine();
                s.Push(Console.ReadLine());
            }
            for (int p = 0; p < 3; p++)
            {
                String Aux = s.Pop();
                if (Aux == ")" || Aux == "(" || Aux == "[" || Aux == "]" || Aux == "{" || Aux == "}")
                {
                    cont++;
                }
                Console.WriteLine("aber=" + Aux);
            }

            if (cont % 2 == 0)
            {// si el resultado es diferente de cero la ecuacion es correcta si no es incorrecta 
                Console.WriteLine("La ecuacion ingresada es correcta");
            }
            else
            {
                Console.WriteLine("la ecuacion ingresadad es incorrecta");

            }
        }
    }
}
