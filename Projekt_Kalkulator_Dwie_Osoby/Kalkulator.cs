using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Kalkulator_Dwie_Osoby
{
    internal class Kalkulator
    {
        public int Dodaj(int a, int b)
        {
            return a + b;
        }
        public int Odejmowanie(int a, int b) //odejmuje liczbe b od liczby a
        {
            return a - b;
        }

        public int Dzielenie(int a, int b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }
}
