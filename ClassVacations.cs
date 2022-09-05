using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    class ClassVacations
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_Vacations_add(
          int Vacation_Id
            , string Vacation_Name
            , DateTime Vactation_Starting
            , DateTime Vacation_Ending
            , string Vacation_Notes
            //Created By & Created Date
            , string Created_By
            , DateTime Created_Date

           )
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@Vacation_Id", Vacation_Id);
            para[1] = new SqlParameter("@Vacation_Name", Vacation_Name);
            para[2] = new SqlParameter("@Vactation_Starting", Vactation_Starting);
            para[3] = new SqlParameter("@Vacation_Ending", Vacation_Ending);
            para[4] = new SqlParameter("@Vacation_Notes", Vacation_Notes);
            //Created By & Created Date
            para[5] = new SqlParameter("@Created_By", Created_By);
            para[6] = new SqlParameter("@Created_Date", Created_Date);
            para[7] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Vacations", para);
            dtac.close();
        }

        //التعديل
        public void mng_Vacations_Update(
          int Vacation_Id
            , string Vacation_Name
            , DateTime Vactation_Starting
            , DateTime Vacation_Ending
            , string Vacation_Notes
            //Created By & Created Date
            , string Created_By
            , DateTime Created_Date

           )
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@Vacation_Id", Vacation_Id);
            para[1] = new SqlParameter("@Vacation_Name", Vacation_Name);
            para[2] = new SqlParameter("@Vactation_Starting", Vactation_Starting);
            para[3] = new SqlParameter("@Vacation_Ending", Vacation_Ending);
            para[4] = new SqlParameter("@Vacation_Notes", Vacation_Notes);
            //Created By & Created Date
            para[5] = new SqlParameter("@Created_By", Created_By);
            para[6] = new SqlParameter("@Created_Date", Created_Date);
            para[7] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Vacations", para);
            dtac.close();
        }

        
        //إظهار جميع اليانات
        public DataTable ShowVacations_Sett(int Vacation_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Vacation_Id", Vacation_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowVacations_Sett", para);
            dtac.close();
            return dt;
        }
        //البحث
        public DataTable SearchVacations_Sett(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchVacations_Sett", para);
            dtac.close();
            return dt;
        }

        public void mng_VacationsDel(int Vacation_Id)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Vacation_Id", Vacation_Id);

            dtac.open();
            dtac.ExcutCommand("mng_VacationsDel", para);
            dtac.close();
        }

        public DataTable Get_Vacations_Id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Vacations_Id", null);
            dtac.close();
            return dt;
        }

    }
}
