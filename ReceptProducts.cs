using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ReceptProducts
    {
        
           Code.DataAccessLayer dtac = new DataAccessLayer();
        public DataTable rec_id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("rec_id", null);
            dtac.close();
            return dt;
        }
        public void AddReceptPro(string rec_id, 
            string pur_id, string pro_id, 
            double pur_qty, double rec_qty, 
            string rec_date, string rec_stat,
            string username, string rec_note ,
            string note
            //Created By & Created Date
            , string Created_By
            , DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[12];
            para[0] = new SqlParameter("@rec_id", Convert.ToInt32(rec_id));
            para[1] = new SqlParameter("@pur_id", Convert.ToInt32(pur_id));
            para[2] = new SqlParameter("@pro_id", pro_id);
            para[3] = new SqlParameter("@pur_qty", pur_qty);
            para[4] = new SqlParameter("@rec_qty", rec_qty);
            para[5] = new SqlParameter("@rec_date", rec_date);
            para[6] = new SqlParameter("@rec_stat", rec_stat);
            para[7] = new SqlParameter("@username", username);
            para[8] = new SqlParameter("@rec_note", rec_note);
            para[9] = new SqlParameter("@note", note);
            //Created By & Created Date
            para[10] = new SqlParameter("@Created_By", Created_By);
            para[11] = new SqlParameter("@Created_Date", Created_Date);


            dtac.open();
            dtac.ExcutCommand("AddReceptPro", para);
            dtac.close();

        }
        public void UpdateReceptPro(string rec_id, string pur_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@rec_id", Convert.ToInt32(rec_id));
            para[1] = new SqlParameter("@pur_id", Convert.ToInt32(pur_id));
            dtac.open();
            dtac.ExcutCommand("UpdateReceptPro", para);
            dtac.close();

        }
        public void DelReceptPro(string rec_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rec_id", Convert.ToInt32(rec_id));
         

            dtac.open();
            dtac.ExcutCommand("DelReceptPro", para);
            dtac.close();

        }
        public DataTable ShowReceptItems(string rec_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rec_id", Convert.ToInt32(rec_id));

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowReceptItems", para);
            dtac.close();
            return dt;
        }
        
        public DataTable serch_Recbyname(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", vrb_serch);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("serch_Recbyname", para);
            dtac.close();
            return dt;
        }
    }
}
