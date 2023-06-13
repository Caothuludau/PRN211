using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBDConnect.Model
{
    internal class Course
    {
        public int courseId { get; set; }
        public string? courseCode { get; set; }

        public string? courseDescription { get; set; }

        public int subjectId { get; set; }

        public int instructorId { get; set; }
        public int termId { get; set; }
        public int campusId { get; set; }

        public Course(int courseId, string? courseCode, string? courseDescription, int subjectId, int instructorId, int termId, int campusId)
        {
            this.courseId = courseId;
            this.courseCode = courseCode;
            this.courseDescription = courseDescription;
            this.subjectId = subjectId;
            this.instructorId = instructorId;
            this.termId = termId;
            this.campusId = campusId;
        }

        public Course()
        {
            
        }
    }
}
