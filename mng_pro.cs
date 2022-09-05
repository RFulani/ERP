using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace INV.Code
{
    class mng_pro
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void Add_QtyItems(int wh_id,
                               string pro_id,
                               decimal itm_qty,
                               decimal itm_qtyreserved,
                               decimal itm_minqty,
                               decimal itm_reqqty,
                               string itm_unit,
                               int itm_stat,
                               string checkproc
            //Created By & Created Date
            , string Created_By
            , DateTime Created_Date
                               )
        {
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@wh_id", wh_id);
            para[1] = new SqlParameter("@pro_id", pro_id);
            para[2] = new SqlParameter("@itm_qty", itm_qty);
            para[3] = new SqlParameter("@itm_qtyreserved", itm_qtyreserved);
            para[4] = new SqlParameter("@itm_minqty", itm_minqty);
            para[5] = new SqlParameter("@itm_reqqty", itm_reqqty);
            para[6] = new SqlParameter("@itm_unit", "p");
            para[7] = new SqlParameter("@itm_stat", 0);
            //Created By & Created Date
            para[8] = new SqlParameter("@Created_By", Properties.Settings.Default.user_name);
            para[9] = new SqlParameter("@Created_Date", DateTime.Now);

            para[10] = new SqlParameter("@check", checkproc);
            dtac.open();
            dtac.ExcutCommand("Add_QtyItems", para);
            dtac.close();
        }
        public void Cut_QtyItems(int wh_id,
                               string pro_id,
                               decimal itm_qty,
                               decimal itm_qtyreserved,
                               decimal itm_minqty,
                               decimal itm_reqqty,
                               string itm_unit,
                               int itm_stat

                               )
        {
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@wh_id", wh_id);
            para[1] = new SqlParameter("@pro_id", pro_id);
            para[2] = new SqlParameter("@itm_qty", itm_qty);
            para[3] = new SqlParameter("@itm_qtyreserved", itm_qtyreserved);
            para[4] = new SqlParameter("@itm_minqty", itm_minqty);
            para[5] = new SqlParameter("@itm_reqqty", itm_reqqty);
            para[6] = new SqlParameter("@itm_unit", "Pcs");
            para[7] = new SqlParameter("@itm_stat", 0);
            para[8] = new SqlParameter("@check", "d");
            para[9] = new SqlParameter("@Created_By", Properties.Settings.Default.user_name);
            para[10] = new SqlParameter("@Created_Date", DateTime.Now);
            dtac.open();
            dtac.ExcutCommand("Add_QtyItems", para);
            dtac.close();
        }
        public void addprushor(
                               int pro_stat,
                               string pro_id,
                               string name,
                               double cost,
                               double pro_percent,
                               double pro_price,
                               string note,
                               string pro_comp,
                               string pro_des,
                               int pro_new,
                               int pro_qty,
                               DateTime ex_date,
                              int cat_id,
                              int pro_load
                               //Created By & Created Date


                               )
        {
            SqlParameter[] para = new SqlParameter[17];
            para[0] = new SqlParameter("@pro_stat", pro_stat);
            para[1] = new SqlParameter("@pro_id", pro_id);
            para[2] = new SqlParameter("@name", name);
            para[3] = new SqlParameter("@cost", cost);
            para[4] = new SqlParameter("@pro_percent", pro_percent);
            para[5] = new SqlParameter("@pro_price", pro_price);
            para[6] = new SqlParameter("@note", note);
            para[7] = new SqlParameter("@pro_comp", pro_comp);
            para[8] = new SqlParameter("@pro_des", pro_des);
            para[9] = new SqlParameter("@pro_new", pro_new);
            para[10] = new SqlParameter("@check", "a");
            para[11] = new SqlParameter("@pro_qty", pro_qty);
            para[12] = new SqlParameter("@ex_date", ex_date);
            para[13] = new SqlParameter("@cat_id", cat_id);
            para[14] = new SqlParameter("@pro_load", pro_load);
            //Created By & Created Date
            para[15] = new SqlParameter("@Created_By", Properties.Settings.Default.user_name);
            para[16] = new SqlParameter("@Created_Date", DateTime.Now);


            dtac.open();
            dtac.ExcutCommand("mng_prushor", para);
            dtac.close();
        }
        public void ActivelNewProshor(string pro_id, int pro_new)

        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@pro_id", pro_id);
            para[1] = new SqlParameter("@pro_new", pro_new);

            dtac.open();
            dtac.ExcutCommand("ActivelNewProshor", para);
            dtac.close();
        }
        public void CancelNewProshAll()

        {

            dtac.open();
            dtac.ExcutCommand("CancelNewProshAll", null);
            dtac.close();
        }
        public void CancelNewProsh(string pro_id)

        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@pro_id", pro_id);


            dtac.open();
            dtac.ExcutCommand("CancelNewProsh", para);
            dtac.close();
        }
        //اضافة منج
        public void addpro(string pro_id,
                           string pro_name,
                           decimal pro_qty,
                           decimal pro_price,
                           string pro_date,
                           decimal pro_cost,
                           string pro_unit,
                           int cat_id,
                           decimal pro_price2,
                           string pro_type,
                           byte[] img,
                           string pro_code,
                           string pro_des,
                           decimal lastcost,
                           decimal avgcost,
                           string username,
                           decimal othercost,
                           decimal pro_priceL,
                           decimal pro_pricH,
                           string ex_date,
                           int new_pro,
                           int proshor,
                           int pro_offer,
                           int pro_gift,
                           decimal net_cost,
                           decimal precent_Add,
                           decimal precent_discount,
                           decimal VAT,
                           decimal Length,
                           decimal Width,
                           decimal Depth,
                           decimal Weight,
                           string mold_id,
                           decimal pro_Length,
                           decimal pro_Width,
                            decimal pro_thickness,
                            string pro_StorgeArea,
                            string proName_Eng,
                            string cat_Name,
                            int pro_no,
                           decimal pro_price3,
                          //Created By & Created Date
                          string Created_By,
                          DateTime Created_Date,
                         int pro_type_id,
                         string reference_No)
        {
            SqlParameter[] para = new SqlParameter[46];
            para[0] = new SqlParameter("@pro_id", SqlDbType.VarChar, 50);
            para[0].Value = pro_id;
            para[1] = new SqlParameter("@check", SqlDbType.NChar, 1);
            para[1].Value = "a";
            para[2] = new SqlParameter("@pro_name", SqlDbType.NVarChar, 50);
            para[2].Value = pro_name;
            para[3] = new SqlParameter("@pro_qty", SqlDbType.Decimal);
            para[3].Value = pro_qty;
            para[4] = new SqlParameter("@pro_price", SqlDbType.Decimal);
            para[4].Value = pro_price;
            para[5] = new SqlParameter("@pro_date", SqlDbType.NChar, 10);
            para[5].Value = pro_date;
            para[6] = new SqlParameter("@pro_cost", SqlDbType.Decimal);
            para[6].Value = pro_cost;
            para[7] = new SqlParameter("@pro_unit", SqlDbType.VarChar, 50);
            para[7].Value = pro_unit;
            para[8] = new SqlParameter("@cat_id", SqlDbType.Int);
            para[8].Value = cat_id;
            para[9] = new SqlParameter("@pro_price2", SqlDbType.Decimal);
            para[9].Value = pro_price2;
            para[10] = new SqlParameter("@pro_type", SqlDbType.NChar, 5);
            para[10].Value = pro_type;
            para[11] = new SqlParameter("@pro_img", SqlDbType.Image);
            para[11].Value = img;
            para[12] = new SqlParameter("@pro_code", SqlDbType.NVarChar, 50);
            para[12].Value = pro_code;
            para[13] = new SqlParameter("@pro_des", SqlDbType.NVarChar, 2000);
            para[13].Value = pro_des;
            para[14] = new SqlParameter("@pro_lastcost", Convert.ToDecimal(lastcost));
            para[15] = new SqlParameter("@pro_avgcost", Convert.ToDecimal(avgcost));
            para[16] = new SqlParameter("@username", username);
            para[17] = new SqlParameter("@pro_othercost", Convert.ToDecimal(othercost));
            para[18] = new SqlParameter("@pro_priceL", Convert.ToDecimal(pro_priceL));
            para[19] = new SqlParameter("@pro_priceH", Convert.ToDecimal(pro_pricH));
            para[20] = new SqlParameter("@ex_date", ex_date);
            para[21] = new SqlParameter("@new_pro", new_pro);
            para[22] = new SqlParameter("@proshor", proshor);
            para[23] = new SqlParameter("@pro_offer", pro_offer);
            para[24] = new SqlParameter("@pro_gift", pro_gift);
            para[25] = new SqlParameter("@net_cost", net_cost);
            para[26] = new SqlParameter("@precent_Add", precent_Add);
            para[27] = new SqlParameter("@precent_discount", precent_discount);
            para[28] = new SqlParameter("@VAT", VAT);
            para[29] = new SqlParameter("@Length", Length);
            para[30] = new SqlParameter("@Width", Width);
            para[31] = new SqlParameter("@Depth", Depth);
            para[32] = new SqlParameter("@Weight", Weight);
            para[33] = new SqlParameter("@mold_id", mold_id);
            para[34] = new SqlParameter("@pro_Length", pro_Length);
            para[35] = new SqlParameter("@pro_Width", pro_Width);
            para[36] = new SqlParameter("@pro_thickness", pro_thickness);
            para[37] = new SqlParameter("@pro_StorgeArea", pro_StorgeArea);
            para[38] = new SqlParameter("@proName_Eng", SqlDbType.NVarChar, 100);
            para[38].Value = proName_Eng;
            para[39] = new SqlParameter("@cat_Name", SqlDbType.NVarChar, 100);
            para[39].Value = cat_Name;
            para[40] = new SqlParameter("@pro_no", SqlDbType.NVarChar, 100);
            para[40].Value = pro_no;
            para[41] = new SqlParameter("@pro_price3", pro_price3);
            //Created By & Created Date
            para[42] = new SqlParameter("@Created_By", Created_By);
            para[43] = new SqlParameter("@Created_Date", Created_Date);
            //-*-*-*-*-*-
            para[44] = new SqlParameter("@pro_type_id", pro_type_id);
            para[45] = new SqlParameter("@reference_No", reference_No);

            dtac.open();
            dtac.ExcutCommand("AddDelUpdat_pro", para);
            dtac.close();
        }
        //تعديل منج  
        public void updpro(
                            string pro_id,
                           string pro_name,
                           decimal pro_qty,
                           decimal pro_price,
                           string pro_date,
                           decimal pro_cost,
                           string pro_unit,
                           int cat_id,
                           decimal pro_price2,
                           string pro_type,
                           byte[] img,
                           string pro_code,
                           string pro_des,
                           decimal lastcost,
                           decimal avgcost,
                           string username,
                           decimal othercost,
                           decimal pro_priceL,
                           decimal pro_pricH,
                           string ex_date,
                           int new_pro,
                           int proshor,
                           int pro_offer,
                           int pro_gift,
                           decimal net_cost,
                           decimal precent_Add,
                           decimal precent_discount,
                           decimal VAT,
                           decimal Length,
                           decimal Width,
                           decimal Depth,
                           decimal Weight,
                           string mold_id,
                           decimal pro_Length,
                           decimal pro_Width,
                            decimal pro_thickness,
                            string pro_StorgeArea,
                            string proName_Eng,
                            string cat_Name,
                            int pro_no,
                           decimal pro_price3,
                          //Created By & Created Date
                          string Created_By,
                          DateTime Created_Date,
                          int pro_type_id,
                          string @oldpro_id,
                          string reference_No)
        {
            SqlParameter[] para = new SqlParameter[47];
            para[0] = new SqlParameter("@pro_id", SqlDbType.VarChar, 50);
            para[0].Value = pro_id;
            para[1] = new SqlParameter("@check", SqlDbType.NChar, 1);
            para[1].Value = "u";
            para[2] = new SqlParameter("@pro_name", SqlDbType.NVarChar, 50);
            para[2].Value = pro_name;
            para[3] = new SqlParameter("@pro_qty", SqlDbType.NChar, 10);
            para[3].Value = pro_qty;
            para[4] = new SqlParameter("@pro_price", SqlDbType.NChar, 10);
            para[4].Value = pro_price;
            para[5] = new SqlParameter("@pro_date", SqlDbType.NChar, 10);
            para[5].Value = pro_date;
            para[6] = new SqlParameter("@pro_cost", SqlDbType.NChar, 10);
            para[6].Value = pro_cost;
            para[7] = new SqlParameter("@pro_unit", SqlDbType.VarChar, 50);
            para[7].Value = pro_unit;
            para[8] = new SqlParameter("@cat_id", SqlDbType.Int);
            para[8].Value = cat_id;
            para[9] = new SqlParameter("@pro_price2", SqlDbType.NVarChar, 100);
            para[9].Value = pro_price2;
            para[10] = new SqlParameter("@pro_type", SqlDbType.NChar, 5);
            para[10].Value = pro_type;
            para[11] = new SqlParameter("@pro_img", SqlDbType.Image);
            para[11].Value = img;
            para[12] = new SqlParameter("@pro_code", SqlDbType.NVarChar, 50);
            para[12].Value = pro_code;
            para[13] = new SqlParameter("@pro_des", SqlDbType.NVarChar, 2000);
            para[13].Value = pro_des;
            para[14] = new SqlParameter("@pro_lastcost", Convert.ToDouble(lastcost));
            para[15] = new SqlParameter("@pro_avgcost", Convert.ToDouble(avgcost));
            para[16] = new SqlParameter("@username", username);
            para[17] = new SqlParameter("@pro_othercost", Convert.ToDouble(othercost));
            para[18] = new SqlParameter("@pro_priceL", Convert.ToDouble(pro_priceL));
            para[19] = new SqlParameter("@pro_priceH", Convert.ToDouble(pro_pricH));
            para[20] = new SqlParameter("@ex_date", ex_date);
            para[21] = new SqlParameter("@new_pro", new_pro);
            para[22] = new SqlParameter("@proshor", proshor);
            para[23] = new SqlParameter("@pro_offer", pro_offer);
            para[24] = new SqlParameter("@pro_gift", pro_gift);
            para[25] = new SqlParameter("@net_cost", net_cost);
            para[26] = new SqlParameter("@precent_Add", precent_Add);
            para[27] = new SqlParameter("@precent_discount", precent_discount);
            para[28] = new SqlParameter("@VAT", VAT);
            para[29] = new SqlParameter("@Length", Length);
            para[30] = new SqlParameter("@Width", Width);
            para[31] = new SqlParameter("@Depth", Depth);
            para[32] = new SqlParameter("@Weight", Weight);
            para[33] = new SqlParameter("@mold_id", mold_id);
            para[34] = new SqlParameter("@pro_Length", pro_Length);
            para[35] = new SqlParameter("@pro_Width", pro_Width);
            para[36] = new SqlParameter("@pro_thickness", pro_thickness);
            para[37] = new SqlParameter("@pro_StorgeArea", pro_StorgeArea);
            para[38] = new SqlParameter("@proName_Eng", SqlDbType.NVarChar, 100);
            para[38].Value = proName_Eng;
            para[39] = new SqlParameter("@cat_Name", SqlDbType.NVarChar, 100);
            para[39].Value = cat_Name;
            para[40] = new SqlParameter("@pro_no", SqlDbType.NVarChar, 100);
            para[40].Value = pro_no;
            para[41] = new SqlParameter("@pro_price3", pro_price3);
            //Created By & Created Date
            para[42] = new SqlParameter("@Created_By", Created_By);
            para[43] = new SqlParameter("@Created_Date", Created_Date);
            //-*-*-*-*-*-
            para[44] = new SqlParameter("@pro_type_id", pro_type_id);
            //-*-*-*-*-*-
            para[45] = new SqlParameter("@oldpro_id", @oldpro_id);
            //-*-*-*-*-*-

            para[46] = new SqlParameter("@reference_No", reference_No);



            dtac.open();
            dtac.ExcutCommand("AddDelUpdat_pro", para);
            dtac.close();
        }
        //الرقم التسلسلي
        public DataTable Get_pro_Id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_pro_Id", null);
            dtac.close();
            return dt;
        }
        public void updproQtyCostPricEx(string pro_id, string pro_price,
            double net_cost, string pro_price2, string othercost,
            string ex_date
       )
        {
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@pro_id", pro_id);

            para[1] = new SqlParameter("@check", "q");

            para[2] = new SqlParameter("@pro_price", pro_price);

            para[3] = new SqlParameter("@net_cost", net_cost);

            para[4] = new SqlParameter("@pro_price2", pro_price2);

            para[5] = new SqlParameter("@pro_othercost", Convert.ToDouble(othercost));

            para[6] = new SqlParameter("@ex_date", ex_date);

            dtac.open();
            dtac.ExcutCommand("AddDelUpdat_pro", para);
            dtac.close();
        }
        //حذف منتج
        public void delpro(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@pro_id", SqlDbType.VarChar, 50);
            para[0].Value = pro_id;
            para[1] = new SqlParameter("@check", SqlDbType.NChar, 1);
            para[1].Value = "d";

            dtac.open();
            dtac.ExcutCommand("AddDelUpdat_pro", para);
            dtac.close();
        }
        public void delprushor()
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@check", SqlDbType.NChar, 1);
            para[0].Value = "d";

            dtac.open();
            dtac.ExcutCommand("mng_prushor", para);
            dtac.close();
        }

        public void DelProOfProshor(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@pro_id", pro_id);


            dtac.open();
            dtac.ExcutCommand("DelProOfProshor", para);
            dtac.close();
        }
        //بحث

        public DataTable serch_probycat(int vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", SqlDbType.Int);
            para[0].Value = vrb_serch;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("serch_probycat", para);
            dtac.close();
            return dt;
        }

        public DataTable serch_probyname(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", SqlDbType.VarChar, 50);
            para[0].Value = vrb_serch;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("serch_probyname", para);
            dtac.close();
            return dt;
        }
        public DataTable serch_probycode(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", SqlDbType.VarChar, 50);
            para[0].Value = vrb_serch;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("serch_probycode", para);
            dtac.close();
            return dt;
        }

        public DataTable CostReport(int cat_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@cat_id", cat_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("CostReport", para);
            dtac.close();
            return dt;
        }
        public DataTable serch_probyid(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", SqlDbType.VarChar, 50);
            para[0].Value = vrb_serch;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("serch_probyid", para);
            dtac.close();
            return dt;
        }

        public DataTable serch_probyidPrice(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", SqlDbType.VarChar, 50);
            para[0].Value = vrb_serch;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("serch_probyidPrice", para);
            dtac.close();
            return dt;
        }
        public DataTable Get_All_pro(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", SqlDbType.VarChar, 50);
            para[0].Value = vrb_serch;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_All_pro", para);
            dtac.close();
            return dt;
        }
        public DataTable Get_All_proNoPic(string vrb_serch, int wh_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@vrb_serch", SqlDbType.VarChar, 50);
            para[0].Value = vrb_serch;
            para[1] = new SqlParameter("@wh_id", wh_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("[Get_All_proNoPic]", para);
            dtac.close();
            return dt;
        }
        public DataTable GetAllProByCat(int cat_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@cat_id", cat_id);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetAllProByCat", para);
            dtac.close();
            return dt;
        }
        public DataTable Get_Pro_ByCode(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", SqlDbType.VarChar, 50);
            para[0].Value = vrb_serch;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("[Get_Pro_ByCode]", para);
            dtac.close();
            return dt;
        }
        public DataTable showe_All_pro()
        {


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_All_pro", null);
            dtac.close();
            return dt;
        }
        public DataTable GetValStoor()
        {


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetValStoor", null);
            dtac.close();
            return dt;
        }
        public DataTable GetAll_NewProForProshor(int qtyL, int qtyH)
        {
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@qty", qtyL);
            para[1] = new SqlParameter("@qtyH", qtyH);
            dtac.open();
            dt = dtac.Selectdata("GetAll_NewProForProshor", para);
            dtac.close();
            return dt;
        }
        public DataTable GetProForProshor(string pro_id)
        {
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pro_id", pro_id);
            dtac.open();
            dt = dtac.Selectdata("GetProForProshor", para);
            dtac.close();
            return dt;
        }
        public DataTable InsertQtyPriceEx(string pro_id)
        {
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pro_id", pro_id);
            dtac.open();
            dt = dtac.Selectdata("InsertQtyPriceEx", para);
            dtac.close();
            return dt;
        }
        public DataTable Check_id(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", SqlDbType.VarChar, 50);
            para[0].Value = vrb_serch;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Check_id", para);
            dtac.close();
            return dt;
        }
        public DataTable Check_gift(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pro_id", pro_id);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Check_gift", para);
            dtac.close();
            return dt;
        }
        public DataTable prom(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pro_id", pro_id);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("prom", para);
            dtac.close();
            return dt;
        }
        public DataTable prom1(string pro_id, int wh_id, DateTime Date_From, DateTime Date_TO, int rep_id)
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@pro_id", pro_id);
            para[1] = new SqlParameter("@wh_id", wh_id);
            para[2] = new SqlParameter("@Date_From", Date_From);
            para[3] = new SqlParameter("@Date_TO", Date_TO);
            para[4] = new SqlParameter("@rep_id", rep_id);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("prom1", para);
            dtac.close();
            return dt;
        }

        public DataTable promTotal(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pro_id", pro_id);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("promTotal", para);
            dtac.close();
            return dt;
        }
        public DataTable get_codeof_at(int cat_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@cat_id", SqlDbType.Int);
            para[0].Value = cat_id;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("get_codeof_at", para);
            dtac.close();
            return dt;
        }
        public DataTable getallcat()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("getallcat", null);
            dtac.close();
            return dt;
        }
        public DataTable pro_id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("pro_id", null);
            dtac.close();
            return dt;
        }
        public DataTable GetOldProhr(string pro_name, int qty)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@vrb_serch", pro_name);
            para[1] = new SqlParameter("@qty", qty);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetOldProhr", para);
            dtac.close();
            return dt;
        }
        public DataTable checkpro_inv(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@pro_id", SqlDbType.VarChar, 50);
            para[0].Value = pro_id;

            dtac.open();
            DataTable dt = new DataTable();
            dt = dtac.Selectdata("checkpro_inv", para);
            dtac.close();
            return dt;


        }

        public DataTable Check_qty(string pro_id, string pro_qty)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@pro_id", SqlDbType.VarChar, 50);
            para[0].Value = pro_id;
            para[1] = new SqlParameter("@pro_qty", SqlDbType.NChar, 10);
            para[1].Value = pro_qty;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Check_qty", para);
            dtac.close();
            return dt;
        }
        public void UpdatQTY_pro_inv(int pro_qty, string pro_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@pro_id", SqlDbType.VarChar, 50);
            para[0].Value = pro_id;
            para[1] = new SqlParameter("@inv_qty", SqlDbType.Int);
            para[1].Value = pro_qty;


            dtac.open();
            dtac.ExcutCommand("UpdatQTY_pro_inv", para);
            dtac.close();
        }

        public void UpdateCostQtyPro(int pro_qty, string pro_id,
            string pro_cost, double pro_lastcost, double pro_avgcost,
            string pur_typ, double pur_gift, int wh_id
           )
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@pro_id", pro_id);
            para[1] = new SqlParameter("@pro_qty", pro_qty);
            para[2] = new SqlParameter("@pro_cost", pro_cost);
            para[3] = new SqlParameter("@pro_lastcost", pro_lastcost);
            para[4] = new SqlParameter("@pro_avgcost", pro_avgcost);
            para[5] = new SqlParameter("@pur_typ", pur_typ);
            para[6] = new SqlParameter("@pur_gift", pur_gift);
            para[7] = new SqlParameter("@wh_id", wh_id);
            dtac.open();
            dtac.ExcutCommand("UpdateCostQtyPro", para);
            dtac.close();
        }

        public DataTable getQty_pro(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@pro_id", SqlDbType.VarChar, 50);
            para[0].Value = pro_id;
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("getQty_pro", para);
            dtac.close();
            return dt;
        }
        public DataTable Show_img(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@pro_id", SqlDbType.VarChar, 50);
            para[0].Value = pro_id;
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_img", para);
            dtac.close();
            return dt;
        }
        public DataTable TotalProCost(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@pro_id", pro_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("TotalProCost", para);
            dtac.close();
            return dt;
        }
        public DataTable GetItemsPur(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@pro_id", pro_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetItemsPur", para);
            dtac.close();
            return dt;
        }
        public DataTable Show_QtyWh(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@pro_id", pro_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_QtyWh", para);
            dtac.close();
            return dt;
        }
        public DataTable Sum_qty(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@pro_id", pro_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Sum_qty", para);
            dtac.close();
            return dt;
        }
        public DataTable get_prices(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@pro_id", pro_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("get_prices", para);
            dtac.close();
            return dt;
        }

        public void ProLoadOrNot(string pro_id, int pro_load)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@pro_id", pro_id);
            para[1] = new SqlParameter("@pro_load", pro_load);

            dtac.open();
            dtac.ExcutCommand("ProLoadOrNot", para);
            dtac.close();
        }
        //تقرير المخزون
        public void Getting_Costs(string pro_id,
                                 decimal pro_avgcost,
                                 decimal pro_lastcost,
                                 decimal pro_cost
         
            )
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@pro_id", pro_id);
            para[1] = new SqlParameter("@pro_cost", pro_cost);
            para[2] = new SqlParameter("@pro_lastcost", pro_lastcost);
            para[3] = new SqlParameter("@pro_avgcost", pro_avgcost);
            dtac.open();
            dtac.ExcutCommand("Getting_Costs", para);
            dtac.close();
        }
        //كميات المنتج
        public DataTable RptProQtys(int cat_id, int wh_id, decimal Min_Qtys, decimal Max_Qtys, int rep_id)
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@cat_id", cat_id);
            para[1] = new SqlParameter("@wh_id", wh_id);
            para[2] = new SqlParameter("@Min_Qtys", Min_Qtys);
            para[3] = new SqlParameter("@Max_Qtys", Max_Qtys);
            para[4] = new SqlParameter("@rep_id", rep_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("RptProQtys", para);
            dtac.close();
            return dt;
        }

        public DataTable RptProPrices(int cat_id, int rep_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@cat_id", cat_id);
            para[1] = new SqlParameter("@rep_id", rep_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("RptProPrices", para);
            dtac.close();
            return dt;
        }

        public DataTable RptQtysProfit(int cat_id, int rep_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@cat_id", cat_id);
            para[1] = new SqlParameter("@rep_id", rep_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("RptQtysProfit", para);
            dtac.close();
            return dt;
        }

        public DataTable Rpt_ProductFlow(/*string pro_id*/)
        {
            //SqlParameter[] para = new SqlParameter[1];
            //para[0] = new SqlParameter("@pro_id", pro_id);
            

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Rpt_ProductFlow",null /*para*/);
            dtac.close();
            return dt;
        }

        public DataTable Get_All_proforDC(string vrb_serch, int wh_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@vrb_serch", SqlDbType.VarChar, 50);
            para[0].Value = vrb_serch;
            para[1] = new SqlParameter("@wh_id", wh_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_All_proforDC", para);
            dtac.close();
            return dt;
        }
        public DataTable Get_All_proforDC_1(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", SqlDbType.VarChar, 50);
            para[0].Value = vrb_serch;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_All_proforDC_1", para);
            dtac.close();
            return dt;
        }
        //****************************************************************************//
        public void mng_DirectMaterials_add(

                              string FinalProduct_id,
                              string FinalProduct,
                              string pro_id,
                              string pro_name,
                              decimal pro_qty,
                              decimal pro_wastage,
                              string Notes,
                            //Created By & Created Date
                            string Created_By,
                            DateTime Created_Date


                              )
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@FinalProduct_id", FinalProduct_id);
            para[1] = new SqlParameter("@FinalProduct", FinalProduct);
            para[2] = new SqlParameter("@pro_id", pro_id);
            para[3] = new SqlParameter("@pro_name", pro_name);
            para[4] = new SqlParameter("@pro_qty", pro_qty);
            para[5] = new SqlParameter("@pro_wastage", pro_wastage);
            para[6] = new SqlParameter("@Notes", Notes);
            //Created By & Created Date
            para[7] = new SqlParameter("@Created_By", Created_By);
            para[8] = new SqlParameter("@Created_Date", Created_Date);
            para[9] = new SqlParameter("@check", "a");
 
      


            dtac.open();
            dtac.ExcutCommand("mng_DirectMaterials", para);
            dtac.close();
        }
        public void mng_DirectMaterials_update(
                             string FinalProduct_id,
                              string FinalProduct,
                              string pro_id,
                              string pro_name,
                              decimal pro_qty,
                              decimal pro_wastage,
                              string Notes,
                            //Created By & Created Date
                            string Created_By,
                            DateTime Created_Date


                              )
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@FinalProduct_id", FinalProduct_id);
            para[1] = new SqlParameter("@FinalProduct", FinalProduct);
            para[2] = new SqlParameter("@pro_id", pro_id);
            para[3] = new SqlParameter("@pro_name", pro_name);
            para[4] = new SqlParameter("@pro_qty", pro_qty);
            para[5] = new SqlParameter("@pro_wastage", pro_wastage);
            para[6] = new SqlParameter("@Notes", Notes);
            //Created By & Created Date
            para[7] = new SqlParameter("@Created_By", Created_By);
            para[8] = new SqlParameter("@Created_Date", Created_Date);
            para[9] = new SqlParameter("@check", "u");
 

            dtac.open();
            dtac.ExcutCommand("mng_DirectMaterials", para);
            dtac.close();
        }
        //الحذف
        public void mng_DirectMaterials_Del(string FinalProduct_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@FinalProduct_id", FinalProduct_id);

            dtac.open();
            dtac.ExcutCommand("mng_DirectMaterials_Del", para);
            dtac.close();
        }

         

        public DataTable Show_DirectMaterials_proId(string FinalProduct_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@FinalProduct_id", FinalProduct_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_DirectMaterials_proId", para);
            dtac.close();
            return dt;
        }

        public DataTable Show_DirectM_proid(string FinalProduct_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@FinalProduct_id", FinalProduct_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_DirectM_proid", para);
            dtac.close();
            return dt;
        }


        //Report_Where/SELECT para
        public DataTable Show_Pro_Act(string where, string SELECT)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@where", where);
            para[1] = new SqlParameter("@SELECT", SELECT);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_Pro_Act", para);
            dtac.close();
            return dt;
        }

        //Report_Where/SELECT para فيمة المخزون
        public DataTable RptWarehouse(string where, string SELECT)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@where", where);
            para[1] = new SqlParameter("@SELECT", SELECT);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("RptWarehouse", para);
            dtac.close();
            return dt;
        }

    }

}
