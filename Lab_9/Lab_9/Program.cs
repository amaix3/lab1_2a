using System;

namespace Lab_9
{
    class Program
    {
        private static bool _canPrint = true;
        static void Main(string[] args)
        {
            var printer = new Printer();

            printer.PaperJammed += PaperJammedEventHandler;
            printer.OutOfInk += OutOfInkEventHandler;

            for (int i = 0; i < 500; i++)
            {
                printer.Print(i);


                if (!_canPrint)
                {
                    break;
                }
            }
           

            Console.Read();
        }

        static void PaperJammedEventHandler(object sender, PaperJammedEventArgs e)
        {
            Console.WriteLine($"Main: Paper Jammed at page {e.Page}");
            _canPrint = false;
        }

        static void OutOfInkEventHandler(object sender, OutOfInkEventArgs c)
        {
            Console.WriteLine($"Please replace {c.InkColor}");
            _canPrint = false;
        }
    }
}
