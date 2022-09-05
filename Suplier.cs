using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace INV.Code
{
    
    class Suplier
    {
        Code.DataAccessLayer dac = new DataAccessLayer();

        public void mng_sup_add(
                                int sup_id,
                                string sup_name,
                                DateTime sup_date,
                                string sup_mobile ,
                                string sup_tel,
                                string sup_country,
                                string sup_city,
                                string sup_email,
                                string sup_company ,
                                int sup_credit,
                                string Account_no,
                                //Created By & Created Date
                                string Created_By,
                                DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[14];
            para[0] = new SqlParameter("@check", "a");
            para[1] = new SqlParameter("@sup_id", sup_id);
            para[2] = new SqlParameter("@sup_name", sup_name);
            para[3] = new SqlParameter("@sup_date", sup_date);
            para[4] = new SqlParameter("@sup_mobile", sup_mobile);
            para[5] = new SqlParameter("@sup_tel", sup_tel);
            para[6] = new SqlParameter("@sup_country",sup_country);
            para[7] = new SqlParameter("@sup_city", sup_city);
            para[8] = new SqlParameter("@sup_email", sup_email);
            para[9] = new SqlParameter("@sup_company", sup_company);
            para[10] = new SqlParameter("@sup_credit", sup_credit);
            para[11] = new SqlParameter("@Account_no", Account_no);
            //Created By & Created Date
            para[12] = new SqlParameter("@Created_By", Created_By);
            para[13] = new SqlParameter("@Created_Date", Created_Date);
            dac.open();
            dac.ExcutCommand("mng_sup", para);
            dac.close();

           
        }
        public void mng_sup_update(int sup_id,
                                    string sup_name,
                                    DateTime sup_date,
                                    string sup_mobile,
                                    string sup_tel,
                                    string sup_country,
                                    string sup_city,
                                    string sup_email,
                                    string sup_company,
                                    int sup_credit,
                                    string Account_no,
                                   //Created By & Created Date
                                   string Created_By,
                                    DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[13];
            para[0] = new SqlParameter("@check", "u");
            para[1] = new SqlParameter("@sup_id", sup_id);
            para[2] = new SqlParameter("@sup_name", sup_name);
            para[3] = new SqlParameter("@sup_date", sup_date);
            para[4] = new SqlParameter("@sup_mobile", sup_mobile);
            para[5] = new SqlParameter("@sup_tel", sup_tel);
            para[6] = new SqlParameter("@sup_country", sup_country);
            para[7] = new SqlParameter("@sup_city", sup_city);
            para[8] = new SqlParameter("@sup_email", sup_email);
            para[9] = new SqlParameter("@sup_company", sup_company);
            para[10] = new SqlParameter("@sup_credit", sup_credit);
            para[11] = new SqlParameter("@Account_no", Account_no);
            //Created By & Created Date
            para[12] = new SqlParameter("@Created_By", Created_By);
            para[13] = new SqlParameter("@Created_Date", Created_Date);
            dac.open();
            dac.ExcutCommand("mng_sup", para);
            dac.close();
        }
        public void mng_sup_del(int sup_id,
            string sup_name,
            DateTime sup_date,
            string sup_mobile,
            string sup_tel,
            string sup_country,
            string sup_city,
            string sup_email,
            string sup_company,
            int sup_credit,
          //Created By & Created Date
           string Created_By,
          DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[13];
            para[0] = new SqlParameter("@check", "d");
            para[1] = new SqlParameter("@sup_id", sup_id);
            para[2] = new SqlParameter("@sup_name", sup_name);
            para[3] = new SqlParameter("@sup_date", sup_date);
            para[4] = new SqlParameter("@sup_mobile", sup_mobile);
            para[5] = new SqlParameter("@sup_tel", sup_tel);
            para[6] = new SqlParameter("@sup_country", sup_country);
            para[7] = new SqlParameter("@sup_city", sup_city);
            para[8] = new SqlParameter("@sup_email", sup_email);
            para[9] = new SqlParameter("@sup_company", sup_company);
            para[10] = new SqlParameter("@sup_credit", sup_credit);
            //Created By & Created Date
            para[11] = new SqlParameter("@Created_By", Created_By);
            para[12] = new SqlParameter("@Created_Date", Created_Date);
            dac.open();
            dac.ExcutCommand("mng_sup", para);
            dac.close();


        }
        public DataTable ShowSup_byname(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", vrb_serch);


            DataTable dt = new DataTable();
            dac.open();
            dt = dac.Selectdata("ShowSup_byname", para);
            dac.close();
            return dt;
        }
        public DataTable ShowSup_byID(int vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", vrb_serch);


            DataTable dt = new DataTable();
            dac.open();
            dt = dac.Selectdata("ShowSup_byID", para);
            dac.close();
            return dt;
        }
        public DataTable checkSup_Motion(int sup_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@sup_id", SqlDbType.Int);
            para[0].Value = sup_id;

            dac.open();
            DataTable dt = new DataTable();
            dt = dac.Selectdata("checkSup_Motion", para);
            dac.close();
            return dt;


        }
    }
}
