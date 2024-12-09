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
            Console.WriteLine(k.Odejmowanie(5, 7));
            Console.WriteLine(k.Dodaj(4, 440));
            Console.WriteLine(k.Dzielenie(400,50));
            Console.WriteLine(k.Mnozenie(-8,-92));
        }
    }
}
