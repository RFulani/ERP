using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace INV.Code
{
    class ClassSettlement
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_Settlement_add(
            int Sett_ID
           ,DateTime Sett_Date 
           , int Sett_Type_id
           , String Sett_Type  
           ,int emp_id  
           , String emp_name
           , decimal Basic_Salary
            , decimal House_Allow
            , decimal Other_Allow
           , decimal Total_Salary
           , DateTime last_day_working  
           ,decimal End_of_service_Award  
           , int WorkingDays
           ,int  WorkingYears 
            ,decimal  WorkingDays_Amount  
           ,DateTime Vac_starting   
           , DateTime Vac_ending   
           , int Vac_days
           , int Vac_CountedDays
            ,decimal Vac_CountedDays_Amount  
           , int Ticket_benefit
           ,decimal Ticket_Amount  
           , decimal sett_otherBenefits  
           , String Exp_otherBenefits
           , decimal total_Amount_Benefits  
           , decimal Adv_house_allow 
           , decimal Loan  
           , decimal gosi  
           , decimal assets  
           , String Exp_assets
           , decimal Penalties  
           , String Exp_Penalties
           , decimal other_Deductions  
           , String Exp_OtherDeductions
           , decimal Total_AmountDeductions
           , String Notes
            ,int Reason_EOS_Id
            ,String Reason_EOS
            //Created By & Created Date
            , string Created_By
            , DateTime Created_Date

            )
        {
            SqlParameter[] para = new SqlParameter[41];
            para[0] = new SqlParameter("@Sett_ID", Sett_ID);
            para[1] = new SqlParameter("@Sett_Date", Sett_Date);
            para[2] = new SqlParameter("@Sett_Type_id", Sett_Type_id);
            para[3] = new SqlParameter("@Sett_Type", Sett_Type);
            para[4] = new SqlParameter("@emp_id", emp_id);
            para[5] = new SqlParameter("@emp_name", emp_name);
            para[6] = new SqlParameter("@Basic_Salary", Basic_Salary);
            para[7] = new SqlParameter("@House_Allow", House_Allow);
            para[8] = new SqlParameter("@Other_Allow", Other_Allow);
            para[9] = new SqlParameter("@Total_Salary", Total_Salary);
            para[10] = new SqlParameter("@last_day_working", last_day_working);
            para[11] = new SqlParameter("@End_of_service_Award", End_of_service_Award);
            para[12] = new SqlParameter("@WorkingDays", WorkingDays);
            para[13] = new SqlParameter("@WorkingYears", WorkingYears);
            para[14] = new SqlParameter("@WorkingDays_Amount", WorkingDays_Amount);
            para[15] = new SqlParameter("@Vac_starting", Vac_starting);
            para[16] = new SqlParameter("@Vac_ending", Vac_ending);
            para[17] = new SqlParameter("@Vac_days", Vac_days);
            para[18] = new SqlParameter("@Vac_CountedDays", Vac_CountedDays);
            para[19] = new SqlParameter("@Vac_CountedDays_Amount", Vac_CountedDays_Amount);
            para[20] = new SqlParameter("@Ticket_benefit", Ticket_benefit);
            para[21] = new SqlParameter("@Ticket_Amount", Ticket_Amount);
            para[22] = new SqlParameter("@sett_otherBenefits", sett_otherBenefits);
            para[23] = new SqlParameter("@Exp_otherBenefits", Exp_otherBenefits);
            para[24] = new SqlParameter("@total_Amount_Benefits", total_Amount_Benefits);
            para[25] = new SqlParameter("@Adv_house_allow", Adv_house_allow);
            para[26] = new SqlParameter("@Loan", Loan);
            para[27] = new SqlParameter("@gosi", gosi);
            para[28] = new SqlParameter("@assets", assets);
            para[29] = new SqlParameter("@Exp_assets", Exp_assets);
            para[30] = new SqlParameter("@Penalties", Penalties);
            para[31] = new SqlParameter("@Exp_Penalties", Exp_Penalties);
            para[32] = new SqlParameter("@other_Deductions", other_Deductions);
            para[33] = new SqlParameter("@Exp_OtherDeductions", Exp_OtherDeductions);
            para[34] = new SqlParameter("@Total_AmountDeductions", Total_AmountDeductions);
            para[35] = new SqlParameter("@Notes", Notes);
            para[36] = new SqlParameter("@Reason_EOS_Id", Reason_EOS_Id);
            para[37] = new SqlParameter("@Reason_EOS", Reason_EOS);
            //Created By & Created Date
            para[38] = new SqlParameter("@Created_By", Created_By);
            para[39] = new SqlParameter("@Created_Date", Created_Date);
            para[40] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Settlement", para);
            dtac.close();
        }

        //التعديل
        public void mng_Settlement_Update(
          int Sett_ID
           , DateTime Sett_Date
           , int Sett_Type_id
           , String Sett_Type
           , int emp_id
           , String emp_name
           , decimal Basic_Salary
             , decimal House_Allow
            , decimal Other_Allow
           , decimal Total_Salary
           , DateTime last_day_working
           , decimal End_of_service_Award
           , int WorkingDays
           , int WorkingYears
            , decimal WorkingDays_Amount
           , DateTime Vac_starting
           , DateTime Vac_ending
           , int Vac_days
           , int Vac_CountedDays
            , decimal Vac_CountedDays_Amount
           , int Ticket_benefit
           , decimal Ticket_Amount
           , decimal sett_otherBenefits
           , String Exp_otherBenefits
           , decimal total_Amount_Benefits
           , decimal Adv_house_allow
           , decimal Loan
           , decimal gosi
           , decimal assets
           , String Exp_assets
           , decimal Penalties
           , String Exp_Penalties
           , decimal other_Deductions
           , String Exp_OtherDeductions
           , decimal Total_AmountDeductions
            , String Notes
             , int Reason_EOS_Id
            , String Reason_EOS
             //Created By & Created Date
            , string Created_By
           , DateTime Created_Date

            )
        {
            SqlParameter[] para = new SqlParameter[41];
            para[0] = new SqlParameter("@Sett_ID", Sett_ID);
            para[1] = new SqlParameter("@Sett_Date", Sett_Date);
            para[2] = new SqlParameter("@Sett_Type_id", Sett_Type_id);
            para[3] = new SqlParameter("@Sett_Type", Sett_Type);
            para[4] = new SqlParameter("@emp_id", emp_id);
            para[5] = new SqlParameter("@emp_name", emp_name);
            para[6] = new SqlParameter("@Basic_Salary", Basic_Salary);
            para[7] = new SqlParameter("@House_Allow", House_Allow);
            para[8] = new SqlParameter("@Other_Allow", Other_Allow);
            para[9] = new SqlParameter("@Total_Salary", Total_Salary);
            para[10] = new SqlParameter("@last_day_working", last_day_working);
            para[11] = new SqlParameter("@End_of_service_Award", End_of_service_Award);
            para[12] = new SqlParameter("@WorkingDays", WorkingDays);
            para[13] = new SqlParameter("@WorkingYears", WorkingYears);
            para[14] = new SqlParameter("@WorkingDays_Amount", WorkingDays_Amount);
            para[15] = new SqlParameter("@Vac_starting", Vac_starting);
            para[16] = new SqlParameter("@Vac_ending", Vac_ending);
            para[17] = new SqlParameter("@Vac_days", Vac_days);
            para[18] = new SqlParameter("@Vac_CountedDays", Vac_CountedDays);
            para[19] = new SqlParameter("@Vac_CountedDays_Amount", Vac_CountedDays_Amount);
            para[20] = new SqlParameter("@Ticket_benefit", Ticket_benefit);
            para[21] = new SqlParameter("@Ticket_Amount", Ticket_Amount);
            para[22] = new SqlParameter("@sett_otherBenefits", sett_otherBenefits);
            para[23] = new SqlParameter("@Exp_otherBenefits", Exp_otherBenefits);
            para[24] = new SqlParameter("@total_Amount_Benefits", total_Amount_Benefits);
            para[25] = new SqlParameter("@Adv_house_allow", Adv_house_allow);
            para[26] = new SqlParameter("@Loan", Loan);
            para[27] = new SqlParameter("@gosi", gosi);
            para[28] = new SqlParameter("@assets", assets);
            para[29] = new SqlParameter("@Exp_assets", Exp_assets);
            para[30] = new SqlParameter("@Penalties", Penalties);
            para[31] = new SqlParameter("@Exp_Penalties", Exp_Penalties);
            para[32] = new SqlParameter("@other_Deductions", other_Deductions);
            para[33] = new SqlParameter("@Exp_OtherDeductions", Exp_OtherDeductions);
            para[34] = new SqlParameter("@Total_AmountDeductions", Total_AmountDeductions);
            para[35] = new SqlParameter("@Notes", Notes);
            para[36] = new SqlParameter("@Reason_EOS_Id", Reason_EOS_Id);
            para[37] = new SqlParameter("@Reason_EOS", Reason_EOS);
            //Created By & Created Date
            para[38] = new SqlParameter("@Created_By", Created_By);
            para[39] = new SqlParameter("@Created_Date", Created_Date);

            para[40] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Settlement", para);
            dtac.close();
        }
        //الحذف
        public void mng_SettlementDel(int Sett_ID)

        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Sett_ID", Sett_ID);

            dtac.open();
            dtac.ExcutCommand("mng_SettlementDel", para);
            dtac.close();
        }


        //لإضافة الارقام
        public DataTable Get_SettlementId()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_SettlementId", null);
            dtac.close();
            return dt;
        }


        // إظهار جميع السجلات للبحث
        public DataTable ShowSettlement(int Sett_ID)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Sett_ID", Sett_ID);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowSettlement", para);
            dtac.close();
            return dt;
        }
        //للبحث
        public DataTable SearchSettlement (string searchSETT)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@searchSETT", searchSETT);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchSettlement", para);
            dtac.close();
            return dt;
        }
        //Show All St For EMP

        public DataTable ShowSittlmentEmpId(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowSittlmentEmpId", para);
            dtac.close();
            return dt;
        }


        public DataTable SittlmentEmpId_Showing(int emp_id, int sett_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[1] = new SqlParameter("@emp_id", emp_id);
            para[0] = new SqlParameter("@sett_id", @sett_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SittlmentEmpId_Showing", para);
            dtac.close();
            return dt;
        }

    }
}
