using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassAdditionalCosts
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_AdditionalCosts_add(
                                        int AdditionalCosts_Id
                                      , int inv_id
                                      , string description  
                                      , decimal amount  
                                      , string currency  
                                      , decimal exchange  
                                      , decimal amount_SAR  
                                      , decimal vat_Percent  
                                      , decimal vat_Amount  
                                      , decimal total
                                      , string reference 
                                       //Created By & Created Date
                                      , string Created_By
                                      , DateTime Created_Date


                                                           )
        {
            SqlParameter[] para = new SqlParameter[14];
            para[0] = new SqlParameter("@AdditionalCosts_Id", AdditionalCosts_Id);
            para[1] = new SqlParameter("@inv_id", inv_id);
            para[2] = new SqlParameter("@description", description);
            para[3] = new SqlParameter("@amount", amount);
            para[4] = new SqlParameter("@currency", currency);
            para[5] = new SqlParameter("@exchange", exchange);
            para[6] = new SqlParameter("@amount_SAR", amount_SAR);
            para[7] = new SqlParameter("@vat_Percent", vat_Percent);
            para[8] = new SqlParameter("@vat_Amount", vat_Amount);
            para[9] = new SqlParameter("@total", total);
            para[10] = new SqlParameter("@reference", reference);
            //Created By & Created Date
            para[11] = new SqlParameter("@Created_By", Created_By);
            para[12] = new SqlParameter("@Created_Date", Created_Date);
            para[13] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_AdditionalCosts", para);
            dtac.close();
        }


        public void mng_AdditionalCosts_Update(
                                        int AdditionalCosts_Id
                                      , int inv_id
                                      , string description
                                      , decimal amount
                                      , string currency
                                      , decimal exchange
                                      , decimal amount_SAR
                                      , decimal vat_Percent
                                      , decimal vat_Amount
                                      , decimal total
                                      , string reference
                                      //Created By & Created Date
                                      , string Created_By
                                      , DateTime Created_Date


                                                           )
        {
            SqlParameter[] para = new SqlParameter[14];
            para[0] = new SqlParameter("@AdditionalCosts_Id", AdditionalCosts_Id);
            para[1] = new SqlParameter("@inv_id", inv_id);
            para[2] = new SqlParameter("@description", description);
            para[3] = new SqlParameter("@amount", amount);
            para[4] = new SqlParameter("@currency", currency);
            para[5] = new SqlParameter("@exchange", exchange);
            para[6] = new SqlParameter("@amount_SAR", amount_SAR);
            para[7] = new SqlParameter("@vat_Percent", vat_Percent);
            para[8] = new SqlParameter("@vat_Amount", vat_Amount);
            para[9] = new SqlParameter("@total", total);
            para[10] = new SqlParameter("@reference", reference);
            //Created By & Created Date
            para[11] = new SqlParameter("@Created_By", Created_By);
            para[12] = new SqlParameter("@Created_Date", Created_Date);
            para[13] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_AdditionalCosts", para);
            dtac.close();
        }
        //الحذف
        public void mng_AdditionalCosts_Del(int AdditionalCosts_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@AdditionalCosts_Id", AdditionalCosts_Id);

            dtac.open();
            dtac.ExcutCommand("mng_AdditionalCosts_Del", para);
            dtac.close();
        }
        public void mng_AdditionalCosts_Del_Inv(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", inv_id);

            dtac.open();
            dtac.ExcutCommand("mng_AdditionalCosts_Del_Inv", para);
            dtac.close();
        }

        //للبحث
        public DataTable SearchAdditionalCosts(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchAdditionalCosts", para);
            dtac.close();
            return dt;
        }

        // إظهار التكلفه بناءا على رقم التكلفه
        public DataTable ShowAdditionalCosts(int AdditionalCosts_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@AdditionalCosts_Id", AdditionalCosts_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAdditionalCosts", para);
            dtac.close();
            return dt;
        }

        // إظهار جميع التكاليف بناءا على رقم الفاتورة  
        public DataTable ShowAdditionalCosts_invid(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", inv_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAdditionalCosts_invid", para);
            dtac.close();
            return dt;
        }

        public DataTable Get_AdditionalCosts_Id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_AdditionalCosts_Id", null);
            dtac.close();
            return dt;
        }

        public DataTable ShowAdditionalCosts_All()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAdditionalCosts_All", null);
            dtac.close();
            return dt;
        }

    }
}
