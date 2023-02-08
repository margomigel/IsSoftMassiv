using Task1Candidates;

namespace Task2UniverEmployee
{
    public class SupportStaff : UniversityEmployee
    {
        public string Function { get; set; }

        public SupportStaff(Person person, int taxId, string function) : base(person, taxId)
        {
            Function = function;
        }

        public override string GetOfficialDuties()
        {
            return $"{Function} duties";
        }
    }
}