using System;
using System.Collections.Generic;

namespace ASPMVC_App.Models
{
    public partial class Department
    {
        public Department()
        {
            Instructors = new HashSet<Instructor>();
            Subjects = new HashSet<Subject>();
        }

        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
