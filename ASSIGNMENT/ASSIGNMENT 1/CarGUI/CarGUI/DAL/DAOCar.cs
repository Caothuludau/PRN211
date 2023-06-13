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
        public static void AddNewCar(Car car)
        {
            string sql = "insert into Cars values (@make, @color, @petname)";
            SqlParameter make = new SqlParameter("@make", DbType.String);
            SqlParameter color = new SqlParameter("@color", DbType.String);
            SqlParameter petname = new SqlParameter("@petname", DbType.String);
            make.Value = car.Make;
            color.Value = car.Color;
            petname.Value = car.Petname;
            DAO.InsertBySql(sql, make, color, petname);

        }
        public static List<Car> GetAllCars()
        {
            string sql = "select * from Cars";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Car> cars = new List<Car>();
            foreach (DataRow dr in dt.Rows)
            {
                cars.Add(new Car(
                    Convert.ToInt32(dr["CarID"]),
                    dr["Make"].ToString(),
                    dr["Color"].ToString(),
                    dr["PetName"].ToString()
                    ));
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

        public static void DeleteCar(Car car)
        {
            string sql = "delete from Cars where CarID = @id";
            SqlParameter parameter1 = new SqlParameter("@id", DbType.Int32);
            parameter1.Value = car.CarID;
            DAO.DeleteBySql(sql, parameter1);
        }

        public static void UpdateCar(Car car)
        {
            string sql = "update Cars set Make = @make, Color = @color, PetName = @petname where carID = @id";
            SqlParameter make = new SqlParameter("@make", DbType.String);
            SqlParameter color = new SqlParameter("@color", DbType.String);
            SqlParameter petname = new SqlParameter("@petname", DbType.String);
            SqlParameter carID = new SqlParameter("@id", DbType.Int32);

            make.Value = car.Make;
            color.Value = car.Color;
            petname.Value = car.Petname;
            carID.Value = car.CarID;
            DAO.UpdateBySql(sql, make, color, petname, carID);
        }
    }
}
