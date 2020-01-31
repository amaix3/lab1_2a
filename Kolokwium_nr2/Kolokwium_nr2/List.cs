using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_nr2
{
    public class List : IPrzesylka
    {
        public string Lokalizacja { get; set; }
        public string Tresc { get; set; }

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
