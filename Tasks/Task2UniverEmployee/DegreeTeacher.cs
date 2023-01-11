namespace Task2UniverEmployee
{
    public class DegreeTeacher : Teacher
    {
        public string ScienceDegree { get; set; }
        public string Rank { get; set; }

        public DegreeTeacher(string person,
            int taxID,
            Course course,
            string scienceDegree,
            string rank) :
            base(person, taxID, course)
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
//Создать класс DegreeTeacher-
//преподаватель со степенью, наследник от Teacher,
//содержащий поля с информацией о научной степени и звании преподавателя 