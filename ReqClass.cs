using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ReqClass
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void Del_Print_AcSt()
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@check", "d");

            dtac.open();
            dtac.ExcutCommand("Print_AcSt", para);
            dtac.close();
        }
        public DataTable ShowReqDetails(int req_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@req_id", req_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowReqDetails", para);
            dtac.close();
            return dt;
        }
        public DataTable ShowAllReqByStat(string req_stat)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@req_stat", req_stat);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllReqByStat", para);
            dtac.close();
            return dt;
        }
        public DataTable ShowAllReqBySalesMan(int sale_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@sal_id", sale_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllReqBySalesMan", para);
            dtac.close();
            return dt;
        }
        public DataTable ShowAllReqBySalesManAndDate(int sale_id, DateTime Date_From, DateTime Date_To)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@sal_id", sale_id);
            para[1] = new SqlParameter("@Date_From", Date_From);
            para[2] = new SqlParameter("@Date_To", Date_To);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllReqBySalesManAndDate", para);
            dtac.close();
            return dt;
        }
        //Report_Where/SELECT para
        public DataTable Show_ALL_Reqs(string where, string SELECT)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@where", where);
            para[1] = new SqlParameter("@SELECT", SELECT);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_ALL_Reqs", para);
            dtac.close();
            return dt;
        }
        public DataTable ShowAllReq()
        {
            
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllReq", null);
            dtac.close();
            return dt;
        }
        public DataTable ShowAllReqByid(int req_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@req_id", req_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllReqByid", para);
            dtac.close();
            return dt;
        }
    }
}
