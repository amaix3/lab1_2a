using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    public class StronaInternetowa
    {
        public string Serwer;

        public int SzybkoscProcesora { get; private set; }

        public int Lacze { get; set; }

        public int RAM { get; set; }

        public string Technologia { get; set; }

        public StronaInternetowa(int szybkoscProcesora, int lacze, int rAM, string technologia)
        {
            SzybkoscProcesora = szybkoscProcesora;
            Lacze = lacze;
            RAM = rAM;
            Technologia = technologia;
        }


        public string Domena;


        public string Nazwa { get; private set; }

        public string Wlasciciel { get; private set; }


        public StronaInternetowa(string nazwa, string wlasciciel)
        {
            Nazwa = nazwa;
            Wlasciciel = wlasciciel;
            
        }

        

    }
}
