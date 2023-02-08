/*
using Task1Candidates;

internal class Program
{
    const string SUBJECT = "hist";
    private static void Main(string[] args)
    {

        Person personIvanov = new Person("Ivan", "Ivanov",
            new Address("Minsk", "Kalinovskogo", 23, 50));
        SubjectScore ivanovMath = new SubjectScore("math", 10);
        SubjectScore ivanovChem = new SubjectScore("chem", 9);
        SubjectScore ivanovHist = new SubjectScore("hist", 9);
        SubjectScore ivanovPhis = new SubjectScore("phis", 8);
        SubjectScore ivanovLang = new SubjectScore("lang", 10);

        List<SubjectScore> ivanovSubjectScore = new List<SubjectScore> {
            ivanovMath,
            ivanovChem,
            ivanovHist,
            ivanovPhis,
            ivanovLang
        };

        Candidate ivanov = new Candidate(personIvanov, ivanovSubjectScore);

        Candidate petrov = new Candidate(
            new Person("Petr", "Petrov", new Address("Minsk", "Chornogo", 12, 31)),
            new List <SubjectScore>{
                new SubjectScore("math", 9),
                new SubjectScore("chem", 10),
                new SubjectScore("hist", 6),
                new SubjectScore("phis", 7),
                new SubjectScore("lang", 8)
            }
        );

        Candidate sidorov = new Candidate(
            new Person("Alexandr", "Sidorov", new Address("Minsk", "Kolasa", 1, 20)),
            new List <SubjectScore>{
                new SubjectScore("math", 6),
                new SubjectScore("chem", 9),
                new SubjectScore("hist", 9),
                new SubjectScore("phis", 8),
                new SubjectScore("lang", 10)
            }
        );

        Candidate kulikova = new Candidate(
            new Person("Anna", "Kulikova", new Address("Grodno", "Gorkogo", 31, 83)),
            new List <SubjectScore>{
                new SubjectScore("math", 10),
                new SubjectScore("chem", 10),
                new SubjectScore("hist", 8),
                new SubjectScore("phis", 9),
                new SubjectScore("lang", 9)
            }
        );

        Candidate mikulina = new Candidate(
            new Person("Maria", "Mikulina", new Address("Grodno", "BLK", 24, 1)),
            new List <SubjectScore>{
                new SubjectScore("math", 10),
                new SubjectScore("chem", 8),
                new SubjectScore("hist", 9),
                new SubjectScore("phis", 10),
                new SubjectScore("lang", 9)
            }
        );

        List <Candidate> candidates = new List<Candidate>{
            ivanov,
            petrov,
            sidorov,
            kulikova,
            mikulina
        };
        ShowInfoStreets(candidates);
        ShowMaxGradeSubject(candidates, SUBJECT);
    }

    static void ShowInfoStreets(List <Candidate> candidates)
    {
        Console.WriteLine("Candidate's streets are: ");
        foreach ( Candidate candidate in candidates)
        {
            Console.WriteLine(candidate.Person.Address.Street + " ");
        }
        Console.WriteLine();
    }

    static void ShowMaxGradeSubject(List <Candidate> candidates, string subject) 
        {
            int maxGrade = 0;
            foreach (Candidate candidate in candidates)
            {
                foreach (SubjectScore subjectScore in candidate.SubjectScore) 
                {
                    if (subjectScore.Subject == subject && subjectScore.Score > maxGrade) 
                        maxGrade = subjectScore.Score;
                }
            }
            Console.WriteLine($"Max {subject}'s grade is {maxGrade}");
        }
}
*/