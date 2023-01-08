using System;
using System.IO.Pipes;

namespace Task2UniverEmployee
{
	public class UniversityEmployee
	{
		public Person Person;
		public int TaxID { get; set; }

		public UniversityEmployee(Person person, int taxID)
		{
			Person = person;
			TaxID = taxID;
		}

		public virtual string GetOfficialDuties():
		{
			return "University Employee's duties";
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
