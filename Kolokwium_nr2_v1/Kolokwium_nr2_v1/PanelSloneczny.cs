using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_nr2_v1
{
    public class PanelSloneczny : IZasilanie
    {
        DateTime teraz = DateTime.Now;

        TimeSpan godzina1 = new TimeSpan(6, 0, 0);
        TimeSpan godzina2 = new TimeSpan(18, 0, 0);


        public void Zasilaj(int energia)
        {
            if (energia < 100)
            {

                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("NIE OK");
            }

        }
    }
}
