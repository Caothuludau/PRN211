using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        //property
        public int Id { get; set; }//viet tat getter, setter
        public string Name { get; set; }

        public Student()
        {
        }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public virtual void Input()
        {
            Console.WriteLine("Nhap vao ID:");
            Id = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Nhap Name");
            Name = Console.ReadLine();
        }
        public virtual void Display()
        {
            //Console.WriteLine("Student: ID: " + Id + ", Name: " + Name);
            Console.WriteLine($"Student: ID: {Id}, Name: {Name}");
            //Console.WriteLine(String.Format("Student: ID: {0}, Name: {1}", Id, Name));
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   Id == student.Id &&
                   Name == student.Name;
        }
    }
    class SEStudent : Student
    {
       
        public string Skill { get; set; }

        public SEStudent()
        {
        }

        public SEStudent(int id, string name, string skill):base(id,name)//goi ham tao lop cha
        {
            Skill = skill;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap Skill:");
            Skill = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Skill: {Skill}");
        }

        public override string ToString()
        {
            return base.ToString() + $"Skill: {Skill}";
        }

        public override bool Equals(object? obj)
        {
            return obj is SEStudent student &&
                   base.Equals(obj) && Skill == student.Skill;
        }
    }

    }


