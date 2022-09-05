using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace INV.Code
{
    class ClassSalaryIncrease
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_SalaryIncrease_add(
            int SalaryIncrease_Id
           , DateTime SalaryIncrease_date
           , int emp_id
           , string emp_name
           , Decimal basic_salary
           , Decimal house_allowance
           , Decimal transportation_allowance
           , Decimal fuel_allowance
           , Decimal other_allowance
           , Decimal TotalSalary
           , Decimal SalaryIncrease_Basic
           , Decimal SalaryIncrease_House
           , Decimal SalaryIncrease_Transportation
           , Decimal SalaryIncrease_Fuel
           , Decimal SalaryIncrease_OtherAllow
           , Decimal SalaryIncrease_TotalSalary
            , Decimal suggestedInc
           , String Notes
            ,String Sal_Status
                               //Created By & Created Date
                               , string Created_By
                               , DateTime Created_Date


            )
        {
            SqlParameter[] para = new SqlParameter[22];
            para[0] = new SqlParameter("@SalaryIncrease_Id", SalaryIncrease_Id);
            para[1] = new SqlParameter("@SalaryIncrease_date", SalaryIncrease_date);
            para[2] = new SqlParameter("@emp_id", emp_id);
            para[3] = new SqlParameter("@emp_name", emp_name);
            para[4] = new SqlParameter("@basic_salary", basic_salary);
            para[5] = new SqlParameter("@house_allowance", house_allowance);
            para[6] = new SqlParameter("@transportation_allowance", transportation_allowance);
            para[7] = new SqlParameter("@fuel_allowance", fuel_allowance);
            para[8] = new SqlParameter("@other_allowance", other_allowance);
            para[9] = new SqlParameter("@TotalSalary", TotalSalary);
            para[10] = new SqlParameter("@SalaryIncrease_Basic", SalaryIncrease_Basic);
            para[11] = new SqlParameter("@SalaryIncrease_House", SalaryIncrease_House);
            para[12] = new SqlParameter("@SalaryIncrease_Transportation", SalaryIncrease_Transportation);
            para[13] = new SqlParameter("@SalaryIncrease_Fuel", SalaryIncrease_Fuel);
            para[14] = new SqlParameter("@SalaryIncrease_OtherAllow", SalaryIncrease_OtherAllow);
            para[15] = new SqlParameter("@SalaryIncrease_TotalSalary", SalaryIncrease_TotalSalary);
            para[16] = new SqlParameter("@suggestedInc", suggestedInc);
            para[17] = new SqlParameter("@Notes", Notes);
            para[18] = new SqlParameter("@Sal_Status", Sal_Status);
            //Created By & Created Date
            para[19] = new SqlParameter("@Created_By", Created_By);
            para[20] = new SqlParameter("@Created_Date", Created_Date);
            para[21] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_SalaryIncrease", para);
            dtac.close();

        }


        public void mng_SalaryIncrease_Update(
               int SalaryIncrease_Id
               , DateTime SalaryIncrease_date
               , int emp_id
               , string emp_name
               , Decimal basic_salary
               , Decimal house_allowance
               , Decimal transportation_allowance
               , Decimal fuel_allowance
               , Decimal other_allowance
               , Decimal TotalSalary
               , Decimal SalaryIncrease_Basic
               , Decimal SalaryIncrease_House
               , Decimal SalaryIncrease_Transportation
               , Decimal SalaryIncrease_Fuel
               , Decimal SalaryIncrease_OtherAllow
               , Decimal SalaryIncrease_TotalSalary
            ,Decimal suggestedInc
               , String Notes
            ,string Sal_Status
                               //Created By & Created Date
                               , string Created_By
                               , DateTime Created_Date
              )
        {
            SqlParameter[] para = new SqlParameter[22];
            para[0] = new SqlParameter("@SalaryIncrease_Id", SalaryIncrease_Id);
            para[1] = new SqlParameter("@SalaryIncrease_date", SalaryIncrease_date);
            para[2] = new SqlParameter("@emp_id", emp_id);
            para[3] = new SqlParameter("@emp_name", emp_name);
            para[4] = new SqlParameter("@basic_salary", basic_salary);
            para[5] = new SqlParameter("@house_allowance", house_allowance);
            para[6] = new SqlParameter("@transportation_allowance", transportation_allowance);
            para[7] = new SqlParameter("@fuel_allowance", fuel_allowance);
            para[8] = new SqlParameter("@other_allowance", other_allowance);
            para[9] = new SqlParameter("@TotalSalary", TotalSalary);
            para[10] = new SqlParameter("@SalaryIncrease_Basic", SalaryIncrease_Basic);
            para[11] = new SqlParameter("@SalaryIncrease_House", SalaryIncrease_House);
            para[12] = new SqlParameter("@SalaryIncrease_Transportation", SalaryIncrease_Transportation);
            para[13] = new SqlParameter("@SalaryIncrease_Fuel", SalaryIncrease_Fuel);
            para[14] = new SqlParameter("@SalaryIncrease_OtherAllow", SalaryIncrease_OtherAllow);
            para[15] = new SqlParameter("@SalaryIncrease_TotalSalary", SalaryIncrease_TotalSalary);
            para[16] = new SqlParameter("@suggestedInc", suggestedInc);
            para[17] = new SqlParameter("@Notes", Notes);
            para[18] = new SqlParameter("@Sal_Status", Sal_Status);
            //Created By & Created Date
            para[19] = new SqlParameter("@Created_By", Created_By);
            para[20] = new SqlParameter("@Created_Date", Created_Date);
            para[21] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_SalaryIncrease", para);
            dtac.close();
        }
        //الحذف
        public void mng_SalaryIncrease_Del(int SalaryIncrease_Id)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@SalaryIncrease_Id", SalaryIncrease_Id);

            dtac.open();
            dtac.ExcutCommand("mng_SalaryIncreaseDel", para);
            dtac.close();
        }
        //لإضافة الارقام
        public DataTable Get_SalaryIncrease_Id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_SalaryIncrease_Id", null);
            dtac.close();
            return dt;
        }
        // إظهار جميع السجلات للبحث
        public DataTable ShowSalaryIncrease(int SalaryIncrease_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@SalaryIncrease_Id", SalaryIncrease_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowSalaryIncrease", para);
            dtac.close();
            return dt;
        }
        //للبحث
        public DataTable SearchSalaryIncrease(string searchSIn)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@searchSIn", searchSIn);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchSalaryIncrease", para);
            dtac.close();
            return dt;
        }
        public DataTable allSalaryIncrease(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id",emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("allSalaryIncrease", para);
            dtac.close();
            return dt;
        }
        /*للاعتماد*/
        public void UpdateStatusSal(
      
     string Sal_Status
     ,int  SalaryIncrease_Id   


      )
        {
            SqlParameter[] para = new SqlParameter[2];
            
            para[0] = new SqlParameter("@Sal_Status", Sal_Status);
            para[1] = new SqlParameter("@SalaryIncrease_Id", SalaryIncrease_Id);

            dtac.open();
            dtac.ExcutCommand("UpdateStatusSal", para);
            dtac.close();
        }
        /*لتعديل راتب الموظف في ملفات الموظفين*/
        public void Updatingsalary(

    int emp_id ,
    decimal basic_salary   ,
	decimal house_allowance ,
	decimal transportation_allowance  ,
	decimal petrol_allowance  ,
	decimal other_allowance 


     )
        {
            SqlParameter[] para = new SqlParameter[6];

            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@basic_salary", basic_salary);
            para[2] = new SqlParameter("@house_allowance", house_allowance);
            para[3] = new SqlParameter("@transportation_allowance", transportation_allowance);
            para[4] = new SqlParameter("@petrol_allowance", petrol_allowance);
            para[5] = new SqlParameter("@other_allowance", other_allowance);


            dtac.open();
            dtac.ExcutCommand("Updatingsalary", para);
            dtac.close();
        }
    }
}

