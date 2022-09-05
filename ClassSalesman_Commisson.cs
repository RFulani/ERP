using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    class ClassSalesman_Commisson
    {


            Code.DataAccessLayer dtac = new DataAccessLayer();


            //الأضافة
            public void mng_Salesman_Commisson_add(
                                           int id,
                                           int salesman_id,
                                           string salesman_name,
                                           decimal credit_percentage,
                                           decimal cash_percentage,
                                           DateTime Date_From,
                                           DateTime Date_To,
                                           decimal sales_target,
                                           decimal Total_CreditSales,
                                           decimal Toal_CashSales,
                                           decimal Total_CreditSalesReturns,
                                           decimal Total_CashSalesReturns,
                                           decimal salesman_TargetPercentage,
                                           decimal salesman_Received_Percent,
                                           decimal Net_CreditSales,
                                           decimal Net_CashSales,
                                           decimal Total_sales,
                                           decimal salesman_Received,
                                           decimal Credit_Commission,
                                           decimal Cash_Commission,
                                           decimal Total_commission,
                                           decimal remainder,
                                           //Created By & Created Date
                                           string Created_By,
                                           DateTime Created_Date

                                         )
            {
                SqlParameter[] para = new SqlParameter[25];
                para[0] = new SqlParameter("@id", id);
                para[1] = new SqlParameter("@salesman_id", salesman_id);
                para[2] = new SqlParameter("@salesman_name", salesman_name);
                para[3] = new SqlParameter("@credit_percentage", credit_percentage);
                para[4] = new SqlParameter("@cash_percentage", cash_percentage);
                para[5] = new SqlParameter("@Date_From", Date_From);
                para[6] = new SqlParameter("@Date_To", Date_To);
                para[7] = new SqlParameter("@sales_target", sales_target);
                para[8] = new SqlParameter("@Total_CreditSales", Total_CreditSales);
                para[9] = new SqlParameter("@Toal_CashSales", Toal_CashSales);
                para[10] = new SqlParameter("@Total_CreditSalesReturns", Total_CreditSalesReturns);
                para[11] = new SqlParameter("@Total_CashSalesReturns", Total_CashSalesReturns);
                para[12] = new SqlParameter("@salesman_TargetPercentage", salesman_TargetPercentage);
                para[13] = new SqlParameter("@salesman_Received_Percent", salesman_Received_Percent);
                para[14] = new SqlParameter("@Net_CreditSales", Net_CreditSales);
                para[15] = new SqlParameter("@Net_CashSales", Net_CashSales);
                para[16] = new SqlParameter("@Total_sales", Total_sales);
                para[17] = new SqlParameter("@salesman_Received", salesman_Received);
                para[18] = new SqlParameter("@Credit_Commission", Credit_Commission);
                para[19] = new SqlParameter("@Cash_Commission", Cash_Commission);
                para[20] = new SqlParameter("@Total_commission", Total_commission);
                para[21] = new SqlParameter("@remainder", remainder);
                //Created By & Created Date
                para[22] = new SqlParameter("@Created_By", Created_By);
                para[23] = new SqlParameter("@Created_Date", Created_Date);
                para[24] = new SqlParameter("@check", "a");



                dtac.open();
                dtac.ExcutCommand("mng_Salesman_Commisson", para);
                dtac.close();
            }

            //التعديل
            public void mng_Salesman_Commisson_Update(
                                           int id,
                                           int salesman_id,
                                           string salesman_name,
                                           decimal credit_percentage,
                                           decimal cash_percentage,
                                           DateTime Date_From,
                                           DateTime Date_To,
                                           decimal sales_target,
                                           decimal Total_CreditSales,
                                           decimal Toal_CashSales,
                                           decimal Total_CreditSalesReturns,
                                           decimal Total_CashSalesReturns,
                                           decimal salesman_TargetPercentage,
                                           decimal salesman_Received_Percent,
                                           decimal Net_CreditSales,
                                           decimal Net_CashSales,
                                           decimal Total_sales,
                                           decimal salesman_Received,
                                           decimal Credit_Commission,
                                           decimal Cash_Commission,
                                           decimal Total_commission,
                                           decimal remainder,
                                           //Created By & Created Date
                                           string Created_By,
                                           DateTime Created_Date
               )
        {
            SqlParameter[] para = new SqlParameter[25];
            para[0] = new SqlParameter("@id", id);
            para[1] = new SqlParameter("@salesman_id", salesman_id);
            para[2] = new SqlParameter("@salesman_name", salesman_name);
            para[3] = new SqlParameter("@credit_percentage", credit_percentage);
            para[4] = new SqlParameter("@cash_percentage", cash_percentage);
            para[5] = new SqlParameter("@Date_From", Date_From);
            para[6] = new SqlParameter("@Date_To", Date_To);
            para[7] = new SqlParameter("@sales_target", sales_target);
            para[8] = new SqlParameter("@Total_CreditSales", Total_CreditSales);
            para[9] = new SqlParameter("@Toal_CashSales", Toal_CashSales);
            para[10] = new SqlParameter("@Total_CreditSalesReturns", Total_CreditSalesReturns);
            para[11] = new SqlParameter("@Total_CashSalesReturns", Total_CashSalesReturns);
            para[12] = new SqlParameter("@salesman_TargetPercentage", salesman_TargetPercentage);
            para[13] = new SqlParameter("@salesman_Received_Percent", salesman_Received_Percent);
            para[14] = new SqlParameter("@Net_CreditSales", Net_CreditSales);
            para[15] = new SqlParameter("@Net_CashSales", Net_CashSales);
            para[16] = new SqlParameter("@Total_sales", Total_sales);
            para[17] = new SqlParameter("@salesman_Received", salesman_Received);
            para[18] = new SqlParameter("@Credit_Commission", Credit_Commission);
            para[19] = new SqlParameter("@Cash_Commission", Cash_Commission);
            para[20] = new SqlParameter("@Total_commission", Total_commission);
            para[21] = new SqlParameter("@remainder", remainder);
            //Created By & Created Date
            para[22] = new SqlParameter("@Created_By", Created_By);
            para[23] = new SqlParameter("@Created_Date", Created_Date);
            para[24] = new SqlParameter("@check", "u");

                dtac.open();
                dtac.ExcutCommand("mng_Salesman_Commisson", para);
                dtac.close();
            }

            //الحذف
            public void mng_Salesman_Commisson_Del(int id)
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@id", id);

                dtac.open();
                dtac.ExcutCommand("mng_Salesman_Commisson_Del", para);
                dtac.close();
            }
            public DataTable ShowSalesman_Commisson(int id)
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@id ", id);

                DataTable dt = new DataTable();
                dtac.open();
                dt = dtac.Selectdata("ShowSalesman_Commisson", para);
                dtac.close();
                return dt;
            }

        public DataTable ShowAllSalesman_Commisson()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllSalesman_Commisson", null);
            dtac.close();
            return dt;
        }
        //بحث 
        public DataTable SearchSalesman_Commisson(string search)
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@search", search);
                DataTable dt = new DataTable();
                dtac.open();
                dt = dtac.Selectdata("SearchSalesman_Commisson", para);
                dtac.close();
                return dt;
            }


            //للحصول على الارقام تسلسليه
            public DataTable Get_Salesman_Commisson_id()
            {
                DataTable dt = new DataTable();
                dtac.open();
                dt = dtac.Selectdata("Get_Salesman_Commisson_id", null);
                dtac.close();
                return dt;
            }



        }
    }


