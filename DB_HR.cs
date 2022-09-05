using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class DB_HR
    {
        public SqlConnection sqlConnection;
        public DB_HR()
        {
            
                sqlConnection = new SqlConnection(@"Server=" + Properties.Settings.Default.ServerName_Hr + "; Database=" + Properties.Settings.Default.DB_HR + ";Integrated Security=false; User ID = " + Properties.Settings.Default.Username_HR + "; Password=" + Properties.Settings.Default.Passward + "");
            
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
        public DataTable SelectdataHR(string proc_name, SqlParameter[] param)
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
        public void ExcutCommandHR(string proc_name, SqlParameter[] param)
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
