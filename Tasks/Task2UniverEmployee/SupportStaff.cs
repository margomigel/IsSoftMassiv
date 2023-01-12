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

        public override bool Equals(object obj)
        {
            if (obj is SupportStaff)
            {
                SupportStaff supportStaff = obj as SupportStaff;
                return supportStaff.Person.Equals(Person)
                       && supportStaff.TaxId.Equals(TaxId)
                       && supportStaff.Function.Equals(Function);
            }
            {
                return false;
            }
        }
    }
}
//Создать класс SupportStaff-
//наследник от UniversityEmployee,
//включающий с информацией о должностных обязанностях
//- охранник, уборщик, водитель и т.д.