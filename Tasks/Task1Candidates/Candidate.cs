
using System.Dynamic;

namespace Task1Candidates
{
    public class Candidate
    {
        public Person Person;
        public List<SubjectScore> SubjectScore { get; set; }

        public Candidate(Person person, List <SubjectScore> subjectScore)
        {
            Person = person;
            SubjectScore = subjectScore; 
        }
    }
}
