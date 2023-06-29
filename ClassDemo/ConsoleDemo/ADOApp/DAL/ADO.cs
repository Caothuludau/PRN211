using System.Data;
using System.Data.SqlClient;

namespace ADOApp.DAL
{
    internal class ADO
    {
        public static SqlConnection GetConnection()
        {
            string ConnectStr = @"server = DESKTOP-M880BMT\TINH; database = AP;user = sa; password = 123";
            return new SqlConnection(ConnectStr);
        }
        public static DataTable GetDataBySql(string sql, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            if (parameters != null || parameters.Length ==0) cmd.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
