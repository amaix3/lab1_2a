using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_nr2
{

    public class Paczka : IPrzesylka
    {

        Random rnd = new Random();

        public Paczka(string lokalizacja, double waga)
        {
            Lokalizacja = lokalizacja;
            Waga = rnd.Next(1,100);
        }

        public string Lokalizacja { get; set; }
        public double Waga { get; set; }

        public void Info()
        {
            throw new NotImplementedException();
        }

        public void Nadaj()
        {
            throw new NotImplementedException();
        }

        public void Odbierz(int odbierz)
        {
            throw new NotImplementedException();
        }

        public void Przekaz(string przekaz)
        {
            throw new NotImplementedException();
        }

       
    }
}
