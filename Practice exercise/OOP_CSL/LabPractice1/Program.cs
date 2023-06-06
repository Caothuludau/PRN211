using LabPractice1;
using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        NewMethod();

        static void NewMethod()
        {
            Student stu1 = new Student();
            stu1.Id = 1;
            stu1.Skill = "Muaquat";
            stu1.Name = "KhaBank";

            Console.WriteLine("He is {0}, he can {1} and we can call him {2}", stu1.Id, stu1.Skill, stu1.Name);

            //Student stu2 = new Student();
            //stu2.Input();
            //stu2.Output();

            SuperStudent stu3 = new SuperStudent();
            stu3.Input();
            stu3.Output();
        }
    }
}