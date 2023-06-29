using ConsoleApp2;

internal class Program
{
    private static void Main(string[] args)
    {
        CourseList list = new CourseList();
        //list.InputListOfCourse();
        list.InitData();
        
        list.DisplayListOfCourse();
        //list.SearchByStartDate();
    }
}