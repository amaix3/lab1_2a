using System;

namespace Lab_6
{
    class Program
    {
        //static void OpiszSamochod(Samochod auto)
        //{
        //    Console.WriteLine("[" + auto.VIN + "] " + auto.Model + ": " + auto.Przebieg + " km, " + "Ilość drzwi: " + auto.IloscDrzwi + " Waga: " + auto.Waga);
        //}

        // Cwiczenie:

        static void Opisz_serwer(StronaInternetowa serwer)
        {
            Console.WriteLine("SERWER:");
            Console.WriteLine("Szybkość procesora: " + serwer.SzybkoscProcesora + "GHz");
            Console.WriteLine("Łącze: " + serwer.Lacze + "Mb/s");
            Console.WriteLine("RAM: " + serwer.RAM + "GB");
            Console.WriteLine("Technologia: " + serwer.Technologia);
        }

        static void Opisz_domene(Domena domena)
        {
            Console.WriteLine("DOMENA:");
            Console.WriteLine($"Nazwa: {domena.Nazwa} | Ważność: {domena.Waznosc} | Właściciel: {domena.Wlasciciel}");
        }

        static void Main(string[] args)
        {
            //Samochod mojSamochod = new Samochod("Multipla", 100000, 4, 10000);

            //Samochod s2 = new Samochod("Multipla", 100000, 4, 10000);
            //Samochod s3 = new Samochod("Multipla", 100000, 4, 10000);
            //Samochod nowaMultipla = new Samochod(4, 1000);

            ////mojSamochod.Model = "Ferrari";
            //mojSamochod.Waga = 10000;
            //mojSamochod.Przebieg = 30000;
            ////mojSamochod.IloscDrzwi = 1;


            //OpiszSamochod(mojSamochod);
            //OpiszSamochod(s2);
            //OpiszSamochod(s3);
            //OpiszSamochod(nowaMultipla);

            //Console.WriteLine("Wyprodukwano: " + Samochod.IloscModeli);


            // Cwiczenie: 

            StronaInternetowa str = new StronaInternetowa(3, 100, 16, "HTML");
            Domena domena = new Domena("bla", new DateTime(2022, 01, 01), "Jan Kowalski");

            Opisz_serwer(str);
            Console.WriteLine();
            Opisz_domene(domena);

            Console.Read();
        }
    }
}
