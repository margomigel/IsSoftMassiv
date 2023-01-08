using System;

namespace Task2UniverEmployee
{
    public class SupportStaff : UniversityEmployee
    {
        string Function;

        public SupportStaff(Person person, int taxID, string function) : base(person, taxID)
        {
            Function = function;
        }

        public override string GetOfficialDuties():
	{
            return $"{Function} duties";
        }
    }
}
//Создать класс SupportStaff-
//наследник от UniversityEmployee,
//включающий с информацией о должностных обязанностях
//- охранник, уборщик, водитель и т.д.