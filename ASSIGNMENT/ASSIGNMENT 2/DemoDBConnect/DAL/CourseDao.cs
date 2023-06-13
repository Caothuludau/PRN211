using DemoBDConnect.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoBDConnect.DAL
{
    internal class CourseDao
    {
        public static List<Course> GetAllCourses()
        {
            string sql = "select * from Courses";
            DataTable dt = Dao.GetDataBySql(sql);
            List<Course> courses = new List<Course>();
            foreach (DataRow dr in dt.Rows)
            {
                courses.Add(new Course(
                    Convert.ToInt32(dr["CourseId"]),
                    dr["CourseCode"].ToString(),
                    dr["CourseDescription"].ToString(),
                    Convert.ToInt32(dr["SubjectId"]),
                    Convert.ToInt32(dr["InstructorId"]),
                    Convert.ToInt32(dr["TermId"]),
                    Convert.ToInt32(dr["CampusId"])
                    ));
            }
            return courses;
        }
    }
}
