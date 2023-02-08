using Task1Candidates;
using Task2UniverEmployee;
using Tasks.Task3Building;

public class Program
{
    private static void Main(string[] args)
    {
        var petrov = new Teacher(
            new Person(
                "Oleg",
                "Putickiy",
                new Address("Minsk", "Pobeditelei", 3, 8)),
            130579,
            new Course("physics", "about physics")
        );
        var velichko = new Teacher(
            new Person(
                "Alexey",
                "Velichko",
                new Address("Minsk", "Slavinskogo", 4, 120)),
            120345,
            new Course("mathematics", "about mathematics")
        );
        var fedorenko = new SupportStaff(
            new Person(
                "Dmitriy",
                "Fedorenko",
                new Address("Minks", "Skoriny", 8, 32)),
            246800,
            "cleaner"
        );
        var vasilievV = new DegreeTeacher(
            new Person(
                "Vasiliy",
                "Vasiliev",
                new Address("Minsk", "Lojinskaya", 18, 76)),
            112233,
            new Course("history", "about history"),
            "Bachelor",
            "history science"
        );
        var vasilievA = new DegreeTeacher(
            new Person(
                "Alexandr",
                "Vasiliev",
                new Address("Minsk", "Kalinovskogo", 38, 12)),
            112238,
            new Course("history", "about history"),
            "Bachelor",
            "history science"
        );
        var vasilievB = new Teacher(
            new Person(
                "Boris",
                "Vasiliev",
                new Address("Minsk", "Engelsa", 8, 7)),
            222233,
            new Course("mathematics", "about mathematics")
        );
        var volovik = new Teacher(
            new Person(
                "Ivan",
                "Volovik",
                new Address("Minsk", "Rait", 21, 17)),
            221133,
            new Course("mathematics", "about mathematics")
        );
        var voronova = new SupportStaff(
            new Person(
                "Alisa",
                "Voronova",
                new Address("Minks", "Gurskogo", 35, 2)),
            255800,
            "cleaner"
        );

        var universityEmployees = new List<UniversityEmployee> {
            petrov,
            velichko,
            fedorenko,
        };

        var buildings = new List<Building>{
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
                        new Room (11, "lecture"),
                        new Room (22, "laboratory"),
                        new Room (23, "seminary"),
                        new Room (24, "auxiliary"),
                        new Room (25, "lecture"),
                        new Room (26, "laboratory"),
                        },
                    new Address ("Minsk","Nezavisimosti", 11, 102)
                ),
                new Building (
                    new List<Room>{
                        new Room (11, "lecture"),
                        new Room (32, "laboratory"),
                        new Room (33, "seminary"),
                        new Room (34, "auxiliary")
                        },
                    new Address ("Minsk","Nezavisimosti", 13, 103)
                ),
                new Building (
                    new List<Room>{
                        new Room (41, "lecture"),
                        new Room (42, "laboratory"),
                        new Room (43, "seminary"),
                        new Room (44, "auxiliary")
                    },
                    new Address ("Minsk","Nezavisimosti", 14, 100)
                )
        };


        var rector = new Person(
            "Alexandr",
            "Volkov",
            new Address("Minsk", "Kolasa", 23, 75)
            );


        var legalAddress = new Address("Minsk", "Nezavisimosti", 12, 109);


        var university = new University(universityEmployees, rector, buildings, legalAddress);


        university.AddEmployee(vasilievV);
        university.AddEmployee(vasilievA);
        university.AddEmployee(vasilievB);
        university.AddEmployee(volovik);
        university.AddEmployee(voronova);


        var FilteredListUniverEmployees = universityEmployees
            .Where(universityEmployee => universityEmployee.Person.Surname.StartsWith("V"))
            .OrderBy(person => person.TaxId)
            .ToList();

        foreach (var universityEmployee in FilteredListUniverEmployees)
            Console.WriteLine($"{universityEmployee.Person.Surname} {universityEmployee.TaxId}");


        var FilteredTeacherSameCourse = universityEmployees
            .Where(universityEmployee => universityEmployee is Teacher teacher
                && teacher.Course.NameCourse.Contains("mathematics"))
            .ToList();

        foreach (var teacher in FilteredTeacherSameCourse)
            Console.WriteLine($"{teacher.Person}");



        var FilteredListTaxIdDuties = university.UniversityEmployees
            .Select(unEmpl => (id: unEmpl.TaxId, duties: unEmpl.GetOfficialDuties()))
            .ToList();

        foreach (var taxIdDuties in FilteredListTaxIdDuties)
            Console.WriteLine($"TaxId: {taxIdDuties.id}, Duties: {taxIdDuties.duties}");


        var FilteredBuildingsWithSameRoom = buildings
            .Where(building => building.Rooms.Any(room => room.RoomNumber==11))
            .ToList();

        foreach(Building building in FilteredBuildingsWithSameRoom)
            Console.WriteLine(building.Address);


        var BuildingWithMaxRooms = buildings
            .MaxBy(building => building.Rooms.Count);

        Console.WriteLine(BuildingWithMaxRooms.Address);


            var FilteredSameSurname = universityEmployees
                .GroupBy(univerEmployee => univerEmployee.Person.Surname)
                .MaxBy(group => group.Count());

        Console.WriteLine($"{FilteredSameSurname.Key}: {FilteredSameSurname.Count()}");

        // Сортировка Sort():
        universityEmployees.Sort();
        universityEmployees.Reverse();
        
        // Сортировка Sort через новый объект:
        universityEmployees.Sort(new ComparerNameSurname());
        universityEmployees.Reverse();

        var SorteduniversityEmployees = universityEmployees.OrderByDescending(univerEmployee 
            => (univerEmployee.Person.NameSurnameLength()))
            .ToList();

        Console.WriteLine(" ");
    }
}

// LINQ
// + Вывести на экран всех сотрудников университета с фамилией,
// начинающейся на определенную букву (по выбору).
// Данный список должен быть отсортирован поTaxId сотрудника 

//2 + Вывести на экран всех преподавателей университета,
//читающих определенный курс  (по выбору., один и тот же курс может читаться несколькими преподавателями).

//3. + Вывести на экран TaxID и должностные обязанности каждого сотрудника (только эту информацию)

//4. + Вывести на экран адреса всех зданий, в который есть комната с определенным номером (по выбору)

//5. + Вывести на экран адрес здания с максимальным количеством комнат в нем

//6. + Вывести на экран самую часто встречающуюся фамилию сотрудника, и число таких сотрудников