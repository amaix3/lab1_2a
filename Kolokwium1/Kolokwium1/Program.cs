using System;

namespace Kolokwium1
{
    class Program
    {
        static void Zadanie1()
        {
            Console.WriteLine("Zadanie 1: ");

            Console.WriteLine("y[n] = 1,5 *(y[n-1]) - 1");

            Console.WriteLine();

            double n;

            Console.Write("Podaj n: ");

            n = double.Parse(Console.ReadLine());

            if (n == 0)
            {
                double y = 1.5 * 1 - 1;
                Console.WriteLine("Wynik to: " + y);
            }
            else
            {
                double y = 1.5 * (n - 1) - 1;
                Console.WriteLine("Wynik to: " + y);
            }


        }


        static void Zadanie2()
        {
            Console.WriteLine("Zadanie 2: ");

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

        //static void Zadanie3()
        //{
        //    Console.WriteLine("Zadanie 3:");
        //    int[,] tablica1 = new int[3, 10];
        //    int[,] tablica2 = new int[10, 8];
        //    int[,] suma = new int[10, 8];

        //    Console.WriteLine("Tablica 1: ");
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 10; j++)
        //        {
        //            tablica1[i, j] = 3;
        //            Console.Write(tablica1[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine();

        //    Console.WriteLine("Tablica 2: ");

        //    for (int i = 0; i < 10; i++)
        //    {
        //        for (int j = 0; j < 8; j++)
        //        {
        //            tablica2[i, j] = 5;
        //            Console.Write(tablica2[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine("Suma: ");

        //    for (int i = 0; i < 10; i++)
        //    {
        //        for (int j = 0; j < 8; j++)
        //        {
        //            suma[i, j] = tablica1[i, j] + tablica2[i, j];

        //            Console.Write(suma[i, j] + " ");
        //        }
        //        Console.WriteLine();

        //    }
        //}

        static void Zadanie4()
        {
            Console.WriteLine("Zadanie 4: ");

            int[,] tablicaA = new int[3, 4];

            int[][] tablicaB = new int[5][];

        }

        static void Ksiazka(EBook ebook)
        {
            Console.WriteLine("Autor: " + ebook.Autor + ", Tytuł: " + ebook.Tytul + ", Data wydania: " + ebook.DataWydania + ", Data ostatniego zakupu: " + ebook.DataOstatniegoZakupu + ", Cena: " + ebook.CenaStandardowa + "zł , Zniżka: " + ebook.Obnizka + "% ."); ;



        }


        static void Main(string[] args)
        {

            Zadanie1();

            Console.WriteLine();

            Zadanie2();

            Console.WriteLine();

            // Zadanie3();


            Console.WriteLine();

            Zadanie4();



            EBook ksiazka = new EBook("Andrzej Sapkowski", "Wiedźmin", "01.01.2000", "16.11.2019", 30, 5);

            Ksiazka(ksiazka);

            if (ksiazka.AktualnaCena() < 0)
            {
                Console.WriteLine("Cena poniżej 0");
            }
            else
            {
                Console.WriteLine("Cena po obliżce: " + ksiazka.AktualnaCena());
            }


            Console.Read();
        }
    }
}
