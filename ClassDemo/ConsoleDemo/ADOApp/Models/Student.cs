using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOApp.Models
{
    internal class Student
    {
        public int StudentId { get; set; }  
        public string RollNumber { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }

        public Student(int studentId, string rollNumber, string firstName, string midName, string lastName)
        {
            StudentId = studentId;
            RollNumber = rollNumber;
            FirstName = firstName;
            MidName = midName;
            LastName = lastName;
        }
    }

}
