using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassJobOrder
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        //الاضافة
        public void mng_JobOrder_add(
                            int Job_Id
                          , int Customer_Id
                          , string Customer_Name
                          , string Pro_Id
                          , string Pro_Name
                          , decimal Qty
                          , string status
                          , string Description
                          , byte[] job_img
                          //Created By & Created Date
                          , string Created_By
                          , DateTime Created_Date
		 
                                                   )
        {
            SqlParameter[] para = new SqlParameter[12];
            para[0] = new SqlParameter("@Job_Id", Job_Id);
            para[1] = new SqlParameter("@Customer_Id", Customer_Id);
            para[2] = new SqlParameter("@Customer_Name", Customer_Name);
            para[3] = new SqlParameter("@Pro_Id", Pro_Id);
            para[4] = new SqlParameter("@Pro_Name", Pro_Name);
            para[5] = new SqlParameter("@Qty", Qty);
            para[6] = new SqlParameter("@status", status);
            para[7] = new SqlParameter("@Description", Description);
            para[8] = new SqlParameter("@job_img", job_img);
            //Created By & Created Date
            para[9] = new SqlParameter("@Created_By", Created_By);
            para[10] = new SqlParameter("@Created_Date", Created_Date);
            para[11] = new SqlParameter("@check", "a");

            dtac.open();
            dtac.ExcutCommand("mng_JobOrder", para);
            dtac.close();
        }
        //التعديل
        public void mng_JobOrder_Update(
                            int Job_Id
                          , int Customer_Id
                          , string Customer_Name
                          , string Pro_Id
                          , string Pro_Name
                          , decimal Qty
                          , string status
                          , string Description
                          , byte[] job_img
                          //Created By & Created Date
                          , string Created_By
                          , DateTime Created_Date

                                                   )
        {
            SqlParameter[] para = new SqlParameter[12];
            para[0] = new SqlParameter("@Job_Id", Job_Id);
            para[1] = new SqlParameter("@Customer_Id", Customer_Id);
            para[2] = new SqlParameter("@Customer_Name", Customer_Name);
            para[3] = new SqlParameter("@Pro_Id", Pro_Id);
            para[4] = new SqlParameter("@Pro_Name", Pro_Name);
            para[5] = new SqlParameter("@Qty", Qty);
            para[6] = new SqlParameter("@status", status);
            para[7] = new SqlParameter("@Description", Description);
            para[8] = new SqlParameter("@job_img", job_img);
            //Created By & Created Date
            para[9] = new SqlParameter("@Created_By", Created_By);
            para[10] = new SqlParameter("@Created_Date", Created_Date);
            para[11] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_JobOrder", para);
            dtac.close();
        }
        //الحذف
        public void mng_JobOrder_Del(int Job_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Job_Id", Job_Id);

            dtac.open();
            dtac.ExcutCommand("mng_JobOrder_Del", para);
            dtac.close();
        }
        //الرقم التسلسلي
        public DataTable Get_JobOrder_Id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_JobOrder_Id", null);
            dtac.close();
            return dt;
        }
        //إظهار جميع البيانات في الداتا جريد
        public DataTable ShowAllJobOrder_dGV()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllJobOrder_dGV", null);
            dtac.close();
            return dt;
        }
        //لإظهار جميع البيانات
        public DataTable ShowAll_JobOrder()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAll_JobOrder", null);
            dtac.close();
            return dt;
        }
        //لإظهار البيانات للبحث بناءاً على الرقم
        public DataTable Show_JobOrderbyId(int Job_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Job_Id", Job_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_JobOrderbyId", para);
            dtac.close();
            return dt;
        }
        //البحث
        public DataTable SearchJobOrder(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchJobOrder", para);
            dtac.close();
            return dt;
        }
    }
}
