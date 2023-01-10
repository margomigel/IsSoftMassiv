using System;

namespace Tasks.Task3Building
{
    public class University
    {
        UniversityEmployee[] universityEmployees;
        public string Rector { get; set; }
        Building[] buildings;

        public University(UniversityEmployee [] universityEmployees, string rector, Buildings [] buildings)
            
    }
}

// Создать класс University,
// включающий массив сотрудников,
// ректора,
// и массив зданий (с адресами и помещениями внутри них)