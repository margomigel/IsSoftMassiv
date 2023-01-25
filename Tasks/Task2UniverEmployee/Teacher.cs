using Task1Candidates;

namespace Task2UniverEmployee
{
    public class Teacher : UniversityEmployee
    {
        public Course Course { get; set; }

        public Teacher(Person person, int taxId, Course course) : base(person, taxId)
        {
            Course = course;
        }

        public override string GetOfficialDuties()
        {
            return $"teaching course {Course}";
        }

        /*public override bool Equals(object obj)
        {
            if (obj is Teacher teacher)
            {
                return teacher.Person.Equals(Person)
                       && teacher.TaxId.Equals(TaxId)
                       && teacher.Course.Equals(Course);
            }
                return false;
        }*/
    }
}

//Создать класс Teacher
//(наследник UniversityEmployee),
//содержащий поле Course- курс, который обеспечивается данным преподавателем