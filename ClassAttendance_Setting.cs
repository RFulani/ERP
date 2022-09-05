using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace INV.Code
{
    class ClassAttendance_Setting
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        //إضافة الحضور 
        public void mng_Attendance_Setting_Add(
                                  int Attendance_No
                                , string Attendance_Name
                                , string Notes
                                , DateTime punch_intime
                                , DateTime start_registerpunchin
                                , DateTime last_lateallowance
                                , DateTime punch_outtime
                                , DateTime end_pushouttime
                                , DateTime last_earilryallowpunchout
                                , double rate_overtime
                                , double rate_overtimeholiday
                                , double rate_absentdate
                                , double rate_late
                                , int emp_req
                                , int emp_out_req
                                , int emp_overtime_req
                                , DateTime date_from
                                , DateTime date_to
                                //Created By & Created Date
                                , string Created_By
                                , DateTime Created_Date

            )
        {
            SqlParameter[] para = new SqlParameter[21];
            para[0] = new SqlParameter("@Attendance_No", Attendance_No);
            para[1] = new SqlParameter("@Attendance_Name", Attendance_Name);
            para[2] = new SqlParameter("@Notes", Notes);
            para[3] = new SqlParameter("@punch_intime", punch_intime);
            para[4] = new SqlParameter("@start_registerpunchin", start_registerpunchin);
            para[5] = new SqlParameter("@last_lateallowance", last_lateallowance);
            para[6] = new SqlParameter("@punch_outtime", punch_outtime);
            para[7] = new SqlParameter("@end_pushouttime", end_pushouttime);
            para[8] = new SqlParameter("@last_earilryallowpunchout", last_earilryallowpunchout);
            para[9] = new SqlParameter("@rate_overtime", rate_overtime);
            para[10] = new SqlParameter("@rate_overtimeholiday", rate_overtimeholiday);
            para[11] = new SqlParameter("@rate_absentdate", rate_absentdate);
            para[12] = new SqlParameter("@rate_late", rate_late);
            para[13] = new SqlParameter("@emp_req", emp_req);
            para[14] = new SqlParameter("@emp_out_req", emp_out_req);
            para[15] = new SqlParameter("@emp_overtime_req ", emp_overtime_req);
            para[16] = new SqlParameter("@date_from ", date_from);
            para[17] = new SqlParameter("@date_to ", date_to);
            //Created By & Created Date
            para[18] = new SqlParameter("@Created_By", Created_By);
            para[19] = new SqlParameter("@Created_Date", Created_Date);
            para[20] = new SqlParameter("@check", "a");


            dtac.open();
            dtac.ExcutCommand("mng_Attendance_Setting", para);
            dtac.close();

        }

        // تعديل الحضور
        public void mng_Attendance_Setting_Update(
                                  int Attendance_No
                                , string Attendance_Name
                                , string Notes
                                , DateTime punch_intime
                                , DateTime start_registerpunchin
                                , DateTime last_lateallowance
                                , DateTime punch_outtime
                                , DateTime end_pushouttime
                                , DateTime last_earilryallowpunchout
                                , double rate_overtime
                                , double rate_overtimeholiday
                                , double rate_absentdate
                                , double rate_late
                                , int emp_req
                                , int emp_out_req
                                , int emp_overtime_req
                                , DateTime date_from
                                , DateTime date_to
                                //Created By & Created Date
                                , string Created_By
                                , DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[21];
            para[0] = new SqlParameter("@Attendance_No", Attendance_No);
            para[1] = new SqlParameter("@Attendance_Name", Attendance_Name);
            para[2] = new SqlParameter("@Notes", Notes);
            para[3] = new SqlParameter("@punch_intime", punch_intime);
            para[4] = new SqlParameter("@start_registerpunchin", start_registerpunchin);
            para[5] = new SqlParameter("@last_lateallowance", last_lateallowance);
            para[6] = new SqlParameter("@punch_outtime", punch_outtime);
            para[7] = new SqlParameter("@end_pushouttime", end_pushouttime);
            para[8] = new SqlParameter("@last_earilryallowpunchout", last_earilryallowpunchout);
            para[9] = new SqlParameter("@rate_overtime", rate_overtime);
            para[10] = new SqlParameter("@rate_overtimeholiday", rate_overtimeholiday);
            para[11] = new SqlParameter("@rate_absentdate", rate_absentdate);
            para[12] = new SqlParameter("@rate_late", rate_late);
            para[13] = new SqlParameter("@emp_req", emp_req);
            para[14] = new SqlParameter("@emp_out_req", emp_out_req);
            para[15] = new SqlParameter("@emp_overtime_req ", emp_overtime_req);
            para[16] = new SqlParameter("@date_from ", date_from);
            para[17] = new SqlParameter("@date_to ", date_to);
            //Created By & Created Date
            para[18] = new SqlParameter("@Created_By", Created_By);
            para[19] = new SqlParameter("@Created_Date", Created_Date);
            para[20] = new SqlParameter("@check", "u");
          

            dtac.open();
            dtac.ExcutCommand("mng_Attendance_Setting", para);
            dtac.close();

        }
        //الحذف
        public void mng_Attendance_Setting_Del(int Attendance_No)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Attendance_No", Attendance_No);

            dtac.open();
            dtac.ExcutCommand("mng_Attendance_SettingDel", para);
            dtac.close();
        }

        //إظهار جميع اليانات
        public DataTable ShowAttendance_Setting(int Attendance_No)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Attendance_No", Attendance_No);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAttendance_Setting", para);
            dtac.close();
            return dt;
        }
        //البحث
        public DataTable SearchShowAttendance_Setting(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchShowAttendance_Setting", para);
            dtac.close();
            return dt;
        }


        public DataTable Get_Attendance_SettingId()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Attendance_SettingId", null);
            dtac.close();
            return dt;
        }


        public DataTable ShowAttendances_Sett( )
        {
            SqlParameter[] para = new SqlParameter[0];
           

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("showAtt_setting", para);
            dtac.close();
            return dt;
        }

        // تعديل اعدادات الحضور للفرع
        public void Att_AllBranch(int branch_id
                                , DateTime punch_intime
                                , DateTime start_registerpunchin
                                , DateTime last_lateallowance
                                , DateTime punch_outtime
                                , DateTime end_pushouttime
                                , DateTime last_earilryallowpunchout
                                , double rate_overtime
                                , double rate_overtimeholiday
                                , double rate_afsentdate
                                , double rate_late
                                , int emp_req
                                , int emp_out_req
                                , int emp_overtime_req)
        {
            SqlParameter[] para = new SqlParameter[14];
            para[0] = new SqlParameter("@branch_id", branch_id);
            para[1] = new SqlParameter("@punch_intime", punch_intime);
            para[2] = new SqlParameter("@start_registerpunchin", start_registerpunchin);
            para[3] = new SqlParameter("@last_lateallowance", last_lateallowance);
            para[4] = new SqlParameter("@punch_outtime", punch_outtime);
            para[5] = new SqlParameter("@end_pushouttime", end_pushouttime);
            para[6] = new SqlParameter("@last_earilryallowpunchout", last_earilryallowpunchout);
            para[7] = new SqlParameter("@rate_overtime", rate_overtime);
            para[8] = new SqlParameter("@rate_overtimeholiday", rate_overtimeholiday);
            para[9] = new SqlParameter("@rate_afsentdate", rate_afsentdate);
            para[10] = new SqlParameter("@rate_late", rate_late);
            para[11] = new SqlParameter("@emp_req", emp_req);
            para[12] = new SqlParameter("@emp_out_req", emp_out_req);
            para[13] = new SqlParameter("@emp_overtime_req ", emp_overtime_req);
            

            dtac.open();
            dtac.ExcutCommand("Att_AllBranch", para);
            dtac.close();

        }
        // تعديل اعدادات الحضور لجميع الموظفين
        public void Att_AllEmp( 
                                  DateTime punch_intime
                                , DateTime start_registerpunchin
                                , DateTime last_lateallowance
                                , DateTime punch_outtime
                                , DateTime end_pushouttime
                                , DateTime last_earilryallowpunchout
                                , double rate_overtime
                                , double rate_overtimeholiday
                                , double rate_afsentdate
                                , double rate_late
                                , int emp_req
                                , int emp_out_req
                                , int emp_overtime_req)
        {
            SqlParameter[] para = new SqlParameter[13];
            
            para[0] = new SqlParameter("@punch_intime", punch_intime);
            para[1] = new SqlParameter("@start_registerpunchin", start_registerpunchin);
            para[2] = new SqlParameter("@last_lateallowance", last_lateallowance);
            para[3] = new SqlParameter("@punch_outtime", punch_outtime);
            para[4] = new SqlParameter("@end_pushouttime", end_pushouttime);
            para[5] = new SqlParameter("@last_earilryallowpunchout", last_earilryallowpunchout);
            para[6] = new SqlParameter("@rate_overtime", rate_overtime);
            para[7] = new SqlParameter("@rate_overtimeholiday", rate_overtimeholiday);
            para[8] = new SqlParameter("@rate_afsentdate", rate_afsentdate);
            para[9] = new SqlParameter("@rate_late", rate_late);
            para[10] = new SqlParameter("@emp_req", emp_req);
            para[11] = new SqlParameter("@emp_out_req", emp_out_req);
            para[12] = new SqlParameter("@emp_overtime_req ", emp_overtime_req);


            dtac.open();
            dtac.ExcutCommand("Att_AllEmp", para);
            dtac.close();

        }
    }
}
