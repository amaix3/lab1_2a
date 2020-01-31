using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace Kolokwium_nr2
{
    class Program
    {
        static void Zadanie1()
        {
            Console.WriteLine("ZADANIE 1:");

            List<Gracz> kolekcja = new List<Gracz>();

            for (int i = 0; i < 100; i++)
            {
                kolekcja.Add(new Gracz());
            }

            foreach (var item in kolekcja)
            {
                Console.WriteLine($"Punkty: {item.Punkty} | Zwyciestwa: {item.Zwyciestwa}");
            }

            Console.WriteLine();
            Console.WriteLine("Ranking według punktów i zwyciestw: ");

            List<Gracz> ranking = kolekcja.OrderBy(x => x.Punkty).ThenBy(x => x.Zwyciestwa).ToList();

            foreach (var item in ranking)
            {
                Console.WriteLine($"Punkty: {item.Punkty} | Zwyciestwa: {item.Zwyciestwa}");

            }

        }

        static void Zadanie2()
        {
            Console.WriteLine("ZADANIE 2: ");

            List<IPrzesylka> lista = new List<IPrzesylka>();


        }

        static void Zadanie3()
        {
            Console.WriteLine("ZADANIE 3:");

            var ankieta = new Ankieta()
            {
                A = 1,
                B = 2,
                C = 3,
                D = 4

            };

            var (A, B, C, D, suma) = ankieta;


            Console.WriteLine($"A : {ankieta.A} | B: {ankieta.B} | C: {ankieta.C} | D: {ankieta.D} | SUMA: {ankieta.Suma}");
        }

        static void Zadanie4()
        {
            Console.WriteLine("ZADANIE 4: ");
        }

        static void Zadanie5()
        {
            Console.WriteLine("ZADANIE 5: ");

            Console.WriteLine("Odczytanie pliku: ");

            string text = File.ReadAllText("tekst.txt");
            Console.WriteLine(text);


            



        }
        static void Main(string[] args)
        {
            Zadanie1();

            Console.WriteLine();

           Zadanie2();

            Console.WriteLine();

            Zadanie3();

            Console.WriteLine();

            Zadanie4();

            Zadanie5();
            Console.Read();
        }
    }
}
