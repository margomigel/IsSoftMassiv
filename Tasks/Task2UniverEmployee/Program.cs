using Task1Candidates;
using Task2UniverEmployee;

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
            new Person (
                "Dmitriy",
                "Fedorenko",
                new Address ("Minks", "Skoriny", 8, 32)),
            24680,
            "cleaner"
            );
        var vasiliev = new DegreeTeacher(
            new Person (
                "Vasiliy",
                "Vasiliev",
                new Address ("Minsk", "Lojinskaya", 18,76)),
            112233,
            new Course("history", "about history"),
            "Bachelor",
            "history science"
            );

        List<UniversityEmployee> universityEmployees = new List <UniversityEmployee>{
            petrov,
            ivanov,
            fedorenko,
            vasiliev
        };

        Console.WriteLine("University Employees are: ");
        foreach (var universityEmployee in universityEmployees)
        {
            Console.WriteLine($" {universityEmployee.Person} {universityEmployee.GetOfficialDuties()}; ");
        }

        Console.WriteLine(" ");
        Console.WriteLine("University's teachers are: ");
        foreach (var universityEmployee in universityEmployees)
        {
            if (universityEmployee is Teacher)
            {
                Console.WriteLine($" {universityEmployee.Person} {universityEmployee.GetOfficialDuties()}; ");
            }
        }
    }
}
*/

//Вывести на консоль всех сотрудников университета
//с описанием должностных обязанностей каждого

//Вывести на консоль только всех преподавателей