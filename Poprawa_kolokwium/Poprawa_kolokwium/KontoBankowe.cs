using System;
using System.Collections.Generic;
using System.Text;

namespace Poprawa_kolokwium
{
    public class KontoBankowe
    {
        double _stan;

        public KontoBankowe(double stan)
        {
            Stan = stan;
        }

        public double Stan
        {
            get
            {
                return _stan;
            }
            set
            {
                if (value >= 100)
                {
                    value = _stan;
                }
                else
                {
                    Console.WriteLine("DEBET!");
                }
            }
        }

        public void Wlasciciel()
        {
            Console.Write("Podaj imie: ");
            string imie = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();
        }

        


        public void Numer()
        {
            for (int i = 0; i < 26; i++)
            {
                int rnd = new Random().Next(0, 9);
                Console.Write(rnd);
            }
        }

        public void Uznanie()
        {

        }

        public void Obciazenie()
        {

        }

        public void Historia()
        {
            
        }

    }
}
