using Task1Candidates;
namespace Task2UniverEmployee
{
	public abstract class UniversityEmployee
	{
		public Person Person { get; set; }
		public int TaxId { get; set; }

		public UniversityEmployee(Person person, int taxId)
		{
			Person = person;
			TaxId = taxId;
		}
        public abstract string GetOfficialDuties();

        public override bool Equals(object obj)
        {
            return (obj is UniversityEmployee universityEmployee && universityEmployee.TaxId.Equals(TaxId));
        }
    }
}

//Создать класс UniversityEmployee,
//включающий поле типа Person и поле TaxID  


//В классе UniversityEmployee
//определить виртуальный метод GetOfficialDuties(),
//возвращающий строковое описание обязанностей  и возможностей сотрудника


//!!Переопределить метод GetOfficialDuties для всех наследников,
//в частности, для Teacher выводить список курсов,
//на которых он специлизируется 
