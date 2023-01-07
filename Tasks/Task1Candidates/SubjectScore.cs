using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Candidates
{
    public class SubjectScore
    {
        const int MAX_CORE = 10;
        private int _score;
        public string Subject { get; set; }
        public int Score { 
            get
            {
                return _score;
            }
            
            set
            { 
                if (value > 0 && value <= MAX_CORE)
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
