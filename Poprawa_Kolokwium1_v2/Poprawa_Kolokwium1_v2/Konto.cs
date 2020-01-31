using System;
using System.Collections.Generic;
using System.Text;

namespace Poprawa_Kolokwium1_v2
{
    public class Konto
    {
        public Konto(string email, string haslo, string login)
        {
            Email = email;
            Haslo = haslo;
            Login = login;
        }

        string _email;
        public string Email
        {
            get
            {
                return _email;
            }

            private set
            {
                if (!(value.Contains('@')))
                {
                    value = _email;

                }
                else
                {
                    Console.WriteLine("Możesz zmienić E-mail: ");

                    _email = Console.ReadLine();
                }
            }
        }

        string _haslo;
        public string Haslo
        {
            get
            {
                return _haslo;
            }
            set
            {
                if (!(value.Length <= 6))
                {
                    value = _haslo;
                    
                }
                else
                {
                    Console.WriteLine("Możesz zmienić hasło: ");
                    _haslo = Console.ReadLine();
                }
            }
        }


        string _login;
        public string Login { get; set; }

        int _punkty;
        public int Punkty
        {
            get
            {
                return 0;
            }

        }




    }
}
