using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Lab_11
{
     public class IOFileReader : IReader
    {
        public List<Person> ReadPeople(string fileName)
        {
            string[] allData = File.ReadAllLines(fileName);

            var people = allData.Select(x => CSVStringToPersonConverter.Convert(x));



        return people.ToList();
        }
    }

}
