using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_opdracht_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Doos d = new Doos(2, 7);

            d.neem_meerdere_ballen(9);
            Console.ReadLine();
        }
    }
}
