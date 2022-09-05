using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassAtt1
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        Code.DB_HR dhr = new DB_HR();
        //--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_
        public void mng_Att_1_add( 
                                 int emp_id
                                 , String emp_name
                                 , DateTime Date_emp
                                 , string Att_1_day
                                 , DateTime login_time
                                 , DateTime logout_time
                                 , decimal Overtime
                                 , decimal Late
                                 , decimal logout_early
                                 , decimal Att1_absent
                                 , String Notes
                                 , String status_Att
                                 , String Updating
                                 , decimal OvertimeHolday
                               //Created By & Created Date
                               , string Created_By
                               , DateTime Created_Date


                                                           )
        {
            SqlParameter[] para = new SqlParameter[17];
           
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@emp_name", emp_name);
            para[2] = new SqlParameter("@Date_emp", Date_emp);
            para[3] = new SqlParameter("@Att_1_day", Att_1_day);
            para[4] = new SqlParameter("@login_time", login_time);
            para[5] = new SqlParameter("@logout_time", logout_time);
            para[6] = new SqlParameter("@Overtime", Overtime);
            para[7] = new SqlParameter("@Late", Late);
            para[8] = new SqlParameter("@logout_early", logout_early);
            para[9] = new SqlParameter("@Att1_absent", Att1_absent);
            para[10] = new SqlParameter("@Notes", Notes);
            para[11] = new SqlParameter("@status_Att", status_Att);
            para[12] = new SqlParameter("@Updating", Updating);
            para[13] = new SqlParameter("@OvertimeHolday", OvertimeHolday);
            //Created By & Created Date
            para[14] = new SqlParameter("@Created_By", Created_By);
            para[15] = new SqlParameter("@Created_Date", Created_Date);
            para[16] = new SqlParameter("@check", "a");

            dtac.open();
            dtac.ExcutCommand("mng_Att_1", para);
            dtac.close();
        }

        //--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_
        public void mng_Att_1_Update(
                                   int emp_id
                                  , String emp_name
                                  , DateTime Date_emp
                                  , string Att_1_day
                                  , DateTime login_time
                                  , DateTime logout_time
                                  , decimal Overtime
                                  , decimal Late
                                  , decimal logout_early
                                  , decimal Att1_absent
                                  , String Notes
                                  , String status_Att
                                  , String Updating
                                  , decimal OvertimeHolday
                               //Created By & Created Date
                               , string Created_By
                               , DateTime Created_Date

                                     )
        {


            SqlParameter[] para = new SqlParameter[17];

            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@emp_name", emp_name);
            para[2] = new SqlParameter("@Date_emp", Date_emp);
            para[3] = new SqlParameter("@Att_1_day", Att_1_day);
            para[4] = new SqlParameter("@login_time", login_time);
            para[5] = new SqlParameter("@logout_time", logout_time);
            para[6] = new SqlParameter("@Overtime", Overtime);
            para[7] = new SqlParameter("@Late", Late);
            para[8] = new SqlParameter("@logout_early", logout_early);
            para[9] = new SqlParameter("@Att1_absent", Att1_absent);
            para[10] = new SqlParameter("@Notes", Notes);
            para[11] = new SqlParameter("@status_Att", status_Att);
            para[12] = new SqlParameter("@Updating", Updating);
            para[13] = new SqlParameter("@OvertimeHolday", OvertimeHolday);
            //Created By & Created Date
            para[14] = new SqlParameter("@Created_By", Created_By);
            para[15] = new SqlParameter("@Created_Date", Created_Date);
            para[16] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Att_1", para);
            dtac.close();
        }
        //--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_

        //الحذف
        public void mng_Att_1_Del(int emp_id, DateTime Att_from, DateTime Att_to)


        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@Att_from", Att_from);
            para[2] = new SqlParameter("@Att_to", Att_to);

            dtac.open();
            dtac.ExcutCommand("mng_Att_1_Del", para);
            dtac.close();
        }

        //الحذف
        public void mng_Att_1_ALL_Del(DateTime Att_from, DateTime Att_to)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Att_from", Att_from);
            para[1] = new SqlParameter("@Att_to", Att_to);

            dtac.open();
            dtac.ExcutCommand("mng_Att_1_ALL_Del", para);
            dtac.close();
        }
        //--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_
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
        //--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_

        public DataTable AttEmp(int emp_id, int dep_id, DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@dep_id", dep_id);
            para[2] = new SqlParameter("@from", from);
            para[3] = new SqlParameter("@to", to);
            para[4] = new SqlParameter("@check", "0");

            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dhr.SelectdataHR("AttEmp", para);
            dtac.close();
            return dtemp;
        }
        //--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_

        // إظهار جميع السجلات للبحث
        public DataTable ShowAtt_1(int emp_id, DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@from", from);
            para[2] = new SqlParameter("@to", to);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAtt_1", para);
            dtac.close();
            return dt;
        }

        // إظهار جميع السجلات للبحث
        public DataTable ShowAtt_2( DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];
           
            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@to", to);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAtt_2", para);
            dtac.close();
            return dt;
        }

        //للبحث
        public DataTable SearchAtt_1(string SearchAtt_1)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@SearchAtt_1", SearchAtt_1);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchAtt_1", para);
            dtac.close();
            return dt;
        }
        //--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_
        public DataTable GetEmpAtt(int emp_id,  DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@DateFrom", from);
            para[2] = new SqlParameter("@DateTo", to);
          

            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("GetEmpAtt", para);
            dtac.close();
            return dtemp;
        }

        public DataTable GetEmpAtt_ALL(DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];
            
            para[0] = new SqlParameter("@DateFrom", from);
            para[1] = new SqlParameter("@DateTo", to);


            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("GetEmpAtt_ALL", para);
            dtac.close();
            return dtemp;
        }
        //--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_
        public DataTable ShowAttTotal(int emp_id, DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@from", from);
            para[2] = new SqlParameter("@to", to);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAttTotal", para);
            dtac.close();
            return dt;
        }

        public DataTable ShowAttTotalAll( DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];
            
            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@to", to);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAttTotalAll", para);
            dtac.close();
            return dt;
        }
        //--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_--_
        public DataTable VacationsEmp(int emp_id, DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@Date_From", from);
            para[2] = new SqlParameter("@Date_To", to);


            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("VacationsEmp", para);
            dtac.close();
            return dtemp;
        }
    }
}
