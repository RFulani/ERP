using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    class ClassDirectCosts
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_DirectCosts_add(
             int RecId
            , DateTime RecDate
            , int Branch_id
            , string Branch
            , int Warehouse_id
            , string Warehouse
            , string refer
            , string Notes
            , string FinalProduct_id
            , string FinalProduct
            , decimal FinalProduct_Qty
            , decimal FinalProduct_costPer
            , decimal FinalProduct_tot
            , string Pro_Desc
            //Created By & Created Date
            , string Created_By
            , DateTime Created_Date

           )
        {
            SqlParameter[] para = new SqlParameter[17];
            para[0] = new SqlParameter("@RecId", RecId);
            para[1] = new SqlParameter("@RecDate", RecDate);
            para[2] = new SqlParameter("@Branch_id", Branch_id);
            para[3] = new SqlParameter("@Branch", Branch);
            para[4] = new SqlParameter("@Warehouse_id", Warehouse_id);
            para[5] = new SqlParameter("@Warehouse", Warehouse);
            para[6] = new SqlParameter("@refer", refer);
            para[7] = new SqlParameter("@Notes", Notes);
            para[8] = new SqlParameter("@FinalProduct_id", FinalProduct_id);
            para[9] = new SqlParameter("@FinalProduct", FinalProduct);
            para[10] = new SqlParameter("@FinalProduct_Qty", FinalProduct_Qty);
            para[11] = new SqlParameter("@FinalProduct_costPer", FinalProduct_costPer);
            para[12] = new SqlParameter("@FinalProduct_tot", FinalProduct_tot);
            para[13] = new SqlParameter("@Pro_Desc", Pro_Desc);
            //Created By & Created Date
            para[14] = new SqlParameter("@Created_By", Created_By);
            para[15] = new SqlParameter("@Created_Date", Created_Date);
            para[16] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_DirectCosts", para);
            dtac.close();
        }

        //التعديل
        public void mng_DirectCosts_Update(
             int RecId
            , DateTime RecDate
            , int Branch_id
            , string Branch
            , int Warehouse_id
            , string Warehouse
            , string refer
            , string Notes
            , string FinalProduct_id
            , string FinalProduct
            , decimal FinalProduct_Qty
            , decimal FinalProduct_costPer
            , decimal FinalProduct_tot
            , string Pro_Desc
            //Created By & Created Date
            , string Created_By
            , DateTime Created_Date

           )
        {
            SqlParameter[] para = new SqlParameter[17];
            para[0] = new SqlParameter("@RecId", RecId);
            para[1] = new SqlParameter("@RecDate", RecDate);
            para[2] = new SqlParameter("@Branch_id", Branch_id);
            para[3] = new SqlParameter("@Branch", Branch);
            para[4] = new SqlParameter("@Warehouse_id", Warehouse_id);
            para[5] = new SqlParameter("@Warehouse", Warehouse);
            para[6] = new SqlParameter("@refer", refer);
            para[7] = new SqlParameter("@Notes", Notes);
            para[8] = new SqlParameter("@FinalProduct_id", FinalProduct_id);
            para[9] = new SqlParameter("@FinalProduct", FinalProduct);
            para[10] = new SqlParameter("@FinalProduct_Qty", FinalProduct_Qty);
            para[11] = new SqlParameter("@FinalProduct_costPer", FinalProduct_costPer);
            para[12] = new SqlParameter("@FinalProduct_tot", FinalProduct_tot);
            para[13] = new SqlParameter("@Pro_Desc", Pro_Desc);
            //Created By & Created Date
            para[14] = new SqlParameter("@Created_By", Created_By);
            para[15] = new SqlParameter("@Created_Date", Created_Date);
            para[16] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_DirectCosts", para);
            dtac.close();
        }



        //الحذف
        public void mng_DirectCosts_Del(int RecId)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@RecId", RecId);

            dtac.open();
            dtac.ExcutCommand("mng_DirectCosts_Del", para);
            dtac.close();
        }
        //*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*
        //*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*

        //الأضافة
        public void mng_DirectCost_Details_add(
             int RecId
           , string pro_id
           , string pro_name
           , decimal pro_qty
            , decimal pro_wastage
           , decimal pro_cost
           , decimal pro_totCost
           , string Note
            //Created By & Created Date
            , string Created_By
            , DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@RecId", RecId);
            para[1] = new SqlParameter("@pro_id", pro_id);
            para[2] = new SqlParameter("@pro_name", pro_name);
            para[3] = new SqlParameter("@pro_qty", pro_qty);
            para[4] = new SqlParameter("@pro_wastage", pro_wastage);
            para[5] = new SqlParameter("@pro_cost", pro_cost);
            para[6] = new SqlParameter("@pro_totCost", pro_totCost);
            para[7] = new SqlParameter("@Note", Note);
            //Created By & Created Date
            para[8] = new SqlParameter("@Created_By", Created_By);
            para[9] = new SqlParameter("@Created_Date", Created_Date);
            para[10] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_DirectCost_Details", para);
            dtac.close();
        }

        //التعديل
        public void mng_DirectCost_Details_Update(
             int RecId
           , string pro_id
           , string pro_name
           , decimal pro_qty
            , decimal pro_wastage
           , decimal pro_cost
           , decimal pro_totCost
           , string Note
            //Created By & Created Date
            , string Created_By
            , DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@RecId", RecId);
            para[1] = new SqlParameter("@pro_id", pro_id);
            para[2] = new SqlParameter("@pro_name", pro_name);
            para[3] = new SqlParameter("@pro_qty", pro_qty);
            para[4] = new SqlParameter("@pro_wastage", pro_wastage);
            para[5] = new SqlParameter("@pro_cost", pro_cost);
            para[6] = new SqlParameter("@pro_totCost", pro_totCost);
            para[7] = new SqlParameter("@Note", Note);
            //Created By & Created Date
            para[8] = new SqlParameter("@Created_By", Created_By);
            para[9] = new SqlParameter("@Created_Date", Created_Date);
            para[9] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_DirectCost_Details", para);
            dtac.close();
        }

        //الحذف
        public void mng_DirectCost_Details_Del(int RecId)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@RecId", RecId);

            dtac.open();
            dtac.ExcutCommand("mng_DirectCost_Details_Del", para);
            dtac.close();
        }
        //*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*
        //*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*-_*

        public DataTable ShowDirectCosts(int RecId)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@RecId", RecId);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowDirectCosts", para);
            dtac.close();
            return dt;
        }


        public DataTable ShowDirectCosts_Details(int RecId)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@RecId", RecId);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowDirectCosts_Details", para);
            dtac.close();
            return dt;
        }

        public DataTable SearchDirectCosts(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchDirectCosts", para);
            dtac.close();
            return dt;
        }

        public DataTable Get_DirectCosts_id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_DirectCosts_id", null);
            dtac.close();
            return dt;
        }
    }
}
