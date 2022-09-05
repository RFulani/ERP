using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    class ClassBank_Details
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();


        //الأضافة
        public void mng_Bank_Details_add(
                                       int Bank_id,
                                       //int brn_id,
                                       //string brn_name_Ar,
                                       string Bank_name_Ar,
                                       string Bank_name_Eng,
                                       string SWIFT_code,
                                       string account_no,
                                       string IBAN_no,
                                       //Created By & Created Date
                                       string Created_By,
                                       DateTime Created_Date

                                     )
        {
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@Bank_id", Bank_id);
            //para[1] = new SqlParameter("@brn_id", brn_id);
            //para[2] = new SqlParameter("@brn_name_Ar", brn_name_Ar);
            para[1] = new SqlParameter("@Bank_name_Ar", Bank_name_Ar);
            para[2] = new SqlParameter("@Bank_name_Eng", Bank_name_Eng);
            para[3] = new SqlParameter("@SWIFT_code", SWIFT_code);
            para[4] = new SqlParameter("@account_no", account_no);
            para[5] = new SqlParameter("@IBAN_no", IBAN_no);
            //Created By & Created Date
            para[6] = new SqlParameter("@Created_By", Created_By);
            para[7] = new SqlParameter("@Created_Date", Created_Date);
            para[8] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Bank_Details", para);
            dtac.close();
        }

        //التعديل
        public void mng_Bank_Details_Update(
                                       int Bank_id,
                                       /*int brn_id,
                                       string brn_name_Ar,*/
                                       string Bank_name_Ar,
                                       string Bank_name_Eng,
                                       string SWIFT_code,
                                       string account_no,
                                       string IBAN_no,
                                       //Created By & Created Date
                                       string Created_By,
                                       DateTime Created_Date
           )
        {
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@Bank_id", Bank_id);
            //para[1] = new SqlParameter("@brn_id", brn_id);
            //para[2] = new SqlParameter("@brn_name_Ar", brn_name_Ar);
            para[1] = new SqlParameter("@Bank_name_Ar", Bank_name_Ar);
            para[2] = new SqlParameter("@Bank_name_Eng", Bank_name_Eng);
            para[3] = new SqlParameter("@SWIFT_code", SWIFT_code);
            para[4] = new SqlParameter("@account_no", account_no);
            para[5] = new SqlParameter("@IBAN_no", IBAN_no);
            //Created By & Created Date
            para[6] = new SqlParameter("@Created_By", Created_By);
            para[7] = new SqlParameter("@Created_Date", Created_Date);
            para[8] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_Bank_Details", para);
            dtac.close();
        }

        //الحذف
        public void mng_Bank_Details_Del(int Bank_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Bank_id", Bank_id);

            dtac.open();
            dtac.ExcutCommand("mng_Bank_Details_Del", para);
            dtac.close();
        }
        public DataTable ShowBank_Details(int Bank_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Bank_id ", Bank_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowBank_Details", para);
            dtac.close();
            return dt;
        }

        //بحث 
        public DataTable SearchBank_Details(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchBank_Details", para);
            dtac.close();
            return dt;
        }


        //للحصول على الارقام تسلسليه
        public DataTable Get_Bank_id()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Bank_id", null);
            dtac.close();
            return dt;
        }

        public DataTable ShowBanks_To_Branches()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowBanks_To_Branches", null);
            dtac.close();
            return dt;
        }



    }
}
