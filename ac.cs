using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ac
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void Del_Print_AcSt()
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@check", "d");

            dtac.open();
            dtac.ExcutCommand("Print_AcSt", para);
            dtac.close();
        }

        public void uac(string ac_id, decimal Debtor, decimal Creditor)
        {
            SqlParameter[] para = new SqlParameter[3];

            para[0] = new SqlParameter("@ac_id", ac_id);
            para[1] = new SqlParameter("@Debtor", Debtor);
            para[2] = new SqlParameter("@Creditor", Creditor);
            dtac.open();
            dtac.ExcutCommand("uac", para);
            dtac.close();
        }
        public DataTable ExpensesOfcash(DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@from_date", from);

            para[1] = new SqlParameter("@to_date", to);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ExpensesOfcash", para);
            dtac.close();
            return dt;
        }
        public void Print_AcSt(
                                string val,
                                string de,
                                string cr,
                                string id,
                                string typ,
                                DateTime daterow,
                                string note,
                               //Created By & Created Date
                               string Created_By,
                               DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@val", Convert.ToDecimal(val));
            para[1] = new SqlParameter("@check", "a");
            para[2] = new SqlParameter("@de", Convert.ToDecimal(de));
            para[3] = new SqlParameter("@cr", Convert.ToDecimal(cr));
            para[4] = new SqlParameter("@typ", typ);
            para[5] = new SqlParameter("@daterow", daterow);
            para[6] = new SqlParameter("@note", note);
            para[7] = new SqlParameter("@id", id);
            //Created By & Created Date
            para[8] = new SqlParameter("@Created_By", Created_By);
            para[9] = new SqlParameter("@Created_Date", Created_Date);

            dtac.open();
            dtac.ExcutCommand("Print_AcSt", para);
            dtac.close();
        }
        //اضافة حساب
        public void mng_ac_add(string ac_id,
                               string ac_name,
                               DateTime ac_date,
                               string ac_cat,
                               string Debtor,
                               string Creditor,
                               string start_value,
                               string ac_target,
                               string ac_cur,
                               int ac_no,
                               int MainCategory_Id,
                               string MainCategory,
                               int branch_id,
                               string branch_name,
                               int Cost_Center,
                               //Created By & Created Date
                               string Created_By,
                               DateTime Created_Date,
                               //----------------------
                               string Code_Cat_Id,
                               string Account_no,
                               int Code_Cat_no)
        {
            SqlParameter[] para = new SqlParameter[21];
            para[0] = new SqlParameter("@ac_id", ac_id);
            para[1] = new SqlParameter("@check", "a");
            para[2] = new SqlParameter("@ac_name", ac_name);

            para[3] = new SqlParameter("@ac_date", ac_date);
            para[4] = new SqlParameter("@ac_cat", ac_cat);
            para[5] = new SqlParameter("@Debtor", Debtor);
            para[6] = new SqlParameter("@Creditor", Creditor);
            para[7] = new SqlParameter("@start_value", start_value);
            para[8] = new SqlParameter("@ac_target", ac_target);
            para[9] = new SqlParameter("@ac_cur", ac_cur);
            para[10] = new SqlParameter("@ac_no", ac_no);
            para[11] = new SqlParameter("@MainCategory_Id", MainCategory_Id);
            para[12] = new SqlParameter("@MainCategory", MainCategory);
            para[13] = new SqlParameter("@branch_id", branch_id);
            para[14] = new SqlParameter("@branch_name", branch_name);
            para[15] = new SqlParameter("@Cost_Center", Cost_Center);
            //Created By & Created Date
            para[16] = new SqlParameter("@Created_By", Created_By);
            para[17] = new SqlParameter("@Created_Date", Created_Date);
            //-------------------------------------------------
            para[18] = new SqlParameter("@Code_Cat_Id", Code_Cat_Id);
            para[19] = new SqlParameter("@Account_no", Account_no);
            para[20] = new SqlParameter("@Code_Cat_no", Code_Cat_no);
            dtac.open();
            dtac.ExcutCommand("mng_ac", para);
            dtac.close();
        }
        //تعديل حساب  
        public void mng_ac_up(string ac_id,
                              string ac_name,
                              DateTime ac_date,
                              string ac_cat,
                              string Debtor,
                              string Creditor,
                              string start_value,
                              string ac_target,
                              string ac_cur,
                               int MainCategory_Id,
                               string MainCategory,
                               int branch_id,
                               string branch_name,
                               int Cost_Center,
                               //Created By & Created Date
                               string Created_By,
                              DateTime Created_Date,
                               //----------------------
                               string Code_Cat_Id,
                               string Account_no,
                               int Code_Cat_no)


        {
            SqlParameter[] para = new SqlParameter[20];
            para[0] = new SqlParameter("@ac_id", ac_id);
            para[1] = new SqlParameter("@check", "u");
            para[2] = new SqlParameter("@ac_name", ac_name);
            para[3] = new SqlParameter("@ac_date", ac_date);
            para[4] = new SqlParameter("@ac_cat", ac_cat);
            para[5] = new SqlParameter("@Debtor", Debtor);
            para[6] = new SqlParameter("@Creditor", Creditor);
            para[7] = new SqlParameter("@start_value", start_value);
            para[8] = new SqlParameter("@ac_target", ac_target);
            para[9] = new SqlParameter("@ac_cur", ac_cur);

            para[10] = new SqlParameter("@MainCategory_Id", MainCategory_Id);
            para[11] = new SqlParameter("@MainCategory", MainCategory);
            para[12] = new SqlParameter("@branch_id", branch_id);
            para[13] = new SqlParameter("@branch_name", branch_name);
            para[14] = new SqlParameter("@Cost_Center", Cost_Center);
            //Created By & Created Date
            para[15] = new SqlParameter("@Created_By", Created_By);
            para[16] = new SqlParameter("@Created_Date", Created_Date);
            //-------------------------------------------------
            para[17] = new SqlParameter("@Code_Cat_Id", Code_Cat_Id);
            para[18] = new SqlParameter("@Account_no", Account_no);
            para[19] = new SqlParameter("@Code_Cat_no", Code_Cat_no);

            dtac.open();
            dtac.ExcutCommand("mng_ac", para);
            dtac.close();
        }

        //حذف حساب
        public void mng_ac_del(string ac_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@ac_id", ac_id);
            para[1] = new SqlParameter("@check", "d");

            dtac.open();
            dtac.ExcutCommand("mng_ac", para);
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
        public DataTable serch_acbyname(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", SqlDbType.NVarChar, 50);
            para[0].Value = vrb_serch;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("serch_acbyname", para);
            dtac.close();
            return dt;
        }
        public DataTable serch_acbyid(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", vrb_serch);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("serch_acbyid", para);
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
        public DataTable show_ac()
        {


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("show_ac", null);
            dtac.close();
            return dt;
        }
        public DataTable Check_ac_id(int ac_no)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ac_no", ac_no);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Check_ac_id", para);
            dtac.close();
            return dt;
        }
        public DataTable Check_ac_idString(string ac_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ac_id", ac_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Check_ac_idString", para);
            dtac.close();
            return dt;
        }
        public DataTable ac_id()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ac_id", null);
            dtac.close();
            return dt;
        }
        public DataTable showAcEmp()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("showAcEmp", null);
            dtac.close();
            return dt;
        }
        public void add_cr_ac(string ac_id, decimal Creditor)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@ac_id", ac_id);

            para[1] = new SqlParameter("@Creditor", Creditor);

            dtac.open();
            dtac.ExcutCommand("add_cr_ac", para);
            dtac.close();
        }
        public void up_cr_ac(int ac_id_cr, string val, string old_val, int ac_id_dr)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@ac_id_cr", ac_id_cr);
            para[1] = new SqlParameter("@val", val);
            para[2] = new SqlParameter("@old_val", old_val);
            para[3] = new SqlParameter("@ac_id_dr", ac_id_dr);

            dtac.open();
            dtac.ExcutCommand("up_cr_ac", para);
            dtac.close();
        }
        public void del_cr_dr_ac(int ac_id_cr, decimal old_val, int ac_id_dr)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@ac_id_cr", ac_id_cr);

            para[1] = new SqlParameter("@old_val", old_val);
            para[2] = new SqlParameter("@ac_id_dr", ac_id_dr);

            dtac.open();
            dtac.ExcutCommand("del_cr_dr_ac", para);
            dtac.close();
        }
        public void add_de_ac(string ac_id, decimal Debtor)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@ac_id", ac_id);

            para[1] = new SqlParameter("@Debtor", Convert.ToDecimal(Debtor));

            dtac.open();
            dtac.ExcutCommand("add_de_ac", para);
            dtac.close();
        }
        public DataTable ShowAc_Cat()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAc_Cat", null);
            dtac.close();
            return dt;
        }
        public DataTable show_acByDate(DateTime from, DateTime To)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@To", To);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("show_acByDate", para);
            dtac.close();
            return dt;
        }
        public DataTable show_acById(string ac_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ac_id", ac_id);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("show_acById", para);
            dtac.close();
            return dt;
        }
        //لإظهار جميع الحسابات بناءا على رقم التصنيف
        public DataTable GteAcByCatId(int MainCategory_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@MainCategory_Id", MainCategory_Id);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GteAcByCatId", para);
            dtac.close();
            return dt;
        }
        //لإظهار جميع الحسابات بناءا على رقم التصنيف و الفنرة
        public DataTable GteAcByCatId_Date(int MainCategory_Id, DateTime from, DateTime To)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@MainCategory_Id", MainCategory_Id);
            para[1] = new SqlParameter("@from", from);
            para[2] = new SqlParameter("@To", To);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GteAcByCatId_Date", para);
            dtac.close();
            return dt;
        }
        //لإظهار جميع الحسابات التي لديها ارصده
        public DataTable GteAc_WithBalanc( DateTime from, DateTime To)
        {
            SqlParameter[] para = new SqlParameter[2];
           
            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@To", To);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GteAc_WithBalanc", para);
            dtac.close();
            return dt;
        }
        //لإظهار جميع الحسابات بناءا على رقم التصنيف
        public DataTable GetAcByCatId(int MainCategory_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@MainCategory_Id", MainCategory_Id);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetAcByCatId", para);
            dtac.close();
            return dt;
        }
        public DataTable GetAc_Code_Cat_Id(int MainCategory_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@MainCategory_Id", MainCategory_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetAc_Code_Cat_Id", para);
            dtac.close();
            return dt;

            
        }
        //الإرقام التسلسليه بناءا على التصنيفات
        public DataTable Code_Cat_no(int MainCategory_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@MainCategory_Id", MainCategory_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Code_Cat_no", para);
            dtac.close();
            return dt;


        }


        //لإظهار جميع الحسابات بناءا على  رقم إنشاء الفاتورة وقيمة الحقل
        public DataTable GetAccountsByCat(  string item_value)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@item_value", item_value);
             

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetAccountsByCat", para);
            dtac.close();
            return dt;
        }

        public DataTable Check_ac_id_AccountNo(string ac_id, string Account_no)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@ac_id", ac_id);
            para[1] = new SqlParameter("@Account_no", Account_no);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Check_ac_id_AccountNo", para);
            dtac.close();
            return dt;
        }
    }
}
