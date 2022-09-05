using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace INV.Code
{
    class ClassAccCat
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        //الاضافة
        public void mng_AccCat_add(
                            int AccCat_Id     
                          , string AccCat_code   
                          , string AccCat_Name
                          , string MainCat
                          , string AccCat_Type
                          //Created By & Created Date
                          , string Created_By
                          , DateTime Created_Date
                                                   )
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@AccCat_Id", AccCat_Id);
            para[1] = new SqlParameter("@AccCat_code", AccCat_code);
            para[2] = new SqlParameter("@AccCat_Name", AccCat_Name);
            para[3] = new SqlParameter("@MainCat", MainCat);
            para[4] = new SqlParameter("@AccCat_Type", AccCat_Type);
            //Created By & Created Date
            para[5] = new SqlParameter("@Created_By", Created_By);
            para[6] = new SqlParameter("@Created_Date", Created_Date);
            para[7] = new SqlParameter("@check", "a");

            dtac.open();
            dtac.ExcutCommand("mng_AccCat", para);
            dtac.close();
        }
        //التعديل
        public void mng_AccCat_Update(
                            int AccCat_Id
                          , string AccCat_code
                          , string AccCat_Name
                          , string MainCat
                          , string AccCat_Type
                          //Created By & Created Date
                          , string Created_By
                          , DateTime Created_Date
                                                   )
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@AccCat_Id", AccCat_Id);
            para[1] = new SqlParameter("@AccCat_code", AccCat_code);
            para[2] = new SqlParameter("@AccCat_Name", AccCat_Name);
            para[3] = new SqlParameter("@MainCat", MainCat);
            para[4] = new SqlParameter("@AccCat_Type", AccCat_Type);
            //Created By & Created Date
            para[5] = new SqlParameter("@Created_By", Created_By);
            para[6] = new SqlParameter("@Created_Date", Created_Date);
            para[7] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_AccCat", para);
            dtac.close();
        }
        //الحذف
        public void mng_AccCat_Del(int AccCat_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@AccCat_Id", AccCat_Id);

            dtac.open();
            dtac.ExcutCommand("mng_AccCat_Del", para);
            dtac.close();
        }
        //الرقم التسلسلي
        public DataTable Get_AccCat_Id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_AccCat_Id", null);
            dtac.close();
            return dt;
        }
        //إظهار جميع البيانات في الداتا جريد
        public DataTable ShowAllAccCat_dGV()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllAccCat_dGV", null);
            dtac.close();
            return dt;
        }
        //لإظهار جميع البيانات
        public DataTable ShowAllAccCat()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllAccCat", null);
            dtac.close();
            return dt;
        }
        //لإظهار البيانات للبحث بناءاً على الرقم
        public DataTable ShowAccCatbyId(int AccCat_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@AccCat_Id", AccCat_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAccCatbyId", para);
            dtac.close();
            return dt;
        }
        //البحث
        public DataTable SearchAccCat(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchAccCat", para);
            dtac.close();
            return dt;
        }

        public DataTable ShowAccCat_Id_MainCat(string MainCat)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@MainCat", MainCat);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAccCat_Id_MainCat", para);
            dtac.close();
            return dt;
        }
    }
}
