using CarGUI.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGUI.DAL
{
    internal class DAOOrder
    {
        public static bool isCarOrdered(Car car)
        {
            string sql = "select * from Orders where CarID = @id";
            SqlParameter parameter1 = new SqlParameter("@id", DbType.Int32);
            parameter1.Value = car.CarID;
            DataTable dt = DAO.GetDataBySql(sql, parameter1);
            if (dt == null)
            {
                return false;
            }
            else if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
