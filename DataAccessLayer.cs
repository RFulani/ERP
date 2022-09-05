using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace INV.Code
{
    class DataAccessLayer
    {
       public SqlConnection sqlConnection;
        public DataAccessLayer()
        { 
              string mode = Properties.Settings.Default.mode;
            if (mode == "sql")
            {
                sqlConnection = new SqlConnection(@"Server=" + Properties.Settings.Default.server + "; Database=" + Properties.Settings.Default.database + ";Integrated Security=false; User ID = " + Properties.Settings.Default.user_data + "; Password=" + Properties.Settings.Default.pass_data + "");
            }else
            {
                sqlConnection = new SqlConnection(@"Server=" + Properties.Settings.Default.server + "; Database=" + Properties.Settings.Default.database + "; Integrated Security=True");

            }
        }
        public void open()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }
        public void close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            { 
            sqlConnection.Close();
            }

        }
        public DataTable Selectdata(string proc_name , SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = proc_name;
            sqlcmd.Connection = sqlConnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            SqlDataAdapter dr = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            
            dr.Fill(dt);
            return dt;

        }
        public DataTable SelectdataText(string TxtComnd)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = TxtComnd;
            sqlcmd.Connection = sqlConnection;
            SqlDataAdapter dr = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();

            dr.Fill(dt);
            return dt;

        }
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }
        public void ExcutCommand(string proc_name, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = proc_name;
            sqlcmd.Connection = sqlConnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery();
        }

    }
}
