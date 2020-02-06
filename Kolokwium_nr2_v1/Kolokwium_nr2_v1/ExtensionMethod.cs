using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_nr2_v1
{
    public static class ExtensionMethod
    {
        //Zadanie2
        public static string znaki(this int liczba, string tekst)
        {
            StringBuilder sb = new StringBuilder();

            if (tekst.Length < liczba)
            {
                Console.WriteLine(tekst);
            }
            if (tekst.Length > liczba)
            {
                sb.Append(".");
            }

            return tekst;
            

        }
    }
}
