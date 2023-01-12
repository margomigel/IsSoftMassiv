using Task1Candidates;
using Task2UniverEmployee;

namespace Tasks.Task3Building
{
    public class University
    {
        public List <UniversityEmployee> universityEmployees;
        public Person Rector { get; set; }
        public List <Building> buildings;
        public Address LegalAddress { get; set; }

        public University(List <UniversityEmployee> universityEmployees, Person rector, List<Building> buildings, Address legalAddress)
        {
            this.universityEmployees= universityEmployees;
            Rector= rector;
            this.buildings = buildings;
            LegalAddress= legalAddress;
        }

    }
}

// Создать класс University,
// включающий массив сотрудников,
// ректора,
// и массив зданий (с адресами и помещениями внутри них)