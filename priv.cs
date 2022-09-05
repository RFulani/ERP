using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class priv
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void Update_priv(string user_id,
                                int screen_id,
                                bool ad,
                                bool ed,
                                bool de,
                                bool sh,
                                bool print ,
                                bool search,
                                bool cost ,
                                bool limtprice,
                                bool profit,
                                int VAT_status,
                                decimal VAT_value
            //Created By & Created Date
            , string Created_By
            , DateTime Created_Date
)
        {
            SqlParameter[] para = new SqlParameter[15];
            para[0] = new SqlParameter("@user_id", user_id);
            para[1] = new SqlParameter("@screen_id", screen_id);
            para[2] = new SqlParameter("@priv_add", ad);
            para[3] = new SqlParameter("@priv_edit", ed);
            para[4] = new SqlParameter("@priv_delete", de);
            para[5] = new SqlParameter("@priv_display", sh);
            para[6] = new SqlParameter("@priv_print", print);
            para[7] = new SqlParameter("@priv_search", search);
            para[8] = new SqlParameter("@priv_cost", cost);
            para[9] = new SqlParameter("@priv_limtprice", limtprice);
            para[10] = new SqlParameter("@priv_profit", profit);
            para[11] = new SqlParameter("@VAT_status", VAT_status);
            para[12] = new SqlParameter("@VAT_value", VAT_value);
            //Created By & Created Date
            para[13] = new SqlParameter("@Created_By", Created_By);
            para[14] = new SqlParameter("@Created_Date", Created_Date);



            dtac.open();
            dtac.ExcutCommand("Update_priv", para);
            dtac.close();
        }

        public DataTable Get_allList()
        {
           
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_allList", null);
            dtac.close();
            return dt;
        }
        public DataTable get_priv(string user_id, int list_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@user_id", user_id);
            para[1] = new SqlParameter("@list_id", list_id);
            
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("get_priv", para);
            dtac.close();
            return dt;
        }


        public DataTable get_priv11(int screen_id,string user_id)
        {
            SqlParameter[] para = new SqlParameter[2];
        
            para[0] = new SqlParameter("@screen_id", screen_id);
            para[1] = new SqlParameter("@user_id", user_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("get_priv11", para);
            dtac.close();
            return dt;
        }

        public DataTable Show_screenONPriv(int list_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@list_id", list_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_screenONPriv", para);
            dtac.close();
            return dt;
        }


        public DataTable Get_priv_Form(string user_id, int screen_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@user_id", user_id);
            para[1] = new SqlParameter("@screen_id", screen_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_priv_Form", para);
            dtac.close();
            return dt;
        }
        public DataTable Get_priv_FormDisplay(string user_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@user_id", user_id);
            

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_priv_FormDisplay", para);
            dtac.close();
            return dt;
        }



        public DataTable privShowing_Screen(string user_id, int screen_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@user_id", user_id);
            para[1] = new SqlParameter("@screen_id", screen_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("privShowing_Screen", para);
            dtac.close();
            return dt;
        }
        public void EnablePriv(
                                string user_id,
                                int screen_id
                               
)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@user_id", user_id);
            para[1] = new SqlParameter("@screen_id", screen_id);


            dtac.open();
            dtac.ExcutCommand("EnablePriv", para);
            dtac.close();
        }
        public void disablePriv(
                                string user_id,
                                int screen_id

                                )
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@user_id", user_id);
            para[1] = new SqlParameter("@screen_id", screen_id);


            dtac.open();
            dtac.ExcutCommand("disablePriv", para);
            dtac.close();
        }
    }
}
