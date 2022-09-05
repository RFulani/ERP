using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace INV.Code
{
    class ClassMainAttendance
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();


        //أضافة الحضور الرئيسي
        public void mng_mainattendanceAdd(
            int rpta_id
            ,DateTime rpta_date
            , DateTime rpta_datesalary
           
            , string rpta_note
            )
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@rpta_id", rpta_id);
            para[1] = new SqlParameter("@rpta_date", rpta_date);
            para[2] = new SqlParameter("@rpta_datesalary", rpta_datesalary);
            
            para[3] = new SqlParameter("@rpta_note", rpta_note);
            para[4] = new SqlParameter("@check", "a");


            dtac.open();
            dtac.ExcutCommand("mng_mainattendance", para);
            dtac.close();

        }

        // تعديل الحضور الرئيسي

        public void mng_mainattendanceUpdate(
            int rpta_id
            , DateTime rpta_date
            , DateTime rpta_datesalary
            
            , string rpta_note
            )
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@rpta_id", rpta_id);
            para[1] = new SqlParameter("@rpta_date", rpta_date);
            para[2] = new SqlParameter("@rpta_datesalary", rpta_datesalary);
            
            para[3] = new SqlParameter("@rpta_note", rpta_note);
            para[4] = new SqlParameter("@check", "u");


            dtac.open();
            dtac.ExcutCommand("mng_mainattendance", para);
            dtac.close();
        }

        //بحث الحضور الرئيسي
        public DataTable mng_mainattendanceSearch(int rpta_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rpta_id", rpta_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("mng_mainattendanceSearch", para);
            dtac.close();
            return dt;
        }


        //حذف الحضور الرئيسي
        public void mng_mainattendanceDel(int rpta_id)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@rpta_id", rpta_id);

            dtac.open();
            dtac.ExcutCommand("mng_mainattendanceDel", para);
            dtac.close();
        }


        public void RptAttendace_RowDel(int rpta_id, int emp_id)


        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@rpta_id", rpta_id);
            para[1] = new SqlParameter("@emp_id", emp_id);

            dtac.open();
            dtac.ExcutCommand("RptAttendace_RowDel", para);
            dtac.close();
        }
    }
    }
