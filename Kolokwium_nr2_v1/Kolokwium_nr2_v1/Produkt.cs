using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_nr2_v1
{
    public class Produkt : Skladnik
    {
        public string _nazwa;

        public Produkt(string nazwa)
        {

            _weglowodany = Weglowodany;
            _tluszcz = Tluszcz;
            _sol = Sol;

        }

        public int Weglowodany
        {
            get
            {
                return _weglowodany;
            }
            set
            {
                _weglowodany = value;
            }
        }
        public int Tluszcz
        {
            get
            {
                return _tluszcz;
            }
            set
            {
                _tluszcz = value;
            }
        }
        public int Sol
        {

            get
            {
                return _sol;
            }
            set
            {
                _sol = value;
            }
        }

        public void suma()
        {
            Console.WriteLine($"Suma składników odżywczych: {(_weglowodany + _tluszcz + _sol)}");
            Console.WriteLine($"Weglowodany: {_weglowodany} | Tluszcz: {_tluszcz} | Sol: {_sol}");
        }
    }
}
