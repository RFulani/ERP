using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class Class_logo
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
      
        public void add_Logo(
                             string co_name_ar,
                             string co_name_en,
                             string co_adress_ar,
                             string co_adress_en,
                             string co_ac_ar,
                             string co_ac_en,
                             string TIN,
                             byte[] co_logo,
                            //Created By & Created Date
                            string Created_By,
                            DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@co_name_ar", co_name_ar);
            para[1] = new SqlParameter("@co_name_en", co_name_en);
            para[2] = new SqlParameter("@co_adress_ar", co_adress_ar);
            para[3] = new SqlParameter("@co_adress_en", co_adress_en);
            para[4] = new SqlParameter("@co_ac_ar", co_ac_ar);
            para[5] = new SqlParameter("@co_ac_en", co_ac_en);
            para[6] = new SqlParameter("@TIN", TIN);
            para[7] = new SqlParameter("@co_logo", co_logo);
            //Created By & Created Date
            para[8] = new SqlParameter("@Created_By", Created_By);
            para[9] = new SqlParameter("@Created_Date", Created_Date);
            para[10] = new SqlParameter("@check", "a");


            dtac.open();
            dtac.ExcutCommand("mng_logo", para);
            dtac.close();
        }
        public void Update_Logo(
                             string co_name_ar,
                             string co_name_en,
                             string co_adress_ar,
                             string co_adress_en,
                             string co_ac_ar,
                             string co_ac_en,
                             string TIN,
                             byte[] co_logo,                                
                             //Created By & Created Date
                             string Created_By,
                             string Created_Date)
        {
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@co_name_ar", co_name_ar);
            para[1] = new SqlParameter("@co_name_en", co_name_en);
            para[2] = new SqlParameter("@co_adress_ar", co_adress_ar);
            para[3] = new SqlParameter("@co_adress_en", co_adress_en);
            para[4] = new SqlParameter("@co_ac_ar", co_ac_ar);
            para[5] = new SqlParameter("@co_ac_en", co_ac_en);
            para[6] = new SqlParameter("@TIN", TIN);
            para[7] = new SqlParameter("@co_logo", co_logo);
            //Created By & Created Date
            para[8] = new SqlParameter("@Created_By", Created_By);
            para[9] = new SqlParameter("@Created_Date", Created_Date);
            para[10] = new SqlParameter("@check", "u");


            dtac.open();
            dtac.ExcutCommand("mng_logo", para);
            dtac.close();
        }
        public void Del_Logo()
        {
            
            dtac.open();
            dtac.ExcutCommand("mng_logo", null);
            dtac.close();
        }
        public DataTable GetLogo()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetLogo", null);
            dtac.close();
            return dt;
        }
    }
}
