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
    }
}