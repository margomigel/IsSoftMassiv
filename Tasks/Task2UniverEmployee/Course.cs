using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Task2UniverEmployee
{
	public class Course
	{
		public string NameCourse;
		public string CourseAbout;

		public Course(string nameCourse, string courseAbout)
		{
			NameCourse = nameCourse;
			CourseAbout = courseAbout;
		}
		public override string ToString()
		{
            return $"{NameCourse}: {CourseAbout}";
        }
    }
}
//Создать класс Course-
//включает название и описание курса