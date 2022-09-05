using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class OutItems
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public DataTable out_id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("out_id", null);
            dtac.close();
            return dt;
        }
        public DataTable GetOutItem_DetailsById(int out_id)
        {
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@out_id", out_id);

           
            dtac.open();
            dt = dtac.Selectdata("GetOutItem_DetailsById", para);
            dtac.close();
            return dt;
        }
        public DataTable GetOutItemById(int out_id)
        {
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@out_id", out_id);


            dtac.open();
            dt = dtac.Selectdata("GetOutItemById", para);
            dtac.close();
            return dt;
        }
        public DataTable SearchOutItem(string out_ToName,string out_typ)
        {
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@search", out_ToName);
            para[1] = new SqlParameter("@out_typ", out_typ);

            dtac.open();
            dt = dtac.Selectdata("SearchOutItem", para);
            dtac.close();
            return dt;
        }

        public void mng_OutItem_A(int out_id,
            string out_ref, string out_date,
            int out_typeQty, int out_to,
            string out_address, int out_sal_id,
            string out_note,string out_typ,
                                                    //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[12];
            para[0] = new SqlParameter("@out_id", out_id);
            para[1] = new SqlParameter("@check", "a");
            para[2] = new SqlParameter("@out_ref", out_ref);
            para[3] = new SqlParameter("@out_date", out_date);
            para[4] = new SqlParameter("@out_typeQty", out_typeQty);
            para[5] = new SqlParameter("@out_to", out_to);
            para[6] = new SqlParameter("@out_address", out_address);
            para[7] = new SqlParameter("@out_sal_id", out_sal_id);
            para[8] = new SqlParameter("@out_note", out_note);
            para[9] = new SqlParameter("@out_typ", out_typ);
            //Created By & Created Date
            para[10] = new SqlParameter("@Created_By", Created_By);
            para[11] = new SqlParameter("@Created_Date", Created_Date);

            dtac.open();
            dtac.ExcutCommand("mng_OutItem", para);
            dtac.close();
        }
        public void mng_OutItem_U(int out_id,
            string out_ref, 
            string out_date, 
            int out_typeQty, 
            int out_to,
            string out_address,
            int out_sal_id,
            string out_note,
            string out_typ,
                                         //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[12];
            para[0] = new SqlParameter("@out_id", out_id);
            para[1] = new SqlParameter("@check", "u");
            para[2] = new SqlParameter("@out_ref", out_ref);
            para[3] = new SqlParameter("@out_date", out_date);
            para[4] = new SqlParameter("@out_typeQty", out_typeQty);
            para[5] = new SqlParameter("@out_to", out_to);
            para[6] = new SqlParameter("@out_address", out_address);
            para[7] = new SqlParameter("@out_sal_id", out_sal_id);
            para[8] = new SqlParameter("@out_note", out_note);
            para[9] = new SqlParameter("@out_typ", out_typ);
            //Created By & Created Date
            para[10] = new SqlParameter("@Created_By", Created_By);
            para[11] = new SqlParameter("@Created_Date", Created_Date);

            dtac.open();
            dtac.ExcutCommand("mng_OutItem", para);
            dtac.close();
        }
        public void mng_OutItem_D(int out_id)
        {
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@out_id", out_id);
            para[1] = new SqlParameter("@check", "d");
            para[2] = new SqlParameter("@out_ref", null);
            para[3] = new SqlParameter("@out_date", null);
            para[4] = new SqlParameter("@out_typeQty", 0);
            para[5] = new SqlParameter("@out_to", 0);
            para[6] = new SqlParameter("@out_address", null);
            para[7] = new SqlParameter("@out_sal_id", 0);
            para[8] = new SqlParameter("@out_note", null);

            dtac.open();
            dtac.ExcutCommand("mng_OutItem", para);
            dtac.close();
        }

        //Details
        public void mng_OutItem_details_A(int out_id,
            string pro_id,
            double out_pro_qty,
                                         //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@out_id", out_id);
            para[1] = new SqlParameter("@check", "a");
            para[2] = new SqlParameter("@pro_id", pro_id);
            para[3] = new SqlParameter("@out_pro_qty", out_pro_qty);
            //Created By & Created Date
            para[4] = new SqlParameter("@Created_By", Created_By);
            para[5] = new SqlParameter("@Created_Date", Created_Date);

            dtac.open();
            dtac.ExcutCommand("mng_OutItem_details", para);
            dtac.close();
        }
        public void mng_OutItem_details_U(double out_qty,
            string pro_id,
            string out_id,
                                         //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@oldout_pro_qty", out_qty);
            para[1] = new SqlParameter("@check", "u");
            para[2] = new SqlParameter("@pro_id", pro_id);
            para[3] = new SqlParameter("@out_pro_qty", 0);
            para[4] = new SqlParameter("@out_id", Convert.ToInt32(out_id));
            //Created By & Created Date
            para[5] = new SqlParameter("@Created_By", Created_By);
            para[6] = new SqlParameter("@Created_Date", Created_Date);

            dtac.open();
            dtac.ExcutCommand("mng_OutItem_details", para);
            dtac.close();
        }
        public void mng_OutItem_details_D(int out_id)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@out_id", out_id);
            para[1] = new SqlParameter("@check", "d");
            para[2] = new SqlParameter("@pro_id", "f");
            para[3] = new SqlParameter("@out_pro_qty", 0);

            dtac.open();
            dtac.ExcutCommand("mng_OutItem_details", para);
            dtac.close();
        }

        public DataTable ShowLuckPro(string pro_id)
        {
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pro_id", pro_id);

            dtac.open();
            dt = dtac.Selectdata("ShowLuckPro", para);
            dtac.close();
            return dt;
        }

        public void UpdateStat_OutItem(int out_id,string pro_id,int stat,double qty)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@out_id", out_id);
            para[1] = new SqlParameter("@stat", stat);
            para[2] = new SqlParameter("@pro_id", pro_id);
            para[3] = new SqlParameter("@newout_pro_qty", qty);

            dtac.open();
            dtac.ExcutCommand("UpdateStat_OutItem", para);
            dtac.close();
        }
    }
}
