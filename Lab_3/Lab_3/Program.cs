using System;

namespace Lab_3
{
    class Program
    {
        static double ObliczSrednia(string nazwa)
        {

            string tekst = string.Empty;
            double suma = 0;
            int licznik = 0;

            Console.WriteLine("Wpisz oceny dla " + nazwa);

            while (tekst != "0")
            {
                tekst = Console.ReadLine();
                double ocena;
                bool czyPrzekonwertowano = double.TryParse(tekst, out ocena);


                if (czyPrzekonwertowano)
                {
                    if (ocena > 0 && ocena <= 5)
                    {
                        suma += ocena;
                        licznik++;
                    }
                    else
                    {
                        Console.WriteLine("To nie jest poprawna ocena.");
                    }

                }
                else
                {
                    Console.WriteLine("Podano niepoprawną liczbę");
                }
            }

            double wynik = suma / licznik;
            Console.WriteLine("Średnia z " + nazwa + " to: " + String.Format("{0:N2}", wynik));
            
            return wynik;


        }

        static void Main(string[] args)
        {
            string[] przedmioty = { "P1", "BOiO", "PTC" };
            double[] srednie = new double[przedmioty.Length];



            for (int i = 0; i < przedmioty.Length; i++)
            {
                srednie[i] = ObliczSrednia(przedmioty[i]);
            }
            double sredniaCalkowita = 0;
            foreach (double sredniaCzastkowa in srednie)
            {
                sredniaCalkowita += sredniaCzastkowa;
            }

            Console.WriteLine("Średnia całkowita: " + String.Format("{0:N2}", sredniaCalkowita / przedmioty.Length));

            

            Console.ReadLine();

            //przyciecie do 2 znaków po przecinku: String.Format("{0:N2}"
        }
    }
}
