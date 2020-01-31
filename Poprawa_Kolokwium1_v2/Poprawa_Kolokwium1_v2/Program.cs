using System;

namespace Poprawa_Kolokwium1_v2
{
    class Program
    {// x z kreska - to srednia
        static double Zadanie1(double a, double b, double c)
        {
            if (a > 0 && a < 1)
            {
                Console.WriteLine($"Parametr a = {a} mieście się w przedziale [0-1]");
            }

            else
            {
                Console.WriteLine($"Parametr a = {a} nie mieści się przedziale [0-1]");
            }

            if (b > 0 && b < 1)
            {

                Console.WriteLine($"Parametr b = {b} mieście się w przedziale [0-1]");
            }
            else
            {
                Console.WriteLine($"Parametr b = {b} nie mieści się przedziale [0-1]");
            }

            if (c > 0 && c < 1)
            {

                Console.WriteLine($"Parametr c = {c} mieście się w przedziale [0-1]");
            }
            else
            {
                Console.WriteLine($"Paramrtr c = {c} nie mieści się przedziale [0-1]");
            }

            return a * b * c;
        }



        static void Zadanie2()
        {
            Console.WriteLine("ZADANIE 2:");

            double[] tablica = new double[10] { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4 };

            double suma = 0;

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                suma += tablica[i];
            }

            double srednia = suma / tablica.Length;

            double gora = 0;

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                gora += Math.Pow(tablica[i] - srednia, 2);
            }

            double wynik = Math.Sqrt(gora / tablica.Length);

            Console.WriteLine(wynik);

        }

        static void Zadanie3()
        {
            Console.WriteLine("ZADANIE 3:");
        }

        static void Otworz(int pin)
        {
            Console.WriteLine("Otwarto drzwi");
        }

        static void Otworz(string pin)
        {
            Console.WriteLine("Otwarto drzwi");
        }

        static void Otworz(DateTime data)
        {
            DateTime data1 = new DateTime(2020, 05, 01);
            DateTime data2 = new DateTime(2020, 05, 03);



        }
        static void Zadanie4()
        {
            Console.WriteLine("ZADANIE 4:");

            Console.Write("Podaj PIN: ");

            int PIN = int.Parse(Console.ReadLine());


            if (PIN == 1234)
            {
                Otworz(PIN);
            }
            else
            {
                Console.WriteLine("Drzwi zamkniete");
            }

            string a = Convert.ToString(PIN);

            if (a == "password")
            {
                Otworz(a);
            }

            DateTime Data = DateTime.Now;

        }

        static void Zadanie5()
        {
            Console.WriteLine("ZADANIE 5:");
            Konto konto = new Konto("adamnowak123@gmail.com", "auto", "AdaM");

            Console.WriteLine($"Email: {konto.Email} | Login: {konto.Login} | Hasło: {konto.Haslo}");


        }
        static void Main(string[] args)
        {
            //Zadanie1:
            Console.WriteLine($"Wynik: {Zadanie1(0.7, 0.5, 0.2)}");

            Console.WriteLine();

            Zadanie2();

            Console.WriteLine();

            Zadanie3();

            Console.WriteLine();

            Zadanie4();

            Console.WriteLine();

            Zadanie5();
            Console.Read();
        }
    }
}
