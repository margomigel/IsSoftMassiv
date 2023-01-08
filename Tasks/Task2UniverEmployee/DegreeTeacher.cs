using System;

namespace Task2UniverEmployee
{
    public class DegreeTeacher : Teacher
    {
        public string ScienceDegree;
        public string Rank;

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
    }
}
//Создать класс DegreeTeacher-
//преподаватель со степенью, наследник от Teacher,
//содержащий поля с информацией о научной степени и звании преподавателя 