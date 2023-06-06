using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPractice1
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Skill { get; set; }

        public Student()
        {
            
        }
        public Student(int id, string name, string skill)
        {
            Id = id;
            Name = name;
            Skill = skill;
        }

        public void Input()
        {
            Console.WriteLine("Nhap vao ID: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao ten: ");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap vao ky nang cua {0}", this.Name);
            Skill = Console.ReadLine();
        }

        public virtual void Output() 
        {
            Console.WriteLine("He is {0}, he can {1} and we can call him {2}", this.Id, this.Skill, this.Name);
        }

    }
}
