using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBDConnect.Model
{
    internal class RollCallBook
    {
        public int rollCallBookId { get; set; }
        public int teachingScheduleId { get; set; }
        public int studentId { get; set; }
        public bool isAbsent { get; set; }

        public string? comment { get; set; }

        public RollCallBook(int rollCallBookId, int teachingScheduleId, int studentId, bool isAbsent, string? comment)
        {
            this.rollCallBookId = rollCallBookId;
            this.teachingScheduleId = teachingScheduleId;
            this.studentId = studentId;
            this.isAbsent = isAbsent;
            this.comment = comment;
        }

        public RollCallBook()
        {
            
        }
    }
}
