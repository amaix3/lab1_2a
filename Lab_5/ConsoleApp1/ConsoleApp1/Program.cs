using System;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            // Napisz program wspomagający magazyn biblioteki
            // Każda książka ma tytuł. Magazyn ma 3 regały
            // Regał ma 6 półek. Półka ma 10 miejsc. Wskaż, gdzie szukać książki na podstawie tytułu


            Ksiazka[,,] magazyn = new Ksiazka[3, 6, 10];
            
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    for(int k = 0; k < 10; k++)
                    {
                        magazyn[i, j, k] = new Ksiazka("Metro", "Dmitrij Głuchowski", i, j, k);
                    }
                }
            }

            //magazyn[1, 1, 1] = new Ksiazka()
            //{
            //    Tytul = "Metro",
            //    Autor = "Dmitrij Głuchowski",
            //    Miejsce = 1,
            //    Regal = 1,
            //    Polka = 1

            //};

            magazyn[2, 4, 5] = new Ksiazka()
            {
                Tytul = "Igrzyska śmierci",
                Autor = "Suzanne Collins",
                Miejsce = 5,
                Regal = 4,
                Polka = 2

            };

            magazyn[1, 3, 4] = new Ksiazka()
            {
                Tytul = "Kredziarz",
                Autor = "C.J. Tudor",
                Miejsce = 4,
                Regal = 3,
                Polka = 1

            };


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        Console.WriteLine(magazyn[i, j, k].Autor);
                        Console.WriteLine(magazyn[i, j, k].Tytul);
                    }
                }
            }

            Console.WriteLine("Jaka książka jest potrzebna?");
            string ksiazka = Console.ReadLine();
           

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (magazyn[i, j, k].Tytul == ksiazka || magazyn[i, j, k].Autor == ksiazka)
                        {
                            Console.WriteLine("Na regale: " + i + ". Na półce: " + j + ". Na miejscu: " + k + ".");
                        }
                    }
                }
            }

            Console.Read();
        }
    }
}
