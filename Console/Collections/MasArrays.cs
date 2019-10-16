using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class MasArrays
    {
public void Sorted()
        {
            SortedList sl = new SortedList();
            sl.Add(1, "Valor 1");
            sl.Add(5, "valor 5");
            sl.Add(7,null);
            ICollection llave = sl.Keys;
            foreach (int k in llave)
            {
                Console.WriteLine("llave: "+k+"valor: "+sl[k]);
            }
        }
    }
}
