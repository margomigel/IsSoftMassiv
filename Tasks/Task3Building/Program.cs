using Task1Candidates;
using Task2UniverEmployee;
using Tasks.Task3Building;

internal class Program
{
    private static void Main(string[] args)
    {
        

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
        }
    }
//Создать и инициализировать объект
//типа University (ректор, юридический адрес, сотрудники, здания)