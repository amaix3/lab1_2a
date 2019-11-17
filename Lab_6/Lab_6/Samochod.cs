using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    public class Samochod
    {
       // private static int IloscModeli = 0;

        public static int IloscModeli { get; private set; } = 0;

        public readonly string Model;

        public int VIN { get; private set; }

        public int Przebieg { get; set; }

        private int _przebieg;

        public void ZwiekszPrzebieg (int dystans)
        {
            if(dystans < 0)
            {
                throw new ArgumentException("Dystans nie może być ujemny.");
            }
            Przebieg += Przebieg;
        }


       // public int Przebieg;
        //{ 
        //    get
        //    {
        //        return _przebieg;
        //    }
        //    set
        //    {
        //        if(value > Przebieg)
        //        {
        //            _przebieg = value;
        //        }
                
        //    }

        //}

        public int IloscDrzwi { get; private set; }

        private int _waga;

        public Samochod(int iloscDrzwi, int waga) : this("Multipla", 0, iloscDrzwi, waga)
        {
            //Model = "Multipla";
            //Przebieg = 0;
            //IloscDrzwi = iloscDrzwi;
            //Waga = waga;
            //  VIN = IloscModeli++;

        }

        public Samochod(string model, int przebieg, int iloscDrzwi, int waga) : this()
        {
            Model = model;
            Przebieg = przebieg;
            IloscDrzwi = iloscDrzwi;
            Waga = waga;
            //VIN = IloscModeli++;

        }

        public Samochod(int id)
        {
            // var dane = Baza.GetById(id);
            // Przebieg = dane.Przebieg;

        }

        private Samochod()
        {
            VIN = IloscModeli++;
        }

       

        public int Waga
        {
            get
            {
                return _waga;
            }
            set
            {
                _waga = value;

                if(_waga < 0)
                {
                    _waga = 0;
                }
            }
        }

      
    }
}
