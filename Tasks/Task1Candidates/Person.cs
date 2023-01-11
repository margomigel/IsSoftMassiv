namespace Task1Candidates
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Address;

        public Person (string name, string surname, Address address)
        {
            Name = name;
            Surname = surname;
            Address = address;
        }
    }
}
