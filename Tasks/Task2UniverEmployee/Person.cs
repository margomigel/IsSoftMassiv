using System;

namespace Task2UniverEmployee
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person (string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
