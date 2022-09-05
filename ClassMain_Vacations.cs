using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    class ClassMain_Vacations
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_Main_Vacations_add(
          int Vac_id
            , int emp_id
             ,  string  emp_name
            ,  DateTime Vac_from
           ,  DateTime Vac_To  
	
            //Created By & Created Date
            , string Created_By
            , DateTime Created_Date

           )
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@Vac_id", Vac_id);
            para[1] = new SqlParameter("@emp_id", emp_id);
            para[2] = new SqlParameter("@emp_name", emp_name);
            para[3] = new SqlParameter("@Vac_from", Vac_from);
            para[4] = new SqlParameter("@Vac_To", Vac_To);
            //Created By & Created Date
            para[5] = new SqlParameter("@Created_By", Created_By);
            para[6] = new SqlParameter("@Created_Date", Created_Date);
            para[7] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Main_Vacations", para);
            dtac.close();
        }

        //التعديل
        public void mng_Main_Vacations_Update(
           int Vac_id
         , int emp_id
         , string emp_name
         , DateTime Vac_from
         , DateTime Vac_To
       //Created By & Created Date
         , string Created_By
         , DateTime Created_Date

           )
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@Vac_id", Vac_id);
            para[1] = new SqlParameter("@emp_id", emp_id);
            para[2] = new SqlParameter("@emp_name", emp_name);
            para[3] = new SqlParameter("@Vac_from", Vac_from);
            para[4] = new SqlParameter("@Vac_To", Vac_To);
            //Created By & Created Date
            para[5] = new SqlParameter("@Created_By", Created_By);
            para[6] = new SqlParameter("@Created_Date", Created_Date);
            para[7] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Main_Vacations", para);
            dtac.close();
        }

        public void mng_Main_VacationsDel(int Vac_id, int emp_id, DateTime FROM, DateTime To)
        { 
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@Vac_id", Vac_id);
            para[1] = new SqlParameter("@emp_id", emp_id);
            para[2] = new SqlParameter("@FROM", FROM);
            para[3] = new SqlParameter("@To", To);

            dtac.open();
            dtac.ExcutCommand("mng_Main_VacationsDel", para);
            dtac.close();
        }

        public DataTable EmpsforVacations(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("EmpsforVacations", para);
            dtac.close();
            return dt;
        }

        public DataTable BranchEmpforVac(int branch_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@branch_id", branch_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("BranchEmpforVac", para);
            dtac.close();
            return dt;
        }

        public DataTable ShowEmpforVac(int Vacation_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Vacation_Id", Vacation_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowEmpforVac", para);
            dtac.close();
            return dt;
        }

        
    }
}
