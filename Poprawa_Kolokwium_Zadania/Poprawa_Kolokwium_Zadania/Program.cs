using System;

namespace Poprawa_Kolokwium_Zadania
{
    class Program
    {
        static void Zadanie1()
        {
            Console.WriteLine("ZADANIE1: ");

            bool czyNalezy = true;

            Console.WriteLine("Podaj punkty z przedziału [-1, 1]");

            Console.Write("Podaj a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Podaj b: ");
            double b = double.Parse(Console.ReadLine());


            if (Math.Pow(a, 2) + Math.Pow(b, 2) <= 1)
            {
                Console.WriteLine(czyNalezy);
            }
            else
            {
                czyNalezy = false;
                Console.WriteLine(czyNalezy);
            }
        }

        static void Zadanie2()
        {
            Console.WriteLine("ZADANIE 2: ");

            int[] tablica = new int[10] { 1, 2, 1, 7, 1, 1, 7, 1, 9, 7 };

            int wynik = 0;

            for (int i = 0; i < tablica.Length; i++)
            {

                if (tablica[i] == 1)
                {
                    wynik += 1;
                }

            }

            Console.WriteLine();

            Console.WriteLine($"Liczba 1 wystąpiła {wynik} raz/y");

        }

        static void Zadanie3()
        {
            Console.WriteLine("ZADANIE 3: ");

            int[,] tablica = new int[4, 4];

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    tablica[i, j] = i + j;
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            tablica[2, 3] = 9;

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int suma1 = 0;
            int suma2 = 0;

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    if (i + 1 > j)
                    {
                        continue;
                    }
                    else
                    {
                        suma1 += tablica[i, j];
                    }
                }
            }

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    if (i < j + 1)
                    {
                        continue;
                    }
                    else
                    {
                        suma2 += tablica[i, j];
                    }
                }
            }

            if (suma1 == suma2)
            {
                Console.WriteLine("Sumy pod i nad przekątną są równe");
            }
            else
            {
                Console.WriteLine("Sumy pod i nad przekątną nie są równe");
            }

        }
        public static void Zadanie4()
        {
            Console.WriteLine("ZADANIE 4: ");

            KontoBankowe konto = new KontoBankowe("Adam", "Nowak");

            konto.Uznanie(100);
            konto.Uznanie(300);
            konto.Uznanie(800);
            konto.Obciazenie(1000);

            Console.WriteLine($"Właściciel: {konto.Imie} {konto.Nazwisko} | Numer konta: {konto.Numer} | Stan: {konto.Stan}");

            konto.WypiszHistorie();

        }

        public static void WypiszTablice(double[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static double[,] Zadanie5(double[,] tablica2D, int indeks, bool czyKolumna)
        {
            double[,] nowaTablica;

            if (czyKolumna)
            {
                nowaTablica = new double[tablica2D.GetLength(0), tablica2D.GetLength(1) - 1];

                for (int i = 0; i < nowaTablica.GetLength(0); i++)
                {
                    for (int j = 0; j < nowaTablica.GetLength(1); j++)
                    {
                        if (j >= indeks)
                        {
                            nowaTablica[i, j] = tablica2D[i, (j + 1)];
                        }
                        else
                            nowaTablica[i, j] = tablica2D[i, j];
                    }
                }
                return nowaTablica;
            }
            else
            {
                nowaTablica = new double[tablica2D.GetLength(0) - 1, tablica2D.GetLength(1)];

                for (int i = 0; i < nowaTablica.GetLength(0); i++)
                {
                    for (int j = 0; j < nowaTablica.GetLength(1); j++)
                    {
                        if (j >= indeks)
                        {
                            nowaTablica[i, j] = tablica2D[(i + 1), j];
                        }
                        else
                            nowaTablica[i, j] = tablica2D[i, j];
                    }
                }
                return nowaTablica;
            }
        }

        static void Zadanie5()
        {
            Console.WriteLine("ZADANIE 5: ");

            Random random = new Random();

            double[,] mojatablica = new double[3, 6];

            for (int i = 0; i < mojatablica.GetLength(0); i++)
            {
                for (int j = 0; j < mojatablica.GetLength(1); j++)
                {
                    mojatablica[i, j] = random.Next(100);
                }
            }

            Console.WriteLine("Przed usunieciem kolumny:");

            WypiszTablice(mojatablica);

            Console.WriteLine();

            var usunKolumne = Zadanie5(mojatablica, 2, false);

            Console.WriteLine("Wypisuje po usunieciu kolumny:");

            WypiszTablice(usunKolumne);

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
