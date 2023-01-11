
namespace Task1Candidates
{
    public class SubjectScore
    {
        const int MAX_SCORE = 10;
        private int _score;
        public string Subject { get; set; }
        public int Score { 
            get
            {
                return _score;
            }
            
            set
            { 
                if (value > 0 && value <= MAX_SCORE)
                {
                    _score = value; 
                }
            }
        }

        public SubjectScore(string subject, int score)
        {
            Subject = subject;
            _score = score;
        }
    }
}
