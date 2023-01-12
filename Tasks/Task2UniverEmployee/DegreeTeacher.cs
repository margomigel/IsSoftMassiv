using Task1Candidates;

namespace Task2UniverEmployee
{
    public class DegreeTeacher : Teacher
    {
        public string ScienceDegree { get; set; }
        public string Rank { get; set; }

        public DegreeTeacher(Person person,
            int taxId,
            Course course,
            string scienceDegree,
            string rank) :
            base(person, taxId, course)
        {
            ScienceDegree = scienceDegree;
            Rank = rank;
        }

        public override string GetOfficialDuties()
        {
            return $"teaching course {Course}; Degree: {ScienceDegree} {Rank}";
        }

        /*public override bool Equals(object obj)
        {
            if (obj is DegreeTeacher)
            {
                DegreeTeacher degreeTeacher = obj as DegreeTeacher;
                return degreeTeacher.Person.Equals(Person)
                       && degreeTeacher.TaxId.Equals(TaxId).Equals(TaxId)
                       && degreeTeacher.Course.Equals(Course).Equals(Course)
                       && degreeTeacher.ScienceDegree.Equals(ScienceDegree)
                       && degreeTeacher.Rank.Equals(Rank);
            }

            {
                return false;
            }
        }*/
    }
}
//Создать класс DegreeTeacher-
//преподаватель со степенью, наследник от Teacher,
//содержащий поля с информацией о научной степени и звании преподавателя 