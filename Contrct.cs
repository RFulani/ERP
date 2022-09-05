using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class Contrct
    {

        Code.DataAccessLayer dtac = new DataAccessLayer();
        //اضافة حساب
        public void mng_cont_add(
                                int cont_id,
                                string cont_titl,
                                string cont_date,
                                int cus_id,
                                string co_name,
                                string co_onr_name,
                                string co_cr,
                                string co_mob,
                                string co_tel,
                                string cont_x1,
                                string cont_x2,
                                string cont_x3,
                                string cont_x4,
                                string cont_x5,
                                string cont_x6,
                                string cont_x7,
                                string cont_x8,
                                         //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[20];
            para[0] = new SqlParameter("@cont_id", cont_id);
            para[1] = new SqlParameter("@check", "a");
            para[2] = new SqlParameter("@cont_titl", cont_titl);
            para[3] = new SqlParameter("@cont_date", cont_date);
            para[4] = new SqlParameter("@cus_id", cus_id);
            para[5] = new SqlParameter("@co_name", co_name);
            para[6] = new SqlParameter("@co_onr_name", co_onr_name);
            para[7] = new SqlParameter("@co_cr", co_cr);
            para[8] = new SqlParameter("@co_mob", co_mob);
            para[9] = new SqlParameter("@co_tel", co_tel);
            para[10] = new SqlParameter("@cont_x1", cont_x1);
            para[11] = new SqlParameter("@cont_x2", cont_x2);
            para[12] = new SqlParameter("@cont_x3", cont_x3);
            para[13] = new SqlParameter("@cont_x4", cont_x4);
            para[14] = new SqlParameter("@cont_x5", cont_x5);
            para[15] = new SqlParameter("@cont_x6", cont_x6);
            para[16] = new SqlParameter("@cont_x7", cont_x7);
            para[17] = new SqlParameter("@cont_x8", cont_x8);
            //Created By & Created Date
            para[18] = new SqlParameter("@Created_By", Created_By);
            para[19] = new SqlParameter("@Created_Date", Created_Date);

            dtac.open();
            dtac.ExcutCommand("mng_cont", para);
            dtac.close();
        }
        //تعديل حساب  
        public void mng_cont_up( 
                                int cont_id,
                                string cont_titl,
                                string cont_date,
                                int cus_id,
                                string co_name,
                                string co_onr_name,
                                string co_cr,
                                string co_mob,
                                string co_tel,
                                string cont_x1,
                                string cont_x2,
                                string cont_x3,
                                string cont_x4,
                                string cont_x5,
                                string cont_x6,
                                string cont_x7,
                                string cont_x8,
                                         //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[20];
            para[0] = new SqlParameter("@cont_id", cont_id);
            para[1] = new SqlParameter("@check", "u");
            para[2] = new SqlParameter("@cont_titl", cont_titl);
            para[3] = new SqlParameter("@cont_date", cont_date);
            para[4] = new SqlParameter("@cus_id", cus_id);
            para[5] = new SqlParameter("@co_name", co_name);
            para[6] = new SqlParameter("@co_onr_name", co_onr_name);
            para[7] = new SqlParameter("@co_cr", co_cr);
            para[8] = new SqlParameter("@co_mob", co_mob);
            para[9] = new SqlParameter("@co_tel", co_tel);
            para[10] = new SqlParameter("@cont_x1", cont_x1);
            para[11] = new SqlParameter("@cont_x2", cont_x2);
            para[12] = new SqlParameter("@cont_x3", cont_x3);
            para[13] = new SqlParameter("@cont_x4", cont_x4);
            para[14] = new SqlParameter("@cont_x5", cont_x5);
            para[15] = new SqlParameter("@cont_x6", cont_x6);
            para[16] = new SqlParameter("@cont_x7", cont_x7);
            para[17] = new SqlParameter("@cont_x8", cont_x8);
            //Created By & Created Date
            para[18] = new SqlParameter("@Created_By", Created_By);
            para[19] = new SqlParameter("@Created_Date", Created_Date);

            dtac.open();
            dtac.ExcutCommand("mng_cont", para);
            dtac.close();
        }

        //حذف حساب
        public void mng_cont_del(
                                int cont_id,
                                string cont_titl,
                                string cont_date,
                                int cus_id,
                                string co_name,
                                string co_onr_name,
                                string co_cr,
                                string co_mob,
                                string co_tel,
                                string cont_x1,
                                string cont_x2,
                                string cont_x3,
                                string cont_x4,
                                string cont_x5,
                                string cont_x6,
                                string cont_x7,
                                string cont_x8,
                                         //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[20];
            para[0] = new SqlParameter("@cont_id", cont_id);
            para[1] = new SqlParameter("@check", "d");
            para[2] = new SqlParameter("@cont_titl", cont_titl);
            para[3] = new SqlParameter("@cont_date", cont_date);
            para[4] = new SqlParameter("@cus_id", cus_id);
            para[5] = new SqlParameter("@co_name", co_name);
            para[6] = new SqlParameter("@co_onr_name", co_onr_name);
            para[7] = new SqlParameter("@co_cr", co_cr);
            para[8] = new SqlParameter("@co_mob", co_mob);
            para[9] = new SqlParameter("@co_tel", co_tel);
            para[10] = new SqlParameter("@cont_x1", cont_x1);
            para[11] = new SqlParameter("@cont_x2", cont_x2);
            para[12] = new SqlParameter("@cont_x3", cont_x3);
            para[13] = new SqlParameter("@cont_x4", cont_x4);
            para[14] = new SqlParameter("@cont_x5", cont_x5);
            para[15] = new SqlParameter("@cont_x6", cont_x6);
            para[16] = new SqlParameter("@cont_x7", cont_x7);
            para[17] = new SqlParameter("@cont_x8", cont_x8);
            //Created By & Created Date
            para[18] = new SqlParameter("@Created_By", Created_By);
            para[19] = new SqlParameter("@Created_Date", Created_Date);

            dtac.open();
            dtac.ExcutCommand("mng_cont", para);
            dtac.close();
        }


        //بحث


        public DataTable show_contByCus(string verb)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@verb", verb);
            

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("show_contByCus", para);
            dtac.close();
            return dt;
        }
        public DataTable show_contByid(int verb)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@verb", verb);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("show_contByid", para);
            dtac.close();
            return dt;
        }
        public DataTable cont_id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("cont_id", null);
            dtac.close();
            return dt;
        }
    }
}
