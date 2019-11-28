using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Yo heredo = new Yo();
            Console.WriteLine("yo heredo de mi padre:");
           heredo.Padre();
            Console.WriteLine("yo heredo de mi madre:");
            heredo.Madre();
            Console.ReadKey();
        }
    }
}
