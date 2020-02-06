using System;
using System.Collections.Generic;
using System.Linq;

namespace Kolokwium_nr2_v1
{
    class Program
    {
        public static Random rnd;

        static void Zadanie1()
        {
            Console.WriteLine("ZADANIE 1:");
            rnd = new Random();

            List<Produkt> lista = new List<Produkt>();

            lista.Add(new Produkt("Produkt1"));
            lista.Add(new Produkt("Produkt2"));

            foreach (var item in lista)
            {
                item.suma();
            }

        
        }
        static void Zadanie4()
        {
            Console.WriteLine("ZADANIE 4: ");
            var panel = new PanelSloneczny();
            var bateria = new Bateria();

            Console.WriteLine("Panel:");
            panel.Zasilaj(99);

            Console.WriteLine();

            Console.WriteLine("Bateria: ");
            bateria.Zasilaj(100);
        }
        static void Main(string[] args)
        {
            Zadanie1();

            Console.WriteLine();

            Zadanie4();


            Console.Read();
        }
    }
}
