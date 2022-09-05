using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassStatmentSetting_2
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_StatmentSetting_2_add(
                                    int id
                                  , string item_value
                                  , string Ac_id
                                  , string Ac_name
                                  , string Ac_type
                                  //Created By & Created Date
                                  , string Created_By
                                  , DateTime Created_Date
                                                           )
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@id", id);
            para[1] = new SqlParameter("@item_value", item_value);
            para[2] = new SqlParameter("@Ac_id", Ac_id);
            para[3] = new SqlParameter("@Ac_name", Ac_name);
            para[4] = new SqlParameter("@Ac_type", Ac_type);
            //Created By & Created Date
            para[5] = new SqlParameter("@Created_By", Created_By);
            para[6] = new SqlParameter("@Created_Date", Created_Date);
            para[7] = new SqlParameter("@check", "a");


            dtac.open();
            dtac.ExcutCommand("mng_StatmentSetting_2", para);
            dtac.close();
        }

        public void mng_StatmentSetting_2_Update(
                                    int id
                                  , string Ac_id
                                  , string Ac_name
                                  , string Ac_type
                                  //Created By & Created Date
                                  , string Created_By
                                  , DateTime Created_Date
                                                           )
        {
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@id", id);
            para[1] = new SqlParameter("@Ac_id", Ac_id);
            para[2] = new SqlParameter("@Ac_name", Ac_name);
            para[3] = new SqlParameter("@Ac_type", Ac_type);
            //Created By & Created Date
            para[4] = new SqlParameter("@Created_By", Created_By);
            para[5] = new SqlParameter("@Created_Date", Created_Date);
            para[6] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_StatmentSetting_2", para);
            dtac.close();
        }
        //الحذف
        public void mng_StatmentSetting_2_Del(int id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", id);

            dtac.open();
            dtac.ExcutCommand("mng_StatmentSetting_2_Del", para);
            dtac.close();
        }

        //للحصول على الارقام تسلسليه
        public DataTable Get_StatmentSett_2_id()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_StatmentSett_2_id", null);
            dtac.close();
            return dt;
        }
    }
}
