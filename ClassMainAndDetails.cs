 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace INV.Code
{
    class ClassMainAndDetails
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_Salary_DetailsAdd(
             // /*متحولات جدول الماين سالري*/
             int rpta_id


           , DateTime Preparing_Date
           , DateTime Salary_Date
           , String Notes

           //*متحولا تفاصيل الراتب*/


           , int Emp_No
           , String Name
           , decimal Basic_Salary
           , decimal House_Allowances

           , decimal Other_Allowances
           , decimal OverTime
           , decimal Other_TypesOfSalaries
           , decimal Total_SalariesandAllowances
           , decimal Loan
           , decimal gosi
           , decimal Late
           , decimal Absence
           , decimal other_deduction
           , decimal Total_Deduction
                               //Created By & Created Date
                               , string Created_By
                               , DateTime Created_Date

)
        {
            SqlParameter[] para = new SqlParameter[21];
            para[0] = new SqlParameter("@rpta_id", rpta_id);
            para[1] = new SqlParameter("@Preparing_Date", Preparing_Date);
            para[2] = new SqlParameter("@Salary_Date", Salary_Date);
            para[3] = new SqlParameter("@Notes", Notes);
            para[4] = new SqlParameter("@Emp_No", Emp_No);
            para[5] = new SqlParameter("@Name", Name);
            para[6] = new SqlParameter("@Basic_Salary", Basic_Salary);
            para[7] = new SqlParameter("@House_Allowances", House_Allowances);
            para[8] = new SqlParameter("@Other_Allowances", Other_Allowances);
            para[9] = new SqlParameter("@OverTime", OverTime);
            para[10] = new SqlParameter("@Other_TypesOfSalaries", Other_TypesOfSalaries);
            para[11] = new SqlParameter("@Total_SalariesandAllowances", Total_SalariesandAllowances);
            para[12] = new SqlParameter("@Loan", Loan);
            para[13] = new SqlParameter("@gosi", gosi);
            para[14] = new SqlParameter("@Late", Late);
            para[15] = new SqlParameter("@Absence", Absence);
            para[16] = new SqlParameter("@other_deduction", other_deduction);
            para[17] = new SqlParameter("@Total_Deduction", Total_Deduction);
            //Created By & Created Date
            para[18] = new SqlParameter("@Created_By", Created_By);
            para[19] = new SqlParameter("@Created_Date", Created_Date);
            para[20] = new SqlParameter("@check", "a");


            dtac.open();
            dtac.ExcutCommand("mng_Salary_Details", para);
            dtac.close();
        }
        public void mng_Salary_DetailsUpdate(
                                                // /*متحولات جدول الماين سالري*/
                                                int rpta_id
                                           
                                              , DateTime Preparing_Date
                                              , DateTime Salary_Date
                                              , String Notes

           //*متحولا تفاصيل الراتب*/


           , int Emp_No
           , String Name
           , decimal Basic_Salary
           , decimal House_Allowances

           , decimal Other_Allowances
           , decimal OverTime
           , decimal Other_TypesOfSalaries
           , decimal Total_SalariesandAllowances
           , decimal Loan
           , decimal gosi
           , decimal Late
           , decimal Absence
           , decimal other_deduction
           , decimal Total_Deduction
                               //Created By & Created Date
                               , string Created_By
                               , DateTime Created_Date

            )
        {
            SqlParameter[] para = new SqlParameter[21];
            para[0] = new SqlParameter("@rpta_id", rpta_id);
            para[1] = new SqlParameter("@Preparing_Date", Preparing_Date);
            para[2] = new SqlParameter("@Salary_Date", Salary_Date);
            para[3] = new SqlParameter("@Notes", Notes);
            para[4] = new SqlParameter("@Emp_No", Emp_No);
            para[5] = new SqlParameter("@Name", Name);
            para[6] = new SqlParameter("@Basic_Salary", Basic_Salary);
            para[7] = new SqlParameter("@House_Allowances", House_Allowances);
            para[8] = new SqlParameter("@Other_Allowances", Other_Allowances);
            para[9] = new SqlParameter("@OverTime", OverTime);
            para[10] = new SqlParameter("@Other_TypesOfSalaries", Other_TypesOfSalaries);
            para[11] = new SqlParameter("@Total_SalariesandAllowances", Total_SalariesandAllowances);
            para[12] = new SqlParameter("@Loan", Loan);
            para[13] = new SqlParameter("@gosi", gosi);
            para[14] = new SqlParameter("@Late", Late);
            para[15] = new SqlParameter("@Absence", Absence);
            para[16] = new SqlParameter("@other_deduction", other_deduction);
            para[17] = new SqlParameter("@Total_Deduction", Total_Deduction);
            //Created By & Created Date
            para[18] = new SqlParameter("@Created_By", Created_By);
            para[19] = new SqlParameter("@Created_Date", Created_Date);
            para[20] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Salary_Details", para);
            dtac.close();
        }
        public void mng_Salary_DetailsDel(int rpta_id)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rpta_id", rpta_id);

            dtac.open();
            dtac.ExcutCommand("mng_Salary_DetailsDel", para);
            dtac.close();
        }
        public void DelEmpOfSalaryDetails(int rpta_id,int emp_id)


        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@rpta_id", rpta_id);
            para[1] = new SqlParameter("@emp_id", emp_id);

            dtac.open();
            dtac.ExcutCommand("DelEmpOfSalaryDetails", para);
            dtac.close();
        }

        public DataTable SearchSalaryIssue(string Issue_search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Issue_search", Issue_search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchSalaryIssue", para);
            dtac.close();
            return dt;
        }
        public DataTable CheckSalaryIssue_ById(int tb_Rtpa_No)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rpta_id", tb_Rtpa_No);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("CheckSalaryIssue_ById", para);
            dtac.close();
            return dt;

        }

        public DataTable ShowSalaryDetails(int rpta_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rpta_id", rpta_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowSalaryDetails", para);
            dtac.close();
            return dt;
        }
        public DataTable ShowSalaryDetailsByBranch(int branch_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@branch_id", branch_id) ;
          
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowSalaryDetailsByBranch", para);
            dtac.close();
            return dt;
        }
    }
}
