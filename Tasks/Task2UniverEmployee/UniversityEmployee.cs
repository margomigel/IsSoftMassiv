using Task1Candidates;
namespace Task2UniverEmployee
{
    public abstract class UniversityEmployee : IComparable<UniversityEmployee>
    {
        public Person Person { get; set; }
        public int TaxId { get; set; }

        public UniversityEmployee(Person person, int taxId)
        {
            ArgumentNullException.ThrowIfNull(person);
            Person = person;
            CheckLenghtEmployee(person);
            TaxId = taxId;
            CheckTaxId(taxId);
        }

        private void CheckTaxId(int taxId)
        {
            if (taxId < 0)
            {
                throw new ArgumentException("Wrong TaxId!");
            }
        }

        private void CheckLenghtEmployee(Person person)
        {
            if (person.NameSurnameLength() > 20)
            {
                throw new ArgumentException("Wrong Name and Surname length!");
            }
        }

       
        public int CompareTo(UniversityEmployee compareUniversityEmployee)
        {
            int a = Person.NameSurnameLength();
            int b = (compareUniversityEmployee.Person.NameSurnameLength());

            if (a > b)
                return 1;
            else
                if (a < b)
                    return -1;
            return 0;
        }
       
       
        public abstract string GetOfficialDuties();

        public override bool Equals(object obj)
        {
            return (obj is UniversityEmployee universityEmployee && universityEmployee.TaxId.Equals(TaxId));
        }
    }
}

//В классе UniversityEmployee
//определить виртуальный метод GetOfficialDuties(),
//возвращающий строковое описание обязанностей  и возможностей сотрудника


//!!Переопределить метод GetOfficialDuties для всех наследников,
//в частности, для Teacher выводить список курсов,
//на которых он специлизируется 
