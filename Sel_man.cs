using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class Sel_man
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public DataTable Show_Sel_man()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_Sel_man", null);
            dtac.close();
            return dt;
        }
        public DataTable search_Sel_man(int sal_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@sal_id", sal_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("search_Sel_man", para);
            dtac.close();
            return dt;
        }
        public void AddSalMan(string sal_id,
            string sal_name,
            string sal_mobile,
            string sal_date,
            string credit_percentage,
            string cash_percentage,
            string sal_pass,
            int User_Status,
            int wh_id,
                                         //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)

        {
            SqlParameter[] para = new SqlParameter[12];
            para[0] = new SqlParameter("@sal_id", Convert.ToInt32(sal_id));
            para[1] = new SqlParameter("@check", "a");
            para[2] = new SqlParameter("@sal_name", sal_name);
            para[3] = new SqlParameter("@sal_mobil", sal_mobile);
            para[4] = new SqlParameter("@sal_date", DateTime.Now.Date);
            para[5] = new SqlParameter("@credit_percentage", Convert.ToDecimal(credit_percentage));
            para[6] = new SqlParameter("@cash_percentage", Convert.ToDecimal(cash_percentage));
            para[7] = new SqlParameter("@sal_pass", sal_pass);
            para[8] = new SqlParameter("@User_Status", User_Status);
            para[9] = new SqlParameter("@wh_id", wh_id);
            //Created By & Created Date
            para[10] = new SqlParameter("@Created_By", Created_By);
            para[11] = new SqlParameter("@Created_Date", Created_Date);
            
            dtac.open();
            dtac.ExcutCommand("mng_sal_man", para);
            dtac.close();
        }
        public void UpdateSalMan(string sal_id,
            string sal_name,
            string sal_mobile,
            string sal_date,
            string credit_percentage,
            string cash_percentage,
                      string sal_pass,
            int User_Status,
            int wh_id,
                                         //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[12];
            para[0] = new SqlParameter("@sal_id", Convert.ToInt32(sal_id));
            para[1] = new SqlParameter("@check", "u");
            para[2] = new SqlParameter("@sal_name", sal_name);
            para[3] = new SqlParameter("@sal_mobil", sal_mobile);
            para[4] = new SqlParameter("@sal_date", DateTime.Now.Date);
            para[5] = new SqlParameter("@credit_percentage", Convert.ToDecimal(credit_percentage));
            para[6] = new SqlParameter("@cash_percentage", Convert.ToDecimal(cash_percentage));
            para[7] = new SqlParameter("@sal_pass", sal_pass);
            para[8] = new SqlParameter("@User_Status", User_Status);
            para[9] = new SqlParameter("@wh_id", wh_id);
            //Created By & Created Date
            para[10] = new SqlParameter("@Created_By", Created_By);
            para[11] = new SqlParameter("@Created_Date", Created_Date);

            dtac.open();
            dtac.ExcutCommand("mng_sal_man", para);
            dtac.close();
        }
        public void DelSalMan(string sal_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@sal_id", Convert.ToInt32(sal_id));
            para[1] = new SqlParameter("@check", "d");
           

            dtac.open();
            dtac.ExcutCommand("mng_sal_man", para);
            dtac.close();
        }

        public void mng_sal_man_DEL(string sal_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@sal_id", Convert.ToInt32(sal_id));
            
            dtac.open();
            dtac.ExcutCommand("mng_sal_man_DEL", para);
            dtac.close();
        }
    }
}
