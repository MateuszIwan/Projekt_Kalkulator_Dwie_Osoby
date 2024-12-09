using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Kalkulator_Dwie_Osoby
{
    internal static class Kalkulator
    {
        public static int Dodaj(int a, int b)
        {
            return a + b;
        }
        public static int Mnozenie(int a, int b)
        {
            return a * b;
        }
        public static int Bonifacy(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1 || n == 2)
                return 1;

            int l1 = 0;
            int l2 = 1;

            for (int i = 0; i < n - 1; i++)
            {
                l2 = l2 + l1;
                l1 = l2 - l1;
            }
            return l2;
        }
    }
}
