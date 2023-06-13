using ConsoleApp1;
using ConsoleAppSE1715;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //DemoArrayList();
        DemoList();
        
    }
    public static void DemoArrayList()
    {
        ArrayList l1 = new ArrayList();
        l1.Add(5);
        l1.Add(6);
        l1.Add(7);
        int sum = (int)l1[0] + (int)l1[1];
        Console.WriteLine(sum);

        ArrayList l2 = new ArrayList();
        l2.Add(new Student(1, "Trung"));
        l2.Add(new Student(2, "Hoa"));
        l2.Add(new Student(3, "Hang"));
        l2.Add(new Employee());
        ((Student)l2[0]).Display();
    }
    public static void DemoList()
    {
        List<int> l1 = new List<int>();
        l1.Add(5);
        //l1.Add("Hang"); 
        l1.Add(6);
        int sum = l1[0] + l1[1];
        Console.WriteLine(sum);

        List<Student> list = new List<Student>();
        list.Add(new Student(1, "Hoang"));
        list.Add(new Student(2, "Nga"));
        //list.Add(new Employee());
        list[0].Display();

        Student student = new Student(1, "Hoang");
        if (list.Contains(student)) Console.WriteLine("Co tim thay");
        else Console.WriteLine("Khong thay");
    }
}