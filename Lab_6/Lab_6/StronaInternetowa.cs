using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    public class StronaInternetowa
    {

        public int SzybkoscProcesora { get; private set; }

        public int Lacze { get; private set; }

        public int RAM { get; private set; }

        public string Technologia { get; private set; }

        public StronaInternetowa(int szybkoscProcesora, int lacze, int rAM, string technologia)
        {
            SzybkoscProcesora = szybkoscProcesora;
            Lacze = lacze;
            RAM = rAM;
            Technologia = technologia;
        }


    }

    public class Domena
    {
        public Domena(string nazwa, DateTime waznosc, string wlasciciel)
        {
            Nazwa = nazwa;
            Waznosc = waznosc;
            Wlasciciel = wlasciciel;
        }

        public string Nazwa { get; set; }
        public DateTime Waznosc { get; set; }
        public string Wlasciciel { get; set; }
    }
}
