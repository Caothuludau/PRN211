using DemoBDConnect.Model;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBDConnect.DAL
{
    internal class RollCallBookDao
    {
        public static List<RollCallBook> GetAllRollCallBooks()
        {
            string sql = "select * from Roll_Call_Books";
            DataTable dt = Dao.GetDataBySql(sql);
            List<RollCallBook> rollCallBooks = new List<RollCallBook>();
            foreach (DataRow dr in dt.Rows)
            {
                rollCallBooks.Add(new RollCallBook(
                    Convert.ToInt32(dr["RollCallBookId"]),
                    Convert.ToInt32(dr["TeachingScheduleId"]),
                    Convert.ToInt32(dr["StudentId"]),
                    Convert.ToBoolean(dr["IsAbsent"]),
                    dr["Comment"].ToString()
                    ));
            }
            return rollCallBooks;
        }

        public static void UpdateAttendance(bool absentStatus, RollCallBook rcb)
        {
            string sql = "update Roll_Call_Books set IsAbsent = @isAbsent where RollCallBookId = @rcbId";
            SqlParameter isAbsent = new SqlParameter("@isAbsent", SqlDbType.Bit);
            SqlParameter rcbId = new SqlParameter("@rcbId", SqlDbType.Int);

            isAbsent.Value = Convert.ToByte(absentStatus);
            rcbId.Value = rcb.rollCallBookId;
            Dao.UpdateBySql(sql, isAbsent, rcbId);
        }
    }
}
