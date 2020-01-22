using System;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 1 (klasa: ExtensionMethods)

            //int liczba = Convert.ToInt32(Console.ReadLine());

            //(int wynik, int reszta) = liczba.Podziel(3);

            //Console.WriteLine($"{liczba} / 3 = {wynik} r {reszta}");


            //Console.WriteLine();

            string text = "Ala ma kota";

            Console.WriteLine(text.ZliczZnaki('a'));

            ////char t = 'a';
            ////var w = char.ToUpper(t);
            ////var w = char.ToLower(t);
            ////string text2 = "";
            ////var text3 = text2.ToUpper();
            ////var text3 = text2.ToLower();
            Console.WriteLine(text.ZliczZnaki2('a'));
            Console.WriteLine(text.ZliczZnaki2());
            Console.WriteLine(text.ZliczZnaki2('a', true));
            ////Console.WriteLine(text);

            Console.WriteLine();


            // Zadanie 2:
            Reklama reklama = new Reklama("Kup teraz", TypOsoby.Dziecko | TypOsoby.Mlodziez | TypOsoby.Starszy, Zainteresowania.Gaming);

            // | - operator suma bitowa

            reklama.Test();

            Console.Read();
        }
    }
}
