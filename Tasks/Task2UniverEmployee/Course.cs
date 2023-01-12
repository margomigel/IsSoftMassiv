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

        public override bool Equals(object obj)
        {
            if (obj is Course)
            {
                Course course = obj as Course;
                return course.NameCourse.Equals(NameCourse)
                       && course.CourseAbout.Equals(CourseAbout);
            }

            {
                return false;
            }
        }
    }
}
//Создать класс Course-
//включает название и описание курса