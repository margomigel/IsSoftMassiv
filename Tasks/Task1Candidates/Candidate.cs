using Task2UniverEmployee;

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
            foreach (SubjectScore subjectScore in SubjectScore)
            {
                if (subjectScore.Equals(subjectScoreToAdd))
                {
                    return;
                }
            }
            SubjectScore.Add(subjectScoreToAdd);
        }
    }
}
