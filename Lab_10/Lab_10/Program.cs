using System;

namespace Lab_10
{
    class Program
    {
        /*
       static double ObliczCeneBiletu(object pasazer)
       {

           if (pasazer is Dziecko dziecko)
           {
               //var dziecko = (Dziecko)pasazer;
               Console.WriteLine($"To jest dziecko. ma znizke {dziecko.Znizka}");
           }
           else if (pasazer is OsobaStarsza oStarsza)
           {
               Console.WriteLine("To jest osoba starsza");

               if (oStarsza.ZwolnienieZOplat)
               {
                   Console.WriteLine("Ma darmowe przejazdy");
               }
           }
           */

        /*
        switch (pasazer)
        {
            case Dziecko d:
                Console.WriteLine($"To jest dziecko, ma znizke {d.Znizka}");
                break;

            case OsobaStarsza os when os.ZwolnienieZOplat:
                Console.WriteLine("To jest osoba starsza. Ma darmowe przejazdy");
                break;

            case OsobaStarsza _:
                Console.WriteLine("To jest osoba starsza");
                break;

            case Rencista r when r.CzyZwolniona || r.DataWaznosci > DateTime.Now:
                Console.WriteLine("To jest rencista.");
                Console.WriteLine("Jest zwolniona");
                break;

            case Rencista _:
                Console.WriteLine("To jest rencista. nie jest zwolniona");
                break;

            case null:
                Console.WriteLine("Nie wiem co to jest");
                break;

            default:
                Console.WriteLine("Default");
                break;
        }
        return 0;
    }
        */
    static void Main(string[] args)
        {
            /*
            var pasazer = new ZwyklyPasazer();
            var dziecko = new Dziecko() { Znizka = 0.5 };
            var emeryt = new OsobaStarsza() { ZwolnienieZOplat = true };
            var rencista = new Rencista() { CzyZwolniona = true, DataWaznosci = new DateTime(2020, 03, 07) };

            ObliczCeneBiletu(pasazer);
            ObliczCeneBiletu(dziecko);
            ObliczCeneBiletu(emeryt);
            ObliczCeneBiletu(rencista);
            ObliczCeneBiletu("pasazer");
            ObliczCeneBiletu(null);
            */

            //Zadanie 2:

            var osoba = new OsobaStarsza()
            {
                NrLegitymacji = "1234567890",
                ZwolnienieZOplat = true,
                DataUrodzenia = DateTime.Now.AddYears(-70),
                AdresZdjecia = "./images/photos/1234567890.jpg"
            };

            var dzieckoo = new Dziecko()
            {
                Znizka = 0.5,
                DataUrodzenia = DateTime.Now.AddYears(-15)           
            };


            //(string legitka, bool znizka, DateTime dataUr, string fotka) = osoba.ZwrocWaszyskieDane();

            //var (legitymacja, obnizka, dataUrodz, zdjecieRencisty) = osoba.ZwrocWaszyskieDane();

            //var temp = osoba.ZwrocWaszyskieDane();
            //Console.WriteLine($"{temp.nrLegitymacji}, {temp.zwolnienie}");

            var(nrLegitymacji, zwolnienie, dataUr, zdjecie) = osoba;
            var(samNr, fotka) = osoba;

            var (dataU, klasa) = dzieckoo;
            Console.WriteLine($"{dataU} : {klasa}");

            Console.Read();
        }
    }
}
