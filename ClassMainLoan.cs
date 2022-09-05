using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace INV.Code
{
    class ClassMainLoan
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_loan_MainDetailsAdd(
                                            int loan_No
                                          , int emp_Id
                                          , String emp_Name
                                          , String loan_type
                                          , decimal loan_value
                                          , DateTime loan_date
                                          , decimal installment_payments_Count
                                          , String Loan_status
                                           )
                                {
                                          SqlParameter[] para = new SqlParameter[9];
                                          para[0] = new SqlParameter("@loan_No", loan_No);
                                          para[1] = new SqlParameter("@emp_Id", emp_Id);
                                          para[2] = new SqlParameter("@emp_Name", emp_Name);
                                          para[3] = new SqlParameter("@loan_type", loan_type);
                                          para[4] = new SqlParameter("@loan_value", loan_value);
                                          para[5] = new SqlParameter("@loan_date", loan_date);
                                          para[6] = new SqlParameter("@installment_payments_Count", installment_payments_Count);
                                          para[7] = new SqlParameter("@Loan_status", Loan_status);
                                          para[8] = new SqlParameter("@check", "a");

                                             dtac.open();
                                            dtac.ExcutCommand("mng_loan_MainDetails", para);
                                            dtac.close();
                                }

        public void mng_loan_MainDetailsUpdate(
              int loan_No
           , int emp_Id
           , String emp_Name

           , String loan_type
           , decimal loan_value
           , DateTime loan_date

           , decimal installment_payments_Count

           , String Loan_status
           )
        {
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@loan_No", loan_No);
            para[1] = new SqlParameter("@emp_Id", emp_Id);
            para[2] = new SqlParameter("@emp_Name", emp_Name);
            para[3] = new SqlParameter("@loan_type", loan_type);
            para[4] = new SqlParameter("@loan_value", loan_value);
            para[5] = new SqlParameter("@loan_date", loan_date);
            para[6] = new SqlParameter("@installment_payments_Count", installment_payments_Count);
            para[7] = new SqlParameter("@Loan_status", Loan_status);
            para[8] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_loan_MainDetails", para);
            dtac.close();
        }
        public DataTable ShowLoanByID(int loan_No)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@loan_No", loan_No);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowLoanByID", para);
            dtac.close();
            return dt;
        }
        public DataTable SearchLoan(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchLoan", para);
            dtac.close();
            return dt;
        }

        public DataTable ShowMainLoan(int loan_No)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@loan_No", loan_No);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowMainLoan", para);
            dtac.close();
            return dt;
      
        }
        public void LoanDel(int loan_No)

        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@loan_No", loan_No);

            dtac.open();
            dtac.ExcutCommand("LoanDel", para);
            dtac.close();
        }
        public void LoanDelFroUpdate(int loan_No)

        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@loan_No", loan_No);

            dtac.open();
            dtac.ExcutCommand("LoanDelFroUpdate", para);
            dtac.close();
        }
    }


  
}
