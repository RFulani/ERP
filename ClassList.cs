using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace INV.Code
{
    class ClassList
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_list_add(
                                    int list_id 
                                    , String list_name
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date


                                 )
                               {
                                SqlParameter[] para = new SqlParameter[5];
                                para[0] = new SqlParameter("@list_id", list_id);
                                para[1] = new SqlParameter("@list_name", list_name);
            //Created By & Created Date
            para[2] = new SqlParameter("@Created_By", Created_By);
            para[3] = new SqlParameter("@Created_Date", Created_Date);
            para[4] = new SqlParameter("@check", "a");

                                 dtac.open();
                                 dtac.ExcutCommand("mng_list", para);
                                 dtac.close();
                                  }

        //التعديل
        public void mng_list_Update(
                                    int list_id
                                    , String list_name
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
           )
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@list_id", list_id);
            para[1] = new SqlParameter("@list_name", list_name);
            //Created By & Created Date
            para[2] = new SqlParameter("@Created_By", Created_By);
            para[3] = new SqlParameter("@Created_Date", Created_Date);
            para[2] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_list", para);
            dtac.close();
        }

        //الحذف
        public void mng_list_Del(int list_id)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@list_id", list_id);

            dtac.open();
            dtac.ExcutCommand("mng_listDel", para);
            dtac.close();
        }


        public DataTable Show_List()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_List", null);
            dtac.close();
            return dt;
        }

        public DataTable Show_List_dgv(int list_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@list_id", list_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_List_dgv", para);
            dtac.close();
            return dt;
        }


        public DataTable Get_list_id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_list_id", null);
            dtac.close();
            return dt;
        }
    }
}
