using Excerse_01;

internal class Program
{
    private static void Main(string[] args)
    {
        CourseList list = new CourseList();
        //list.InputListOfCourse();
        //list.InitData();
        list.ReadFromFile(@"TextFile1.txt");
        list.DisplayListOfCourse();
        //list.SearchByStartDate();
        list.Sort();
        list.DisplayListOfCourse();
        list.SortByStartDate();
        list.DisplayListOfCourse();
        list.SortById();
        list.DisplayListOfCourse();
    }
}