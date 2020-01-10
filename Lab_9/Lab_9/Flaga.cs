using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{
    [Flags]
    public enum TypOsoby
    {
        Brak = 0,
        Niemowle = 1, // [0001]
        Dziecko = 2, // [0010]
        Mlodziez = 4, // [0100]
        Dorosly = 8, // [1000]
        Starszy = 16
    }

    // Dziecko + mlodziez + starszy = [1011] => 11

    [Flags]
    enum Zainteresowania
    {
        Elektornika,
        Motoryzacja,
        Gaming,
        Edukacja
    }
}
