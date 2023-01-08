using Task2UniverEmployee;
using System.Security.Cryptography.X509Certificates;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        UniversityEmployee petrov = new Teacher("Petr", "Petrov", 13579, "physics", "about physics");
        UniversityEmployee ivanov = new Teacher("Ivan", "Ivanov", 12345, "mathematics", "about mathematics");
        UniversityEmployee fedorov = new SupportStaff("Fedor", "Fedorov", 24680, "cleaner");
        UniversityEmployee vasiliev = new DegreeTeacher("Vasiliy", "Vasiliev", 112233, 
            "history", "about history", "Bachelor", "history science");

        UniversityEmployee[] universityEmployees = {
            petrov,
            ivanov,
            fedorov,
            vasiliev
        }

        foreach (UniversityEmployee universityEmployee in universityEmployees)
        {
            Console.WriteLine($" {universityEmployee.Surname} {universityEmployee.GetOfficialDuties} \")
        }

        foreach (UniversityEmployee universityEmployee in universityEmployees)
        {
            if (universityEmployee is Teacher)
            {
                Console.WriteLine($" {universityEmployee.Surname} {universityEmployee.GetOfficialDuties} \")
            }
        }
    }
}

//Вывести на консоль всех сотрудников университета
//с описанием должностных обязанностей каждого

//Вывести на консоль только всех преподавателей