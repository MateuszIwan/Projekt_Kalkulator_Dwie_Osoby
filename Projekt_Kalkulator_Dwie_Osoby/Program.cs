using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Kalkulator_Dwie_Osoby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();
            Console.WriteLine(k.Odejmowanie(5, 4));
            Console.WriteLine(k.Odejmowanie(25, 27));
            Console.WriteLine(k.Odejmowanie(8, 8));

        }
    }
}
