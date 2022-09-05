using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassAssignments
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_Assignments_add(
            int Assignments_Id
           , int emp_id
           , string Emp_Name
           , int emp_id_2
           , string Emp_Name_2
           , string Task 
           ,DateTime Task_date 
           , DateTime Task_Time_From  
           , DateTime Task_Time_To  
           , decimal Task_Period
           , int Assign_SignIn
           , int Assign_LogIn
           , string Notes
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[16];
            para[0] = new SqlParameter("@Assignments_Id", Assignments_Id);
            para[1] = new SqlParameter("@emp_id", emp_id);
            para[2] = new SqlParameter("@Emp_Name", Emp_Name);
            para[3] = new SqlParameter("@emp_id_2", emp_id_2);
            para[4] = new SqlParameter("@Emp_Name_2", Emp_Name_2);
            para[5] = new SqlParameter("@Task", Task);
            para[6] = new SqlParameter("@Task_date", Task_date);
            para[7] = new SqlParameter("@Task_Time_From", Task_Time_From);
            para[8] = new SqlParameter("@Task_Time_To", Task_Time_To);
            para[9] = new SqlParameter("@Task_Period", Task_Period);
            para[10] = new SqlParameter("@Assign_SignIn", Assign_SignIn);
            para[11] = new SqlParameter("@Assign_LogIn", Assign_LogIn);
            para[12] = new SqlParameter("@Notes", Notes);
            //Created By & Created Date
            para[13] = new SqlParameter("@Created_By", Created_By);
            para[14] = new SqlParameter("@Created_Date", Created_Date);

            para[15] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Assignments", para);
            dtac.close();
        }

        //التعديل

        public void mng_Assignments_Update(
         int Assignments_Id
           , int emp_id
           , string Emp_Name
           , int emp_id_2
           , string Emp_Name_2
           , string Task
           , DateTime Task_date
           , DateTime Task_Time_From
           , DateTime Task_Time_To
           , decimal Task_Period
           , int Assign_SignIn
           , int Assign_LogIn
           , string Notes
          //Created By & Created Date
           , string Created_By
           , DateTime Created_Date
          )
        {
            SqlParameter[] para = new SqlParameter[16];
            para[0] = new SqlParameter("@Assignments_Id", Assignments_Id);
            para[1] = new SqlParameter("@emp_id", emp_id);
            para[2] = new SqlParameter("@Emp_Name", Emp_Name);
            para[3] = new SqlParameter("@emp_id_2", emp_id_2);
            para[4] = new SqlParameter("@Emp_Name_2", Emp_Name_2);
            para[5] = new SqlParameter("@Task", Task);
            para[6] = new SqlParameter("@Task_date", Task_date);
            para[7] = new SqlParameter("@Task_Time_From", Task_Time_From);
            para[8] = new SqlParameter("@Task_Time_To", Task_Time_To);
            para[9] = new SqlParameter("@Task_Period", Task_Period);
            para[10] = new SqlParameter("@Assign_SignIn", Assign_SignIn);
            para[11] = new SqlParameter("@Assign_LogIn", Assign_LogIn);
            para[12] = new SqlParameter("@Notes", Notes);
            //Created By & Created Date
            para[13] = new SqlParameter("@Created_By", Created_By);
            para[14] = new SqlParameter("@Created_Date", Created_Date);
            para[15] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Assignments", para);
            dtac.close();
        }
        //الحذف
        public void mng_AssignmentsDel(int Assignments_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Assignments_Id", Assignments_Id);

            dtac.open();
            dtac.ExcutCommand("mng_AssignmentsDel", para);
            dtac.close();
        }


        public DataTable ShowAssignments(int Assignments_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Assignments_Id", Assignments_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAssignments", para);
            dtac.close();
            return dt;
        }

        public DataTable SearchAssignments(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchAssignments", para);
            dtac.close();
            return dt;
        }

        public DataTable Get_Assignments_Id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Assignments_Id", null);
            dtac.close();
            return dt;
        }


        public DataTable ShowAssignmentsforAtt( DateTime From, DateTime To)
        {
            SqlParameter[] para = new SqlParameter[2];
            
            para[0] = new SqlParameter("@From", From);
            para[1] = new SqlParameter("@To", To);
            
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAssignmentsforAtt", para);
            dtac.close();
            return dt;
        }
    }
}
