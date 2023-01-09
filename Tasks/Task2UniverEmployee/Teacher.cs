using System;

namespace Task2UniverEmployee
{
	public class Teacher : UniversityEmployee
	{
		public Course Course { get; set; }

		public Teacher(string person, int taxID, Course course): base (person, taxID)
		{
			Course = course;
		}
	}

    public override string GetOfficialDuties()
	{
        return $"teaching course {Course.course}";
    }
}
//Создать класс Teacher
//(наследник UniversityEmployee),
//содержащий поле Course- курс, который обеспечивается данным преподавателем