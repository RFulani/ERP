using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class cash
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public DataTable StatCashfromCR(string ac_id,
                                        DateTime from,
                                        DateTime to,
                                        int sal_id
                                       )
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@from_id", ac_id);
            para[1] = new SqlParameter("@from", from);
            para[2] = new SqlParameter("@to", to);
            para[3] = new SqlParameter("@sal_id", sal_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("StatCashfromCR", para);
            dtac.close();
            return dt;
        }
        public DataTable StatCashToDe(int ac_id, DateTime from, DateTime to,int sal_id)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@to_id", ac_id);
            para[1] = new SqlParameter("@from", from);
            para[2] = new SqlParameter("@to", to);
            para[3] = new SqlParameter("@sal_id", sal_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("StatCashToDe", para);
            dtac.close();
            return dt;
        }
        public DataTable StatCashSal(DateTime from, DateTime to, int sal_id)
        {
            SqlParameter[] para = new SqlParameter[3];
           
            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@to", to);
            para[2] = new SqlParameter("@sal_id", sal_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("StatCashSal", para);
            dtac.close();
            return dt;
        }
        //اضافة حساب
        public void mng_cash_add(string cash_id,
            DateTime cash_date,
            string cash_type,
            string sal_id,
            string cash_ref,
            string from_id,
            string cash_value,
            string shek_id,
            string cash_textvalue,
            DateTime shek_date,
            string bank_name,
            string to_id,
            string cash_resone ,
            string cash_cat,
            string from_name,
            string to_name,
            int branch_id,
            string branch_name,
            int CostCenter_id,
            string CostCenter,
                                         //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[19];
            para[0] = new SqlParameter("@check", "a");
            para[1] = new SqlParameter("@cash_id", Convert.ToDouble(cash_id));
            para[2] = new SqlParameter("@cash_date", cash_date);
            para[3] = new SqlParameter("@cash_type", cash_type);
            para[4] = new SqlParameter("@sal_id", Convert.ToDouble(sal_id));
            para[5] = new SqlParameter("@cash_ref", cash_ref);
            para[6] = new SqlParameter("@from_id", Convert.ToDouble(from_id));
            para[7] = new SqlParameter("@cash_value", Convert.ToDouble(cash_value));
            para[8] = new SqlParameter("@shek_id", shek_id);
            para[9] = new SqlParameter("@cash_textvalue", cash_textvalue);
            para[10] = new SqlParameter("@shek_date", shek_date);
            para[11] = new SqlParameter("@bank_name", bank_name);
            para[12] = new SqlParameter("@to_id", Convert.ToDouble(to_id));
            para[13] = new SqlParameter("@cash_resone", cash_resone);
            para[14] = new SqlParameter("@cash_cat", cash_cat);
            para[15] = new SqlParameter("@from_name", from_name);
            para[16] = new SqlParameter("@to_name", to_name);
            para[16] = new SqlParameter("@branch_id", branch_id);
            para[16] = new SqlParameter("@branch_name", branch_name);
            para[16] = new SqlParameter("@CostCenter_id", CostCenter_id);
            para[16] = new SqlParameter("@CostCenter", CostCenter);
            //Created By & Created Date
            para[17] = new SqlParameter("@Created_By", Created_By);
            para[18] = new SqlParameter("@Created_Date", Created_Date);
            dtac.open();
            dtac.ExcutCommand("mng_cash", para);
            dtac.close();
        }

        //تعديل حساب  
        public void mng_cash_up(string cash_id,
                                DateTime cash_date,
                                string cash_type,
                                string sal_id,
                                string cash_ref,
                                string from_id,
                                string cash_value,
                                string shek_id,
                                string cash_textvalue,
                                DateTime shek_date,
                                string bank_name,
                                string to_id,
                                string cash_resone,
                                string cash_cat,
                                string from_name,
                                string to_name,
                                 int branch_id,
                                string branch_name,
                                 int CostCenter_id,
                                string CostCenter,
                                         //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[19];
            para[0] = new SqlParameter("@check", "u");
            para[1] = new SqlParameter("@cash_id", Convert.ToInt32(cash_id));
            para[2] = new SqlParameter("@cash_date", cash_date);
            para[3] = new SqlParameter("@cash_type", cash_type);
            para[4] = new SqlParameter("@sal_id", Convert.ToInt32(sal_id));
            para[5] = new SqlParameter("@cash_ref", cash_ref);
            para[6] = new SqlParameter("@from_id", Convert.ToInt32(from_id));
            para[7] = new SqlParameter("@cash_value", Convert.ToDouble(cash_value));
            para[8] = new SqlParameter("@shek_id", shek_id);
            para[9] = new SqlParameter("@cash_textvalue", cash_textvalue);
            para[10] = new SqlParameter("@shek_date", shek_date);
            para[11] = new SqlParameter("@bank_name", bank_name);
            para[12] = new SqlParameter("@to_id", Convert.ToDouble(to_id));
            para[13] = new SqlParameter("@cash_resone", cash_resone);
            para[14] = new SqlParameter("@cash_cat", cash_cat);
            para[15] = new SqlParameter("@from_name", from_name);
            para[16] = new SqlParameter("@to_name", to_name);
            para[16] = new SqlParameter("@branch_id", branch_id);
            para[16] = new SqlParameter("@branch_name", branch_name);
            para[16] = new SqlParameter("@CostCenter_id", CostCenter_id);
            para[16] = new SqlParameter("@CostCenter", CostCenter);
            //Created By & Created Date
            para[17] = new SqlParameter("@Created_By", Created_By);
            para[18] = new SqlParameter("@Created_Date", Created_Date);

            dtac.open();
            dtac.ExcutCommand("mng_cash", para);
            dtac.close();
        }

        //حذف حساب
        public void mng_cash_del(int cash_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@cash_id", cash_id);
            para[1] = new SqlParameter("@check", "d");

            dtac.open();
            dtac.ExcutCommand("mng_cash", para);
            dtac.close();
        }

        //بحث

        public DataTable Serach_cash_bycr(string vrb_serch,string cashtyp)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@vrb_serch", vrb_serch);
            para[1] = new SqlParameter("@cashtyp", cashtyp);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Serach_cash_bycr", para);
            dtac.close();
            return dt;
        }
        public DataTable Serach_cash_byid(int vrb_serch,string cashtyp)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@vrb_serch", vrb_serch);
            para[1] = new SqlParameter("@cashtyp", cashtyp);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Serach_cash_byid", para);
            dtac.close();
            return dt;
        }

        public DataTable show_cash_byid(int vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", vrb_serch);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("show_cash_byid", para);
            dtac.close();
            return dt;
        }

        public DataTable show_ac()
        {


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("show_ac", null);
            dtac.close();
            return dt;
        }
        public DataTable Check_cash_id(int cash_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@cash_id", cash_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Check_cash_id", para);
            dtac.close();
            return dt;
        }

        public DataTable cash_id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("cash_id", null);
            dtac.close();
            return dt;
        }

        //إظهار جميع البيانات في الداتا جريد
        public DataTable ShowAllrecipts_dGV(int branch_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@branch_id", branch_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllrecipts_dGV", para);
            dtac.close();
            return dt;
        }
    }
}
