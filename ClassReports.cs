using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    class ClassReports
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();


        //الأضافة
        public void mng_Reports_add(
                                       int report_no,
                                       string report_Id,
                                       int Processe_id,
                                       DateTime Starting_date,
                                       DateTime Ending_date,
                                       decimal Remaining_Qty,
                                       decimal Missing_Qty,
                                       string Notes,
                                       string rpt_status,
                                       //Created By & Created Date
                                       string Created_By,
                                       DateTime Created_Date
                                     )
        {
            SqlParameter[] para = new SqlParameter[12];
            para[0] = new SqlParameter("@report_no", report_no);
            para[1] = new SqlParameter("@report_Id", report_Id);
            para[2] = new SqlParameter("@Processe_id", Processe_id);
            para[3] = new SqlParameter("@Starting_date", Starting_date);
            para[4] = new SqlParameter("@Ending_date", Ending_date);
            para[5] = new SqlParameter("@Remaining_Qty", Remaining_Qty);
            para[6] = new SqlParameter("@Missing_Qty", Missing_Qty);
            para[7] = new SqlParameter("@Notes", Notes);
            para[8] = new SqlParameter("@rpt_status", rpt_status);
            //Created By & Created Date
            para[9] = new SqlParameter("@Created_By", Created_By);
            para[10] = new SqlParameter("@Created_Date", Created_Date);
            para[11] = new SqlParameter("@check", "a");

            dtac.open();
            dtac.ExcutCommand("mng_Reports", para);
            dtac.close();
        }

        //التعديل
        public void mng_Reports_Update(
                                       int report_no,
                                       string report_Id,
                                       int Processe_id,
                                       DateTime Starting_date,
                                       DateTime Ending_date,
                                       decimal Remaining_Qty,
                                       decimal Missing_Qty,
                                       string Notes,
                                       string rpt_status,
                                       //Created By & Created Date
                                       string Created_By,
                                       DateTime Created_Date
                                     )
        {
            SqlParameter[] para = new SqlParameter[12];
            para[0] = new SqlParameter("@report_no", report_no);
            para[1] = new SqlParameter("@report_Id", report_Id);
            para[2] = new SqlParameter("@Processe_id", Processe_id);
            para[3] = new SqlParameter("@Starting_date", Starting_date);
            para[4] = new SqlParameter("@Ending_date", Ending_date);
            para[5] = new SqlParameter("@Remaining_Qty", Remaining_Qty);
            para[6] = new SqlParameter("@Missing_Qty", Missing_Qty);
            para[7] = new SqlParameter("@Notes", Notes);
            para[8] = new SqlParameter("@rpt_status", rpt_status);
            //Created By & Created Date
            para[9] = new SqlParameter("@Created_By", Created_By);
            para[10] = new SqlParameter("@Created_Date", Created_Date);
            para[11] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_Reports", para);
            dtac.close();
        }

        //الحذف
        public void mng_ReportsDel(int report_no)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@report_no", report_no);

            dtac.open();
            dtac.ExcutCommand("mng_ReportsDel", para);
            dtac.close();
        }
        //إظهار البيانات برقم العمليه
        public DataTable ShowReports(int report_no)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@report_no", report_no);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowReports", para);
            dtac.close();
            return dt;
        }
        //لإظهار جميع التقارير بناءاً على رقم العملية
        public DataTable Show_reportsBy_Processe_id(int Processe_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Processe_id", Processe_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_reportsBy_Processe_id", para);
            dtac.close();
            return dt;
        }
        //الارقام التسلسليه للتقارير
        public DataTable Get_Repoerts_no()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Repoerts_no", null);
            dtac.close();
            return dt;
        }
        //لإظهار جميع التقارير
        public DataTable ShowReportsAll()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowReportsAll", null);
            dtac.close();
            return dt;
        }

        //التعديل
        public void mng_UpdateProcesseStatus(
                                       int Processe_id,
                                       
                                       string status 
                                       
                                     )
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Processe_id", Processe_id);
             para[1] = new SqlParameter("@status", status);
             dtac.open();
            dtac.ExcutCommand("mng_UpdateProcesseStatus", para);
            dtac.close();
        }
    }
}
