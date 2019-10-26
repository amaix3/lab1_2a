using System;

namespace Lab_4
{
 
    class Program
    {
        static string WczytajLiczbe(string licznik)
        {
            Console.WriteLine("Podaj liczbę " + licznik + ": ");
            string tekst = Console.ReadLine();

            return tekst;

        }
        static void Main(string[] args)
        {
            string tekst1 = WczytajLiczbe("1");
            string tekst2 = WczytajLiczbe("2");

            Console.WriteLine("Wybierz operacje: ");
            string operacja = Console.ReadLine();

            int liczba1 = Convert.ToInt32(tekst1);
            int liczba2 = Convert.ToInt32(tekst2);

            switch (operacja)
            {
                case "+":
                    int wynik = Kalkulator.Dodawanie(tekst1, tekst2);
                    Console.WriteLine(wynik);
                    break;

                case "-":
                    int wynik1 = Kalkulator.Odejmowanie(liczba1, liczba2);
                    Console.WriteLine(wynik1);

                    break;
                case "*":
                    int wynik2 = Kalkulator.Mnozenie(liczba1, liczba2);
                    Console.WriteLine(wynik2);

                    break;
                case "/":
                    /* double wynik3 = Dzielenie(liczba1, liczba2, out bool wynik5);

                     if(wynik5)
                     {
                         Console.WriteLine(wynik3);
                     }
                     else
                     {
                         Console.WriteLine("Podzielono przez 0");
                     } */

                    try
                    {
                        Console.WriteLine(Kalkulator.PodzielZWyjatkiem(liczba1, liczba2));
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Nie można dzielić przez 0.");
                    }
                   
                    
                    break;
                default:
                    Console.WriteLine("Wybrano zły typ operacji.");
                    break;
            }

            Console.Read();
        }
    }
}
