using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassJobContract
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_JobContract_add(
                                        int JobContract_Id 
                                       ,int emp_id
                                       , String emp_cardType
                                       , String emp_cardId
                                       , String emp_Name_Ar
                                       , String emp_Name_En
                                       , String Nationaliy
                                       , String Gender
                                       , String Religion
                                       , DateTime DOB
                                       , String Marital_status
                                       , int dependes
                                       , String Quailification
                                       , String major_ar
                                       , String Position_Name
                                       , String branch
                                       , String department
                                       , int Vac
                                       , int Vac_days
                                       , int Vac_Hours 
                                       , String Contract_Type
                                       , DateTime start_contract
                                       , DateTime end_contract
                                       , DateTime Start_work
                                       , String phoneNo_sp
                                       , String Email_sp
                                       , String Address
                                       , byte[] Emp_Image
                                       , String Emp_Notes
                                       , decimal Basic_Salary
                                       , decimal House_Allow
                                       , decimal transportation
                                       , decimal fuel
                                       , decimal total_salary
                                       , string contract_period
                                       , string businessDays
                                       , string Visa
                                       //Created By & Created Date
                                       , string Created_By
                                       , DateTime Created_Date

                                                           )
        {
            SqlParameter[] para = new SqlParameter[40];
            para[0] = new SqlParameter("@JobContract_Id", JobContract_Id);
            para[1] = new SqlParameter("@emp_id", emp_id);
            para[2] = new SqlParameter("@emp_cardType", emp_cardType);
            para[3] = new SqlParameter("@emp_cardId", emp_cardId);
            para[4] = new SqlParameter("@emp_Name_Ar", emp_Name_Ar);
            para[5] = new SqlParameter("@emp_Name_En", emp_Name_En);
            para[6] = new SqlParameter("@Nationaliy", Nationaliy);
            para[7] = new SqlParameter("@Gender", Gender);
            para[8] = new SqlParameter("@Religion", Religion);
            para[9] = new SqlParameter("@DOB", DOB);
            para[10] = new SqlParameter("@Marital_status", Marital_status);
            para[11] = new SqlParameter("@dependes", dependes);
            para[12] = new SqlParameter("Quailification", Quailification);
            para[13] = new SqlParameter("@major_ar", major_ar);
            para[14] = new SqlParameter("@Position_Name", Position_Name);
            para[15] = new SqlParameter("@branch", branch);
            para[16] = new SqlParameter("@department", department);
            para[17] = new SqlParameter("@Vac", Vac);
            para[18] = new SqlParameter("@Vac_days", Vac_days);
            para[19] = new SqlParameter("@Vac_Hours", Vac_Hours);
            para[20] = new SqlParameter("@Contract_Type", Contract_Type);
            para[21] = new SqlParameter("@start_contract", start_contract);
            para[22] = new SqlParameter("@end_contract", end_contract);
            para[23] = new SqlParameter("@Start_work", Start_work);
            para[24] = new SqlParameter("@phoneNo_sp", phoneNo_sp);
            para[25] = new SqlParameter("@Email_sp", Email_sp);
            para[26] = new SqlParameter("@Address", Address);
            para[27] = new SqlParameter("@Emp_Image", Emp_Image);
            para[28] = new SqlParameter("@Emp_Notes", Emp_Notes);
            para[29] = new SqlParameter("@Basic_Salary", Basic_Salary);
            para[30] = new SqlParameter("@House_Allow", House_Allow);
            para[31] = new SqlParameter("@transportation", transportation);
            para[32] = new SqlParameter("@fuel", fuel);
            para[33] = new SqlParameter("@total_salary", total_salary);
            para[34] = new SqlParameter("@contract_period", contract_period);
            para[35] = new SqlParameter("@businessDays", businessDays);
            para[36] = new SqlParameter("@Visa", Visa);
            //Created By & Created Date
            para[37] = new SqlParameter("@Created_By", Created_By);
            para[38] = new SqlParameter("@Created_Date", Created_Date);

            para[39] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_JobContract", para);
            dtac.close();
        }
        public void mng_JobContract_Update(
  int JobContract_Id
                                       , int emp_id
                                       , String emp_cardType
                                       , String emp_cardId
                                       , String emp_Name_Ar
                                       , String emp_Name_En
                                       , String Nationaliy
                                       , String Gender
                                       , String Religion
                                       , DateTime DOB
                                       , String Marital_status
                                       , int dependes
                                       , String Quailification
                                       , String major_ar
                                       , String Position_Name
                                       , String branch
                                       , String department
                                       , int Vac
                                       , int Vac_days
                                       , int Vac_Hours
                                       , String Contract_Type
                                       , DateTime start_contract
                                       , DateTime end_contract
                                       , DateTime Start_work
                                       , String phoneNo_sp
                                       , String Email_sp
                                       , String Address
                                       , byte[] Emp_Image
                                       , String Emp_Notes
                                       , decimal Basic_Salary
                                       , decimal House_Allow
                                       , decimal transportation
                                       , decimal fuel
                                       , decimal total_salary
                                       , string contract_period
                                       , string businessDays
                                       , string Visa
                                       //Created By & Created Date
                                       , string Created_By
                                       , DateTime Created_Date

                                                           )
        {

            SqlParameter[] para = new SqlParameter[40];
            para[0] = new SqlParameter("@JobContract_Id", JobContract_Id);
            para[1] = new SqlParameter("@emp_id", emp_id);
            para[2] = new SqlParameter("@emp_cardType", emp_cardType);
            para[3] = new SqlParameter("@emp_cardId", emp_cardId);
            para[4] = new SqlParameter("@emp_Name_Ar", emp_Name_Ar);
            para[5] = new SqlParameter("@emp_Name_En", emp_Name_En);
            para[6] = new SqlParameter("@Nationaliy", Nationaliy);
            para[7] = new SqlParameter("@Gender", Gender);
            para[8] = new SqlParameter("@Religion", Religion);
            para[9] = new SqlParameter("@DOB", DOB);
            para[10] = new SqlParameter("@Marital_status", Marital_status);
            para[11] = new SqlParameter("@dependes", dependes);
            para[12] = new SqlParameter("Quailification", Quailification);
            para[13] = new SqlParameter("@major_ar", major_ar);
            para[14] = new SqlParameter("@Position_Name", Position_Name);
            para[15] = new SqlParameter("@branch", branch);
            para[16] = new SqlParameter("@department", department);
            para[17] = new SqlParameter("@Vac", Vac);
            para[18] = new SqlParameter("@Vac_days", Vac_days);
            para[19] = new SqlParameter("@Vac_Hours", Vac_Hours);
            para[20] = new SqlParameter("@Contract_Type", Contract_Type);
            para[21] = new SqlParameter("@start_contract", start_contract);
            para[22] = new SqlParameter("@end_contract", end_contract);
            para[23] = new SqlParameter("@Start_work", Start_work);
            para[24] = new SqlParameter("@phoneNo_sp", phoneNo_sp);
            para[25] = new SqlParameter("@Email_sp", Email_sp);
            para[26] = new SqlParameter("@Address", Address);
            para[27] = new SqlParameter("@Emp_Image", Emp_Image);
            para[28] = new SqlParameter("@Emp_Notes", Emp_Notes);
            para[29] = new SqlParameter("@Basic_Salary", Basic_Salary);
            para[30] = new SqlParameter("@House_Allow", House_Allow);
            para[31] = new SqlParameter("@transportation", transportation);
            para[32] = new SqlParameter("@fuel", fuel);
            para[33] = new SqlParameter("@total_salary", total_salary);
            para[34] = new SqlParameter("@contract_period", contract_period);
            para[35] = new SqlParameter("@businessDays", businessDays);
            para[36] = new SqlParameter("@Visa", Visa);
            //Created By & Created Date
            para[37] = new SqlParameter("@Created_By", Created_By);
            para[38] = new SqlParameter("@Created_Date", Created_Date);

            para[39] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_JobContract", para);
            dtac.close();
        }

        //الحذف
        public void mng_JobContractDel(int JobContract_Id)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@JobContract_Id", JobContract_Id);

            dtac.open();
            dtac.ExcutCommand("mng_JobContractDel", para);
            dtac.close();
        }

        //للحصول على رقم الموظف
        public DataTable Get_EmpIdForJobContract()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("emp_id", null);
            dtac.close();
            return dt;
        }


        public DataTable CheckEmpJC_ById(int JobContract_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@JobContract_Id", JobContract_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("CheckEmpJC_ById", para);
            dtac.close();
            return dt;
        }
        public DataTable ShowJobContract(int JobContract_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@JobContract_Id", JobContract_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowJobContract", para);
            dtac.close();
            return dt;
        }


        public DataTable SearchJobContract(string searchJC)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@searchJC", searchJC);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchJobContract", para);
            dtac.close();
            return dt;
        }

        //لإضافة الارقام
        public DataTable Get_JobContracttId()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_JobContracttId", null);
            dtac.close();
            return dt;
        }


    }
}
