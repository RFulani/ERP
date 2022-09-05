using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace INV.Code
{
    class ClassProcesses
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();


        //الأضافة
        public void mng_Processes_add(
                                       int Processe_id ,
                                       DateTime Processe_date,
                                       string Machine_id ,
                                       string Machine_name,
                                       string pro_id ,
                                       string pro_name,
                                       string status ,
			                           int emp_1st ,
                                       string emp_name_1st,
                                       int emp_2nd ,
                                       string emp_name_2nd,
                                       int emp_3rd ,
                                       string emp_name_3rd,
                                       int emp_4th,
                                       string emp_name_4th,
                                       string notes,
                                       decimal Qyt,
                                       int mold_id,
                                       string Mold_Name,
                                       int JobOrder_Id,
                                       //Created By & Created Date
                                       string Created_By,
                                       DateTime Created_Date
                                     )
        {
            SqlParameter[] para = new SqlParameter[23];
            para[0] = new SqlParameter("@Processe_id", Processe_id);
            para[1] = new SqlParameter("@Processe_date", Processe_date);
            para[2] = new SqlParameter("@Machine_id", Machine_id);
            para[3] = new SqlParameter("@Machine_name", Machine_name);
            para[4] = new SqlParameter("@pro_id", pro_id);
            para[5] = new SqlParameter("@pro_name", pro_name);
            para[6] = new SqlParameter("@status", status);
            para[7] = new SqlParameter("@emp_1st", emp_1st);
            para[8] = new SqlParameter("@emp_name_1st", emp_name_1st);
            para[9] = new SqlParameter("@emp_2nd", emp_2nd);
            para[10] = new SqlParameter("@emp_name_2nd", emp_name_2nd);
            para[11] = new SqlParameter("@emp_3rd", emp_3rd);
            para[12] = new SqlParameter("@emp_name_3rd", emp_name_3rd);
            para[13] = new SqlParameter("@emp_4th", emp_4th);
            para[14] = new SqlParameter("@emp_name_4th", emp_name_4th);
            para[15] = new SqlParameter("@notes", notes);
            para[16] = new SqlParameter("@Qyt", Qyt);
            para[17] = new SqlParameter("@mold_id", mold_id);
            para[18] = new SqlParameter("@Mold_Name", Mold_Name);
            para[19] = new SqlParameter("@JobOrder_Id", JobOrder_Id);
            //Created By & Created Date
            para[20] = new SqlParameter("@Created_By", Created_By);
            para[21] = new SqlParameter("@Created_Date", Created_Date);
            para[22] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Processes", para);
            dtac.close();
        }

        //التعديل
        public void mng_Processes_Update(
                                       int Processe_id,
                                       DateTime Processe_date,
                                       string Machine_id,
                                       string Machine_name,
                                       string pro_id,
                                       string pro_name,
                                       string status,
                                       int emp_1st,
                                       string emp_name_1st,
                                       int emp_2nd,
                                       string emp_name_2nd,
                                       int emp_3rd,
                                       string emp_name_3rd,
                                       int emp_4th,
                                       string emp_name_4th,
                                       string notes,
                                       decimal Qyt,
                                       int mold_id,
                                       string Mold_Name,
                                       int JobOrder_Id,
                                       //Created By & Created Date
                                       string Created_By,
                                       DateTime Created_Date
                                     )
        {
            SqlParameter[] para = new SqlParameter[23];
            para[0] = new SqlParameter("@Processe_id", Processe_id);
            para[1] = new SqlParameter("@Processe_date", Processe_date);
            para[2] = new SqlParameter("@Machine_id", Machine_id);
            para[3] = new SqlParameter("@Machine_name", Machine_name);
            para[4] = new SqlParameter("@pro_id", pro_id);
            para[5] = new SqlParameter("@pro_name", pro_name);
            para[6] = new SqlParameter("@status", status);
            para[7] = new SqlParameter("@emp_1st", emp_1st);
            para[8] = new SqlParameter("@emp_name_1st", emp_name_1st);
            para[9] = new SqlParameter("@emp_2nd", emp_2nd);
            para[10] = new SqlParameter("@emp_name_2nd", emp_name_2nd);
            para[11] = new SqlParameter("@emp_3rd", emp_3rd);
            para[12] = new SqlParameter("@emp_name_3rd", emp_name_3rd);
            para[13] = new SqlParameter("@emp_4th", emp_4th);
            para[14] = new SqlParameter("@emp_name_4th", emp_name_4th);
            para[15] = new SqlParameter("@notes", notes);
            para[16] = new SqlParameter("@Qyt", Qyt);
            para[17] = new SqlParameter("@mold_id", mold_id);
            para[18] = new SqlParameter("@Mold_Name", Mold_Name);
            para[19] = new SqlParameter("@JobOrder_Id", JobOrder_Id);
            //Created By & Created Date
            para[20] = new SqlParameter("@Created_By", Created_By);
            para[21] = new SqlParameter("@Created_Date", Created_Date);
            para[22] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_Processes", para);
            dtac.close();
        }

        //الحذف
        public void mng_ProcessesDel(int Processe_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Processe_id", Processe_id);

            dtac.open();
            dtac.ExcutCommand("mng_ProcessesDel", para);
            dtac.close();
        }
        //إظهار البيانات برقم العمليه
        public DataTable ShowProcesses(int Processe_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Processe_id", Processe_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowProcesses", para);
            dtac.close();
            return dt;
        }
        //إظهار جميع العمليات
        public DataTable ShowAllProcesses()
        {
            SqlParameter[] para = new SqlParameter[0];
            
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllProcesses", para);
            dtac.close();
            return dt;
        }
        //البحث
        public DataTable SearchProcesses(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchProcesses", para);
            dtac.close();
            return dt;
        }
        //للحصول على رقم تسلسلي تلقائي للرقم العملية
        public DataTable Get_ProcesseId()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_ProcesseId", null);
            dtac.close();
            return dt;
        }
        //لإظهار العمليات لالات الشغاله
        public DataTable PM()
        {
            SqlParameter[] para = new SqlParameter[0];
            //para[0] = new SqlParameter("@Processe_id", Processe_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("PM", para);
            dtac.close();
            return dt;
        }
        //لإظهار العمليات لالات الشغاله
        public DataTable PM_Work(string status)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@status", status);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("PM_Work", para);
            dtac.close();
            return dt;
        }
        //showDatefor all
        public DataTable ShowProcesses_Dates(DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@to", to);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowProcessesDates", para);
            dtac.close();
            return dt;
        }

    }
}
