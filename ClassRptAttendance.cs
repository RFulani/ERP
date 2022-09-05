using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace INV.Code
{
    class ClassRptAttendance
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //اضافة تقرير الرواتب
        public void mng_RptAttendaceAdd(
                                          int emp_id
                                        , int rpta_id
                                        , string emp_name
                                        , DateTime salary_date
                                        , decimal Overtime
                                        , decimal Overtime_Value
                                        , decimal Overtime_Holiday
                                        , decimal OverTime_Holiday_Value
                                        , decimal Late_Time
                                        , decimal LateTime_Value
                                        , decimal Absent
                                        , decimal Absent_Value
                                        , decimal early_LogOut
                                        , decimal early_LogOut_Value

                               //Created By & Created Date
                               , string Created_By
                               , DateTime Created_Date
                                        )


        {
            SqlParameter[] para = new SqlParameter[17];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@rpta_id", rpta_id);
            para[2] = new SqlParameter("@emp_name", emp_name);
            para[3] = new SqlParameter("@salary_date", salary_date);
            para[4] = new SqlParameter("@Overtime", Overtime);
            para[5] = new SqlParameter("@Overtime_Value", Overtime_Value);
            para[6] = new SqlParameter("@Overtime_Holiday", Overtime_Holiday);
            para[7] = new SqlParameter("@OverTime_Holiday_Value", OverTime_Holiday_Value);
            para[8] = new SqlParameter("@Late_Time", Late_Time);
            para[9] = new SqlParameter("@LateTime_Value", LateTime_Value);
            para[10] = new SqlParameter("@Absent", Absent);
            para[11] = new SqlParameter("@Absent_Value", Absent_Value);
            para[12] = new SqlParameter("@early_LogOut", early_LogOut);
            para[13] = new SqlParameter("@early_LogOut_Value", early_LogOut_Value);

            //Created By & Created Date
            para[14] = new SqlParameter("@Created_By", Created_By);
            para[15] = new SqlParameter("@Created_Date", Created_Date);
            para[16] = new SqlParameter("@check", "a");

            dtac.open();
            dtac.ExcutCommand("mng_RptAttendace", para);
            dtac.close();


        }



        //تعديل تقرير الرواتب
        public void mng_RptAttendaceUpdate(
                                             int emp_id
                                           , int rpta_id
                                           , string emp_name
                                           , DateTime salary_date
                                           , decimal Overtime
                                           , decimal Overtime_Value
                                           , decimal Overtime_Holiday
                                           , decimal OverTime_Holiday_Value
                                           , decimal Late_Time
                                           , decimal LateTime_Value
                                           , decimal Absent
                                           , decimal Absent_Value
               , decimal early_LogOut
                                        , decimal early_LogOut_Value
                               //Created By & Created Date
                               , string Created_By
                               , DateTime Created_Date
                                           )


        {

            SqlParameter[] para = new SqlParameter[17];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@rpta_id", rpta_id);
            para[2] = new SqlParameter("@emp_name", emp_name);
            para[3] = new SqlParameter("@salary_date", salary_date);
            para[4] = new SqlParameter("@Overtime", Overtime);
            para[5] = new SqlParameter("@Overtime_Value", Overtime_Value);
            para[6] = new SqlParameter("@Overtime_Holiday", Overtime_Holiday);
            para[7] = new SqlParameter("@OverTime_Holiday_Value", OverTime_Holiday_Value);
            para[8] = new SqlParameter("@Late_Time", Late_Time);
            para[9] = new SqlParameter("@LateTime_Value", LateTime_Value);
            para[10] = new SqlParameter("@Absent", Absent);
            para[11] = new SqlParameter("@Absent_Value", Absent_Value);
            para[12] = new SqlParameter("@early_LogOut", early_LogOut);
            para[13] = new SqlParameter("@early_LogOut_Value", early_LogOut_Value);

            //Created By & Created Date
            para[14] = new SqlParameter("@Created_By", Created_By);
            para[15] = new SqlParameter("@Created_Date", Created_Date);

            para[16] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_RptAttendace", para);
            dtac.close();

        }


        //بحث تقرير الرواتب
        public DataTable mng_RptAttendaceSearch(int rpta_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rpta_id", rpta_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("mng_RptAttendaceSearch", para);
            dtac.close();
            return dt;
        }


        // حذف تقرير الرواتب
        public void mng_RptAttendaceDel(int rpta_id)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rpta_id", rpta_id);

            dtac.open();
            dtac.ExcutCommand("mng_RptAttendaceDel", para);
            dtac.close();
        }

        //Get rpta_id
        public DataTable Get_rpta_id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("rpta_id", null);
            dtac.close();
            return dt;
        }


        //Check by rpta_id
        public DataTable CheckRPTA_ById(int rpta_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rpta_id", rpta_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("CheckRPTA_ById", para);
            dtac.close();
            return dt;
        }
        public DataTable ShowEmpByBranch(int branch_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@branch_id", branch_id);
            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("ShowEmpByBranch", para);
            dtac.close();
            return dtemp;
        }
        public DataTable CheckATT(int rpta_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rpta_id", rpta_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("CheckATT", para);
            dtac.close();
            return dt;
        }
        public DataTable GetDataSalaryAndAtt(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetDataSalaryAndAtt", para);
            dtac.close();
            return dt;
        }
        public DataTable SearchRptA(string vrb_serch)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", vrb_serch);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchRptA", para);
            dtac.close();
            return dt;
        }
        public DataTable ShowRptADetails(int rpta_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rpta_id", rpta_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowRptADetails", para);
            dtac.close();
            return dt;
        }
    }
}
