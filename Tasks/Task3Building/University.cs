using Task1Candidates;
using Task2UniverEmployee;

namespace Tasks.Task3Building
{
    public class University
    {
        public List<UniversityEmployee> universityEmployees;
        public Person Rector { get; set; }
        public List<Building> buildings;
        public Address LegalAddress { get; set; }

        public University(List<UniversityEmployee> universityEmployees, Person rector, List<Building> buildings,
            Address legalAddress)
        {
            this.universityEmployees = universityEmployees;
            Rector = rector;
            this.buildings = buildings;
            LegalAddress = legalAddress;
        }

        public override bool Equals(object obj)
        {
            if (obj is University)
            {
                University university = obj as University;
                return university.Rector.Equals(Rector)
                       && university.LegalAddress.Equals(LegalAddress);
            }

            {
                return false;
            }
        }

        public void AddEmployee (UniversityEmployee universityEmployeeToAdd)
        {
            foreach (UniversityEmployee universityEmployee in universityEmployees)
            {
                if (universityEmployee.Equals(universityEmployeeToAdd))
                {
                    return;
                }
            }
            universityEmployees.Add(universityEmployeeToAdd);
        }


        public void AddBuilding(Building buildingToAdd)
        {
            foreach (Building building in buildings)
            {
                if (building.Equals(buildingToAdd))
                {
                    return;
                }
            }
            buildings.Add(buildingToAdd);
        }
    }
}

// Создать класс University,
// включающий массив сотрудников,
// ректора,
// и массив зданий (с адресами и помещениями внутри них)