using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassEmployee_Vacation_Request
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_Employee_Vacation_Request_add(
                                                            int Vac_Id
                                                          , DateTime Vac_Date
                                                          , int Vac_Type_Id
                                                          , String Vac_Type_Name
                                                          , int Vac_Emp_Id
                                                          , String Vac_Emp_Name
                                                          , int Vac_Days
                                                          , DateTime Vac_Starting
                                                          , DateTime Vac_Ending
                                                          , decimal Vac_Hours
                                                          , DateTime Vac_Hours_Leaving
                                                          , DateTime Vac_Hours_Returning
                                                          , String Vac_Hospital_Name
                                                          , String Vac_Hospital_Report_Id
                                                          , DateTime Vac_Hospital_Report_Date
                                                          , String Vac_Reason
                                                          , String Vac_Notes
                                                          , int Emp2nd_Id
                                                          , string Emp2nd_Name
                                                          , string VR_Address
                                                          , string VR_Phone
                                                          , int Vac_Status_Id
                                                          , string Vac_Status
                                                          //Created By & Created Date
                                                          , string Created_By
                                                          , DateTime Created_Date
                                                           )
        {
            SqlParameter[] para = new SqlParameter[26];
            para[0] = new SqlParameter("@Vac_Id", Vac_Id);
            para[1] = new SqlParameter("@Vac_Date", Vac_Date);
            para[2] = new SqlParameter("@Vac_Type_Id", Vac_Type_Id);
            para[3] = new SqlParameter("@Vac_Type_Name", Vac_Type_Name);
            para[4] = new SqlParameter("@Vac_Emp_Id", Vac_Emp_Id);
            para[5] = new SqlParameter("@Vac_Emp_Name", Vac_Emp_Name);
            para[6] = new SqlParameter("@Vac_Days", Vac_Days);
            para[7] = new SqlParameter("@Vac_Starting", Vac_Starting);
            para[8] = new SqlParameter("@Vac_Ending", Vac_Ending);
            para[9] = new SqlParameter("@Vac_Hours", Vac_Hours);
            para[10] = new SqlParameter("@Vac_Hours_Leaving", Vac_Hours_Leaving);
            para[11] = new SqlParameter("@Vac_Hours_Returning", Vac_Hours_Returning);
            para[12] = new SqlParameter("@Vac_Hospital_Name", Vac_Hospital_Name);
            para[13] = new SqlParameter("@Vac_Hospital_Report_Id", Vac_Hospital_Report_Id);
            para[14] = new SqlParameter("@Vac_Hospital_Report_Date", Vac_Hospital_Report_Date);
            para[15] = new SqlParameter("@Vac_Reason", Vac_Reason);
            para[16] = new SqlParameter("@Vac_Notes", Vac_Notes);
            para[17] = new SqlParameter("@Emp2nd_Id", Emp2nd_Id);
            para[18] = new SqlParameter("@Emp2nd_Name", Emp2nd_Name);
            para[19] = new SqlParameter("@VR_Address", VR_Address);
            para[20] = new SqlParameter("@VR_Phone", VR_Phone);
            para[21] = new SqlParameter("@Vac_Status_Id", Vac_Status_Id);
            para[22] = new SqlParameter("@Vac_Status", Vac_Status);
            //Created By & Created Date
            para[23] = new SqlParameter("@Created_By", Created_By);
            para[24] = new SqlParameter("@Created_Date", Created_Date);
            para[25] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Employee_Vacation_Request", para);
            dtac.close();
        }
        public void mng_Employee_Vacation_Request_Update(
                                                            int Vac_Id
                                                          , DateTime Vac_Date
                                                          , int Vac_Type_Id
                                                          , String Vac_Type_Name
                                                          , int Vac_Emp_Id
                                                          , String Vac_Emp_Name
                                                          , int Vac_Days
                                                          , DateTime Vac_Starting
                                                          , DateTime Vac_Ending
                                                          , decimal Vac_Hours
                                                          , DateTime Vac_Hours_Leaving
                                                          , DateTime Vac_Hours_Returning
                                                          , String Vac_Hospital_Name
                                                          , String Vac_Hospital_Report_Id
                                                          , DateTime Vac_Hospital_Report_Date
                                                          , String Vac_Reason
                                                          , String Vac_Notes
                                                          , int Emp2nd_Id
                                                          , string Emp2nd_Name
                                                          , string VR_Address
                                                          , string VR_Phone
                                                          , int Vac_Status_Id
                                                          , string Vac_Status
                                                          //Created By & Created Date
                                                          , string Created_By
                                                          , DateTime Created_Date
                                                           )
        {
            SqlParameter[] para = new SqlParameter[26];
            para[0] = new SqlParameter("@Vac_Id", Vac_Id);
            para[1] = new SqlParameter("@Vac_Date", Vac_Date);
            para[2] = new SqlParameter("@Vac_Type_Id", Vac_Type_Id);
            para[3] = new SqlParameter("@Vac_Type_Name", Vac_Type_Name);
            para[4] = new SqlParameter("@Vac_Emp_Id", Vac_Emp_Id);
            para[5] = new SqlParameter("@Vac_Emp_Name", Vac_Emp_Name);
            para[6] = new SqlParameter("@Vac_Days", Vac_Days);
            para[7] = new SqlParameter("@Vac_Starting", Vac_Starting);
            para[8] = new SqlParameter("@Vac_Ending", Vac_Ending);
            para[9] = new SqlParameter("@Vac_Hours", Vac_Hours);
            para[10] = new SqlParameter("@Vac_Hours_Leaving", Vac_Hours_Leaving);
            para[11] = new SqlParameter("@Vac_Hours_Returning", Vac_Hours_Returning);
            para[12] = new SqlParameter("@Vac_Hospital_Name", Vac_Hospital_Name);
            para[13] = new SqlParameter("@Vac_Hospital_Report_Id", Vac_Hospital_Report_Id);
            para[14] = new SqlParameter("@Vac_Hospital_Report_Date", Vac_Hospital_Report_Date);
            para[15] = new SqlParameter("@Vac_Reason", Vac_Reason);
            para[16] = new SqlParameter("@Vac_Notes", Vac_Notes);
            para[17] = new SqlParameter("@Emp2nd_Id", Emp2nd_Id);
            para[18] = new SqlParameter("@Emp2nd_Name", Emp2nd_Name);
            para[19] = new SqlParameter("@VR_Address", VR_Address);
            para[20] = new SqlParameter("@VR_Phone", VR_Phone);
            para[21] = new SqlParameter("@Vac_Status_Id", Vac_Status_Id);
            para[22] = new SqlParameter("@Vac_Status", Vac_Status);
            //Created By & Created Date
            para[23] = new SqlParameter("@Created_By", Created_By);
            para[24] = new SqlParameter("@Created_Date", Created_Date);
            para[25] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Employee_Vacation_Request", para);
            dtac.close();
        }
       
        //الحذف
        public void mng_Employee_Vacation_RequestDel(int Vac_Id, int emp_id)


        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Vac_Id", Vac_Id);
            para[1] = new SqlParameter("@emp_id", emp_id);

            dtac.open();
            dtac.ExcutCommand("mng_Employee_Vacation_RequestDel", para);
            dtac.close();
        }

       // إظهار جميع السجلات للبحث
        public DataTable ShowVacation_Request(int Vac_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Vac_Id", Vac_Id);
            
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowVacation_Request", para);
            dtac.close();
            return dt;
        }

        //لإضافة الارقام
        public DataTable Get_Employee_Vacation_Request()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Employee_Vacation_Request", null);
            dtac.close();
            return dt;
        }
        //للبحث
        public DataTable SearchEmployee_Vacation_Request(string searchEVR)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@searchEVR", searchEVR);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchEmployee_Vacation_Request", para);
            dtac.close();
            return dt;
        }
      
        public DataTable Vactionrequest_Showing(int Vac_Emp_Id, int Vac_Id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[1] = new SqlParameter("@Vac_Emp_Id", Vac_Emp_Id);
            para[0] = new SqlParameter("@Vac_Id", Vac_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Vactionrequest_Showing", para);
            dtac.close();
            return dt;
        }
       
        /*لتعديل حاله الموظف في ملفات الموظفين بعد إعتماد الإجازه*/
        public void UpdatingEmpStatus_Vac(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);

            dtac.open();
            dtac.ExcutCommand("UpdatingEmpStatus_Vac", para);
            dtac.close();
        }
        /*لتغيير حاله الموظف في ملفات الموظفين في حاله رفض الإجازة*/
        public void UpdatingEmpStatus_Vac1(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);

            dtac.open();
            dtac.ExcutCommand("UpdatingEmpStatus_Vac1", para);
            dtac.close();
        }


        public DataTable ShowVacforAtt(int emp_id, DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@Date_From", from);
            para[2] = new SqlParameter("@Date_To", to);


            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("ShowVacforAtt", para);
            dtac.close();
            return dtemp;
        }

        //*-*-*-*-*-*-*--*-*-*-*-*-*-*-*-*--*-*-*-*-*-*-*--*-*-*-*--*-*-*-*-------*-*--*-*-*
        //لإظهار جميع طلبات الإجازه
        public DataTable ShowAllVacation_Request(int Vac_Emp_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Vac_Emp_Id", Vac_Emp_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllVacation_Request", para);
            dtac.close();
            return dt;
        }
        //لإظهار جميع طلبات الإجازه بناءاً على حاله الطلب
        public DataTable ShowAllVacation_Request_ByStatus(int Vac_Emp_Id, int Vac_Status_Id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Vac_Emp_Id", Vac_Emp_Id);
            para[1] = new SqlParameter("@Vac_Status_Id", Vac_Status_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllVacation_Request_ByStatus", para);
            dtac.close();
            return dt;
        }
        //لإظهار جميع طلبات الإجازه بناءاً على الفتره  
        public DataTable ShowAllVac_byDate(int emp_id, DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@Date_From", from);
            para[2] = new SqlParameter("@Date_To", to);


            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("ShowAllVac_byDate", para);
            dtac.close();
            return dtemp;
        }
        //لإظهار جميع طلبات الإجازه بناءاً على الفتره والحاله
        public DataTable ShowAllVac_byDateandStatus(int emp_id, DateTime from, DateTime to, int Vac_Status_Id)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@Date_From", from);
            para[2] = new SqlParameter("@Date_To", to);
            para[3] = new SqlParameter("@Vac_Status_Id", Vac_Status_Id);


            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("ShowAllVac_byDateandStatus", para);
            dtac.close();
            return dtemp;
        }

    }
}
