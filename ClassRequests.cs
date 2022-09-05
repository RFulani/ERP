using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassRequests
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        //طلب تعديل راتب
        public DataTable Orders_SalaryIncrase (DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@to", to);
            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("Orders_SalaryIncrase", para);
            dtac.close();
            return dtemp;
        }
        //تصفيات
        public DataTable Orders_Settlement(DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@to", to);
            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("Orders_Settlement", para);
            dtac.close();
            return dtemp;
        }
        //سلف
        public DataTable Orders_Loans(DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@to", to);
            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("Orders_Loans", para);
            dtac.close();
            return dtemp;
        }
        //خطابات تعريف
        public DataTable Orders_EVR(DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@to", to);
            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("Orders_EVR", para);
            dtac.close();
            return dtemp;
        }
        //إجازات
        public DataTable Orders_Vacation(DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@to", to);
            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("Orders_Vacation", para);
            dtac.close();
            return dtemp;
        }
        //عقوبات
        public DataTable Orders_Penatly(DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@to", to);
            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("Orders_Penatly", para);
            dtac.close();
            return dtemp;
        }

        //الأضافة
        public void mng_Requests_add(
            String Appro_ID  
           , int Req_Id
           , String Req_Type  
           , String C_Name_1  
           , int C_Value_1  
           ,DateTime C_ApproDate_1  
           , String C_Note_1  
           ,String C_Name2  
           , int C_Value_2  
           , DateTime C_ApproDate_2  
           , String C_Note_2  
           ,String C_Name_3  
           ,int C_Value_3  
           ,DateTime C_ApproDate_3  
           , String C_Note_3
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[18];
            para[0] = new SqlParameter("@Appro_ID", Appro_ID);
            para[1] = new SqlParameter("@Req_Id", Req_Id);
            para[2] = new SqlParameter("@Req_Type", Req_Type);
            para[3] = new SqlParameter("@C_Name_1", C_Name_1);
            para[4] = new SqlParameter("@C_Value_1", C_Value_1);
            para[5] = new SqlParameter("@C_ApproDate_1", C_ApproDate_1);
            para[6] = new SqlParameter("@C_Note_1", C_Note_1);
            para[7] = new SqlParameter("@C_Name2", C_Name2);
            para[8] = new SqlParameter("@C_Value_2", C_Value_2);
            para[9] = new SqlParameter("@C_ApproDate_2", C_ApproDate_2);
            para[10] = new SqlParameter("@C_Note_2", C_Note_2);
            para[11] = new SqlParameter("@C_Name_3", C_Name_3);
            para[12] = new SqlParameter("@C_Value_3", C_Value_3);
            para[13] = new SqlParameter("@C_ApproDate_3", C_ApproDate_3);
            para[14] = new SqlParameter("@C_Note_3", C_Note_3);
            //Created By & Created Date
            para[15] = new SqlParameter("@Created_By", Created_By);
            para[16] = new SqlParameter("@Created_Date", Created_Date);
            para[17] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Requests", para);
            dtac.close();
        }

        //التعديل
        public void mng_Requests_Update(
            String Appro_ID
           , int Req_Id
           , String Req_Type
           , String C_Name_1
           , int C_Value_1
           , DateTime C_ApproDate_1
           , String C_Note_1
           , String C_Name2
           , int C_Value_2
           , DateTime C_ApproDate_2
           , String C_Note_2
           , String C_Name_3
           , int C_Value_3
           , DateTime C_ApproDate_3
           , String C_Note_3
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
           )
        {
            SqlParameter[] para = new SqlParameter[18];
            para[0] = new SqlParameter("@Appro_ID", Appro_ID);
            para[1] = new SqlParameter("@Req_Id", Req_Id);
            para[2] = new SqlParameter("@Req_Type", Req_Type);
            para[3] = new SqlParameter("@C_Name_1", C_Name_1);
            para[4] = new SqlParameter("@C_Value_1", C_Value_1);
            para[5] = new SqlParameter("@C_ApproDate_1", C_ApproDate_1);
            para[6] = new SqlParameter("@C_Note_1", C_Note_1);
            para[7] = new SqlParameter("@C_Name2", C_Name2);
            para[8] = new SqlParameter("@C_Value_2", C_Value_2);
            para[9] = new SqlParameter("@C_ApproDate_2", C_ApproDate_2);
            para[10] = new SqlParameter("@C_Note_2", C_Note_2);
            para[11] = new SqlParameter("@C_Name_3", C_Name_3);
            para[12] = new SqlParameter("@C_Value_3", C_Value_3);
            para[13] = new SqlParameter("@C_ApproDate_3", C_ApproDate_3);
            para[14] = new SqlParameter("@C_Note_3", C_Note_3);
            //Created By & Created Date
            para[15] = new SqlParameter("@Created_By", Created_By);
            para[16] = new SqlParameter("@Created_Date", Created_Date);
            para[17] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Requests", para);
            dtac.close();
        }
        public DataTable Get_OrdersId()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Appro_ID", null);
            dtac.close();
            return dt;
        }

        public DataTable ShowRequests(int Req_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Req_Id", Req_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowRequests", para);
            dtac.close();
            return dt;
        }
    }
}
