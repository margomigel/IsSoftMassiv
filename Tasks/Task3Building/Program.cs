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

        List<UniversityEmployee> universityEmployees = new List<UniversityEmployee>{
            petrov,
            ivanov,
            fedorenko,
            vasiliev
        };

        List <Building> buildings = new List<Building>{
                new Building (
                    new List<Room>{
                        new Room (1, "lecture"),
                        new Room (2, "laboratory"),
                        new Room (3, "seminary"),
                        new Room (4, "auxiliary")
                        },
                    new Address ("Minsk","Nezavisimosti", 10, 100)
                ),
                new Building (
                    new List <Room>{
                        new Room (1, "lecture"),
                        new Room (2, "laboratory"),
                        new Room (3, "seminary"),
                        new Room (4, "auxiliary")
                        },
                    new Address ("Minsk","Nezavisimosti", 11, 102)
                ),
                new Building (
                    new List<Room>{
                        new Room (1, "lecture"),
                        new Room (2, "laboratory"),
                        new Room (3, "seminary"),
                        new Room (4, "auxiliary")
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
        }
    }
//Создать и инициализировать объект
//типа University (ректор, юридический адрес, сотрудники, здания)