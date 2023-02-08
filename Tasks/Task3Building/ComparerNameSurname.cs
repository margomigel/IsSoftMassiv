using System.Data;
using Task2UniverEmployee;

namespace Tasks.Task3Building
{
    public class ComparerNameSurname : IComparer<UniversityEmployee>
    {
        public int Compare(UniversityEmployee x, UniversityEmployee y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException("Don't compare Employee with null");
            }
            int a = (x.Person.NameSurnameLength());
            int b = (y.Person.NameSurnameLength());
            return a.CompareTo(b);
        }
    }
   
}
