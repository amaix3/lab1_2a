using System;

namespace Kolokwium_Poprawiona_Wersja
{
    class Program
    {
        static double y(double n)
        {
            if (n == 0)
            {
                return 1;
            }

            return (1.5 * y(n - 1) - 1);

        }
        static void Zadanie1()
        {
            Console.WriteLine("ZADANIE 1: ");

            Console.WriteLine("y[n] = 1,5 *(y[n-1]) - 1");

            Console.WriteLine();

            double n;

            Console.Write("Podaj n: ");

            n = double.Parse(Console.ReadLine());

            Console.WriteLine($"y[{n}] = {y(n)}");
        }

        static void Zadanie2()
        {
            Console.WriteLine("ZADANIE 2: ");

            int x;

            int[] tablica = new int[200];

            Console.WriteLine("Wyświetlenie całej tablicy: ");

            for (int i = 1; i < tablica.Length; i++)
            {
                tablica[i] = i;
                Console.WriteLine(tablica[i]);
            }

            Console.Write("Podaj liczbę, aby podzielić: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Tablica podzielona przez wybraną liczbę: ");

            if (x == 0)
            {
                Console.WriteLine("Nie można dzielić przez 0!");
            }
            else
            {
                for (int i = 1; i < tablica.Length; i++)
                {
                    if (tablica[i] % x == 0)
                    {
                        Console.WriteLine(tablica[i]);
                    }
                }
            }
        }

        static void Zadanie3()
        {
            Console.WriteLine("ZADANIE 3:");
            int[,] jeden = new int[3, 8];
            int[,] dwa = new int[5, 5];

            int rozmiar1 = Math.Max(jeden.GetLength(0), dwa.GetLength(0));
            int rozmiar2 = Math.Max(jeden.GetLength(1), dwa.GetLength(1));

            int[,] wynik = new int[rozmiar1, rozmiar2];

            for (int i = 0; i < jeden.GetLength(0); i++)
            {
                for (int j = 0; j < jeden.GetLength(1); j++)
                {
                    jeden[i, j] = 1;
                    wynik[i, j] += jeden[i, j];
                }
            }

            for (int i = 0; i < dwa.GetLength(0); i++)
            {
                for (int j = 0; j < dwa.GetLength(1); j++)
                {
                    dwa[i, j] = 1;
                    wynik[i, j] += dwa[i, j];
                }
            }

            for (int i = 0; i < wynik.GetLength(0); i++)
            {
                for (int j = 0; j < wynik.GetLength(1); j++)
                {
                    Console.Write(wynik[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        static int Najmniejsza(int[,] tablica)
        {
            int min = int.MaxValue;

            foreach (var item in tablica)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        static int Najmniejsza(int[][] tablica)
        {
            int min = int.MinValue;

            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    if (tablica[i][j] < min)
                    {
                        min = tablica[i][j];
                    }
                }
            }

            return min;
        }

        static void Zadanie4()
        {
            Console.WriteLine("ZADANIE 4:");

            int[,] prostokatna = new int[3, 8];

            for (int i = 0; i < prostokatna.GetLength(0); i++)
            {
                for (int j = 0; j < prostokatna.GetLength(1); j++)
                {
                    prostokatna[i, j] = 1;
                }
            }

            int[] poszarpana = new int[8];
        }

        static void Zadanie5()
        {
            Console.WriteLine("ZADANIE 5:");

            Ebook book = new Ebook("Henryk Sienkiewicz", "Potop", new DateTime(1886, 01, 01), new DateTime(2019, 04, 01), 49.99, 30);

            Console.WriteLine($"Autor: {book.Autor} | Tytuł: {book.Tytul} | Data Wydania: {book.DataWydania} | Data ostatniego zakupu: {book.DataOstatniegoZakupu} | Cena standardowa: {book.CenaStandardowa} zł | Obniżka: {book.Obnizka} % | Aktualna cena: {book.AktualnaCena} zł");
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
