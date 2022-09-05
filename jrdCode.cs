using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class jrdCode
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public DataTable jrd_id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("jrd_id", null);
            dtac.close();
            return dt;
        }
        //ادارة بيانات الجرد
        public void Add_jrd(string jrd_id,
            DateTime jrd_date ,
            string jrd_ref,
            string wer_id,
            string note,
            string userdo,
   //Created By & Created Date
            string Created_By,
         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@jrd_id", Convert.ToInt32(jrd_id));
            para[1] = new SqlParameter("@jrd_date", jrd_date);
            para[2] = new SqlParameter("@jrd_ref", jrd_ref);
            para[3] = new SqlParameter("@wer_id", Convert.ToInt32(wer_id));
            para[4] = new SqlParameter("@note", note);
            para[5] = new SqlParameter("@userdo", userdo);
            //Created By & Created Date
            para[6] = new SqlParameter("@Created_By", Created_By);
            para[7] = new SqlParameter("@Created_Date", Created_Date);

            para[8] = new SqlParameter("@check", "a");
            


            dtac.open();
            dtac.ExcutCommand("mng_jrd", para);
            dtac.close();

        }
        public void Update_jrd(string jrd_id,
            DateTime jrd_date, 
            string jrd_ref,
            string wer_id,
            string note, 
            string userdo,
            //Created By & Created Date
            string Created_By,
         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@jrd_id", Convert.ToInt32(jrd_id));
            para[1] = new SqlParameter("@jrd_date", jrd_date);
            para[2] = new SqlParameter("@jrd_ref", jrd_ref);
            para[3] = new SqlParameter("@wer_id", Convert.ToInt32(wer_id));
            para[4] = new SqlParameter("@note", note);
            para[5] = new SqlParameter("@userdo", userdo);
            //Created By & Created Date
            para[6] = new SqlParameter("@Created_By", Created_By);
            para[7] = new SqlParameter("@Created_Date", Created_Date);

            para[8] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_jrd", para);
            dtac.close();

        }
        public void Del_jrd(string jrd_id,
            DateTime jrd_date,
            string jrd_ref,
            string wer_id,
            string note,
            string userdo,
            //Created By & Created Date
            string Created_By,
         DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@jrd_id", Convert.ToInt32(jrd_id));
            para[1] = new SqlParameter("@jrd_date", jrd_date);
            para[2] = new SqlParameter("@jrd_ref", jrd_ref);
            para[3] = new SqlParameter("@wer_id", Convert.ToInt32(wer_id));
            para[4] = new SqlParameter("@note", note);
            para[5] = new SqlParameter("@userdo", userdo);
            para[6] = new SqlParameter("@Created_By", Created_By);
            para[7] = new SqlParameter("@Created_Date", Created_Date);
            para[8] = new SqlParameter("@check", "d");



            dtac.open();
            dtac.ExcutCommand("mng_jrd", para);
            dtac.close();

        }

        //ادارة تفاصيل الجرد
        public void Add_jrdDetails(string jrd_id, string pro_id,
            int pro_qty,int pro_qtydef, string pro_qtyjrd,
            string jrd_note,int wh_id,
            //Created By & Created Date
            string Created_By,
         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@jrd_id", Convert.ToInt32(jrd_id));
            para[1] = new SqlParameter("@pro_id", pro_id);
            para[2] = new SqlParameter("@pro_qtyjrd", Convert.ToDouble(pro_qtyjrd));
            para[3] = new SqlParameter("@jrd_note", jrd_note);
            para[4] = new SqlParameter("@check", "a");
            para[5] = new SqlParameter("@pro_qty", pro_qty);
            para[6] = new SqlParameter("@pro_qtydef", pro_qtydef);
            para[7] = new SqlParameter("@wh_id", wh_id);
            //Created By & Created Date
            para[8] = new SqlParameter("@Created_By", Created_By);
            para[9] = new SqlParameter("@Created_Date", Created_Date);






            dtac.open();
            dtac.ExcutCommand("mng_jrdDetails", para);
            dtac.close();

        }
        public void Del_jrdDetails(string jrd_id, string pro_id, int pro_qtydef)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@jrd_id", Convert.ToInt32(jrd_id));
            para[1] = new SqlParameter("@pro_id", pro_id);
            para[2] = new SqlParameter("@pro_qtydef", pro_qtydef);
            
            para[3] = new SqlParameter("@check", "d");



            dtac.open();
            dtac.ExcutCommand("mng_jrdDetails", para);
            dtac.close();

        }

        public void Deletejrd (string jrd_id, string pro_id, int pro_qtydef, int wh_id)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@jrd_id", Convert.ToInt32(jrd_id));
            para[1] = new SqlParameter("@pro_id", pro_id);
            para[2] = new SqlParameter("@pro_qtydef", pro_qtydef);
            para[3] = new SqlParameter("@wh_id", wh_id);

            //para[3] = new SqlParameter("@check", "e");



            dtac.open();
            dtac.ExcutCommand("Deletejrd", para);
            dtac.close();

        }
        public DataTable ShowJardForUpdate(string jrd_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@jrd_id", Convert.ToInt32(jrd_id));
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowJardForUpdate", para);
            dtac.close();
            return dt;
        }
        public DataTable Searchjrd(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", vrb_serch);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Searchjrd", para);
            dtac.close();
            return dt;
        }
        public DataTable Showoldjrd(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@jrd_id", vrb_serch);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Showoldjrd", para);
            dtac.close();
            return dt;
        }

        public DataTable Showoldjrddata(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@jrd_id", vrb_serch);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Showoldjrddata", para);
            dtac.close();
            return dt;
        }
    }
}
