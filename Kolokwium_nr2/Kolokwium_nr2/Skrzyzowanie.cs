using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_nr2
{
    enum Kolory
    {
        Czerwony,
        Zolty,
        Zielony
    }
    public class Skrzyzowanie
    {
        public event EventHandler zmiana;

        private Kolory _kolory;
        public int Id { get; set; }
        protected virtual void Zmiana(EventArgs e)
        {
            EventHandler handler = zmiana;
        }
    }
}
