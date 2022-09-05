using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ae
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public DataTable ExpensesOfAe(DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@from_date", from);

            para[1] = new SqlParameter("@to_date", to);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ExpensesOfAe", para);
            dtac.close();
            return dt;
        }
        //  اضافة  بيانات القيد
        public void add_ae(int ae_id,
                          DateTime ae_date,
                          int Invoice_Type_id,
                          string ae_cat,
                          string ae_ref,
                          decimal ae_sum_cr,
                          decimal ae_sum_de,
                          int CostCenter,
                          string CostCenter_Name,
                          int brn_id,
                          int SalesPerson_id,
                          string SalesPerson_name,
                          string Check_no,
                          DateTime Check_date,
                          string Payment_Options,
                         //Created By & Created Date
                         string Created_By,
                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[17];
            para[0] = new SqlParameter("@ae_id", ae_id);
            para[1] = new SqlParameter("@ae_date", ae_date);
            para[2] = new SqlParameter("@Invoice_Type_id", Invoice_Type_id);
            para[3] = new SqlParameter("@ae_cat", ae_cat);
            para[4] = new SqlParameter("@ae_ref", ae_ref);
            para[5] = new SqlParameter("@ae_sum_cr", ae_sum_cr);
            para[6] = new SqlParameter("@ae_sum_de", ae_sum_de);
            para[7] = new SqlParameter("@CostCenter", CostCenter);
            para[8] = new SqlParameter("@CostCenter_Name", CostCenter_Name);
            para[9] = new SqlParameter("@brn_id", brn_id);
            para[10] = new SqlParameter("@SalesPerson_id", SalesPerson_id);
            para[11] = new SqlParameter("@SalesPerson_name", SalesPerson_name);
            para[12] = new SqlParameter("@Check_no", Check_no);
            para[13] = new SqlParameter("@Check_date", Check_date);
            para[14] = new SqlParameter("@Payment_Options", Payment_Options);
            //Created By & Created Date
            para[15] = new SqlParameter("@Created_By", Created_By);
            para[16] = new SqlParameter("@Created_Date", Created_Date);


            dtac.open();
            dtac.ExcutCommand("add_ae", para);
            dtac.close();
        }

        //  تعديل  بيانات القيد
        public void Update_ae(int ae_id,
                          DateTime ae_date,
                          int Invoice_Type_id,
                          string ae_cat,
                          string ae_ref,
                          decimal ae_sum_cr,
                          decimal ae_sum_de,
                          int CostCenter,
                          string CostCenter_Name,
                          int brn_id,
                          int SalesPerson_id,
                          string SalesPerson_name,
                          string Check_no,
                          DateTime Check_date,
                          string Payment_Options,
                         //Created By & Created Date
                         string Created_By,
                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[17];
            para[0] = new SqlParameter("@ae_id", ae_id);
            para[1] = new SqlParameter("@ae_date", ae_date);
            para[2] = new SqlParameter("@Invoice_Type_id", Invoice_Type_id);
            para[3] = new SqlParameter("@ae_cat", ae_cat);
            para[4] = new SqlParameter("@ae_ref", ae_ref);
            para[5] = new SqlParameter("@ae_sum_cr", ae_sum_cr);
            para[6] = new SqlParameter("@ae_sum_de", ae_sum_de);
            para[7] = new SqlParameter("@CostCenter", CostCenter);
            para[8] = new SqlParameter("@CostCenter_Name", CostCenter_Name);
            para[9] = new SqlParameter("@brn_id", brn_id);
            para[10] = new SqlParameter("@SalesPerson_id", SalesPerson_id);
            para[11] = new SqlParameter("@SalesPerson_name", SalesPerson_name);
            para[12] = new SqlParameter("@Check_no", Check_no);
            para[13] = new SqlParameter("@Check_date", Check_date);
            para[14] = new SqlParameter("@Payment_Options", Payment_Options);
            //Created By & Created Date
            para[15] = new SqlParameter("@Created_By", Created_By);
            para[16] = new SqlParameter("@Created_Date", Created_Date);


            dtac.open();
            dtac.ExcutCommand("Update_ae", para);
            dtac.close();
        }

        //  حذف  بيانات القيد
        public void del_ae(int ae_id, int Invoice_Type_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@ae_id", ae_id);
            para[1] = new SqlParameter("@Invoice_Type_id", Invoice_Type_id);

            dtac.open();
            dtac.ExcutCommand("del_ae", para);
            dtac.close();
        }

        //  اضافة  تفاصيل القيد
        public void add_ae_dateils(int ae_id, string ac_id,
            string ac_name, decimal ac_de, decimal ac_cr,
            string ac_reson,
             //Created By & Created Date
             string Created_By,
             DateTime Created_Date,
             int Invoice_Type_id)
        {
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@ae_id", ae_id);
            para[1] = new SqlParameter("@ac_id", ac_id);
            para[2] = new SqlParameter("@ac_name", ac_name);
            para[3] = new SqlParameter("@ac_de", ac_de);
            para[4] = new SqlParameter("@ac_cr", ac_cr);
            para[5] = new SqlParameter("@ac_reson", ac_reson);
            //Created By & Created Date
            para[6] = new SqlParameter("@Created_By", Created_By);
            para[7] = new SqlParameter("@Created_Date", Created_Date);
            //----------------------------------------
            para[8] = new SqlParameter("@Invoice_Type_id", Invoice_Type_id);

            dtac.open();
            dtac.ExcutCommand("add_ae_dateils", para);
            dtac.close();
        }

        //  حذف  تفاصيل القيد
        public void del_ae_dateils(int ae_id, int Invoice_Type_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@ae_id", ae_id);
            para[1] = new SqlParameter("@Invoice_Type_id", Invoice_Type_id);


            dtac.open();
            dtac.ExcutCommand("del_ae_dateils", para);
            dtac.close();
        }
        public void del_ae_dateilsAndData(int ae_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ae_id", ae_id);


            dtac.open();
            dtac.ExcutCommand("del_ae_dateilsAndData", para);
            dtac.close();
        }
        public void del_ae_ac(string ac_id, decimal de, decimal cr, string ae_cat)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@ac_id", ac_id);
            para[1] = new SqlParameter("@cr_val", cr);
            para[2] = new SqlParameter("@de_val", de);
            para[3] = new SqlParameter("@ae_cat", ae_cat);


            dtac.open();
            dtac.ExcutCommand("del_ae_ac", para);
            dtac.close();
        }

        public DataTable ae_id(string ae_cat)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ae_cat", ae_cat);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ae_id", para);
            dtac.close();
            return dt;
        }
        public DataTable Show_aeById(int ae_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ae_id", ae_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_aeById", para);
            dtac.close();
            return dt;
        }

        public DataTable CheckAe(int ae_ref, string ae_cat)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@ae_ref", ae_ref);
            para[1] = new SqlParameter("@ae_cat", ae_cat);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("CheckAe", para);
            dtac.close();
            return dt;
        }
        public DataTable AE_SearchById(string search, string ae_cat )
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@search", search);
            para[1] = new SqlParameter("@ae_cat", ae_cat);
   

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("AE_SearchById", para);
            dtac.close();
            return dt;
        }
        public DataTable AE_Print(int ae_id, string ae_cat)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@ae_id", ae_id);
            para[1] = new SqlParameter("@ae_cat", ae_cat);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("AE_Print", para);
            dtac.close();
            return dt;
        }
        public DataTable Get_Ae_Id_ByRef(string ae_ref)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ae_ref", ae_ref);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Ae_Id_ByRef", para);
            dtac.close();
            return dt;
        }

        public DataTable StatAccountingEntry(string ac_id, DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@ac_id", ac_id);
            para[1] = new SqlParameter("@from", from);
            para[2] = new SqlParameter("@to", to);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("StatAccountingEntry", para);
            dtac.close();
            return dt;
        }
        public DataTable AccountStatment(string ac_id, DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@ac_id", ac_id);
            para[1] = new SqlParameter("@from", from);
            para[2] = new SqlParameter("@to", to);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("AccountStatment", para);
            dtac.close();
            return dt;
        }

        public DataTable show_accouByDate(DateTime from, DateTime To)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@To", To);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("show_accouByDate", para);
            dtac.close();
            return dt;
        }
        
        
        //Report_Where/SELECT para
        public DataTable Show_Acc_Statment(string where/*, string SELECT*/)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@where", where);
            /*para[1] = new SqlParameter("@SELECT", SELECT);*/
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_Acc_Statment", para);
            dtac.close();
            return dt;
        }
    }
}
