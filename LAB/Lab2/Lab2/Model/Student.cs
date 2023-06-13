using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBDConnect.Model
{
    internal class Student
    {
        public string? StudentId { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public DateTime? DOB { get; set; }
        public string? Major { get; set; }
        public float Scholarship { get; set; }
        public bool Active { get; set; }

        public Student(string? studentId, string? name, string? gender, DateTime? dOB, string? major, float scholarship, bool active)
        {
            StudentId = studentId;
            Name = name;
            Gender = gender;
            DOB = dOB;
            Major = major;
            Scholarship = scholarship;
            Active = active;
        }

        public Student()
        {
            
        }

        
    }
}
