using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    
    class ClassSalary
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
      
        public void mng_SalaryAdd(int emp_id ,
                                  decimal basic_salary,
                                  decimal house_allowance,
                                  decimal transportation_allowance,
                                  decimal petrol_allowance,
                                  decimal other_allowance,
                                  decimal gosi_deduction,
                                  decimal other_deduction,
                                  string bank_name,
                                  string swift_code,
                                  string account_no,
                                  string bank_address,
                                  string iban_no,
                                //Created By & Created Date
                                string Created_By,
                                DateTime Created_Date)

                                {
                                 SqlParameter[] para = new SqlParameter[16];
                                 para[0] = new SqlParameter("@emp_id", emp_id);
                                 para[1] = new SqlParameter("@basic_salary", basic_salary);
                                 para[2] = new SqlParameter("@house_allowance", house_allowance);
                                 para[3] = new SqlParameter("@transportation_allowance", transportation_allowance);
                                 para[4] = new SqlParameter("@petrol_allowance", petrol_allowance);
                                 para[5] = new SqlParameter("@other_allowance", other_allowance);
                                 para[6] = new SqlParameter("@gosi_deduction", gosi_deduction);
                                 para[7] = new SqlParameter("@other_deduction", other_deduction);
                                 para[8] = new SqlParameter("@bank_name", bank_name);
                                 para[9] = new SqlParameter("@swift_code", swift_code);
                                 para[10] = new SqlParameter("@account_no", account_no);
                                 para[11] = new SqlParameter("@bank_address", bank_address);
                                 para[12] = new SqlParameter("@iban_no", iban_no);
            //Created By & Created Date
            para[13] = new SqlParameter("@Created_By", Created_By);
            para[14] = new SqlParameter("@Created_Date", Created_Date);
            para[15] = new SqlParameter("@check", "a");

                                 dtac.open();
                                 dtac.ExcutCommand("mng_salary", para);
                                 dtac.close();
                                }
        public void mng_SalaryUpdate(int emp_id,
                                     decimal basic_salary,
                                     decimal house_allowance,
                                     decimal transportation_allowance,
                                     decimal petrol_allowance,
                                     decimal other_allowance,
                                     decimal gosi_deduction,
                                     decimal other_deduction,
                                     string bank_name,
                                     string swift_code,
                                     string account_no,
                                     string bank_address,
                                     string iban_no,
                                //Created By & Created Date
                                string Created_By,
                                DateTime Created_Date,
                                     int oldEmpid)

                                   {
                                    SqlParameter[] para = new SqlParameter[17];
                                    para[0] = new SqlParameter("@emp_id", emp_id);
                                    para[1] = new SqlParameter("@basic_salary", basic_salary);
                                    para[2] = new SqlParameter("@house_allowance", house_allowance);
                                    para[3] = new SqlParameter("@transportation_allowance", transportation_allowance);
                                    para[4] = new SqlParameter("@petrol_allowance", petrol_allowance);
                                    para[5] = new SqlParameter("@other_allowance", other_allowance);
                                    para[6] = new SqlParameter("@gosi_deduction", gosi_deduction);
                                    para[7] = new SqlParameter("@other_deduction", other_deduction);
                                    para[8] = new SqlParameter("@bank_name", bank_name);
                                    para[9] = new SqlParameter("@swift_code", swift_code);
                                    para[10] = new SqlParameter("@account_no", account_no);
                                    para[11] = new SqlParameter("@bank_address", bank_address);
                                    para[12] = new SqlParameter("@iban_no", iban_no);
            //Created By & Created Date
            para[13] = new SqlParameter("@Created_By", Created_By);
            para[14] = new SqlParameter("@Created_Date", Created_Date);
            para[15] = new SqlParameter("@check", "u");
                                    para[16] = new SqlParameter("@oldEmpid", oldEmpid);

                                    dtac.open();
                                    dtac.ExcutCommand("mng_salary", para);
                                    dtac.close();
                                    }
        public DataTable ImportRpta(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", vrb_serch);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ImportRpta", para);
            dtac.close();
            return dt;
        }
        public DataTable SearchEmpSalary(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchEmpSalary", para);
            dtac.close();
            return dt;
        }
        public DataTable ShowEmpForIssueSalary(int rpta_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rpta_id", rpta_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowEmpForIssueSalary", para);
            dtac.close();
            return dt;
        }
        public DataTable GetLoan(int emp_id ,int sdate)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@sdate", sdate);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetLoan", para);
            dtac.close();
            return dt;
        }

        /*فقط لإظهار الموظفين على راس العمل*/
        public DataTable ShowIssueSalary_status(int rpta_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rpta_id", rpta_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowIssueSalary_status", para);
            dtac.close();
            return dt;
        }


        


        public DataTable ShowSala_Emp(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowSala_Emp", para);
            dtac.close();
            return dt;
        }
        public DataTable GetLoan_1(int emp_id, DateTime sdate)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@sdate", sdate);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetLoan_1", para);
            dtac.close();
            return dt;
        }
    }
}
