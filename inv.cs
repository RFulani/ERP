using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace INV.Code
{
    class inv
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public DataTable inv_id()
        {
            
            DataTable dt = new DataTable();
            dtac.open();
            dt=dtac.Selectdata("inv_id",null);
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
        public DataTable inv_Show_detilis(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("inv_Show_detilis", para);
            dtac.close();
            return dt;
        }
        public DataTable last_inv()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("last_inv", null);
            dtac.close();
            return dt;
        }
        public void addinv_data(int inv_id,
            DateTime inv_date,
            string inv_type,
            int cus_id,
            int sals_man,
            string note,
            string total_a,
            string total_b,
            string total_dis,
            string total_qty,
            int inv_Currency,
            string contract_num,
            int offer_id,
            string last_dis_num,
            string proj_name,
            int inv_typ,
            string Currency_val,
            string Amount_paid,
            string Amount_remaining,
            string total_vat,
            string vat_stat,
            int typ_index,
            string Currency_name,
            string sal_name,
            string inv_cus,
            //Created By & Created Date
             string Created_By,
             DateTime Created_Date
)
        {
            SqlParameter[] para = new SqlParameter[28];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;
            para[1] = new SqlParameter("@inv_date", SqlDbType.DateTime);
            para[1].Value = inv_date;
            para[2] = new SqlParameter("@inv_type", inv_type);
            
            para[3] = new SqlParameter("@cus_id", SqlDbType.Int);
            para[3].Value = cus_id;
            para[4] = new SqlParameter("@inv_sales", SqlDbType.Int) ;
            para[4].Value = sals_man;
            para[5] = new SqlParameter("@inv_note", SqlDbType.NVarChar,500);
            para[5].Value = note;
            para[6] = new SqlParameter("@check", SqlDbType.Char,1);
            para[6].Value = "a";

            para[7] = new SqlParameter("@total_a", SqlDbType.NChar, 20);
            para[7].Value = total_a;
            para[8] = new SqlParameter("@total_b", SqlDbType.NChar, 20);
            para[8].Value = total_b;
            para[9] = new SqlParameter("@total_dis", SqlDbType.NChar, 20);
            para[9].Value = total_dis;
            para[10] = new SqlParameter("@total_qty", SqlDbType.NChar, 20);
            para[10].Value = total_qty;
            para[11] = new SqlParameter("@inv_Currency", inv_Currency);
         
            para[12] = new SqlParameter("@Contract_num", SqlDbType.NVarChar, 30);
            para[12].Value = contract_num;
            para[13] = new SqlParameter("@offer_id", SqlDbType.Int);
            para[13].Value = offer_id;
            para[14] = new SqlParameter("@last_dis_num", SqlDbType.NChar, 10);
            para[14].Value = last_dis_num;
            para[15] = new SqlParameter("@proj_name", SqlDbType.NVarChar, 50);
            para[15].Value = proj_name;
            para[16] = new SqlParameter("@inv_typ", inv_typ);
            para[17] = new SqlParameter("@Currency_val", Convert.ToDouble(Currency_val));
            para[18] = new SqlParameter("@Amount_paid", Convert.ToDouble(Amount_paid));
            para[19] = new SqlParameter("@Amount_remaining", Convert.ToDouble(Amount_remaining));
            para[20] = new SqlParameter("@total_vat", Convert.ToDouble(total_vat));
            para[21] = new SqlParameter("@vat_stat", vat_stat);
            para[22] = new SqlParameter("@typ_index", typ_index);
            para[23] = new SqlParameter("@Currency_name", Currency_name);
            para[24] = new SqlParameter("@sal_name", sal_name);
            para[25] = new SqlParameter("@inv_cus", inv_cus);
            para[26] = new SqlParameter("@Created_By", Created_By);
            para[27] = new SqlParameter("@Created_Date", Created_Date);

            dtac.open();
            dtac.ExcutCommand("inv_data", para);
            dtac.close();
            
        }
        public void updateinv_data(int inv_id, string inv_date,
            string inv_type, int cus_id, int sals_man,
            string note, string total_a, string total_b,
            string total_dis, string total_qty,int inv_Currency,
            string contract_num, string last_dis_num,string proj_name,
            int inv_typ, string Currency_val, string Amount_paid,
            string Amount_remaining, string total_vat, string vat_stat,
            int typ_index, string Currency_name,string sal_name,
            string inv_cus,
             //Created By & Created Date
             string Created_By,
             DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[27];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;
            para[1] = new SqlParameter("@inv_date", SqlDbType.NVarChar,20);
            para[1].Value = inv_date;
            para[2] = new SqlParameter("@inv_type", inv_type);
            
            para[3] = new SqlParameter("@cus_id", SqlDbType.Int);
            para[3].Value = cus_id;
            para[4] = new SqlParameter("@inv_sales", SqlDbType.Int);
            para[4].Value = sals_man;
            para[5] = new SqlParameter("@inv_note", SqlDbType.NVarChar, 500);
            para[5].Value = note;
            para[6] = new SqlParameter("@check", SqlDbType.Char,1);
            para[6].Value = "u";

            para[7] = new SqlParameter("@total_a", SqlDbType.NChar, 20);
            para[7].Value = total_a;
            para[8] = new SqlParameter("@total_b", SqlDbType.NChar, 20);
            para[8].Value = total_b;
            para[9] = new SqlParameter("@total_dis", SqlDbType.NChar, 20);
            para[9].Value = total_dis;
            para[10] = new SqlParameter("@total_qty", SqlDbType.NChar, 20);
            para[10].Value = total_qty;
            para[11] = new SqlParameter("@inv_Currency", inv_Currency);
            
            para[12] = new SqlParameter("@Contract_num", SqlDbType.NVarChar, 30);
            para[12].Value = contract_num;
            para[13] = new SqlParameter("@last_dis_num", SqlDbType.NChar, 10);
            para[13].Value = last_dis_num;
            para[14] = new SqlParameter("@proj_name", SqlDbType.NVarChar, 50);
            para[14].Value = proj_name;
            para[15] = new SqlParameter("@inv_typ", inv_typ);
            para[16] = new SqlParameter("@Currency_val", Convert.ToDouble(Currency_val));
            para[17] = new SqlParameter("@Amount_paid", Convert.ToDouble(Amount_paid));
            para[18] = new SqlParameter("@Amount_remaining", Convert.ToDouble(Amount_remaining));
            para[19] = new SqlParameter("@total_vat", Convert.ToDouble(total_vat));
            para[20] = new SqlParameter("@vat_stat", vat_stat);
            para[21] = new SqlParameter("@typ_index", typ_index);
            para[22] = new SqlParameter("@Currency_name", Currency_name);
            para[23] = new SqlParameter("@sal_name", sal_name);
            para[24] = new SqlParameter("@inv_cus", inv_cus);
            para[25] = new SqlParameter("@Created_By", Created_By);
            para[26] = new SqlParameter("@Created_Date", Created_Date);

            dtac.open();
            dtac.ExcutCommand("inv_data", para);
            dtac.close();

        }
        public void delinv_data(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;
           
            para[1] = new SqlParameter("@check", SqlDbType.Char,1);
            para[1].Value = "d";
            dtac.open();
            dtac.ExcutCommand("inv_data", para);
            dtac.close();

        }

        // تفاصيل الفاتورة اضافة تعديل حذف

        public void Add_InvoDetails(int inv_id, string pro_id, string pro_name, int pro_qty , string pro_price, string pro_descont,string pro_total,int inv_typ,string pro_vat,int pro_gift)
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;
            para[1] = new SqlParameter("@pro_id", SqlDbType.VarChar,20);
            para[1].Value = pro_id;
            para[2] = new SqlParameter("@pro_name", SqlDbType.NVarChar, 50);
            para[2].Value = pro_name;
            para[3] = new SqlParameter("@pro_qty", SqlDbType.Int);
            para[3].Value = pro_qty;
            para[4] = new SqlParameter("@pro_price", SqlDbType.VarChar, 50);
            para[4].Value = pro_price;
            para[5] = new SqlParameter("@pro_descont", SqlDbType.VarChar, 50);
            para[5].Value = pro_descont;
            para[6] = new SqlParameter("@pro_total", SqlDbType.VarChar,50);
            para[6].Value = pro_total;
            para[7] = new SqlParameter("@inv_typ", inv_typ);
            para[8] = new SqlParameter("@pro_vat", Convert.ToDouble(pro_vat));
            para[9] = new SqlParameter("@pro_gift", pro_gift);
            dtac.open();
            dtac.ExcutCommand("Add_InvoDetails", para);
            dtac.close();

        }
        public void Delete_InvoDetails_forup(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;
            

            dtac.open();
            dtac.ExcutCommand("Delete_InvoDetails_forup", para);
            dtac.close();

        }
        public void ReQtyToPro(string pro_id,double pro_qty,int inv_typ,int pro_gift,int wh_id)
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@pro_id", pro_id);
            para[1] = new SqlParameter("@pro_qty", pro_qty);
            para[2] = new SqlParameter("@typ", inv_typ);
            para[3] = new SqlParameter("@pro_gift", pro_gift);
            para[4] = new SqlParameter("@wh_id", wh_id);


            dtac.open();
            dtac.ExcutCommand("ReQtyToPro", para);
            dtac.close();

        }

        public void Delete_InvoDetails(int inv_id,string pro_id,int pro_qty)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;
            para[1] = new SqlParameter("@pro_id", SqlDbType.VarChar,50);
            para[1].Value = pro_id;
            para[2] = new SqlParameter("@pro_qty", SqlDbType.Int);
            para[2].Value = pro_qty;
            dtac.open();
            dtac.ExcutCommand("Delete_InvoDetails", para);
            dtac.close();

        }
        public DataTable check_id_inv(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", inv_id);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("check_id_inv", para);
            dtac.close();
            return dt;

        }
        //البحث في بيانات الفاتورة

        public DataTable inv_Search(string inv_id , string cus_name , string inv_date,string check)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@inv_id", SqlDbType.NVarChar,20);
            para[0].Value = inv_id;
            para[1] = new SqlParameter("@cus_name", SqlDbType.NVarChar, 50);
            para[1].Value = cus_name;
            para[2] = new SqlParameter("@inv_date", SqlDbType.NVarChar, 0);
            para[2].Value = inv_date;
            para[3] = new SqlParameter("@check", SqlDbType.NChar,1);
            para[3].Value = check;
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("serchInv", para);
            dtac.close();
            return dt;
        }
        public DataTable serch_Inv(string vrb_serch,int inv_typ)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@vrb_serch", SqlDbType.VarChar, 50);
            para[0].Value = vrb_serch;
            para[1] = new SqlParameter("@inv_typ", inv_typ);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("serch_Inv", para);
            dtac.close();
            return dt;
        }
        public DataTable getdetilis_Inv(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("getdetialsinv", para);
            dtac.close();
            return dt;
        }
        public DataTable GetQtyAndProIdOfInv(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetQtyAndProIdOfInv", para);
            dtac.close();
            return dt;
        }
        public DataTable getQty_detilis_Inv(int inv_id,string pro_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;
            para[1] = new SqlParameter("@pro_id", SqlDbType.VarChar,50);
            para[1].Value = pro_id;
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("getQty_detilis_Inv", para);
            dtac.close();
            return dt;
        }
        public DataTable getdata_Inv(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("getdatainv", para);
            dtac.close();
            return dt;
        }
        public DataTable SearchUser_pur(string searchUser)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@searchUser", searchUser);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchUser_pur", para);
            dtac.close();
            return dt;
        }

    }
    
}
