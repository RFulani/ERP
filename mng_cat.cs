using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class mng_cat
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        //اضافة تصنيف
        public void addcat(
                            int cat_id,
                            string category_code,
                            string cat_name,
                            string cat_cod,
                            string cat_des,
                            string cat_Type,
                            string MainCat_code,
                           //Created By & Created Date
                            string Created_By,
                            DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@cat_id", SqlDbType.Int);
            para[0].Value = cat_id;
            para[1] = new SqlParameter("@category_code", SqlDbType.VarChar, 50);
            para[1].Value = category_code;
            para[2] = new SqlParameter("@cat_name", SqlDbType.NVarChar,50);
            para[2].Value = cat_name;
            para[3] = new SqlParameter("@cat_code", SqlDbType.NChar, 10);
            para[3].Value = cat_cod;
            para[4] = new SqlParameter("@cat_disc", SqlDbType.NChar, 10);
            para[4].Value = cat_des;
            para[5] = new SqlParameter("@cat_Type", SqlDbType.NChar, 10);
            para[5].Value = cat_Type;
            para[6] = new SqlParameter("@MainCat_code", SqlDbType.VarChar, 50);
            para[6].Value = MainCat_code;
            //Created By & Created Date
            para[7] = new SqlParameter("@Created_By", Created_By);
            para[8] = new SqlParameter("@Created_Date", Created_Date);
            para[9] = new SqlParameter("@check", "a");

            dtac.open();
            dtac.ExcutCommand("mng_cat", para);
            dtac.close();
        }
        public void Updatecat(
                            int cat_id,
                            string category_code,
                            string cat_name,
                            string cat_cod,
                            string cat_des,
                            string cat_Type,
                            string MainCat_code,
                            //Created By & Created Date
                            string Created_By,
                            DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@cat_id", SqlDbType.Int);
            para[0].Value = cat_id;
            para[1] = new SqlParameter("@category_code", SqlDbType.VarChar, 50);
            para[1].Value = category_code;
            para[2] = new SqlParameter("@cat_name", SqlDbType.NVarChar, 50);
            para[2].Value = cat_name;
            para[3] = new SqlParameter("@cat_code", SqlDbType.NChar, 10);
            para[3].Value = cat_cod;
            para[4] = new SqlParameter("@cat_disc", SqlDbType.NChar, 10);
            para[4].Value = cat_des;
            para[5] = new SqlParameter("@cat_Type", SqlDbType.NChar, 10);
            para[5].Value = cat_Type;
            para[6] = new SqlParameter("@MainCat_code", SqlDbType.VarChar, 50);
            para[6].Value = MainCat_code;
            //Created By & Created Date
            para[7] = new SqlParameter("@Created_By", Created_By);
            para[8] = new SqlParameter("@Created_Date", Created_Date);
            para[9] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_cat", para);
            dtac.close();
        }
        public void Delcat(int cat_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@cat_id", SqlDbType.Int);
            para[0].Value = cat_id;
            para[1] = new SqlParameter("@check", "d");

            dtac.open();
            dtac.ExcutCommand("mng_cat", para);
            dtac.close();
        }
        //تعديل منج  
        public DataTable CheckCat(int cat_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@cat_id", cat_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("CheckCat", para);
            dtac.close();
            return dt;
        }
        public DataTable ShowCat()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowCat", null);
            dtac.close();
            return dt;
        }
        public DataTable M_cat()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowCat", null);
            dtac.close();
            return dt;
        }

        public DataTable SearchCat(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchCat", para);
            dtac.close();
            return dt;
        }

        public DataTable Get_cat_id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_cat_id", null);
            dtac.close();
            return dt;
        }

        // إظهار جميع السجلات للبحث
        public DataTable ShowCatbyId(int cat_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@cat_id", cat_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowCatbyId", para);
            dtac.close();
            return dt;
        }

        public DataTable ShowCatByMCcat(string M_Cat)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@M_Code", M_Cat);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("AllSecCat", para);
            dtac.close();
            return dt;
        }
    }
}
