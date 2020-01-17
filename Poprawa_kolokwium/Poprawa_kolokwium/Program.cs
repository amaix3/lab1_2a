using System;

namespace Poprawa_kolokwium
{
    class Program
    {
        static void Zadanie1()
        {
            Console.WriteLine("ZADANIE 1: ");


            Console.WriteLine("Podaj punkty z przedziału [-1, 1]");

            Console.Write("Podaj a: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Podaj b: ");
            double y = double.Parse(Console.ReadLine());

            double r = 1;



            if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= r)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void Zadanie2()
        {
            Console.WriteLine("ZADANIE 2: ");

            int[] tablica = new int[10] { 1, 2, 1, 4, 5, 1, 7, 8, 9, 10 };

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                Console.WriteLine(tablica[i]);
            }


        }

        static void Zadanie3()
        {
            Console.WriteLine("ZADANIE 3: ");

            int[,] tablica = new int[4, 4];
            double suma1 = 0;
            double suma2 = 0;

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    tablica[i, j] = i + j;
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    if (tablica[i, j] == i || tablica[i, j] == j)
                    {
                        suma1 += tablica[i, j];
                    }
                }
            }



            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    if (tablica[i, j] == (tablica.GetLength(0) + i - 1) || tablica[i, j] == (tablica.GetLength(1) + j - 1))
                    {
                        suma2 += tablica[i, j];
                    }
                }
            }

            if (suma1 > suma2)
            {
                Console.WriteLine("Suma z pierwszej tablicy jest większa");
            }
            else
            {
                Console.WriteLine("Suma z drugiej tablicy jest wieksza");
            }

        }

        static void Zadanie4()
        {
            Console.WriteLine("ZADANIE 4:");
            KontoBankowe konto = new KontoBankowe(200);

            konto.Wlasciciel();
            konto.Numer();


        }

        static void Zadanie5()
        {
            Console.WriteLine("ZADANIE 5: ");

            double[,] tablica = new double[3, 3];

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    int rnd = new Random().Next(0, 9);
                    tablica[i, j] = rnd;

                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }

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

            Console.WriteLine();

            Zadanie5();

            Console.Read();
        }
    }
}
