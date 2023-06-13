using ExtensionMethod_LinQ;

internal class Program
{
    private static void Main(string[] args)
    {
        //DemoListExtension();
        //DemoUsingCourseExtension();
        DemoUsingLinQ();
    }
    public static void DemoListExtension()
    {
        List<Course> courses = new List<Course>();
        courses.Add(new Course(1, "PRN", new DateTime(2021, 1, 1)));
        courses.Add(new Course(2, "PRO", new DateTime(2022, 5, 3)));
        courses.Add(new Course(3, "PRJ", new DateTime(2023, 6, 6)));
        courses.Add(new Course(4, "CSD", new DateTime(2022, 7, 5)));

        courses.Display();
    }
    public static void DemoUsingCourseExtension()
    {
        Course course = new Course(1, "PRN211", new DateTime(2023, 1, 6));
        course.Display(5);
    }

    public static void DemoUsingLinQ()
    {
        DemoLinQ demo = new DemoLinQ();
        Console.WriteLine("Get course by Id:");
        demo.GetCourseByIDUsingMethod(1).Display();

        Console.WriteLine("Get course by Title:");
        demo.GetCourseByTitleUsingMethod("PR").Display();

        Console.WriteLine("Get course by StartDate:");
        demo.GetCourseByDateUsingMethod(new DateTime(2023, 1, 1), new DateTime(2023, 12, 31));

        Console.WriteLine("Get course by Id:");
        demo.GetCourseByIDUsingQuery(1).Display();

        Console.WriteLine("Get course by Title:");
        demo.GetCourseByTitleUsingQuery("PR").Display();

        Console.WriteLine("Get course by StartDate:");
        demo.GetCourseByDateUsingQuery(new DateTime(2023, 1, 1), new DateTime(2023, 12, 31));
    }
}