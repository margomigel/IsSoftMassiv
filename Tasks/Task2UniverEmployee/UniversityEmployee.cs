
namespace Task2UniverEmployee
{
	public abstract class UniversityEmployee
	{
		public string Person { get; set; }
		public int TaxID { get; set; }

		public UniversityEmployee(string person, int taxID)
		{
			Person = person;
			TaxID = taxID;
		}

		public abstract string GetOfficialDuties();
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
