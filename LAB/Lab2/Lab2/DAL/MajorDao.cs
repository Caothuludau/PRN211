using DemoBDConnect.DAL;
using DemoBDConnect.Model;
using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.DAL
{
    internal class MajorDao
    {
        public static List<Major> GetAllMajors()
        {
            string sql = "select * from Major";
            DataTable dt = Dao.GetDataBySql(sql);
            List<Major> majors = new List<Major>();
            foreach (DataRow dr in dt.Rows)
                majors.Add(new Major(
                    //Convert.ToInt32(dr["StudentId"]),

                    dr["Code"].ToString(),
                    dr["Title"].ToString()
                    ));
            return majors;

        }
    }
}
