using System;
using System.Collections.Generic;
using System.Text;

namespace Poprawa_Kolokwium_Zadania
{
    public class KontoBankowe
    {

        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public string Numer { get; private set; }
        public double Stan { get; private set; }

        List<double> _historia;

        public KontoBankowe(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Numer = NumerKonta();
            _historia = new List<double>(100);
        }

        public List<double> Historia
        {
            get
            {
                return _historia;
            }
        }

        public void Uznanie(double kwota)
        {
            Stan += kwota;
            _historia.Add(kwota);
        }

        public void Obciazenie(double kwota)
        {

            if (!(Stan - kwota < -100))
            {
                Stan -= kwota;
                _historia.Add(-kwota);
            }
            else
            {
                Console.WriteLine("Debet przekroczony.");
            }

        }

        public void WypiszHistorie()
        {
            int i = 1;
            var hist = Historia;

            foreach (var item in hist)
            {
                Console.WriteLine($"{i++}.{item}");
            }
        }

        private string NumerKonta()
        {
            var sb = new StringBuilder();
            var random = new Random();

            for (int i = 1; i <= 26; i++)
            {
                sb.Append(random.Next(10).ToString());
            }

            return sb.ToString();

        }

    }
}
