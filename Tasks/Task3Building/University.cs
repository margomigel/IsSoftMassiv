using Task1Candidates;
using Task2UniverEmployee;

namespace Tasks.Task3Building
{
    public class University
    {
        public List<UniversityEmployee> UniversityEmployees { get; set; }
        public Person Rector { get; set; }
        public List<Building> Buildings { get; set; }
        public Address LegalAddress { get; set; }

        public University(List<UniversityEmployee> universityEmployees, Person rector, List<Building> buildings,
            Address legalAddress)
        {
            UniversityEmployees = universityEmployees;
            Rector = rector;
            Buildings = buildings;
            LegalAddress = legalAddress;
        }

        public override bool Equals(object obj)
        {
            if (obj is University university)
            {
                return university.Rector.Equals(Rector)
                       && university.LegalAddress.Equals(LegalAddress);
            }
            return false;
        }

        public void AddEmployee (UniversityEmployee universityEmployeeToAdd)
        {
            foreach (UniversityEmployee universityEmployee in UniversityEmployees)
            {
                if (universityEmployee.Equals(universityEmployeeToAdd))
                {
                    return;
                }
            }
            UniversityEmployees.Add(universityEmployeeToAdd);
        }

        public void AddBuilding(Building buildingToAdd)
        {
            foreach (Building building in Buildings)
            {
                if (building.Equals(buildingToAdd))
                {
                    return;
                }
            }
            Buildings.Add(buildingToAdd);
        }
    }
}

// Создать класс University,
// включающий массив сотрудников,
// ректора,
// и массив зданий (с адресами и помещениями внутри них)