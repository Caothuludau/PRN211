using DemoBDConnect.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBDConnect.DAL
{
    internal class CourseScheduleDao
    {
        public static List<CourseSchedule> GetAllCourseSchedules()
        {
            string sql = "select * from Course_Schedules";
            DataTable dt = Dao.GetDataBySql(sql);
            List<CourseSchedule> courseSchedules = new List<CourseSchedule>();
            foreach (DataRow dr in dt.Rows)
            {
                courseSchedules.Add(new CourseSchedule(
                    Convert.ToInt32(dr["TeachingScheduleId"]),
                    Convert.ToInt32(dr["CourseId"]),
                    Convert.ToDateTime(dr["TeachingDate"]),
                    Convert.ToInt32(dr["Slot"]),
                    Convert.ToInt32(dr["RoomId"]),
                    dr["Description"].ToString()
                    ));
            }
            return courseSchedules;
        }
    }
}
