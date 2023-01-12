using Task2UniverEmployee;

namespace Task1Candidates
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Address;

        public Person(string name, string surname, Address address)
        {
            Name = name;
            Surname = surname;
            Address = address;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                Person person = obj as Person;
                return person.Name.Equals(Name)
                       && person.Surname.Equals(Surname)
                       && person.Address.Equals(Address);
            }

            {
                return false;
            }
        }
    }
}