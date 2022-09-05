using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    class ClassReport_Setting
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_Report_Setting_add(
                               int rpt_Setting_Id  
                             , int emp_id
                             , string emp_name
                             , string branch_name
                             , int brn_id
                             , string rpt_branch
                             , int cb_rpt_branch
                             , int sal_id
                             , string rpt_salesman
                             , int cb_rpt_salesman
                             , int checkBox_Later
                             , int checkBox_Cash
                             , int checkBox_Bank
                             , int cb_pur_typename
           /*******************************************/
                             , bool pur_id
                             , bool cs_name 
                             , bool pur_typename 
                             , bool pur_date 
                             , bool inv_name 
                             , bool sal_name 
                             , bool pur_total 
                             , bool pur_totaldiscount 
                             , bool pur_AfterDiscountTotal 
                             , bool inv_cost 
                             , bool Profit
            /*******************************************/
                             , bool pro_id
                             , bool pro_name 
                             , bool pro_qty 
                             , bool pro_price 
                             , bool pro_total 
                             , bool pur_gift 
                             , bool pur_perplus 
                             , bool pur_permin 
                             , bool pro_cost 
                             , bool pro_avgcost
                             , bool pro_discount
                             , bool pro_vat
                             , bool pro_additionalCost
                             //Created By & Created Date
                             , string Created_By
                             , DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[41];
            para[0] = new SqlParameter("@rpt_Setting_Id", rpt_Setting_Id);
            para[1] = new SqlParameter("@emp_id", emp_id);
            para[2] = new SqlParameter("@emp_name", emp_name);
            para[3] = new SqlParameter("@branch_name", branch_name);
            para[4] = new SqlParameter("@brn_id", brn_id);
            para[5] = new SqlParameter("@rpt_branch", rpt_branch);
            para[6] = new SqlParameter("@cb_rpt_branch", cb_rpt_branch);
            para[7] = new SqlParameter("@sal_id", sal_id);
            para[8] = new SqlParameter("@rpt_salesman", rpt_salesman);
            para[9] = new SqlParameter("@cb_rpt_salesman", cb_rpt_salesman);
            para[10] = new SqlParameter("@checkBox_Later", checkBox_Later);
            para[11] = new SqlParameter("@checkBox_Cash", checkBox_Cash);
            para[12] = new SqlParameter("@checkBox_Bank", checkBox_Bank);
            para[13] = new SqlParameter("@cb_pur_typename", cb_pur_typename);
            para[14] = new SqlParameter("@pur_id", pur_id);
            para[15] = new SqlParameter("@cs_name", cs_name);
            para[16] = new SqlParameter("@pur_typename", pur_typename);
            para[17] = new SqlParameter("@pur_date", pur_date);
            para[18] = new SqlParameter("@inv_name", inv_name);
            para[19] = new SqlParameter("@sal_name", sal_name);
            para[20] = new SqlParameter("@pur_total", pur_total);
            para[21] = new SqlParameter("@pur_totaldiscount", pur_totaldiscount);
            para[22] = new SqlParameter("@pur_AfterDiscountTotal", pur_AfterDiscountTotal);
            para[23] = new SqlParameter("@inv_cost", inv_cost);
            para[24] = new SqlParameter("@Profit", Profit);
            /*******************************************/
            para[25] = new SqlParameter("@pro_id", pro_id);
            para[26] = new SqlParameter("@pro_name", pro_name);
            para[27] = new SqlParameter("@pro_qty", pro_qty);
            para[28] = new SqlParameter("@pro_price", pro_price);
            para[29] = new SqlParameter("@pro_total", pro_total);
            para[30] = new SqlParameter("@pur_gift", pur_gift);
            para[31] = new SqlParameter("@pur_perplus", pur_perplus);
            para[32] = new SqlParameter("@pur_permin", pur_permin);
            para[33] = new SqlParameter("@pro_cost", pro_cost);
            para[34] = new SqlParameter("@pro_avgcost", pro_avgcost);
            para[35] = new SqlParameter("@pro_discount", pro_discount);
            para[36] = new SqlParameter("@pro_vat", pro_vat);
            para[37] = new SqlParameter("@pro_additionalCost", pro_additionalCost);
            //Created By & Created Date
            para[38] = new SqlParameter("@Created_By", Created_By);
            para[39] = new SqlParameter("@Created_Date", Created_Date);
            para[40] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Report_Setting", para);
            dtac.close();
        }

        //التعديل
        public void mng_Report_Setting_Update(
                               int rpt_Setting_Id
                             , int emp_id
                             , string emp_name
                             , string branch_name
                             , int brn_id
                             , string rpt_branch
                             , int cb_rpt_branch
                             , int sal_id
                             , string rpt_salesman
                             , int cb_rpt_salesman
                             , int checkBox_Later
                             , int checkBox_Cash
                             , int checkBox_Bank
                             , int cb_pur_typename
                             /*******************************************/
                             , bool pur_id
                             , bool cs_name
                             , bool pur_typename
                             , bool pur_date
                             , bool inv_name
                             , bool sal_name
                             , bool pur_total
                             , bool pur_totaldiscount
                             , bool pur_AfterDiscountTotal
                             , bool inv_cost
                             , bool Profit
                             /*******************************************/
                             , bool pro_id
                             , bool pro_name
                             , bool pro_qty
                             , bool pro_price
                             , bool pro_total
                             , bool pur_gift
                             , bool pur_perplus
                             , bool pur_permin
                             , bool pro_cost
                             , bool pro_avgcost
                             , bool pro_discount
                             , bool pro_vat
                             , bool pro_additionalCost
                             //Created By & Created Date
                             , string Created_By
                             , DateTime Created_Date
           )
        {
            SqlParameter[] para = new SqlParameter[41];
            para[0] = new SqlParameter("@rpt_Setting_Id", rpt_Setting_Id);
            para[1] = new SqlParameter("@emp_id", emp_id);
            para[2] = new SqlParameter("@emp_name", emp_name);
            para[3] = new SqlParameter("@branch_name", branch_name);
            para[4] = new SqlParameter("@brn_id", brn_id);
            para[5] = new SqlParameter("@rpt_branch", rpt_branch);
            para[6] = new SqlParameter("@cb_rpt_branch", cb_rpt_branch);
            para[7] = new SqlParameter("@sal_id", sal_id);
            para[8] = new SqlParameter("@rpt_salesman", rpt_salesman);
            para[9] = new SqlParameter("@cb_rpt_salesman", cb_rpt_salesman);
            para[10] = new SqlParameter("@checkBox_Later", checkBox_Later);
            para[11] = new SqlParameter("@checkBox_Cash", checkBox_Cash);
            para[12] = new SqlParameter("@checkBox_Bank", checkBox_Bank);
            para[13] = new SqlParameter("@cb_pur_typename", cb_pur_typename);
            para[14] = new SqlParameter("@pur_id", pur_id);
            para[15] = new SqlParameter("@cs_name", cs_name);
            para[16] = new SqlParameter("@pur_typename", pur_typename);
            para[17] = new SqlParameter("@pur_date", pur_date);
            para[18] = new SqlParameter("@inv_name", inv_name);
            para[19] = new SqlParameter("@sal_name", sal_name);
            para[20] = new SqlParameter("@pur_total", pur_total);
            para[21] = new SqlParameter("@pur_totaldiscount", pur_totaldiscount);
            para[22] = new SqlParameter("@pur_AfterDiscountTotal", pur_AfterDiscountTotal);
            para[23] = new SqlParameter("@inv_cost", inv_cost);
            para[24] = new SqlParameter("@Profit", Profit);
            /*******************************************/
            para[25] = new SqlParameter("@pro_id", pro_id);
            para[26] = new SqlParameter("@pro_name", pro_name);
            para[27] = new SqlParameter("@pro_qty", pro_qty);
            para[28] = new SqlParameter("@pro_price", pro_price);
            para[29] = new SqlParameter("@pro_total", pro_total);
            para[30] = new SqlParameter("@pur_gift", pur_gift);
            para[31] = new SqlParameter("@pur_perplus", pur_perplus);
            para[32] = new SqlParameter("@pur_permin", pur_permin);
            para[33] = new SqlParameter("@pro_cost", pro_cost);
            para[34] = new SqlParameter("@pro_avgcost", pro_avgcost);
            para[35] = new SqlParameter("@pro_discount", pro_discount);
            para[36] = new SqlParameter("@pro_vat", pro_vat);
            para[37] = new SqlParameter("@pro_additionalCost", pro_additionalCost);
            //Created By & Created Date
            para[38] = new SqlParameter("@Created_By", Created_By);
            para[39] = new SqlParameter("@Created_Date", Created_Date);
            para[40] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_Report_Setting", para);
            dtac.close();
        }

        //الحذف
        public void mng_Report_SettingDel(int rpt_Setting_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rpt_Setting_Id", rpt_Setting_Id);

            dtac.open();
            dtac.ExcutCommand("mng_Report_SettingDel", para);
            dtac.close();
        }

        public DataTable Show_Report_Setting(int rpt_Setting_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rpt_Setting_Id", rpt_Setting_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_Report_Setting", para);
            dtac.close();
            return dt;
        }
        public DataTable rpt_Setting_Id()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("rpt_Setting_Id", null);
            dtac.close();
            return dt;
        }

        //البحث
        public DataTable SearchReport_Setting(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchReport_Setting", para);
            dtac.close();
            return dt;
        }

        public DataTable Get_PrivforRpt(string user_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@user_id", user_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_PrivforRpt", para);
            dtac.close();
            return dt;
        }

    }
}
