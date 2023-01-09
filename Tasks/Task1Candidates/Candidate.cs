
namespace Task1Candidates
{
    public class Candidate
    {
        public Person Person;
        public SubjectScore[] SubjectScore;
        
        public Candidate(Person person, SubjectScore[] subjectScore)
        {
            Person = person;
            SubjectScore = subjectScore; 
        }
    }
}
