using ConsoleApp1;
using ConsoleAppSE1715;
internal class Program
{
    private static void Main(string[] args)
    {
        DateTime date = new DateTime(2021, 1, 1);
        Console.WriteLine(date.ToString());
        Console.WriteLine("Hello, World!");
        //Employee e = new Employee();
        //Student s = new Student();
        //Student s2 = new Student(3, "Linh");
        //s2.Display();
        //s.Id = 1;//goi setter
        //s.Name = "Hoang";
        //s.Display();
        //Console.WriteLine(s.Id);//goi getter

        //Student s4 = new Student();
        //s4.Input();
        //s4.Display();

        //SEStudent s1 = new SEStudent();
        //s1.Id = 2;
        //s1.Name = "Dung";
        //s1.Skill = "C#";
        //s1.Display();

        //SEStudent s3 = new SEStudent(4, "Hoa", "Java");
        //s3.Display();
        //SEStudent s5 = new SEStudent();
        //s5.Input();
        //s5.Display();

        Student s6 = new Student(1,"Hoang");
        Student s7 = new Student(1, "Hoang");
        //s6.Input();
        //s6.Display();
        Console.WriteLine(s6.ToString());
        SEStudent s = new SEStudent(1, "Hoang", "Java");
        SEStudent s1 = new SEStudent(1, "Hoang", "C#");
        /*
        if(s6.Equals(s7))  Console.WriteLine("Bang nhau.");
        else Console.WriteLine("khong bang nhau");
        */
        if (s1.Equals(s)) Console.WriteLine("Bang nhau");
        else Console.WriteLine("KHong bang nhau");
        //Console.WriteLine(s6.Equals(s7));
    }
}