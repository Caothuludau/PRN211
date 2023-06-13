using DemoBDConnect.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DemoBDConnect.DAL
{
    internal class StudentDao
    {
        public static List<Student> GetAllStudent() 
        {
            string sql = "select * from Students";
            DataTable dt = Dao.GetDataBySql(sql);
            List<Student> students = new List<Student>();
            foreach (DataRow dr in dt.Rows)
                students.Add(new Student (
                    Convert.ToInt32(dr["StudentId"]),
                    dr["Roll#"].ToString(),
                    dr["FirstName"].ToString(),
                    dr["MidName"].ToString(),
                    dr["LastName"].ToString()));
            return students ;
                    
        }

        public static Student? GetStudent(int StudentId)
        {
            string sql = "select * from Students where StudentId = @id";
            SqlParameter parameter1 = new SqlParameter("@id", DbType.Int32);
            parameter1.Value = StudentId;
            DataTable dt = Dao.GetDataBySql(sql, parameter1);
            if (dt != null)
            {
                return null;
            }
            else
            {
                DataRow dr = dt.Rows[0];
                return new Student(
                    Convert.ToInt32(dr["StudentId"]),
                    dr["Roll#"].ToString(),
                    dr["FirstName"].ToString(),
                    dr["MidName"].ToString(),
                    dr["LastName"].ToString());
            }
        }
    }
}
