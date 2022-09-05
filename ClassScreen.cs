using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    class ClassScreen
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_screen_add(
           int screen_id
           , string screen_name  
           , int list_id
             //Created By & Created Date
                                         ,string Created_By
                                         ,DateTime Created_Date


            )
        {
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@screen_id", screen_id);
            para[1] = new SqlParameter("@screen_name", screen_name);
            para[2] = new SqlParameter("@list_id", list_id);
            //Created By & Created Date
            para[3] = new SqlParameter("@Created_By", Created_By);
            para[4] = new SqlParameter("@Created_Date", Created_Date);
            para[5] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_screen", para);
            dtac.close();
        }

        //التعديل
        public void mng_screen_Update(
          int screen_id
           , string screen_name
           , int list_id
             //Created By & Created Date
                                         , string Created_By
                                         , DateTime Created_Date
           )
        {
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@screen_id", screen_id);
            para[1] = new SqlParameter("@screen_name", screen_name);
            para[2] = new SqlParameter("@list_id", list_id);
            //Created By & Created Date
            para[3] = new SqlParameter("@Created_By", Created_By);
            para[4] = new SqlParameter("@Created_Date", Created_Date);
            para[5] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_screen", para);
            dtac.close();
        }



        //الحذف
        public void mng_screen_Del(int screen_id)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@screen_id", screen_id);

            dtac.open();
            dtac.ExcutCommand("mng_screenDel", para);
            dtac.close();
        }


        public DataTable Show_screen()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_screen", null);
            dtac.close();
            return dt;
        }

        public DataTable Show_screen_dgv(int screen_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@screen_id", screen_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_screen_dgv", para);
            dtac.close();
            return dt;
        }

        public DataTable Get_screen_id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_screen_id", null);
            dtac.close();
            return dt;
        }
    }
}
