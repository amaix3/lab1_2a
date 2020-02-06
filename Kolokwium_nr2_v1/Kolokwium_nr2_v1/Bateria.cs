using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_nr2_v1
{
    public class Bateria : IZasilanie
    {
        public int _pojemnosc = 100;

        public void Zasilaj(int energia)
        {
            while (_pojemnosc > 0)
            {
                Console.WriteLine("OK");
                _pojemnosc--;

                if (_pojemnosc == 0)
                {
                    Console.WriteLine("Brak zasilania");
                }
            }




        }
    }
}
