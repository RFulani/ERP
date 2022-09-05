using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace INV.Code
{
    class ClassAttendance
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
       //إضافة الحضور 
        public void mng_Attend_Add(int emp_id
                                ,  DateTime punch_intime
                                , DateTime start_registerpunchin
                                , DateTime last_lateallowance
                                , DateTime punch_outtime
                                , DateTime end_pushouttime
                                , DateTime last_earilryallowpunchout
                                , double rate_overtime
                                , double rate_overtimeholiday
                                , double rate_afsentdate
                                ,double rate_late
                                ,int emp_req
                                , int emp_out_req
                                , int emp_overtime_req
                                //Created By & Created Date
                                , string Created_By
                                , DateTime Created_Date

            )
        {
            SqlParameter[] para = new SqlParameter[17];
            para[0] = new SqlParameter("@emp_id", emp_id);
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
            //Created By & Created Date
            para[14] = new SqlParameter("@Created_By", Created_By);
            para[15] = new SqlParameter("@Created_Date", Created_Date);
            para[16] = new SqlParameter("@check", "a");


            dtac.open();
            dtac.ExcutCommand("mng_attandance", para);
            dtac.close();

        }

        // تعديل الحضور
        public void mng_Attend_Update(int emp_id
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
                                , int emp_overtime_req
                                //Created By & Created Date
                                , string Created_By
                                , DateTime Created_Date
                                , int oldEmpid)
        {
            SqlParameter[] para = new SqlParameter[18];
            para[0] = new SqlParameter("@emp_id", emp_id);
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
            //Created By & Created Date
            para[14] = new SqlParameter("@Created_By", Created_By);
            para[15] = new SqlParameter("@Created_Date", Created_Date);
            para[16] = new SqlParameter("@check", "u");
            para[17] = new SqlParameter("@oldEmpid", oldEmpid);

            dtac.open();
            dtac.ExcutCommand("mng_attandance", para);
            dtac.close();

        }

        public DataTable SearchEmpAttend(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            DataTable dtA = new DataTable();
            dtac.open();
            dtA = dtac.Selectdata("SearchEmpAttend", para);
            dtac.close();
            return dtA;
        }

        public DataTable ShowAttendances_Emp(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAttendances_Emp", para);
            dtac.close();
            return dt;
        }



        public DataTable SearchEmpforATT(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchEmpforATT", para);
            dtac.close();
            return dt;
        }
    }
}
