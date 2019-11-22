using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium1
{
    public class EBook
    {

        public string Autor { get; private set; }

        public string Tytul { get; private set; }

        public string DataWydania { get; private set; }

        public string DataOstatniegoZakupu;
        public double CenaStandardowa;
        public double Obnizka;


        public EBook(string autor, string tytul, string dataWydania, string dataOstatniegoZakupu, double cenaStandardowa, double obnizka)
        {
            Autor = autor;
            Tytul = tytul;
            DataWydania = dataWydania;
            DataOstatniegoZakupu = dataOstatniegoZakupu;
            CenaStandardowa = cenaStandardowa;
            Obnizka = obnizka;
        }

        public double AktualnaCena()
        {
            return CenaStandardowa - ((100 - Obnizka) / 100);
        }
    }
}
