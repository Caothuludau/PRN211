using ADOApp.Models;
using System.Data;
using System.Data.SqlClient;

namespace ADOApp.DAL
{
    internal class StudentDao
    {
        public static List<Student> GetAllStudent()
        {
            string sql = "select * from Students";
            DataTable dt = ADO.GetDataBySql(sql);
            List<Student> students = new List<Student>();
            foreach (DataRow dr in dt.Rows)
                students.Add(new Student(
                    Convert.ToInt32(dr["StudentId"]),
                    dr["Roll#"].ToString(),
                    dr["FirstName"].ToString(),
                    dr["MidName"].ToString(),
                    dr["LastName"].ToString()));
            return students;
        }
        public static List<Student> GetStudent(int StudentId)
        {
            string sql = "select * from Students where StudentId = @id";
            SqlParameter parameter1 = new SqlParameter("@id",DbType.Int32);
            //SqlParameter parameter2 = null;
            parameter1.Value = StudentId;
            DataTable dt = ADO.GetDataBySql(sql, parameter1);
            if (dt.Rows.Count == 0) return null;
            List<Student> students = new List<Student>();
            //DataRow dr = dt.Rows[0];
            foreach (DataRow dr in dt.Rows)
                students.Add( new Student(
                Convert.ToInt32(dr["StudentId"]),
                dr["Roll#"].ToString(),
                dr["FirstName"].ToString(),
                dr["MidName"].ToString(),
                dr["LastName"].ToString()));
            return students;
        }

    }
}
