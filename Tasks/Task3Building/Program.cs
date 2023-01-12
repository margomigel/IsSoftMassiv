using Task1Candidates;
using Task2UniverEmployee;
using Tasks.Task3Building;

internal class Program
{
    private static void Main(string[] args)
    {
        var petrov = new Teacher(
            new Person(
                "Oleg",
                "Putickiy",
                new Address("Minsk", "Pobeditelei", 3, 8)),
            13579,
            new Course("physics", "about physics")
        );
        var ivanov = new Teacher(
            new Person(
                "Alexey",
                "Velichko",
                new Address("Minsk", "Slavinskogo", 4, 120)),
            12345,
            new Course("mathematics", "about mathematics")
        );
        var fedorenko = new SupportStaff(
            new Person(
                "Dmitriy",
                "Fedorenko",
                new Address("Minks", "Skoriny", 8, 32)),
            24680,
            "cleaner"
        );
        var vasiliev = new DegreeTeacher(
            new Person(
                "Vasiliy",
                "Vasiliev",
                new Address("Minsk", "Lojinskaya", 18, 76)),
            112233,
            new Course("history", "about history"),
            "Bachelor",
            "history science"
        );

        List<UniversityEmployee> universityEmployees = new List<UniversityEmployee> {
            petrov,
            ivanov,
            fedorenko,
        };

        List <Building> buildings = new List<Building>{
                new Building (
                    new List<Room>{
                        new Room (11, "lecture"),
                        new Room (12, "laboratory"),
                        new Room (13, "seminary"),
                        new Room (14, "auxiliary")
                        },
                    new Address ("Minsk","Nezavisimosti", 10, 100)
                ),
                new Building (
                    new List <Room>{
                        new Room (21, "lecture"),
                        new Room (22, "laboratory"),
                        new Room (23, "seminary"),
                        new Room (24, "auxiliary")
                        },
                    new Address ("Minsk","Nezavisimosti", 11, 102)
                ),
                new Building (
                    new List<Room>{
                        new Room (31, "lecture"),
                        new Room (32, "laboratory"),
                        new Room (33, "seminary"),
                        new Room (34, "auxiliary")
                        },
                    new Address ("Minsk","Nezavisimosti", 13, 103)
                )
        };

        Person rector = new Person(
            "Alexandr",
            "Volkov",
            new Address("Minsk", "Kolasa", 23, 75)
            );

        Address legalAddress = new Address("Minsk", "Nezavisimosti", 12, 109);


        University university = new University(universityEmployees, rector, buildings, legalAddress);

        University.AddEmployee(vasiliev);

        var vasiliev1 = new DegreeTeacher(
            new Person(
                "Vasiliy3",
                "Vasiliev",
                new Address("Minsk", "Lojinskaya", 18, 76)),
            112233,
            new Course("history", "about history"),
            "Bachelor",
            "history science");

        University.AddEmployee(vasiliev1);
    }
}
//Создать и инициализировать объект
//типа University (ректор, юридический адрес, сотрудники, здания)
//Для всех сущностей переопределить метод Equals
//Для всех сущностей, включающих списки List,
//           обеспечить уникальность объектов в списке.
//           Например, в университете должен быть только
//           один сотрудник с конкретным ТахId,
//           попытка добавления сотрудника с тем же TaxId не должна быть успшной
//           (сотрудник не добавляется).
//       Для этого в классе University сделать publuc метод AddEmployee,
//           который проходит по списку сотрудников и сранивает их с новым кандидатом при помощи Equals.
//          Если сотрудник с таким TaxId не найден, добавляет его в список. 