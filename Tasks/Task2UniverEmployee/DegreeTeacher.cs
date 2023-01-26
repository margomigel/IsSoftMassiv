using Task1Candidates;

namespace Task2UniverEmployee
{
    public class DegreeTeacher : Teacher
    {
        public string ScienceDegree { get; set; }
        public string Rank { get; set; }

        public DegreeTeacher(Person person, int taxId, Course course, string scienceDegree, string rank) 
            : base(person, taxId, course)
        {
            ScienceDegree = scienceDegree;
            Rank = rank;
        }

        public override string GetOfficialDuties()
        {
            return $"teaching course {Course}; Degree: {ScienceDegree} {Rank}";
        }
    }
}