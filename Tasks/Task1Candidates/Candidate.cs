using Task2UniverEmployee;

namespace Task1Candidates
{
    public class Candidate
    {
        public Person Person;
        public List<SubjectScore> SubjectScore { get; set; }

        public Candidate(Person person, List<SubjectScore> subjectScore)
        {
            Person = person;
            SubjectScore = subjectScore;
        }

        public override bool Equals(object obj)
        {
            if (obj is Candidate)
            {
                Candidate candidate = obj as Candidate;
                return candidate.Person.Equals(Person);
            }

            {
                return false;
            }
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
