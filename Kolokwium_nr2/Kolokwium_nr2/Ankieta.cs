using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_nr2
{
    public class Ankieta
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int Suma { get; set; }
        public string Wynik { get; set; }

        public void Deconstruct(out int a, out int b, out int c, out int d, out double suma)
        {
            a = A;
            b = B;
            c = C;
            d = D;
            suma = Suma;
            Suma = A + B + C + D;
        }

        public void Deconstruct(string wynik)
        {
            wynik = Wynik;

            if (A == 1)
            {
                Wynik = "20 %";
            }
            else if (B == 2)
            {
                Wynik = "30 %";
            }
           else if(C == 3)
            {
                Wynik = "40 %";
            }
            else if (D == 4)
            {
                Wynik = "40%";
            }
        }
    }
}
