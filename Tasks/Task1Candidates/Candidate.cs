using Task2UniverEmployee;
using Tasks.Task3Building;

namespace Task1Candidates
{
    public class Candidate
    {
        public Person Person { get; set; }
        public List<SubjectScore> SubjectScore { get; set; }

        public Candidate(Person person, List<SubjectScore> subjectScore)
        {
            Person = person;
            SubjectScore = subjectScore;
        }

        public override bool Equals(object obj)
        {
            return (obj is Candidate candidate && candidate.Person.Equals(Person));
        }

        public void AddCandidate(SubjectScore subjectScoreToAdd)
        {
            if (SubjectScore.Contains(subjectScoreToAdd)) return;
            SubjectScore.Add(subjectScoreToAdd);
        }
    }
}
