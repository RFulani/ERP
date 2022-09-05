using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    class ClassAhuda
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_Ahuda_add(
                                   int assets_id
                                 , string assets_Type  
                                 , int emp_id 
                                 , string emp_name  
                                 , int FixedAsset_id  
                                 , string FixedAsset_Name_Ar  
                                 , string assets_Supervisor  
                                 , DateTime assets_date  
                                 , string assets_note
                                 , string Ahuda_stat
                                //Created By & Created Date
                                , string Created_By
                                , DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[13];
            para[0] = new SqlParameter("@assets_id", assets_id);
            para[1] = new SqlParameter("@assets_Type", assets_Type);
            para[2] = new SqlParameter("@emp_id", emp_id);
            para[3] = new SqlParameter("@emp_name", emp_name);
            para[4] = new SqlParameter("@FixedAsset_id", FixedAsset_id);
            para[5] = new SqlParameter("@FixedAsset_Name_Ar", FixedAsset_Name_Ar);
            para[6] = new SqlParameter("@assets_Supervisor", assets_Supervisor);
            para[7] = new SqlParameter("@assets_date", assets_date);
            para[8] = new SqlParameter("@assets_note", assets_note);
            para[9] = new SqlParameter("@Ahuda_stat", Ahuda_stat);
            //Created By & Created Date
            para[10] = new SqlParameter("@Created_By", Created_By);
            para[11] = new SqlParameter("@Created_Date", Created_Date);
            para[12] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Ahuda", para);
            dtac.close();
        }

        //التعديل
        public void mng_Ahuda_Update(
                                   int assets_id
                                 , string assets_Type
                                 , int emp_id
                                 , string emp_name
                                 , int FixedAsset_id
                                 , string FixedAsset_Name_Ar
                                 , string assets_Supervisor
                                 , DateTime assets_date
                                 , string assets_note
                                 , string Ahuda_stat
                                //Created By & Created Date
                                , string Created_By
                                , DateTime Created_Date

           )
        {
            SqlParameter[] para = new SqlParameter[13];
            para[0] = new SqlParameter("@assets_id", assets_id);
            para[1] = new SqlParameter("@assets_Type", assets_Type);
            para[2] = new SqlParameter("@emp_id", emp_id);
            para[3] = new SqlParameter("@emp_name", emp_name);
            para[4] = new SqlParameter("@FixedAsset_id", FixedAsset_id);
            para[5] = new SqlParameter("@FixedAsset_Name_Ar", FixedAsset_Name_Ar);
            para[6] = new SqlParameter("@assets_Supervisor", assets_Supervisor);
            para[7] = new SqlParameter("@assets_date", assets_date);
            para[8] = new SqlParameter("@assets_note", assets_note);
            para[9] = new SqlParameter("@Ahuda_stat", Ahuda_stat);
            //Created By & Created Date
            para[10] = new SqlParameter("@Created_By", Created_By);
            para[11] = new SqlParameter("@Created_Date", Created_Date);
            para[12] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Ahuda", para);
            dtac.close();
        }



        //الحذف
        public void mng_Ahuda_Del(int assets_id)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@assets_id", assets_id);

            dtac.open();
            dtac.ExcutCommand("mng_AhudaDel", para);
            dtac.close();
        }

        public DataTable ShowAhuda(int assets_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@assets_id", assets_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAhuda", para);
            dtac.close();
            return dt;
        }
        public DataTable Get_AhudaId()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_AhudaId", null);
            dtac.close();
            return dt;
        }

        //البحث
        public DataTable SearchAhuda(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchAhuda", para);
            dtac.close();
            return dt;
        }

        public DataTable Show_AllAhuda()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_AllAhuda", null);
            dtac.close();
            return dt;
        }

    }
}
