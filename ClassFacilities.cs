using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    
    class ClassFacilities
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        //الأضافة
        public void mng_Facilities_add(
           int Fac_Id
           , DateTime Fac_date
           , int Fac_type_Id
           ,  String Fac_type  
           , String Fac_reference
           , int Fac_Days 
           , decimal Fac_saudi_amount
           , decimal Fac_DollarPrice
           , decimal Fac_US_amount
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[12];
            para[0] = new SqlParameter("@Fac_Id", Fac_Id);
            para[1] = new SqlParameter("@Fac_date", Fac_date);
            para[2] = new SqlParameter("@Fac_type_Id", Fac_type_Id);
            para[3] = new SqlParameter("@Fac_type", Fac_type);
            para[4] = new SqlParameter("@Fac_reference", Fac_reference);
            para[5] = new SqlParameter("@Fac_Days", Fac_Days);
            para[6] = new SqlParameter("@Fac_saudi_amount", Fac_saudi_amount);
            para[7] = new SqlParameter("@Fac_DollarPrice", Fac_DollarPrice);
            para[8] = new SqlParameter("@Fac_US_amount", Fac_US_amount);
            //Created By & Created Date
            para[9] = new SqlParameter("@Created_By", Created_By);
            para[10] = new SqlParameter("@Created_Date", Created_Date);
            para[11] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Facilities", para);
            dtac.close();
        }

        //التعديل
        public void mng_Facilities_Update(
            int Fac_Id
           , DateTime Fac_date
           , int Fac_type_Id
           , String Fac_type
           , String Fac_reference
           , int Fac_Days
           , decimal Fac_saudi_amount
           , decimal Fac_DollarPrice
           , decimal Fac_US_amount
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
           )
        {
            SqlParameter[] para = new SqlParameter[12];
            para[0] = new SqlParameter("@Fac_Id", Fac_Id);
            para[1] = new SqlParameter("@Fac_date", Fac_date);
            para[2] = new SqlParameter("@Fac_type_Id", Fac_type_Id);
            para[3] = new SqlParameter("@Fac_type", Fac_type);
            para[4] = new SqlParameter("@Fac_reference", Fac_reference);
            para[5] = new SqlParameter("@Fac_Days", Fac_Days);
            para[6] = new SqlParameter("@Fac_saudi_amount", Fac_saudi_amount);
            para[7] = new SqlParameter("@Fac_DollarPrice", Fac_DollarPrice);
            para[8] = new SqlParameter("@Fac_US_amount", Fac_US_amount);
            //Created By & Created Date
            para[9] = new SqlParameter("@Created_By", Created_By);
            para[10] = new SqlParameter("@Created_Date", Created_Date);
            para[11] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Facilities", para);
            dtac.close();
        }



        //الحذف
        public void mng_Facilities_Del(int Fac_Id)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Fac_Id", Fac_Id);

            dtac.open();
            dtac.ExcutCommand("mng_FacilitiesDel", para);
            dtac.close();
        }

        //الحصول على الارقام تلقائياً
        public DataTable Get_FacilitiesId()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_FacilitiesId", null);
            dtac.close();
            return dt;
        }

        //للبحث
        public DataTable SearchFacilities(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchFacilities", para);
            dtac.close();
            return dt;
        }

        // إظهار جميع السجلات للبحث
        public DataTable ShowFacilities(int Fac_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Fac_Id", Fac_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowFacilities", para);
            dtac.close();
            return dt;
        }

    }
}
