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
//Создать класс SupportStaff-
//наследник от UniversityEmployee,
//включающий с информацией о должностных обязанностях
//- охранник, уборщик, водитель и т.д.