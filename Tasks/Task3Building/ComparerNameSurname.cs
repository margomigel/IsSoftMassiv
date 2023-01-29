using Task2UniverEmployee;

namespace Tasks.Task3Building
{
    public class ComparerNameSurname : IComparer<UniversityEmployee>
    {
        public int Compare(UniversityEmployee x, UniversityEmployee y)
        {
            int a = (x.Person.Name.Length + x.Person.Surname.Length);
            int b = (y.Person.Name.Length + y.Person.Surname.Length);
            return a.CompareTo(b);
        }
    }
   
}
