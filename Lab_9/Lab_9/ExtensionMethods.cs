using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_9
{
    static public class ExtensionMethods
    {
        public static (int, int) Podziel(this int dzielna, int dzielnik)
        {
            return (dzielna / dzielnik, dzielna % dzielnik);
        }

        //public static int Ilosc(this string znak, char szukana)
        //{
        //    int ile = 0;
        //    for (int i = 0; i < znak.Length; i++)
        //    {
        //        if (znak[i] == szukana)
        //        {
        //            ile++;
        //        }
        //    }
        //    return znak.Length;
        //}

        public static int ZliczZnaki(this string text, char character)
        {
            return text.Where(x => x.Equals(character)).Count();
        }


        //public static int ZliczZnaki1(this string text, char character, bool caseInvariant = true)
        //{
        //    if (!caseInvariant)
        //    {
        //        text.ZliczZnaki1(character);
        //    }

        //    if (char.IsLetter(character))
        //    {
        //        return text.ZliczZnaki1(char.ToLower(character)) + text.ZliczZnaki1(char.ToUpper(character));

        //    }
        //    else
        //    {
        //        return text.ZliczZnaki1(character);
        //    }


        //}


        public static int ZliczZnaki2(this string text, char character)
        {
            return text.Where(X => X.Equals(character)).Count();
        }

        public static int ZliczZnaki2(this string text)
        {
            return text.Length;
        }

        public static int ZliczZnaki2(this string text, char character1, bool caseInvariant = true)
        {
            if (text.Length == 0 )
            {
                caseInvariant = false;
            }

            if (caseInvariant)
            {
                text = text.ToUpper();
                character1 = char.ToUpper(character1);

            }

            return text.ZliczZnaki2(character1);
        }


        public static int SumaTypowOsob(this TypOsoby typ)
        {
            return Enum.GetValues(typeof(TypOsoby)).Cast<TypOsoby>().Sum(x => (int)x);
        }

    }
}
