using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class Class_Warehouse
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void Add_wh(
                           int wh_id,
                           string wh_name,
                           string wh_addres,
                           int brnId,
              string account_No
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[8];

            para[0] = new SqlParameter("@wh_id", wh_id);
            para[1] = new SqlParameter("@wh_name", wh_name);
            para[2] = new SqlParameter("@wh_addres", wh_addres);
            para[3] = new SqlParameter("@brnId", brnId);
            para[4] = new SqlParameter("@account_No", account_No);
            //Created By & Created Date
            para[5] = new SqlParameter("@Created_By", Created_By);
            para[6] = new SqlParameter("@Created_Date", Created_Date);
            para[7] = new SqlParameter("@check", "a");
            dtac.open();
            dtac.ExcutCommand("mng_wherhouse", para);
            dtac.close();
        }
        public void Udate_wh(int wh_id,
            string wh_name,
            string wh_addres,
            int brnId,
            string account_No,
                                         //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[8];

            para[0] = new SqlParameter("@wh_id", wh_id);
            para[1] = new SqlParameter("@wh_name", wh_name);
            para[2] = new SqlParameter("@wh_addres", wh_addres);
            para[3] = new SqlParameter("@brnId", brnId);
            para[4] = new SqlParameter("@account_No", account_No);
            //Created By & Created Date
            para[5] = new SqlParameter("@Created_By", Created_By);
            para[6] = new SqlParameter("@Created_Date", Created_Date);
            para[7] = new SqlParameter("@check", "u");
            dtac.open();
            dtac.ExcutCommand("mng_wherhouse", para);
            dtac.close();
        }
        public void Del_wh(int wh_id,
            string wh_name,
            string wh_addres,
            int brnId,
             string account_No,
                                         //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[8];

            para[0] = new SqlParameter("@wh_id", wh_id);
            para[1] = new SqlParameter("@wh_name", wh_name);
            para[2] = new SqlParameter("@wh_addres", wh_addres);
            para[3] = new SqlParameter("@brnId", brnId);
            para[4] = new SqlParameter("@account_No", account_No);
            //Created By & Created Date
            para[5] = new SqlParameter("@Created_By", Created_By);
            para[6] = new SqlParameter("@Created_Date", Created_Date);
            para[7] = new SqlParameter("@check", "d");
            dtac.open();
            dtac.ExcutCommand("mng_wherhouse", para);
            dtac.close();
        }

        public DataTable Check_wherhouse(int wh_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@wh_id", wh_id);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Check_wherhouse", para);
            dtac.close();
            return dt;
        }

        public DataTable Check_wherhouse_byBranchId(int brnId)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@brnId", brnId);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Check_wherhouse_byBranchId", para);
            dtac.close();
            return dt;
        }

        public DataTable Show_wherhouse()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_wherhouse", null);
            dtac.close();
            return dt;
        }

        

            public DataTable Check_ItemsQty(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];
           
            para[0] = new SqlParameter("@pro_id", pro_id);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Check_ItemsQty", para);
            dtac.close();
            return dt;
        }
    }
}
