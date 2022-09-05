using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace INV.Code
{
    class ClassLoanDetalis
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_loan_LoanDetailsAdd(
            int loan_No
           , int emp_Id
           , String emp_Name  
           , String loan_type  
           ,decimal loan_value    
           , DateTime loan_date
           , DateTime first_installment_loan
           , int installment_payments_Count
           , decimal installment_Value
           , decimal paid_installment_Count
           , decimal total_payments
           , String Notes  
           /*, int LoanApproved*/
           , int Loan_Status_Id
           , string Loan_Status
          //Created By & Created Date
           , string Created_By
           , DateTime Created_Date

           )
        {
            SqlParameter[] para = new SqlParameter[17];
            para[0] = new SqlParameter("@loan_No", loan_No);
            para[1] = new SqlParameter("@emp_Id", emp_Id);
            para[2] = new SqlParameter("@emp_Name", emp_Name);
            para[3] = new SqlParameter("@loan_type", loan_type);
            para[4] = new SqlParameter("@loan_value", loan_value);
            para[5] = new SqlParameter("@loan_date", loan_date);
            para[6] = new SqlParameter("@first_installment_loan", first_installment_loan);
            para[7] = new SqlParameter("@installment_payments_Count", installment_payments_Count);
            para[8] = new SqlParameter("@installment_Value", installment_Value);
            para[9] = new SqlParameter("@paid_installment_Count", paid_installment_Count);
            para[10] = new SqlParameter("@total_payments", total_payments);
            para[11] = new SqlParameter("@Notes", Notes);
            /*para[12] = new SqlParameter("@LoanApproved", LoanApproved);*/
            para[12] = new SqlParameter("@Loan_Status_Id", Loan_Status_Id);
            para[13] = new SqlParameter("@Loan_Status", Loan_Status);
            //Created By & Created Date
            para[14] = new SqlParameter("@Created_By", Created_By);
            para[15] = new SqlParameter("@Created_Date", Created_Date);
            para[16] = new SqlParameter("@check", "a");

            dtac.open();
            dtac.ExcutCommand("mng_loan_LoanDetails", para);
            dtac.close();
        }
        public void mng_loan_LoanDetailsUpdate(
             int loan_No
           , int emp_Id
           , String emp_Name
           , String loan_type
           , decimal loan_value
           , DateTime loan_date
           , DateTime first_installment_loan
           , int installment_payments_Count
           , decimal installment_Value
           , decimal paid_installment_Count
           , decimal total_payments
           , String Notes
           /*, int LoanApproved*/
           , int Loan_Status_Id
           , string Loan_Status
           //Created By & Created Date
           , string Created_By
           , DateTime Created_Date
           )
        {
            SqlParameter[] para = new SqlParameter[17];
            para[0] = new SqlParameter("@loan_No", loan_No);
            para[1] = new SqlParameter("@emp_Id", emp_Id);
            para[2] = new SqlParameter("@emp_Name", emp_Name);
            para[3] = new SqlParameter("@loan_type", loan_type);
            para[4] = new SqlParameter("@loan_value", loan_value);
            para[5] = new SqlParameter("@loan_date", loan_date);
            para[6] = new SqlParameter("@first_installment_loan", first_installment_loan);
            para[7] = new SqlParameter("@installment_payments_Count", installment_payments_Count);
            para[8] = new SqlParameter("@installment_Value", installment_Value);
            para[9] = new SqlParameter("@paid_installment_Count", paid_installment_Count);
            para[10] = new SqlParameter("@total_payments", total_payments);
            para[11] = new SqlParameter("@Notes", Notes);
            /*para[12] = new SqlParameter("@LoanApproved", LoanApproved);*/
            para[12] = new SqlParameter("@Loan_Status_Id", Loan_Status_Id);
            para[13] = new SqlParameter("@Loan_Status", Loan_Status);
            //Created By & Created Date
            para[14] = new SqlParameter("@Created_By", Created_By);
            para[15] = new SqlParameter("@Created_Date", Created_Date);
            para[16] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_loan_LoanDetails", para);
            dtac.close();
        }
        public DataTable Get_LoanId()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Loan_id", null);
            dtac.close();
            return dt;
        }

        public DataTable LoanReport_Showing(int loan_No, int emp_Id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@loan_No", loan_No);
            para[1] = new SqlParameter("@emp_Id", emp_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("LoanReport_Showing", para);
            dtac.close();
            return dt;
        }
        //*-*-*-*-*-*-*--*-*-*-*-*-*-*-*-*--*-*-*-*-*-*-*--*-*-*-*--*-*-*-*-------*-*--*-*-*
        //لإظهار جميع طلبات السلف
        public DataTable ShowAllloan_Request(int emp_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_Id", emp_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllloan_Request", para);
            dtac.close();
            return dt;
        }
        //لإظهار جميع طلبات السلف بناءاً على حاله الطلب
        public DataTable ShowAllloan_Request_ByStatus(int emp_Id, int Loan_Status_Id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@emp_Id", emp_Id);
            para[1] = new SqlParameter("@Loan_Status_Id", Loan_Status_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllloan_Request_ByStatus", para);
            dtac.close();
            return dt;
        }
        //لإظهار جميع طلبات السلف بناءاً على الفتره  
        public DataTable ShowAllloan_byDate(int emp_Id, DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@emp_Id", emp_Id);
            para[1] = new SqlParameter("@Date_From", from);
            para[2] = new SqlParameter("@Date_To", to);


            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("ShowAllloan_byDate", para);
            dtac.close();
            return dtemp;
        }
        //لإظهار جميع طلبات السلف بناءاً على الفتره والحاله
        public DataTable ShowAllloan_byDateandStatus(int emp_Id, DateTime from, DateTime to, int Loan_Status_Id)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@emp_Id", emp_Id);
            para[1] = new SqlParameter("@Date_From", from);
            para[2] = new SqlParameter("@Date_To", to);
            para[3] = new SqlParameter("@Loan_Status_Id", Loan_Status_Id);


            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("ShowAllloan_byDateandStatus", para);
            dtac.close();
            return dtemp;
        }

    }
}
