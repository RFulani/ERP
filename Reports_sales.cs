using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class Reports_sales
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public DataTable Search_date(string from ,string to)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@from_date", SqlDbType.VarChar, 20);
            para[0].Value = from;
            para[1] = new SqlParameter("@to_date", SqlDbType.VarChar, 20);
            para[1].Value = to;
           
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Search_date", para);
            dtac.close();
            return dt;
        }
        public DataTable GetSalesSum(DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@from_date", from);
            
            para[1] = new SqlParameter("@to_date", to);
            

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetSalesSum", para);
            dtac.close();
            return dt;
        }
        public DataTable GitInvCost(string from, string to)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@from_date", SqlDbType.VarChar, 20);
            para[0].Value = from;
            para[1] = new SqlParameter("@to_date", SqlDbType.VarChar, 20);
            para[1].Value = to;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GitInvCost", para);
            dtac.close();
            return dt;
        }
        public DataTable GitReInvCost(string from, string to)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@from_date", SqlDbType.VarChar, 20);
            para[0].Value = from;
            para[1] = new SqlParameter("@to_date", SqlDbType.VarChar, 20);
            para[1].Value = to;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GitReInvCost", para);
            dtac.close();
            return dt;
        }
        public DataTable GetReSalesSum(DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@from_date", from);
            
            para[1] = new SqlParameter("@to_date", to);
            

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetReSalesSum", para);
            dtac.close();
            return dt;
        }
        public DataTable Search_inv_typ(string typ)
        {
            SqlParameter[] para = new SqlParameter[1];
          
            para[0] = new SqlParameter("@inv_typ", SqlDbType.NChar, 10);
            para[0].Value = typ;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Search_inv_typ", para);
            dtac.close();
            return dt;
        }
        public DataTable Search_inv_cus(int cus_id, string from, string to)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@cus_id", SqlDbType.Int);
            para[0].Value = cus_id;
            para[2] = new SqlParameter("@from_date", SqlDbType.VarChar, 20);
            para[2].Value = from;
            para[1] = new SqlParameter("@to_date", SqlDbType.VarChar, 20);
            para[1].Value = to;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Search_inv_cus", para);
            dtac.close();
            return dt;
        }
        public DataTable Search_inv_pro(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pro_id", SqlDbType.VarChar,50);
            para[0].Value = pro_id;


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Search_inv_pro", para);
            dtac.close();
            return dt;
        }
        public DataTable Search_inv_sal(int sal_id, string from, string to)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@sal_id", SqlDbType.Int);
            para[0].Value = sal_id;
            para[2] = new SqlParameter("@from_date", SqlDbType.VarChar, 20);
            para[2].Value = from;
            para[1] = new SqlParameter("@to_date", SqlDbType.VarChar, 20);
            para[1].Value = to;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Search_inv_sal", para);
            dtac.close();
            return dt;
        }

        public DataTable select_details(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("select_details", para);
            dtac.close();
            return dt;
        }
    }
    
}
