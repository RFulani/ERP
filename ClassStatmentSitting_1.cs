using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassStatmentSitting_1
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_StatmentSetting_1_add(
                                    int id
                                  , string item_value
                                  , string item_name
                                  //Created By & Created Date
                                  , string Created_By
                                  , DateTime Created_Date
                                                           )
        {
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@id", id);
            para[1] = new SqlParameter("@item_value", item_value);
            para[2] = new SqlParameter("@item_name", item_name);
            //Created By & Created Date
            para[3] = new SqlParameter("@Created_By", Created_By);
            para[4] = new SqlParameter("@Created_Date", Created_Date);
            para[5] = new SqlParameter("@check", "a");


            dtac.open();
            dtac.ExcutCommand("mng_StatmentSetting_1", para);
            dtac.close();
        }

        public void mng_StatmentSetting_1_Update(
                                    int id
                                  , string item_name
                                  //Created By & Created Date
                                  , string Created_By
                                  , DateTime Created_Date
                                                           )
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@id", id);
            para[1] = new SqlParameter("@item_name", item_name);
            //Created By & Created Date
            para[2] = new SqlParameter("@Created_By", Created_By);
            para[3] = new SqlParameter("@Created_Date", Created_Date);
            para[4] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_StatmentSetting_1", para);
            dtac.close();
        }
        //الحذف
        public void mng_StatmentSetting_1_Del(int id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", id);

            dtac.open();
            dtac.ExcutCommand("mng_StatmentSetting_1_Del", para);
            dtac.close();
        }

        //للحصول على الارقام تسلسليه
        public DataTable Get_StatmentSett_1_id()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_StatmentSett_1_id", null);
            dtac.close();
            return dt;
        }

        public DataTable GetAccountsforStat(string item_value)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@item_value", item_value);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetAccountsforStat", para);
            dtac.close();
            return dt;
        }
    }
}
