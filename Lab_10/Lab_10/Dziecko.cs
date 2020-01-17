using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10
{
    public class Dziecko
    {
        public double Znizka { get; set; }

        //data urodzenia,  deconstruct = string wypisać w ktorej klasie jest szkola podstawowa, srednia i studia

        public DateTime DataUrodzenia { get; set; }

        public string Klasa { get; set; }

        public void Deconstruct(out DateTime dataUrodzenia, out string klasa)
        {
            dataUrodzenia = DataUrodzenia;

            if (DateTime.Now.Year - dataUrodzenia.Year >= 9 && DateTime.Now.Year - dataUrodzenia.Year <= 14)
            {
                klasa = "podstawówka";
            }
            else if (DateTime.Now.Year - dataUrodzenia.Year >= 15 && DateTime.Now.Year - dataUrodzenia.Year <= 19)
            {
                klasa = "średnia";
            }
            else
            {
                klasa = "studia";
            }


        }
    }
}

