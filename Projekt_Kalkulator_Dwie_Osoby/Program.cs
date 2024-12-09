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
            Console.WriteLine(Kalkulator.Odejmowanie(5, 7));
            Console.WriteLine(Kalkulator.Dodaj(4, 440));
            Console.WriteLine(Kalkulator.Dzielenie(400,50));
            Console.WriteLine(Kalkulator.Mnozenie(-8,-92));
            Console.WriteLine(Kalkulator.Bonifacy(5));
        }
    }
}
