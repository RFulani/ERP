using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace INV.Code
{
    class ClassLoans
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //إضافة القروض 
        public void mng_Loans_Add(
                                 string Loan_No
                               , int tb_Loan_Days
                               , DateTime due_date
                               , DateTime Payment_Date
                               , string Company 
                               , decimal Loan_amount
                               , decimal ARP
                               , decimal ARP_value
                               , decimal Total
                               , string Note 
                               , string Loan_Status
                                //Created By & Created Date
                                , string Created_By
                                , DateTime Created_Date

            )
        {
            SqlParameter[] para = new SqlParameter[14];
            para[0] = new SqlParameter("@Loan_No", Loan_No);
            para[1] = new SqlParameter("@tb_Loan_Days", tb_Loan_Days);
            para[2] = new SqlParameter("@due_date", due_date);
            para[3] = new SqlParameter("@Payment_Date", Payment_Date);
            para[4] = new SqlParameter("@Company", Company);
            para[5] = new SqlParameter("@Loan_amount", Loan_amount);
            para[6] = new SqlParameter("@ARP", ARP);
            para[7] = new SqlParameter("@ARP_value", ARP_value);
            para[8] = new SqlParameter("@Total", Total);
            para[9] = new SqlParameter("@Note", Note);
            para[10] = new SqlParameter("@Loan_Status", Loan_Status);
            //Created By & Created Date
            para[11] = new SqlParameter("@Created_By", Created_By);
            para[12] = new SqlParameter("@Created_Date", Created_Date);
            para[13] = new SqlParameter("@check", "a");


            dtac.open();
            dtac.ExcutCommand("mng_Loans", para);
            dtac.close();

        }

        // تعديل القروض
        public void mng_Loans_Update(
                                             string Loan_No
                               , int tb_Loan_Days
                               , DateTime due_date
                               , DateTime Payment_Date
                               , string Company
                               , decimal Loan_amount
                               , decimal ARP
                               , decimal ARP_value
                               , decimal Total
                               , string Note
                               , string Loan_Status
                                //Created By & Created Date
                                , string Created_By
                                , DateTime Created_Date


                                )
        {
            SqlParameter[] para = new SqlParameter[14];
            para[0] = new SqlParameter("@Loan_No", Loan_No);
            para[1] = new SqlParameter("@tb_Loan_Days", tb_Loan_Days);
            para[2] = new SqlParameter("@due_date", due_date);
            para[3] = new SqlParameter("@Payment_Date", Payment_Date);
            para[4] = new SqlParameter("@Company", Company);
            para[5] = new SqlParameter("@Loan_amount", Loan_amount);
            para[6] = new SqlParameter("@ARP", ARP);
            para[7] = new SqlParameter("@ARP_value", ARP_value);
            para[8] = new SqlParameter("@Total", Total);
            para[9] = new SqlParameter("@Note", Note);
            para[10] = new SqlParameter("@Loan_Status", Loan_Status);
            //Created By & Created Date
            para[11] = new SqlParameter("@Created_By", Created_By);
            para[12] = new SqlParameter("@Created_Date", Created_Date);

            para[13] = new SqlParameter("@check", "u");
          

            dtac.open();
            dtac.ExcutCommand("mng_Loans", para);
            dtac.close();

        }
        //الحذف
        public void mng_LoansDel(string Loan_No)

        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Loan_No", Loan_No);

            dtac.open();
            dtac.ExcutCommand("mng_LoansDel", para);
            dtac.close();
        }
        //لإظهار جميع الحقول
        public DataTable ShowLoans(string Loan_No)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Loan_No", Loan_No);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowLoans", para);
            dtac.close();
            return dt;
        }
        //البحث
        public DataTable SearchLoans(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchLoans", para);
            dtac.close();
            return dt;
        }
        //showAll
        public DataTable ShowLoansforDGV()
        {
            SqlParameter[] para = new SqlParameter[0];
     
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowLoansforDGV", para);
            dtac.close();
            return dt;
        }
        //showLoan_Where para
        public DataTable ShowLoans_dgv(string where)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@where", where);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowLoans_dgv", para);
            dtac.close();
            return dt;
        }
        //showAll+Stat
        public DataTable ShowLoansforprintAll_Stat(string Loan_Status)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Loan_Status", Loan_Status);
           
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowLoansforprintAll_Stat", para);
            dtac.close();
            return dt;
        }

        //showDate+Stat
        public DataTable ShowLoansforprint(DateTime from,DateTime to, string Loan_Status)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@to", to);
            para[2] = new SqlParameter("@Loan_Status", Loan_Status);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowLoansforprint", para);
            dtac.close();
            return dt;
        }

        //showDatefor all
        public DataTable ShowLoansforprintAll(DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@to", to);
           
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowLoansforprintAll", para);
            dtac.close();
            return dt;
        }

 
        public DataTable CheckLoan_ById(string Loan_No)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Loan_No", Loan_No);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("CheckLoan_ById", para);
            dtac.close();
            return dt;
        }
    }
}
