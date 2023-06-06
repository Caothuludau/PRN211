using CarGUI.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarGUI.DAL
{
    internal class DAOCar
    {
        public static List<Car> GetAllCars()
        {
            string sql = "select * from Cars";
            DataTable dt = DAO.GetDataBySql(sql);
            Debug.WriteLine("Here 1");
            List<Car> cars = new List<Car>();
            foreach (DataRow dr in dt.Rows)
            {
                cars.Add(new Car(
                    Convert.ToInt32(dr["CarID"]),
                    dr["Make"].ToString(),
                    dr["Color"].ToString(),
                    dr["PetName"].ToString()
                    ));
                Debug.WriteLine("one more");
            }
            return cars;
        }

        public static Car? GetCar(string CarID)
        {
            string sql = "select * from Cars where CarID = @id";
            SqlParameter parameter1 = new SqlParameter("@id", DbType.Int32);
            parameter1.Value = CarID;
            DataTable dt = DAO.GetDataBySql(sql, parameter1);
            if (dt == null)
            {
                return null;
            }
            else
            {
                    DataRow dr = dt.Rows[0];
                    return new Car(
                        Convert.ToInt32(dr["CarID"]),
                        dr["Make"].ToString(),
                        dr["Color"].ToString(),
                        dr["PetName"].ToString()
                        );
            }
        }
    }
}
