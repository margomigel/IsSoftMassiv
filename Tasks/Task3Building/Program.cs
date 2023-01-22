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

        List <UniversityEmployee> universityEmployees = new List<UniversityEmployee> {
            petrov,
            velichko,
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


        Person rector = new Person(
            "Alexandr",
            "Volkov",
            new Address("Minsk", "Kolasa", 23, 75)
            );


        Address legalAddress = new Address("Minsk", "Nezavisimosti", 12, 109);


        University university = new University(universityEmployees, rector, buildings, legalAddress);

        university.AddEmployee(vasilievV); 
        university.AddEmployee(vasilievA);
        university.AddEmployee(vasilievB);
        university.AddEmployee(volovik);
        university.AddEmployee(voronova);

        var FilteredListUniverEmployees = universityEmployees
            .Where(universityEmployee => universityEmployee.Person.Surname.Contains("V"))
            .OrderBy(person => person.TaxId)
            .ToList();

        foreach (var universityEmployee in FilteredListUniverEmployees)
            Console.WriteLine($"{universityEmployee.Person.Surname} {universityEmployee.TaxId}");


        var FilteredTeacherSameCourse = universityEmployees
            .Where(universityEmployee => universityEmployee is Teacher)
            .Where(teacher => (teacher as Teacher).Course.NameCourse.Contains("mathematics"))
            .ToList();

        foreach (var teacher in FilteredTeacherSameCourse)
            Console.WriteLine($"{teacher.Person}");



        var FilteredListTaxIdDuties = university.universityEmployees
            .Select(universityEmployee => (universityEmployee.TaxId, universityEmployee.GetOfficialDuties()))
            .ToList();

        foreach (var taxIdDuties in FilteredListTaxIdDuties)
            Console.WriteLine(taxIdDuties);


        var FilteredBuildingsWithSameRoom = buildings
            .Where(building => building.rooms
                .Any(room => room.RoomNumber==11))
            .ToList();

        foreach(Building building in FilteredBuildingsWithSameRoom)
            Console.WriteLine(building.Address);


        var BuildingWithMaxRooms = buildings
            .OrderBy(building => building.rooms.Count)
            .Last();

            Console.WriteLine(BuildingWithMaxRooms.Address);


            var FilteredSameSurname = universityEmployees
                .GroupBy(univerEmployee => univerEmployee.Person.Surname)
                .OrderByDescending(group => group.Count())
                .First();

            Console.WriteLine($"{FilteredSameSurname.Key}: {FilteredSameSurname.Count()}");

            universityEmployees.Sort();
            Console.WriteLine(" ");

    }
}
//Создать и инициализировать объект
//типа University (ректор, юридический адрес, сотрудники, здания)

//Для всех сущностей переопределить метод Equals

//Для всех сущностей, включающих списки List, обеспечить уникальность объектов в списке.
//           Например, в университете должен быть только один сотрудник с конкретным ТахId,
//           попытка добавления сотрудника с тем же TaxId не должна быть успшной
//           (сотрудник не добавляется).
//    Для этого в классе University сделать publuc метод AddEmployee,
//          который проходит по списку сотрудников и сранивает их с новым кандидатом при помощи Equals.
//          Если сотрудник с таким TaxId не найден, добавляет его в список. 


// LINQ
// + Вывести на экран всех сотрудников университета с фамилией,
// начинающейся на определенную букву (по выбору).
// Данный список должен быть отсортирован поTaxId сотрудника 

//2 + Вывести на экран всех преподавателей университета,
//читающих определенный курс  (по выбору., один и тот же курс может читаться несколькими преподавателями).

//3. + Вывести на экран TaxID и должностные обязанности каждого сотрудника (только эту информацию)

//4. + Вывести на экран адреса всех зданий, в который есть комната с определенным номером (по выбору)

//5. + Вывести на экран адрес здания с максимальным количеством комнат в нем

//6.Вывести на экран самую часто встречающуюся фамилию сотрудника, и число таких сотрудников