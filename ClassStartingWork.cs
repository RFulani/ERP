using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassStartingWork
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_StartingWork_add(
                                          int Effective_Date_Id 
                                        , int emp_id
                                        , string empName_ar 
					                    ,DateTime Effective_Date  
                                        , String Effective_Date_Type 
					                    ,String Notes
                               //Created By & Created Date
                               , string Created_By
                               , DateTime Created_Date

                                                           )
        {
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@Effective_Date_Id", Effective_Date_Id);
            para[1] = new SqlParameter("@emp_id", emp_id);
            para[2] = new SqlParameter("@empName_ar", empName_ar);
            para[3] = new SqlParameter("@Effective_Date", Effective_Date);
            para[4] = new SqlParameter("@Effective_Date_Type", Effective_Date_Type);
            para[5] = new SqlParameter("@Notes", Notes);
            //Created By & Created Date
            para[6] = new SqlParameter("@Created_By", Created_By);
            para[7] = new SqlParameter("@Created_Date", Created_Date);
            para[8] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_StartingWork", para);
            dtac.close();
        }
        public void mng_StartingWork_Update(
                                        int Effective_Date_Id
                                        , int emp_id
                                        , string empName_ar
                                        , DateTime Effective_Date
                                        , String Effective_Date_Type
                                        , String Notes
                               //Created By & Created Date
                               , string Created_By
                               , DateTime Created_Date

                                                           )
        {

            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@Effective_Date_Id", Effective_Date_Id);
            para[1] = new SqlParameter("@emp_id", emp_id);
            para[2] = new SqlParameter("@empName_ar", empName_ar);
            para[3] = new SqlParameter("@Effective_Date", Effective_Date);
            para[4] = new SqlParameter("@Effective_Date_Type", Effective_Date_Type);
            para[5] = new SqlParameter("@Notes", Notes);
            //Created By & Created Date
            para[6] = new SqlParameter("@Created_By", Created_By);
            para[7] = new SqlParameter("@Created_Date", Created_Date);
            para[8] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_StartingWork", para);
            dtac.close();
        }

        //الحذف
        public void mng_StartingWorkDel(int Effective_Date_Id, int emp_id)


        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Effective_Date_Id", Effective_Date_Id);
            para[1] = new SqlParameter("@emp_id", emp_id);

            dtac.open();
            dtac.ExcutCommand("mng_StartingWorkDel", para);
            dtac.close();
        }

        public DataTable Get_StartingWorkId()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_StartingWorkId", null);
            dtac.close();
            return dt;
        }

        //للبحث
        public DataTable SearchStartingWork(string searchSW)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@searchSW", searchSW);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchStartingWork", para);
            dtac.close();
            return dt;
        }

        // إظهار جميع السجلات للبحث
        public DataTable ShowStartingWork(int Effective_Date_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Effective_Date_Id", Effective_Date_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowStartingWork", para);
            dtac.close();
            return dt;
        }

       

    }
}
