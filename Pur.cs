using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class Pur
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        public DataTable RptInvDate(DateTime from, DateTime to, int rep_id, string Brn_Name)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@from_date", from);

            para[1] = new SqlParameter("@to_date", to);
            para[2] = new SqlParameter("@rep_id", rep_id);
            para[3] = new SqlParameter("@Brn_Name", Brn_Name);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("RptInvDate", para);
            dtac.close();
            return dt;
        }
        public DataTable NPPur(int inv_typ)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_typ", inv_typ);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("NPPur", para);
            dtac.close();
            return dt;
        }
        public DataTable searchReq(string val)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@val", val);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("searchReq", para);
            dtac.close();
            return dt;
        }
        public DataTable ShowReqDetails(int req_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@req_id", req_id);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowReqDetails", para);
            dtac.close();
            return dt;
        }
        public DataTable RptInvCus(int cus_id, DateTime from, DateTime to, int rep_id)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@cus_id", SqlDbType.Int);
            para[0].Value = cus_id;
            para[2] = new SqlParameter("@from_date", from);
            para[3] = new SqlParameter("@rep_id", rep_id);
            para[1] = new SqlParameter("@to_date", to);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("RptInvCus", para);
            dtac.close();
            return dt;
        }
        public DataTable RptInvSal(int sal_id, DateTime from, DateTime to, int rep_id)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@sal_id", sal_id);
            para[1] = new SqlParameter("@to_date", to);
            para[2] = new SqlParameter("@from_date", from);
            para[3] = new SqlParameter("@rep_id", rep_id);



            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("RptInvSal", para);
            dtac.close();
            return dt;
        }
        public void UpdateReqStat(int req_id, string req_note, string req_stat, int salesman_id)
        {

            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@req_id", req_id);

            para[1] = new SqlParameter("@req_stat", req_stat);
            para[2] = new SqlParameter("@req_note", req_note);
            para[3] = new SqlParameter("@salesman_id", salesman_id);

            para[4] = new SqlParameter("@check", "s");


            dtac.open();
            dtac.ExcutCommand("mng_req", para);
            dtac.close();

        }
        public void Del_req(int req_id)
        {

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@req_id", req_id);

            dtac.open();
            dtac.ExcutCommand("Del_mobileReq", para);
            dtac.close();

        }
        public DataTable RptInvTyp(int pur_type, DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@pur_type", SqlDbType.Int);
            para[0].Value = pur_type;
            para[2] = new SqlParameter("@from_date", from);

            para[1] = new SqlParameter("@to_date", to);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("RptInvTyp", para);
            dtac.close();
            return dt;
        }
        public DataTable RptInvPro(int pur_id, DateTime from, DateTime to, int rep_id)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@pur_id", SqlDbType.Int);
            para[0].Value = pur_id;
            para[2] = new SqlParameter("@from_date", from);
            para[3] = new SqlParameter("@rep_id", rep_id);
            para[1] = new SqlParameter("@to_date", to);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("RptInvPro", para);
            dtac.close();
            return dt;
        }
        public DataTable RptInvSelctedPro(string pro_id, DateTime from, DateTime to, int rep_id)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@pro_id", pro_id);

            para[2] = new SqlParameter("@from_date", from);

            para[1] = new SqlParameter("@to_date", to);
            para[3] = new SqlParameter("@rep_id", rep_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("RptInvSelctedPro", para);
            dtac.close();
            return dt;
        }
        public DataTable serch_pur(string vrb_serch, int Create_Invoice_Id/*pur_typ*/)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@vrb_serch", SqlDbType.VarChar, 50);
            para[0].Value = vrb_serch;
            para[1] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("serch_pur", para);
            dtac.close();
            return dt;
        }
        public DataTable Get_pur_id()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("pur_id", null);
            dtac.close();
            return dt;
        }
        public DataTable serch_pur_select()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("serch_pur_select", null);
            dtac.close();
            return dt;
        }
        public DataTable PurNotRecept(string supname)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@supname", supname);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("PurNotRecept", para);
            dtac.close();
            return dt;
        }

        public DataTable lastpur(int pur_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pur_id", SqlDbType.Int);
            para[0].Value = pur_id;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("lastpur", para);
            dtac.close();
            return dt;
        }
        public DataTable GetPurForRecept(int pur_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pur_id", SqlDbType.Int);
            para[0].Value = pur_id;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetPurForRecept", para);
            dtac.close();
            return dt;
        }



        public DataTable last2costofpur(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pro_id", pro_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("lastcost", para);
            dtac.close();
            return dt;
        }
        public DataTable top5propur(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pro_id", pro_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("top5propur", para);
            dtac.close();
            return dt;
        }

        public void addpur_data(int pur_id,
                                int pur_type,
                                DateTime pur_date,
                                int sup_id,
                                Decimal pur_TotalAddtionalCost,
                                Decimal pur_total,
                                Decimal pur_TotalQty,
                                Decimal pur_AfterDiscountTotal,
                                int pur_Currancy,
                                Decimal pur_totaldiscount,
                                Decimal Currancy_val,
                                string username,
                                string note,
                                string pur_conditions,
                                string pur_typ,
                                string pur_typename,
                                string Currancy_name,
                                Decimal vat_total,
                                Decimal vat_percent,
                                string cs_name,
                                Decimal inv_cst,
                                string inv_name,
                                Decimal inv_dis,
                                int sal_id,
                                string sal_name,
                                decimal pur_plusm,
                                decimal pur_plusp,
                                string pur_ref,
                                int Brn_Id,
                                int Qid_Id,
                                int Inv_Type_Id,
                                string Inv_Type,
                                string Brn_Name,
                                Decimal Paid,
                                Decimal restOf_Payment,
                                DateTime date_of_supply,
                                //Created By & Created Date
                                string Created_By,
                                DateTime Created_Date,
                                //---------------------
                                int Create_Invoice_Id,
                                string Cat_Invoice,
                                string Invoice_code,
                                string CheckVal,
                                int Warehouse_id,
                                string Warehouse,
                                 Decimal Commission_percent,
                                  Decimal Commission_Amount)
        {
            SqlParameter[] para = new SqlParameter[46];
            para[0] = new SqlParameter("@pur_id", Convert.ToInt32(pur_id));
            para[1] = new SqlParameter("@pur_type", Convert.ToInt32(pur_type));
            para[2] = new SqlParameter("@pur_date", pur_date);
            para[3] = new SqlParameter("@sup_id", sup_id);
            para[4] = new SqlParameter("@pur_TotalAddtionalCost", Convert.ToDecimal(pur_TotalAddtionalCost));
            para[5] = new SqlParameter("@pur_total", Convert.ToDecimal(pur_total));
            para[6] = new SqlParameter("@pur_TotalQty", Convert.ToDecimal(pur_TotalQty));
            para[7] = new SqlParameter("@pur_AfterDiscountTotal", Convert.ToDecimal(pur_AfterDiscountTotal));
            para[8] = new SqlParameter("@pur_Currancy", Convert.ToInt32(pur_Currancy));
            para[9] = new SqlParameter("@pur_totaldiscount", Convert.ToDecimal(pur_totaldiscount));
            para[10] = new SqlParameter("@Currancy_val", Convert.ToDecimal(Currancy_val));
            para[11] = new SqlParameter("@username", username);
            para[12] = new SqlParameter("@check", CheckVal);
            para[13] = new SqlParameter("@note", note);
            para[14] = new SqlParameter("@pur_conditions", pur_conditions);
            para[15] = new SqlParameter("@pur_typ", pur_typ);
            para[16] = new SqlParameter("@pur_typename", pur_typename);
            para[17] = new SqlParameter("@Currancy_name", Currancy_name);
            para[18] = new SqlParameter("@vat_total", vat_total);
            para[19] = new SqlParameter("@vat_percent", vat_percent);
            para[20] = new SqlParameter("@cs_name", cs_name);
            para[21] = new SqlParameter("@inv_cost", inv_cst);
            para[22] = new SqlParameter("@inv_name", inv_name);
            para[23] = new SqlParameter("@inv_dis", inv_dis);
            para[24] = new SqlParameter("@sal_id", sal_id);
            para[25] = new SqlParameter("@sal_name", sal_name);
            para[26] = new SqlParameter("@pur_plusm", pur_plusm);
            para[27] = new SqlParameter("@pur_plusp", pur_plusp);
            para[28] = new SqlParameter("@pur_ref", pur_ref);
            para[29] = new SqlParameter("@Brn_Id", Brn_Id);
            para[30] = new SqlParameter("@Qid_Id", Qid_Id);
            para[31] = new SqlParameter("@Inv_Type_Id", Inv_Type_Id);
            para[32] = new SqlParameter("@Inv_Type", Inv_Type);
            para[33] = new SqlParameter("@Brn_Name", Brn_Name);
            para[34] = new SqlParameter("@Paid", Paid);
            para[35] = new SqlParameter("@restOf_Payment", restOf_Payment);
            para[36] = new SqlParameter("@date_of_supply", date_of_supply);
            //Created By & Created Date
            para[37] = new SqlParameter("@Created_By", Created_By);
            para[38] = new SqlParameter("@Created_Date", Created_Date);
            //-------------
            para[39] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);
            para[40] = new SqlParameter("@Cat_Invoice", Cat_Invoice);
            para[41] = new SqlParameter("@Invoice_code", Invoice_code);
            para[42] = new SqlParameter("@Warehouse_id", Warehouse_id);
            para[43] = new SqlParameter("@Warehouse", Warehouse);
            para[44] = new SqlParameter("@Commission_percent", Commission_percent);
            para[45] = new SqlParameter("@Commission_Amount", Commission_Amount);
            dtac.open();
            dtac.ExcutCommand("mng_Pur", para);
            dtac.close();

        }
        public void Updatepur_data(int pur_id,
                                int pur_type,
                                DateTime pur_date,
                                int sup_id,
                                Decimal pur_TotalAddtionalCost,
                                Decimal pur_total,
                                Decimal pur_TotalQty,
                                Decimal pur_AfterDiscountTotal,
                                int pur_Currancy,
                                Decimal pur_totaldiscount,
                                Decimal Currancy_val,
                                string username,
                                string note,
                                string pur_conditions,
                                string pur_typename,
                                string Currancy_name,
                                Decimal vat_total,
                                Decimal vat_percent,
                                string cs_name,
                                Decimal inv_cst,
                                string inv_name,
                                Decimal inv_dis,
                                int sal_id,
                                string sal_name,
                                decimal pur_plusm,
                                decimal pur_plusp,
                                string pur_ref,
                                int Brn_Id,
                                int Qid_Id,
                                int Inv_Type_Id,
                                string Inv_Type,
                                string Brn_Name,
                                Decimal Paid,
                                Decimal restOf_Payment,
                                DateTime date_of_supply,
                                //Created By & Created Date
                                string Created_By,
                                DateTime Created_Date,
                                //---------------------
                                int Create_Invoice_Id,
                                string Cat_Invoice,
                                string Invoice_code,
                                int Warehouse_id,
                                string Warehouse,
                                       Decimal Commission_percent,
                                  Decimal Commission_Amount
                                          /*string pur_id,
                                          string pur_type,
                                          DateTime pur_date,
                                          int sup_id,
                                          string pur_TotalAddtionalCost,
                                          string pur_total,
                                          string pur_TotalQty,
                                          string pur_AfterDiscountTotal,
                                          string pur_Currancy,
                                          string pur_totaldiscount,
                                          string Currancy_val,
                                          string username,
                                          string note,
                                          string pur_conditions,
                                          string pur_typename,
                                          string Currancy_name,
                                          Decimal vat_total,
                                          Decimal vat_percent,
                                          string cs_name,
                                          Decimal inv_cst,
                                          string inv_name,
                                          Decimal inv_dis,
                                          int sal_id,
                                          string sal_name,
                                          decimal pur_plusm,
                                          decimal pur_plusp,
                                          string pur_ref,
                                          int Brn_Id,
                                          int Qid_Id,
                                          int Inv_Type_Id,
                                          string Inv_Type,
                                          string Brn_Name,
                                          Decimal Paid,
                                          Decimal restOf_Payment,
                                          DateTime date_of_supply,
                                          //Created By & Created Date
                                          string Created_By,
                                          DateTime Created_Date,
                                           //-------------------
                                           string Cat_Invoice,
                                           string Invoice_code*/)

        {
            SqlParameter[] para = new SqlParameter[45];
            para[0] = new SqlParameter("@pur_id", pur_id);
            para[1] = new SqlParameter("@pur_type", pur_type);
            para[2] = new SqlParameter("@pur_date", pur_date);
            para[3] = new SqlParameter("@sup_id", Convert.ToInt32(sup_id));
            para[4] = new SqlParameter("@pur_TotalAddtionalCost", Convert.ToDecimal(pur_TotalAddtionalCost));
            para[5] = new SqlParameter("@pur_total", Convert.ToDecimal(pur_total));
            para[6] = new SqlParameter("@pur_TotalQty", Convert.ToDecimal(pur_TotalQty));
            para[7] = new SqlParameter("@pur_AfterDiscountTotal", Convert.ToDecimal(pur_AfterDiscountTotal));
            para[8] = new SqlParameter("@pur_Currancy", pur_Currancy);
            para[9] = new SqlParameter("@pur_totaldiscount", Convert.ToDecimal(pur_totaldiscount));
            para[10] = new SqlParameter("@Currancy_val", Convert.ToDecimal(Currancy_val));
            para[11] = new SqlParameter("@username", username);
            para[12] = new SqlParameter("@check", "u");
            para[13] = new SqlParameter("@note", note);
            para[14] = new SqlParameter("@pur_conditions", pur_conditions);
            para[15] = new SqlParameter("@pur_typename", pur_typename);
            para[16] = new SqlParameter("@Currancy_name", Currancy_name);
            para[17] = new SqlParameter("@vat_total", vat_total);
            para[18] = new SqlParameter("@vat_percent", vat_percent);
            para[19] = new SqlParameter("@cs_name", cs_name);
            para[20] = new SqlParameter("@inv_cost", inv_cst);
            para[21] = new SqlParameter("@inv_name", inv_name);
            para[22] = new SqlParameter("@inv_dis", inv_dis);
            para[23] = new SqlParameter("@sal_id", sal_id);
            para[24] = new SqlParameter("@sal_name", sal_name);
            para[25] = new SqlParameter("@pur_plusm", pur_plusm);
            para[26] = new SqlParameter("@pur_plusp", pur_plusp);
            para[27] = new SqlParameter("@pur_ref", pur_ref);
            para[28] = new SqlParameter("@Brn_Id", Brn_Id);
            para[29] = new SqlParameter("@Qid_Id", Qid_Id);
            para[30] = new SqlParameter("@Inv_Type_Id", Inv_Type_Id);
            para[31] = new SqlParameter("@Inv_Type", Inv_Type);
            para[32] = new SqlParameter("@Brn_Name", Brn_Name);
            para[33] = new SqlParameter("@Paid", Paid);
            para[34] = new SqlParameter("@restOf_Payment", restOf_Payment);
            para[35] = new SqlParameter("@date_of_supply", date_of_supply);
            //Created By & Created Date
            para[36] = new SqlParameter("@Created_By", Created_By);
            para[37] = new SqlParameter("@Created_Date", Created_Date);
            //--------------------
            para[38] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);
            para[39] = new SqlParameter("@Cat_Invoice", Cat_Invoice);
            para[40] = new SqlParameter("@Invoice_code", Invoice_code);
            para[41] = new SqlParameter("@Warehouse_id", Warehouse_id);
            para[42] = new SqlParameter("@Warehouse", Warehouse);
            para[43] = new SqlParameter("@Commission_percent", Commission_percent);
            para[44] = new SqlParameter("@Commission_Amount", Commission_Amount);
            dtac.open();
            dtac.ExcutCommand("mng_Pur", para);
            dtac.close();

        }
        public void delPur_data(string pur_id,
            string pur_type,
            int sup_id,
            string pur_TotalAddtionalCost,
            string pur_total, string pur_TotalQty,
            string pur_AfterDiscountTotal, string pur_Currancy,
            string pur_totaldiscount, string Currancy_val,
            string username,
                                         //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[15];
            para[0] = new SqlParameter("@pur_id", Convert.ToInt32(pur_id));
            para[1] = new SqlParameter("@pur_type", pur_type);
            para[2] = new SqlParameter("@pur_date", "01/01/2000");
            para[3] = new SqlParameter("@sup_id", sup_id);
            para[4] = new SqlParameter("@pur_TotalAddtionalCost", Convert.ToDecimal(pur_TotalAddtionalCost));
            para[5] = new SqlParameter("@pur_total", Convert.ToDecimal(pur_total));
            para[6] = new SqlParameter("@pur_TotalQty", Convert.ToDecimal(pur_TotalQty));
            para[7] = new SqlParameter("@pur_AfterDiscountTotal", Convert.ToDecimal(pur_AfterDiscountTotal));
            para[8] = new SqlParameter("@pur_Currancy", pur_Currancy);
            para[9] = new SqlParameter("@pur_totaldiscount", Convert.ToDecimal(pur_totaldiscount));
            para[10] = new SqlParameter("@Currancy_val", Convert.ToDecimal(Currancy_val));
            para[11] = new SqlParameter("@username", username);
            //Created By & Created Date
            para[12] = new SqlParameter("@Created_By", Created_By);
            para[13] = new SqlParameter("@Created_Date", Created_Date);
            para[14] = new SqlParameter("@check", "d");

            dtac.open();
            dtac.ExcutCommand("mng_Pur", para);
            dtac.close();

        }








        // تفاصيل الفاتورة اضافة تعديل حذف

        public void Add_PurDetails(int pur_id,
                                   string pro_id,
                                   string pro_name,
                                   decimal pro_qty,
                                   string pro_Unit,
                                   string pro_Unit_Name,
                                   decimal pro_price,
                                   string pro_discount,
                                   string pro_additionalCost,
                                   decimal pro_total,
                                   string pur_typ,
                                   decimal pur_gift,
                                   decimal pur_perplus,
                                   decimal pur_permin,
                                   decimal pro_vat,
                                   decimal pro_cost,
                                   int wh_id,
                                   decimal Packaging,
                                   string Created_By,
                                   DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[21];
            para[0] = new SqlParameter("@pur_id", Convert.ToInt32(pur_id));
            para[1] = new SqlParameter("@pro_id", pro_id);
            para[2] = new SqlParameter("@pro_name", pro_name);
            para[3] = new SqlParameter("@pro_qty", Convert.ToDecimal(pro_qty));
            para[4] = new SqlParameter("@pro_Unit", pro_Unit);
            para[5] = new SqlParameter("@pro_Unit_Name", pro_Unit_Name);
            para[6] = new SqlParameter("@pro_price", Convert.ToDecimal(pro_price));
            para[7] = new SqlParameter("@pro_discount", Convert.ToDecimal(pro_discount));
            para[8] = new SqlParameter("@pro_additionalCost", Convert.ToDecimal(pro_additionalCost));
            para[9] = new SqlParameter("@pro_total", Convert.ToDecimal(pro_total));
            para[10] = new SqlParameter("@check", "a");
            para[11] = new SqlParameter("@pur_typ", pur_typ);
            para[12] = new SqlParameter("@pur_gift", pur_gift);
            para[13] = new SqlParameter("@pur_perplus", pur_perplus);
            para[14] = new SqlParameter("@pur_permin", pur_permin);
            para[15] = new SqlParameter("@wh_id", wh_id);
            para[16] = new SqlParameter("@Packaging", Packaging);
            para[17] = new SqlParameter("@pro_vat", pro_vat);
            //Created By & Created Date
            para[18] = new SqlParameter("@Created_By", Created_By);
            para[19] = new SqlParameter("@Created_Date", Created_Date);
            para[20] = new SqlParameter("@pro_cost", pro_cost);



            dtac.open();
            dtac.ExcutCommand("mng_PurDetails", para);
            dtac.close();

        }
        public void del_PurDetails(string pur_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pur_id", Convert.ToInt32(pur_id));

            dtac.open();
            dtac.ExcutCommand("del_PurDetails", para);
            dtac.close();

        }
        public void del_PurData(string pur_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pur_id", Convert.ToInt32(pur_id));

            dtac.open();
            dtac.ExcutCommand("del_PurData", para);
            dtac.close();

        }

        public void Delete_PurDetails_forup(int pur_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@pur_id", pur_id);
            para[0] = new SqlParameter("@check", "d");

            dtac.open();
            dtac.ExcutCommand("mng_PurDetails", para);
            dtac.close();

        }

        public void Delete_InvoDetails(int inv_id, string pro_id, int pro_qty)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;
            para[1] = new SqlParameter("@pro_id", SqlDbType.VarChar, 50);
            para[1].Value = pro_id;
            para[2] = new SqlParameter("@pro_qty", SqlDbType.Int);
            para[2].Value = pro_qty;
            dtac.open();
            dtac.ExcutCommand("Delete_InvoDetails", para);
            dtac.close();

        }

        //البحث في بيانات الفاتورة


        public DataTable GetDetialsPur(int pur_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pur_id", SqlDbType.Int);
            para[0].Value = pur_id;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetDetialsPur", para);
            dtac.close();
            return dt;
        }
        public DataTable getQty_detilis_Inv(int inv_id, string pro_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@inv_id", SqlDbType.Int);
            para[0].Value = inv_id;
            para[1] = new SqlParameter("@pro_id", SqlDbType.VarChar, 50);
            para[1].Value = pro_id;
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("getQty_detilis_Inv", para);
            dtac.close();
            return dt;
        }
        public DataTable GetDataPur(int pur_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pur_id", SqlDbType.Int);
            para[0].Value = pur_id;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetDataPur", para);
            dtac.close();
            return dt;
        }


        public DataTable Get_Number_Pur(string inv_name, int Brn_Id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@inv_name", inv_name);
            para[1] = new SqlParameter("@Brn_Id", Brn_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Number_Pur", para);
            dtac.close();
            return dt;
        }
        public DataTable Get_Number_Pur_Brn(string inv_name)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@inv_name", inv_name);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Number_Pur_Brn", para);
            dtac.close();
            return dt;
        }
        public DataTable RptInv( DateTime from, DateTime to,string Brn_Name, string inv_name, string sal_name, string pur_typename, int rep_id)
        {
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@from_date", from);
            para[1] = new SqlParameter("@to_date", to);
            para[2] = new SqlParameter("@Brn_Name", Brn_Name);
            para[3] = new SqlParameter("@inv_name", inv_name);
            para[4] = new SqlParameter("@sal_name", sal_name);
            para[5] = new SqlParameter("@pur_typename", pur_typename);
            para[6] = new SqlParameter("@rep_id", rep_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("RptInv", para);
            dtac.close();
            return dt;
        }

        public DataTable RptInvP(DateTime from_date,
                                 DateTime to_date,
                                 string cat_name,
                                 string pro_name,
                                 int rep_id)
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@from_date", from_date);
            para[1] = new SqlParameter("@to_date", to_date);
            para[2] = new SqlParameter("@cat_name", cat_name);
            para[3] = new SqlParameter("@pro_name", pro_name);
            para[4] = new SqlParameter("@rep_id", rep_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("RptInvP", para);
            dtac.close();
            return dt;
        }

        public DataTable RptWh(DateTime from,
                                DateTime to,
                                string pro_name,
                                string cat_name, 
                                int rep_id)
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@from_date", from);
            para[1] = new SqlParameter("@to_date", to);
            para[2] = new SqlParameter("@pro_name", pro_name);
            para[3] = new SqlParameter("@cat_name", cat_name);
            para[4] = new SqlParameter("@rep_id", rep_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("RptWh", para);
            dtac.close();
            return dt;
        }

        //Report_Where/SELECT para
        public DataTable ReportsInv_Forms(string where, string SELECT)
        {
            SqlParameter[] para = new SqlParameter[2];
             
            para[0] = new SqlParameter("@where", where);
            para[1] = new SqlParameter("@SELECT", SELECT);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ReportsInv_Forms", para);
            dtac.close();
            return dt;
        }

        //Report_Where/SELECT para
        public DataTable RptInvProCat(string where, string SELECT)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@where", where);
            para[1] = new SqlParameter("@SELECT", SELECT);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("RptInvProCat", para);
            dtac.close();
            return dt;
        }

        public DataTable Test(string SELECT)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@SELECT", SELECT);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Test", para);
            dtac.close();
            return dt;
        }
    }
}
