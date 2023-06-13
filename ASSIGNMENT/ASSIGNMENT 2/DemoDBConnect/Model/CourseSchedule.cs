using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBDConnect.Model
{
    internal class CourseSchedule
    {
        public int teachingScheduleId { get; set; }
        public int courseId { get; set; }
        public DateTime teachingDate { get; set; }
        public int slot { get; set; }
        public int roomId { get; set; }
        public string? description { get; set; }

        public CourseSchedule(int teachingScheduleId, int courseId, DateTime teachingDate, int slot, int roomId, string? description)
        {
            this.teachingScheduleId = teachingScheduleId;
            this.courseId = courseId;
            this.teachingDate = teachingDate;
            this.slot = slot;
            this.roomId = roomId;
            this.description = description;
        }

        public CourseSchedule()
        {
            
        }
    }
}
