using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    public class Kalkulator
    {
        

        public static int Dodawanie(int liczba1, int liczba2)
        {

            return liczba1 + liczba2;

        }

        public static int Odejmowanie(int liczba1, int liczba2)
        {
            return liczba1 - liczba2;


        }

        public static int Mnozenie(int liczba1, int liczba2)
        {
            return liczba1 * liczba2;

        }

        public static double Dzielenie(int liczba1, int liczba2, out bool powodzenia)
        {
            if (liczba2 == 0)
            {
                powodzenia = false;
                return 0;
            }
            powodzenia = true;
            return (double)liczba1 / liczba2;

        }

        public static double PodzielZWyjatkiem(int liczba1, int liczba2)
        {
            if (liczba2 == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)liczba1 / liczba2;
        }

       public  static int Dodawanie(string x, string y)
        {
            int tekst1 = Convert.ToInt32(x);
            int tekst2 = Convert.ToInt32(y);

            return Dodawanie(tekst1, tekst2);
        }
    }
}
