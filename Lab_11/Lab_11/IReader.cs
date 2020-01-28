using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11
{
    public interface IReader
    {
        List<Person> ReadPeople(string fileName);
    }
}
