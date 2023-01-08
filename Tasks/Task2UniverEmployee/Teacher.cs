using System;
using System.Security.Cryptography.X509Certificates;

namespace Task2UniverEmployee
{
	public class Teacher : UniversityEmployee
	{
		public Course Course { get; set; }

		public Teacher(Person person, int taxID, Course course): base (person, taxID)
		{
			Course = course;
		}
	}

    public override string GetOfficialDuties():
	{
        return $"teaching course {Course}";
    }
}
//Создать класс Teacher
//(наследник UniversityEmployee),
//содержащий поле Course- курс, который обеспечивается данным преподавателем