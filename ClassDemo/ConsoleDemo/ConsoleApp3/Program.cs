using ExtensionMethod_LinQ_Ex;

internal class Program
{
    private static void Main(string[] args)
    {
        //DemoListExtension();
        DemoUsingCourseExtension();
    }
    public static void DemoListExtension()
    {
        List<Course> courses = new List<Course>();
        courses.Add(new Course(1, "PRN", new DateTime(2023, 10, 10)));
        courses.Add(new Course(2, "PRO", new DateTime(2023, 8, 7)));
        courses.Add(new Course(3, "PRJ", new DateTime(2023, 6, 9)));
        courses.Add(new Course(4, "OSG", new DateTime(2023, 5, 31)));

        courses.Display();
    }
    
    public static void DemoUsingCourseExtension()
    {
        Course course = new Course(1, "PRN", new DateTime(2023, 10, 10));
        course.Display(3);
    }
}