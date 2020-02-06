using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_nr2_v1
{
    public class Skladnik
    {
        public int _weglowodany;
        public int _tluszcz;
        public int _sol;

        public Skladnik()
        {
            _weglowodany = Program.rnd.Next(1,100);
            _tluszcz = Program.rnd.Next(1,100);
            _sol = Program.rnd.Next(1,100);
        }


    }
}
