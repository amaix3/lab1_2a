using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_nr2
{
    public interface IPrzesylka
    {
        void Nadaj();

        void Przekaz(string przekaz);

        void Info();

        void Odbierz(int odbierz);


    }
}
