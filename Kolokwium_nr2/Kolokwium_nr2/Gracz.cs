using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_nr2
{
    public class Gracz
    {


        public int Punkty { get; set; }
        public int Zwyciestwa { get; set; }
        public DateTime OstatniaAktywnosc { get; set; }


        Random rnd = new Random();

        public Gracz()
        {
            Punkty = rnd.Next(0,100);
            Zwyciestwa = rnd.Next(0,20);
            
        }
    }
}
