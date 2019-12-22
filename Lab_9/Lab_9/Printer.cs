using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{
    class Printer
    {
        private Random _random;

        private double _blackInkLevel;
        private double _cyanInkLevel;
        private double _magentaInkLevel;
        private double _yellowInkLevel;

        public event EventHandler<PaperJammedEventArgs> PaperJammed;
        public event EventHandler<OutOfInkEventArgs> OutOfInk;

        List<Ink> _inks;

        public void OnPaperJammed(EventArgs args)
        {
            Console.WriteLine("Printer: Paper Jammed!");
        }

        public void Print(int pageNumber)
        {
            if (_random.NextDouble() < 0.01)
            {
                // generuj event
                // OnPaperJammed(EventArgs.Empty);
                PaperJammed.Invoke(this, new PaperJammedEventArgs(pageNumber));

            }
            else
            {
                Console.WriteLine("Etykiety");

                _inks.ForEach(x =>
                {
                    x.Level -= _random.NextDouble() * (0.1);

                    if (x.Level <= 0)
                    {
                        OutOfInk.Invoke(this, new OutOfInkEventArgs(x.Color, pageNumber));
                    }
                }
                );

            }
        }

        public void ink()
        {

        }

        private void OutOfInkInternalEventHandler(object sender, OutOfInkEventArgs args)
        {
            Console.WriteLine($"[Printer log] {args.InkColor} is empty at page {args.Page} at {DateTime.Now.ToLongDateString()}, {DateTime.Now.ToLongTimeString()}");
        }
        public Printer()
        {
            _random = new Random();

            _inks = new List<Ink>()
            {
                new Ink ("Black"),
                new Ink ("Cyan"),
                new Ink ("Magenta"),
                new Ink ("Yellow")
            };

            PaperJammed += PaperJammed;
            _blackInkLevel = 1;
            _cyanInkLevel = 1;
            _magentaInkLevel = 1;
            _yellowInkLevel = 1;
        }

        private class Ink
        {
            public Ink(double level, string color)
            {
                Level = level;
                Color = color;
            }

            public Ink(string color)
            {
                Level = 1;
                Color = color;
            }
            public double Level { get; set; }
            public string Color { get; set; }
        }
    }

    // wymiana tuszy: 4 tusze, kazda drukarka ma 4 pola na tusz, pobranie losowa tuszow od 0.1 do 0.01, czarny od 0 do 0.1, jak skonczy sie tusz, wygenerować event i napisac który tusz sie skonczył i na ktorej stronie
}
