using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    class Class_Offers
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_Offers_add(
            string product_No,
            string product_Name,
           int Quantity,
          string Offer_Type,
           decimal Percents,
           DateTime Starting_date,
           DateTime Ending_date,
           int Offer_Quantity,
           int Offer_Status_id,
           string Offer_Status,
            //Created By & Created Date
            string Created_By,
            DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[13];
            para[0] = new SqlParameter("@product_No", product_No);
            para[1] = new SqlParameter("@product_Name", product_Name);
            para[2] = new SqlParameter("@Quantity", Quantity);
            para[3] = new SqlParameter("@Offer_Type", Offer_Type);
            para[4] = new SqlParameter("@Percents", Percents);
            para[5] = new SqlParameter("@Starting_date", Starting_date);
            para[6] = new SqlParameter("@Ending_date", Ending_date);
            para[7] = new SqlParameter("@Offer_Quantity", Offer_Quantity);
            para[8] = new SqlParameter("@Offer_Status_id", Offer_Status_id);
            para[9] = new SqlParameter("@Offer_Status", Offer_Status);
            //Created By & Created Date
            para[10] = new SqlParameter("@Created_By", Created_By);
            para[11] = new SqlParameter("@Created_Date", Created_Date);
            para[12] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Offers", para);
            dtac.close();
        }

        //التعديل
        public void mng_Offers_Update(
           string product_No,
            string product_Name,
           int Quantity,
          string Offer_Type,
           decimal Percents,
           DateTime Starting_date,
           DateTime Ending_date,
           int Offer_Quantity,
           int Offer_Status_id,
           string Offer_Status,
            //Created By & Created Date
            string Created_By,
            DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[13];
            para[0] = new SqlParameter("@product_No", product_No);
            para[1] = new SqlParameter("@product_Name", product_Name);
            para[2] = new SqlParameter("@Quantity", Quantity);
            para[3] = new SqlParameter("@Offer_Type", Offer_Type);
            para[4] = new SqlParameter("@Percents", Percents);
            para[5] = new SqlParameter("@Starting_date", Starting_date);
            para[6] = new SqlParameter("@Ending_date", Ending_date);
            para[7] = new SqlParameter("@Offer_Quantity", Offer_Quantity);
            para[8] = new SqlParameter("@Offer_Status_id", Offer_Status_id);
            para[9] = new SqlParameter("@Offer_Status", Offer_Status);
            //Created By & Created Date
            para[10] = new SqlParameter("@Created_By", Created_By);
            para[11] = new SqlParameter("@Created_Date", Created_Date);
            para[12] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_Offers", para);
            dtac.close();
        }

        public DataTable ShowOffers()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowOffers", null);
            dtac.close();
            return dt;
        }

        //الحذف
        public void mng_Offers_Del(string product_No, string product_Name, string Offer_Type)


        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@product_No", product_No);
            para[1] = new SqlParameter("@product_Name", product_Name);
            para[2] = new SqlParameter("@Offer_Type", Offer_Type);

            dtac.open();
            dtac.ExcutCommand("mng_Offers_Del", para);
            dtac.close();
        }

        //عرض العروض بناءا على التاريخ

        public DataTable CheckOffers_ava(DateTime Date_Now, string product_No)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@Date_Now", Date_Now);
            para[1] = new SqlParameter("@product_No", product_No);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("CheckOffers_ava", para);
            dtac.close();
            return dt;

        }
    }
}
