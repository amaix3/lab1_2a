using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_Poprawiona_Wersja
{
    public class Ebook
    {
        public Ebook(string autor, string tytul, DateTime dataWydania, DateTime dataOstatniegoZakupu, double cenaStandardowa, double obnizka)
        {
            Autor = autor;
            Tytul = tytul;
            DataWydania = dataWydania;
            DataOstatniegoZakupu = dataOstatniegoZakupu;
            CenaStandardowa = cenaStandardowa;
            Obnizka = obnizka;
        }

        public string Autor { get; private set; }
        public string Tytul { get; private set; }
        public DateTime DataWydania { get; private set; }
        public DateTime DataOstatniegoZakupu { get; set; }


        double _CenaStandardowa;
        public double CenaStandardowa
        {
            get
            {
                return _CenaStandardowa;
            }

            set
            {
                if (value > 0)
                {
                    _CenaStandardowa = value;
                }
                else
                {
                    Console.WriteLine("Cena nie może być ujemna.");
                }
            }

        }

        double _Obnizka;
        public double Obnizka
        {
            get
            {
                return _Obnizka;
            }
            set
            {
                if (_CenaStandardowa - value > 0)
                {
                    _Obnizka = value;
                }
                else
                {
                    Console.WriteLine("Obniżka nie może być niższa ceny 0 zł.");
                }
            }
        }

        double _AktualnaCena;

        public double AktualnaCena
        {
            get
            {
                return _AktualnaCena = CenaStandardowa * ((100 - Obnizka) / 100);
            }
            set
            {
                _AktualnaCena = CenaStandardowa * ((100 - Obnizka) / 100);
            }

        }
    }
}
