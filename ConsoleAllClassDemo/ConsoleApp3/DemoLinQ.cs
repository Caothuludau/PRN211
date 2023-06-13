namespace ExtensionMethod_LinQ_Ex
{
    internal class DemoLinQ
    {
        List<Course> courses;
        public DemoLinQ()
        {
            courses = new List<Course>()
            {
                new Course(1, "PRN", new DateTime(2023, 10, 10)),
                new Course(1, "PRN", new DateTime(2023, 10, 10)),
                new Course(1, "PRN", new DateTime(2023, 10, 10)),
                new Course(1, "PRN", new DateTime(2023, 10, 10)),
                new Course(1, "PRN", new DateTime(2023, 10, 10)),
                new Course(1, "PRN", new DateTime(2023, 10, 10)),
            };

        }
        public List<Course> GetAll()
        {
            return courses;
        }
        public Course GetCourseByIDUsingMethod(int ID)
        {
            return courses.First(x => x.Id == ID);
        }

        public List<Course> GetCourseByTitleUsingMethod(string pattern)
        {
            return courses.Where(x => x.Title.Contains(pattern)).ToList();
        }
    }
}


