using Task1Candidates;
using Task2UniverEmployee;
using Tasks.Task3Building;

internal class Program
{
    private static void Main(string[] args)
    {
        var petrov = new Teacher(
                "Petr Petrov",
                13579,
                new Course("physics", "about physics")
                );
        var ivanov = new Teacher(
            "Ivan Ivanov",
            12345,
            new Course("mathematics", "about mathematics")
            );
        var fedorov = new SupportStaff(
            "Fedor Fedorov",
            24680,
            "cleaner"
            );
        var vasiliev = new DegreeTeacher(
            "Vasiliy Vasiliev",
            112233,
            new Course("history", "about history"),
            "Bachelor",
            "history science"
            );

        UniversityEmployee[] universityEmployees = {
            petrov,
            ivanov,
            fedorov,
            vasiliev,
            };

        Building[] buildings = {
                new Building (
                    new Room []{
                        new Room (1, "lecture"),
                        new Room (2, "laboratory"),
                        new Room (3, "seminary"),
                        new Room (4, "auxiliary")
                        },
                    new Address ("Minsk","Nezavisimosti", 12, 101)
                ),
                new Building (
                    new Room []{
                        new Room (1, "lecture"),
                        new Room (2, "laboratory"),
                        new Room (3, "seminary"),
                        new Room (4, "auxiliary")
                        },
                    new Address ("Minsk","Nezavisimosti", 12, 102)
                ),
                new Building (
                    new Room []{
                        new Room (1, "lecture"),
                        new Room (2, "laboratory"),
                        new Room (3, "seminary"),
                        new Room (4, "auxiliary")
                        },
                    new Address ("Minsk","Nezavisimosti", 12, 103)
                )
            };

        Person rector = new Person(
            "Alexandr",
            "Volkov",
            new Address("Minsk", "Kolasa", 23, 75)
            );

        Address legalAddress = new Address("Minsk", "Nezavisimosti", 12, 109);


        University university = new University(universityEmployees, rector, buildings, legalAddress);
        
        Console.WriteLine(university.ToString());
        }
    }
//Создать и инициализировать объект
//типа University (ректор, юридический адрес, сотрудники, здания)