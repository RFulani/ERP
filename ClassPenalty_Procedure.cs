using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassPenalty_Procedure
    {

        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_Penslty_Procedure_add(
            int Penslty_Procedure_Id
           ,DateTime  Penslty_Procedure_Date
           , int emp_id
           , string emp_name
           , string violation
           , string Penatly
           , string Penatly_Notes
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@Penslty_Procedure_Id", Penslty_Procedure_Id);
            para[1] = new SqlParameter("@Penslty_Procedure_Date", Penslty_Procedure_Date);
            para[2] = new SqlParameter("@emp_id", emp_id);
            para[3] = new SqlParameter("@emp_name", emp_name);
            para[4] = new SqlParameter("@violation", violation);
            para[5] = new SqlParameter("@Penatly", Penatly);
            para[6] = new SqlParameter("@Penatly_Notes", Penatly_Notes);
            //Created By & Created Date
            para[7] = new SqlParameter("@Created_By", Created_By);
            para[8] = new SqlParameter("@Created_Date", Created_Date);
            para[9] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Penslty_Procedure", para);
            dtac.close();
        }

        //التعديل
        public void mng_Penslty_Procedure_Update(
          int Penslty_Procedure_Id
           , DateTime Penslty_Procedure_Date
           , int emp_id
           , string emp_name
           , string violation
           , string Penatly
           , string Penatly_Notes
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@Penslty_Procedure_Id", Penslty_Procedure_Id);
            para[1] = new SqlParameter("@Penslty_Procedure_Date", Penslty_Procedure_Date);
            para[2] = new SqlParameter("@emp_id", emp_id);
            para[3] = new SqlParameter("@emp_name", emp_name);
            para[4] = new SqlParameter("@violation", violation);
            para[5] = new SqlParameter("@Penatly", Penatly);
            para[6] = new SqlParameter("@Penatly_Notes", Penatly_Notes);
            //Created By & Created Date
            para[7] = new SqlParameter("@Created_By", Created_By);
            para[8] = new SqlParameter("@Created_Date", Created_Date);
            para[9] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Penslty_Procedure", para);
            dtac.close();
        }
        //الحذف
        public void mng_Penslty_ProcedureDel(int Penslty_Procedure_Id)

        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Penslty_Procedure_Id", Penslty_Procedure_Id);

            dtac.open();
            dtac.ExcutCommand("mng_Penslty_ProcedureDel", para);
            dtac.close();
        }
        
        
        public DataTable Get_PenaltyId()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_PenaltyId", null);
            dtac.close();
            return dt;
        }

        // إظهار جميع السجلات للبحث
        public DataTable ShowPenalty_Procedure(int Penslty_Procedure_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Penslty_Procedure_Id", Penslty_Procedure_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowPenalty_Procedure", para);
            dtac.close();
            return dt;
        }

        //للبحث
        public DataTable SearchPenalty_Procedure(string searchPP)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@searchPP", searchPP);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchPenalty_Procedure", para);
            dtac.close();
            return dt;
        }


        public DataTable ShowPenaltyEmpId(int emp_id, int Penslty_Procedure_Id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[1] = new SqlParameter("@emp_id", emp_id);
            para[0] = new SqlParameter("@Penslty_Procedure_Id", Penslty_Procedure_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowPenaltyEmpId", para);
            dtac.close();
            return dt;
        }

        //لإظهار جميع طلبات العقوبات
        public DataTable ShowAllPenalty_Request(int emp_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_Id", emp_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllPenalty_Request", para);
            dtac.close();
            return dt;
        }

        //لإظهار جميع طلبات العقوبات بناءاً على الفتره  
        public DataTable ShowAllPenalty_byDate(int emp_Id, DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@emp_Id", emp_Id);
            para[1] = new SqlParameter("@Date_From", from);
            para[2] = new SqlParameter("@Date_To", to);


            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("ShowAllPenalty_byDate", para);
            dtac.close();
            return dtemp;
        }

    }
}
