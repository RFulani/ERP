using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class Class_offer
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public DataTable offer_id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("offer_id", null);
            dtac.close();
            return dt;
        }
        public DataTable offer_update_num(int offer_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@offer_id", SqlDbType.Int);
            para[0].Value = offer_id;
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("offer_update_num", para);
            dtac.close();
            return dt;
        }
        public DataTable inv_detilis()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("inv_detilis", null);
            dtac.close();
            return dt;
        }
        public DataTable offer_Show_detilis(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("offer_Show_detilis", para);
            dtac.close();
            return dt;
        }
        public DataTable GetReplayCus(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetReplayCus", para);
            dtac.close();
            return dt;
        }
        public DataTable last_offer()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("last_offer", null);
            dtac.close();
            return dt;
        }
        public void addoffer_data(int inv_id, DateTime inv_date, string inv_type, int cus_id, int sals_man, string note, string total_a, string total_b, string total_dis, string total_qty, string inv_Currency, string last_dis_num,int offer_update_num,string proj_name,string note01,decimal trans_val)
        {
            SqlParameter[] para = new SqlParameter[17];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;
            para[1] = new SqlParameter("@inv_date", SqlDbType.DateTime);
            para[1].Value = inv_date;
            para[2] = new SqlParameter("@inv_type", SqlDbType.Char, 10);
            para[2].Value = inv_type;
            para[3] = new SqlParameter("@cus_id", SqlDbType.Int);
            para[3].Value = cus_id;
            para[4] = new SqlParameter("@inv_sales", SqlDbType.Int);
            para[4].Value = sals_man;
            para[5] = new SqlParameter("@inv_note", SqlDbType.NVarChar, 500);
            para[5].Value = note;
            para[6] = new SqlParameter("@check", SqlDbType.Char, 1);
            para[6].Value = "a";

            para[7] = new SqlParameter("@total_a", SqlDbType.NChar, 20);
            para[7].Value = total_a;
            para[8] = new SqlParameter("@total_b", SqlDbType.NChar, 20);
            para[8].Value = total_b;
            para[9] = new SqlParameter("@total_dis", SqlDbType.NChar, 20);
            para[9].Value = total_dis;
            para[10] = new SqlParameter("@total_qty", SqlDbType.NChar, 20);
            para[10].Value = total_qty;
            para[11] = new SqlParameter("@inv_Currency", SqlDbType.NChar, 20);
            para[11].Value = inv_Currency;
            para[12] = new SqlParameter("@last_dis_num", SqlDbType.NChar, 10);
            para[12].Value = last_dis_num;
            para[13] = new SqlParameter("@offer_update_num", SqlDbType.Int);
            para[13].Value = offer_update_num;
            para[14] = new SqlParameter("@proj_name", SqlDbType.NVarChar, 200);
            para[14].Value = proj_name;
            para[15] = new SqlParameter("@inv_note01", note01);
            para[16] = new SqlParameter("@trans_val", trans_val);
            dtac.open();
            dtac.ExcutCommand("offer_data", para);
            dtac.close();

        }
        public void updateoffer_data(int inv_id, DateTime inv_date, string inv_type, int cus_id, int sals_man, string note, string total_a, string total_b, string total_dis, string total_qty, string inv_Currency, string last_dis_num, int offer_update_num, string proj_name, string note01, decimal trans_val)
        {
            SqlParameter[] para = new SqlParameter[17];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;
            para[1] = new SqlParameter("@inv_date", SqlDbType.DateTime);
            para[1].Value = inv_date;
            para[2] = new SqlParameter("@inv_type", SqlDbType.Char, 10);
            para[2].Value = inv_type;
            para[3] = new SqlParameter("@cus_id", SqlDbType.Int);
            para[3].Value = cus_id;
            para[4] = new SqlParameter("@inv_sales", SqlDbType.Int);
            para[4].Value = sals_man;
            para[5] = new SqlParameter("@inv_note", SqlDbType.NVarChar, 500);
            para[5].Value = note;
            para[6] = new SqlParameter("@check", SqlDbType.Char, 1);
            para[6].Value = "u";

            para[7] = new SqlParameter("@total_a", SqlDbType.NChar, 20);
            para[7].Value = total_a;
            para[8] = new SqlParameter("@total_b", SqlDbType.NChar, 20);
            para[8].Value = total_b;
            para[9] = new SqlParameter("@total_dis", SqlDbType.NChar, 20);
            para[9].Value = total_dis;
            para[10] = new SqlParameter("@total_qty", SqlDbType.NChar, 20);
            para[10].Value = total_qty;
            para[11] = new SqlParameter("@inv_Currency", SqlDbType.NChar, 20);
            para[11].Value = inv_Currency;
            para[12] = new SqlParameter("@last_dis_num", SqlDbType.NChar, 10);
            para[12].Value = last_dis_num;
            para[13] = new SqlParameter("@offer_update_num", SqlDbType.Int);
            para[13].Value = offer_update_num;
            para[14] = new SqlParameter("@proj_name", SqlDbType.NVarChar, 200);
            para[14].Value = proj_name;
            para[15] = new SqlParameter("@inv_note01", note01);
            para[16] = new SqlParameter("@trans_val", trans_val);
            dtac.open();
            dtac.ExcutCommand("offer_data", para);
            dtac.close();

        }
        public void deloffer_data(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;

            para[1] = new SqlParameter("@check", SqlDbType.Char, 1);
            para[1].Value = "d";
            dtac.open();
            dtac.ExcutCommand("offer_data", para);
            dtac.close();

        }
        public void ADD_replayOffer(string inv_id, DateTime replay_date, string offer_replay)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@inv_id", Convert.ToInt32(inv_id));
            
            para[1] = new SqlParameter("@offer_replay", offer_replay);
            
            para[2] = new SqlParameter("@replay_date", replay_date);
           
            dtac.open();
            dtac.ExcutCommand("ADD_replayOffer", para);
            dtac.close();

        }

        // تفاصيل الفاتورة اضافة تعديل حذف

        public void Add_offer_Details(int inv_id, string pro_id, string pro_name, int pro_qty, string pro_price, string pro_descont, string pro_total, string sort)
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;
            para[1] = new SqlParameter("@pro_id", SqlDbType.VarChar, 20);
            para[1].Value = pro_id;
            para[2] = new SqlParameter("@pro_name", SqlDbType.NVarChar, 50);
            para[2].Value = pro_name;
            para[3] = new SqlParameter("@pro_qty", SqlDbType.Int);
            para[3].Value = pro_qty;
            para[4] = new SqlParameter("@pro_price", SqlDbType.VarChar, 50);
            para[4].Value = pro_price;
            para[5] = new SqlParameter("@pro_descont", SqlDbType.VarChar, 50);
            para[5].Value = pro_descont;
            para[6] = new SqlParameter("@pro_total", SqlDbType.VarChar, 50);
            para[6].Value = pro_total;
            para[7] = new SqlParameter("@offer_sort", SqlDbType.NChar, 10);
            para[7].Value = sort;

            dtac.open();
            dtac.ExcutCommand("Add_offer_Details", para);
            dtac.close();

        }

        public void Delete_offer_Details(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;

            dtac.open();
            dtac.ExcutCommand("Delete_offer_Details", para);
            dtac.close();

        }

        //البحث في بيانات الفاتورة

        public DataTable serch_offer(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", SqlDbType.VarChar, 50);
            para[0].Value = vrb_serch;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("serch_offer", para);
            dtac.close();
            return dt;
        }
        public DataTable getdetialsoffer(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("getdetialsoffer", para);
            dtac.close();
            return dt;
        }
        public DataTable getQty_detilis_offer(int inv_id, string pro_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;
            para[1] = new SqlParameter("@pro_id", SqlDbType.VarChar, 50);
            para[1].Value = pro_id;
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("getQty_detilis_offer", para);
            dtac.close();
            return dt;
        }
        public DataTable getdataoffer(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("getdataoffer", para);
            dtac.close();
            return dt;
        }
        public DataTable checkoffer_ininv(int offer_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@offer_id", SqlDbType.Int);
            para[0].Value = offer_id;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("checkoffer_ininv", para);
            dtac.close();
            return dt;
        }
        public DataTable Search_date_offer(string from,string to)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@from_date", from);
            para[1] = new SqlParameter("@to_date", to);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Search_date_offer", para);
            dtac.close();
            return dt;
        }
        
            public DataTable Search_Offer_sal(string from, string to,int sal)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@from_date", from);
            para[1] = new SqlParameter("@to_date", to);
            para[2] = new SqlParameter("@sal_id", sal);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Search_Offer_sal", para);
            dtac.close();
            return dt;
        }
    }
}
