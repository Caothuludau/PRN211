using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Course
    {
        public int Id  { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Course()
        {
        }

        public Course(int id, string title, DateTime startDate)
        {
            Id = id;
            Title = title;
            StartDate = startDate;
        }

        public override string ToString()
        {
            return $"{Id} - {Title} - {StartDate.ToString("dd/mm/yyyy")}";
        }
        public virtual void Input()
        {
            Console.WriteLine("Nhap vao Id:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao Title:");
            Title = Console.ReadLine();
            Console.WriteLine("Nhap vao StartDate:");
            //StartDate = Convert.ToDateTime(Console.ReadLine());
            StartDate = DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
        }
        
    }

    class OnlineCourse: Course {
        public OnlineCourse()
        {
        }

        public string Meet
        {
            get; set;
        }

        public OnlineCourse(int id, string title, DateTime startDate, string meet): base(id, title, startDate)
        {
            Meet = meet;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {Meet}";
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap vao link meet:");
            Meet = Console.ReadLine();
        }
    }
}
