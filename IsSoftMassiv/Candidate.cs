using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSoftMassiv
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
