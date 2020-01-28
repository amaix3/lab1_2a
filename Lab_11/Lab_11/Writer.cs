using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Lab_11
{
    public class Writer
    {
        public void WriteToFile(Person person, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);
            writer.Write($"[{person.Id}] {person.Name} {person.LastName}: {person.Phone} ");
        }

        public void WriteToFileOnlyPhones(IEnumerable<Person> person, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                List<Person> lista = person.ToList();

                for (int i = 1; i < lista.Count; i++)
                {
                    writer.WriteLine($"{lista[i].Phone}");
                }
            }
        }

        public void WriteToPhone(IEnumerable<Person> person)
        {
            List<Person> lista = person.ToList();

            string fileName;
            string prefix = "1/result";
            int dziel = 0;

            while (lista.Count > dziel * 10)
            {
                fileName = prefix + ++dziel + ".txt";

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    var nextLine = lista.Skip((dziel - 1) * 10).Take(10);

                    foreach (var item in nextLine)
                    {
                        writer.WriteLine($"[{item.Phone}, {item.LastName}]");
                    }
                }
            }
        }

        public void WriteTheLetters(IEnumerable<Person> person)
        {
            List<Person> lista = person.ToList();

            string fileName;

            var litera = person.OrderBy(x => x.Name).Select(x => x.Name[0]).Distinct();

            foreach (var item in litera)
            {
                fileName = $"2/{item}.txt";

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    var dane = person.Where(x => x.Name[0] == item);

                    foreach (var selected in dane)
                    {
                        writer.WriteLine($"[{selected.Id} | {selected.Phone} {selected.Name} {selected.LastName}]");
                    }
                }
            }
        }

    }
}
