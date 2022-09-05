using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class voch
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        //اضافة حساب
        public void mng_voch_add(int voch_id,
                                string voch_date,
                                string voch_type,
                                int sal_id,
                                string voch_ref,
                                int cus_id,
                                string voch_value,
                                string shek_id,
                                string voch_textvalue,
                                string shek_date,
                                string bank_name,
                                int voch_to,
                                string @voch_resone,
                               //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[16];
            para[0] = new SqlParameter("@check", "a");
            para[1] = new SqlParameter("@voch_id", voch_id);
            para[2] = new SqlParameter("@voch_date", voch_date);
            para[3] = new SqlParameter("@voch_type", voch_type);
            para[4] = new SqlParameter("@sal_id", sal_id);
            para[5] = new SqlParameter("@voch_ref", voch_ref);
            para[6] = new SqlParameter("@cus_id", cus_id);
            para[7] = new SqlParameter("@voch_value", voch_value);
            para[8] = new SqlParameter("@shek_id", shek_id);
            para[9] = new SqlParameter("@voch_textvalue", voch_textvalue);
            para[10] = new SqlParameter("@shek_date", shek_date);
            para[11] = new SqlParameter("@bank_name", bank_name);
            para[12] = new SqlParameter("@voch_to", voch_to);
            para[13] = new SqlParameter("@voch_resone", @voch_resone);
            //Created By & Created Date
            para[14] = new SqlParameter("@Created_By", Created_By);
            para[15] = new SqlParameter("@Created_Date", Created_Date);
            dtac.open();
            dtac.ExcutCommand("mng_voc", para);
            dtac.close();
        }
        //تعديل حساب  
        public void mng_voch_up(
                                int voch_id,
                                string voch_date,
                                string voch_type,
                                int sal_id,
                                string voch_ref,
                                int cus_id,
                                string voch_value,
                                string shek_id,
                                string voch_textvalue,
                                string shek_date,
                                string bank_name,
                                int voch_to,
                                string @voch_resone,
                         //Created By & Created Date
                                string Created_By,
                                 DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[16];
            para[0] = new SqlParameter("@check", "u");
            para[1] = new SqlParameter("@voch_id", voch_id);
            para[2] = new SqlParameter("@voch_date", voch_date);
            para[3] = new SqlParameter("@voch_type", voch_type);
            para[4] = new SqlParameter("@sal_id", sal_id);
            para[5] = new SqlParameter("@voch_ref", voch_ref);
            para[6] = new SqlParameter("@cus_id", cus_id);
            para[7] = new SqlParameter("@voch_value", voch_value);
            para[8] = new SqlParameter("@shek_id", shek_id);
            para[9] = new SqlParameter("@voch_textvalue", voch_textvalue);
            para[10] = new SqlParameter("@shek_date", shek_date);
            para[11] = new SqlParameter("@bank_name", bank_name);
            para[12] = new SqlParameter("@voch_to", voch_to);
            para[13] = new SqlParameter("@voch_resone", @voch_resone);
            //Created By & Created Date
            para[14] = new SqlParameter("@Created_By", Created_By);
            para[15] = new SqlParameter("@Created_Date", Created_Date);
            dtac.open();
            dtac.ExcutCommand("mng_voc", para);
            dtac.close();
        }

        //حذف حساب
        public void mng_voch_del(int voch_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@voch_id", voch_id);
            para[1] = new SqlParameter("@check", "d");

            dtac.open();
            dtac.ExcutCommand("mng_voc", para);
            dtac.close();
        }

        //بحث

        public DataTable Serach_voch_bycr(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", vrb_serch);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Serach_voch_bycr", para);
            dtac.close();
            return dt;
        }
        public DataTable Serach_voch_byid(int vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", vrb_serch);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Serach_cash_byid", para);
            dtac.close();
            return dt;
        }

        public DataTable show_voch_byid(int vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", vrb_serch);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("show_voch_byid", para);
            dtac.close();
            return dt;
        }
        public DataTable show_ac()
        {


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("show_ac", null);
            dtac.close();
            return dt;
        }
        public DataTable Check_voch_id(int voch_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@voch_id", voch_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Check_voch_id", para);
            dtac.close();
            return dt;
        }

        public DataTable voch_id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("voch_id", null);
            dtac.close();
            return dt;
        }
    }
}
