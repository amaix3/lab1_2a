using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Podaj liczbę: ");
            //string odpowiedz = Console.ReadLine();

            //int liczba;
            //bool czySieUdalo = int.TryParse(odpowiedz, out liczba);

            //if (czySieUdalo)
            //{
            //    if (liczba % 2 == 0)
            //    {
            //        Console.WriteLine("Parzysta");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nieparzysta");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Nie podano liczby");
            //}


            //Console.Read();





            //Console.WriteLine("Podaj liczbe:");
            //string odpowiedz = Console.ReadLine();
            //int liczba = Convert.ToInt32(odpowiedz);

            ////(WARUNEK) ? (WARTOSC JESLI TRUE) : (WARTOSC JESLI FALSE);

            //Console.WriteLine((liczba % 2 == 0) ? "Parzysta" : "Nieparzysta");

            //Console.Read();



            /*
            double odleglosc = double.MinValue;
            double suma = 0, licznik = 0;


            while (odleglosc != 0)
            {
                string odlegloscTekst = Console.ReadLine();
                odleglosc = Convert.ToDouble(odlegloscTekst);
                suma += odleglosc;
                licznik++;
            }

            double wynik = suma / (licznik-1);
            Console.WriteLine(wynik);
            Console.Read();
            */

            int licznik = 1;
            int[] liczniki = { 1, 1, 1 };
            string linia = string.Empty;

            while (linia != "exit")
            {

                Console.WriteLine(licznik++);
                linia = Console.ReadLine();


                switch (linia)
                {
                    case "A":
                        Console.WriteLine("A" + liczniki[0]++);
                        licznik++;
                        break;

                    case "B":
                        Console.WriteLine("B" + liczniki[1]++);
                        licznik++;
                        break;

                    case "C":
                        Console.WriteLine("C" + liczniki[2]++);
                        licznik++;
                        break;

                    default:
                        Console.WriteLine("Zły kod produktu.");
                        break;
                }

                if (licznik >= 20)
                {
                    Console.WriteLine("Wyprodukowano max na dziś");
                    Console.Read();
                    break;
                }
            }

        }
    }
}
