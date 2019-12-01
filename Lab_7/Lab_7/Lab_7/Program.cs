using System;
using System.Linq;
using System.Collections.Generic;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;

namespace Lab_7
{
    public class Osoba
    {
        public int id;
        public string imie;
        public string nazwisko;
        public int wiek;
        public string kraj;

        public Osoba(int id, string imie, string nazwisko, int wiek, string kraj)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.kraj = kraj;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> lista = Enumerable.Range(100, 150).ToList();

            //List<int> podzielnePrzez3 = lista.Where(x => x % 3 == 0).ToList();

            //double srednia = podzielnePrzez3.Average();
            //double suma = podzielnePrzez3.Sum();


            ////foreach (var item in lista)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //foreach (var item in podzielnePrzez3)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine($"Srednia to: {srednia}");
            //Console.WriteLine($"Suma to: {suma}");

            //int nrStrony = 2;
            //int elemNaStronie = 10;

            //var strona = lista.Skip(elemNaStronie * (nrStrony - 1)).Take(elemNaStronie);

            //foreach (var item in strona)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Osoba> osoby = lista.Select(x => new Osoba()
            //{
            //    id = x,
            //    imie = x.ToString(),
            //    nazwisko = "aaa"
            //}
            //).ToList();

            // osoby[45].nazwisko = "bbb";

            //Osoba szukana = osoby.First(x => x.nazwisko == "aaa");

            //List<string> nazwiska = osoby.Select(x => x.nazwisko).ToList();
            //List<string> unikalneNazwisko = osoby.Select(x => x.nazwisko).Distinct().ToList();

            //foreach (var item in osoby)
            //{
            //    Console.WriteLine($"{item.id}: {item.imie}: {item.nazwisko}");
            //}

            //foreach (var item in nazwiska)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //foreach (var item in unikalneNazwisko)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //Console.WriteLine($"{szukana.id}: {szukana.imie}: {szukana.nazwisko}");



            var nameGen = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var lastnameGen = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());
            var ageGen = RandomizerFactory.GetRandomizer(new FieldOptionsInteger { Min = 1, Max = 100 });
            var countryGen = RandomizerFactory.GetRandomizer(new FieldOptionsCountry());

            //od uzytkownika bierze max wiek i min wiek, oraz kraj i wyswietla spełniajace wymagania

            Console.WriteLine("Podaj min wiek: ");
            int wiekmin = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj max wiek: ");
            int wiekmax = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj kraj: ");
            string kraj = Console.ReadLine();



            List<Osoba> osoby = Enumerable.Range(100, 150).Select(x => new Osoba(x, nameGen.Generate(), lastnameGen.Generate(), ageGen.Generate().Value, countryGen.Generate())).ToList();

            //foreach (var item in osoby)
            //{
            //    Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko} {item.wiek} {item.kraj}");
            //}


            List<Osoba> szukane = osoby.Where(x => x.kraj == kraj && x.wiek >= wiekmin && x.wiek <= wiekmax).ToList();

            foreach (var item in szukane)
            {
                Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko} {item.wiek} {item.kraj}");
            }


            //foreach (var item in osoby)
            //{
            //    Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko}");
            //}


            //List<Osoba> nazwiskasort = osoby.OrderBy(x => x.nazwisko).ThenBy(x => x.imie).ToList();


            //foreach (var item in nazwiskasort)
            //{
            //    Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko}");
            //}


            Console.Read();
        }
    }
}
