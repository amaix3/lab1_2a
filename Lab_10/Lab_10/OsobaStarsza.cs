using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10
{
    public class OsobaStarsza
    {
        public bool ZwolnienieZOplat { get; set; }

        public string NrLegitymacji { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string AdresZdjecia { get; set; }

        public (string nrLegitymacji, bool zwolnienie, DateTime urodziny, string zdjecie) ZwrocWaszyskieDane()
        {
            return (NrLegitymacji, ZwolnienieZOplat, DataUrodzenia, AdresZdjecia);
        }

        public void Deconstruct(out string nrLegitymacji, out bool zwolnienie, out DateTime urodziny, out string zdjecie)
        {
            nrLegitymacji = NrLegitymacji;
            zwolnienie = ZwolnienieZOplat;
            urodziny = DataUrodzenia;
            zdjecie = AdresZdjecia;
        }

        public void Deconstruct(out string nrLegitymacji, out string zdjecia)
        {
            nrLegitymacji = NrLegitymacji;
            zdjecia = AdresZdjecia;
        }
    }
}
