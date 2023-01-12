namespace Task2UniverEmployee
{
	public class Course
	{
		public string NameCourse { get; set; }
		public string CourseAbout { get; set; }

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