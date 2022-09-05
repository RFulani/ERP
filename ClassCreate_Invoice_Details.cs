using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassCreate_Invoice_Details
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_Create_Invoice_Details_add(
                                      int Details_id
                                    , int Create_Invoice_Id  /*رقم إنشاء الموظف*/
                                    , string Account_No_Id
                                    , string Account_No
                                    , int Invoice_Type_id
                                    , string Invoice_Type  
                                    , string Amount  
                                    , string Amount_t
                                    , string Description
                                    , int Account_Type_id
                                    , string Account_Type
                                    , int Qid_Type_id
                                    , string Qid_Type
                                    //Created By & Created Date
                                    , string Created_By
                                    , DateTime Created_Date

                                                           )
        {
            SqlParameter[] para = new SqlParameter[16];
            para[0] = new SqlParameter("@Details_id", Details_id);
            para[1] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);
            para[2] = new SqlParameter("@Account_No_Id", Account_No_Id);
            para[3] = new SqlParameter("@Account_No", Account_No);
            para[4] = new SqlParameter("@Invoice_Type_id", Invoice_Type_id);
            para[5] = new SqlParameter("@Invoice_Type", Invoice_Type);
            para[6] = new SqlParameter("@Amount", Amount);
            para[7] = new SqlParameter("@Amount_t", Amount_t);
            para[8] = new SqlParameter("@Description", Description);
            para[9] = new SqlParameter("@Account_Type_id", Account_Type_id);
            para[10] = new SqlParameter("@Account_Type", Account_Type);
            para[11] = new SqlParameter("@Qid_Type_id", Qid_Type_id);
            para[12] = new SqlParameter("@Qid_Type", Qid_Type);
            //Created By & Created Date
            para[13] = new SqlParameter("@Created_By", Created_By);
            para[14] = new SqlParameter("@Created_Date", Created_Date);
            para[15] = new SqlParameter("@check", "a");

            dtac.open();
            dtac.ExcutCommand("mng_Create_Invoice_Details", para);
            dtac.close();
        }

        public void mng_Create_Invoice_Details_Update(
                                      int Details_id
                                    , int Create_Invoice_Id  /*رقم إنشاء الموظف*/
                                    , string Account_No_Id
                                    , string Account_No
                                    , int Invoice_Type_id
                                    , string Invoice_Type
                                    , string Amount
                                    , string Amount_t
                                    , string Description
                                    , int Account_Type_id
                                    , string Account_Type
                                    , int Qid_Type_id
                                    , string Qid_Type
                                    //Created By & Created Date
                                    , string Created_By
                                    , DateTime Created_Date

                                                           )
        {
            SqlParameter[] para = new SqlParameter[16];
            para[0] = new SqlParameter("@Details_id", Details_id);
            para[1] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);
            para[2] = new SqlParameter("@Account_No_Id", Account_No_Id);
            para[3] = new SqlParameter("@Account_No", Account_No);
            para[4] = new SqlParameter("@Invoice_Type_id", Invoice_Type_id);
            para[5] = new SqlParameter("@Invoice_Type", Invoice_Type);
            para[6] = new SqlParameter("@Amount", Amount);
            para[7] = new SqlParameter("@Amount_t", Amount_t);
            para[8] = new SqlParameter("@Description", Description);
            para[9] = new SqlParameter("@Account_Type_id", Account_Type_id);
            para[10] = new SqlParameter("@Account_Type", Account_Type);
            para[11] = new SqlParameter("@Qid_Type_id", Qid_Type_id);
            para[12] = new SqlParameter("@Qid_Type", Qid_Type);
            //Created By & Created Date
            para[13] = new SqlParameter("@Created_By", Created_By);
            para[14] = new SqlParameter("@Created_Date", Created_Date);
            para[15] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_Create_Invoice_Details", para);
            dtac.close();
        }

        //الحذف
        public void mng_Create_Invoice_DetailsDel(int Details_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Details_id", Details_id);

            dtac.open();
            dtac.ExcutCommand("mng_Create_Invoice_DetailsDel", para);
            dtac.close();
        }
        //لإظهار جميع البيانات ةفقا لرقم الفاتورة
        public DataTable ShowCreate_Invoice_Details(int Create_Invoice_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowCreate_Invoice_Details", para);
            dtac.close();
            return dt;
        }
        // لإظهار جميع البيانات وفقا لرقم الفاتورة ورقم البيانات
        public DataTable ShowCreate_Invoice_DetailsId(int Details_id, int Create_Invoice_Id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Details_id", Details_id);
            para[1] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowCreate_Invoice_DetailsId", para);
            dtac.close();
            return dt;
        }
        // لإظهار جميع البيانات وفقا لرقم الفاتورة ورقم القيد
        public DataTable ShowCreate_Invoice_Details_Qid(int Create_Invoice_Id, string Qid_Type)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);
            para[1] = new SqlParameter("@Qid_Type", Qid_Type);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowCreate_Invoice_Details_Qid", para);
            dtac.close();
            return dt;
        }
        public DataTable ShowCreate_Invoice_Details_Qid_Type(int Create_Invoice_Id, string Qid_Type)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);
            para[1] = new SqlParameter("@Qid_Type", Qid_Type);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowCreate_Invoice_Details_Qid_Type", para);
            dtac.close();
            return dt;
        }

        //للحصول على الرقم التسلسي
        public DataTable Get_Create_Invoice_Details()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Create_Invoice_Details", null);
            dtac.close();
            return dt;
        }
    }
}
