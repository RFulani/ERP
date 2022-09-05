using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    class ClassMachineMolds
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();


        //الأضافة
        public void mng_MachineMolds_add(
                                       int mold_id,
                                       string Mold_code,
                                       string Mold_Name,
                                       string mold_description,
                                       byte[] Mold_image,
                                       //Created By & Created Date
                                       string Created_By,
                                       DateTime Created_Date
                                     )
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@mold_id", mold_id);
            para[1] = new SqlParameter("@Mold_code", Mold_code);
            para[2] = new SqlParameter("@Mold_Name", Mold_Name);
            para[3] = new SqlParameter("@mold_description", mold_description);
            para[4] = new SqlParameter("@Mold_image", Mold_image);
            //Created By & Created Date
            para[5] = new SqlParameter("@Created_By", Created_By);
            para[6] = new SqlParameter("@Created_Date", Created_Date);
            para[7] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_MachineMolds", para);
            dtac.close();
        }

        //التعديل
        public void mng_MachineMolds_Update(
                                       int mold_id,
                                       string Mold_code,
                                       string Mold_Name,
                                       string mold_description,
                                       byte[] Mold_image,
                                       //Created By & Created Date
                                       string Created_By,
                                       DateTime Created_Date
           )
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@mold_id", mold_id);
            para[1] = new SqlParameter("@Mold_code", Mold_code);
            para[2] = new SqlParameter("@Mold_Name", Mold_Name);
            para[3] = new SqlParameter("@mold_description", mold_description);
            para[4] = new SqlParameter("@Mold_image", Mold_image);
            //Created By & Created Date
            para[5] = new SqlParameter("@Created_By", Created_By);
            para[6] = new SqlParameter("@Created_Date", Created_Date);
            para[7] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_MachineMolds", para);
            dtac.close();
        }

        //الحذف
        public void mng_MachineMoldsDel(int mold_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@mold_id", mold_id);

            dtac.open();
            dtac.ExcutCommand("mng_MachineMoldsDel", para);
            dtac.close();
        }
        public DataTable ShowMachineMolds(int mold_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@mold_id ", mold_id);
        
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowMachineMolds", para);
            dtac.close();
            return dt;
        }

        //بحث 
        public DataTable SearchMolds(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchMolds", para);
            dtac.close();
            return dt;
        }


        public DataTable ShowMoldsByMach_ID(string Machine_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Machine_id", Machine_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowMoldsByMach_ID", para);
            dtac.close();
            return dt;
        }
        //للحصول على الارقام تسلسليه
        public DataTable Get_moldid()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_moldid", null);
            dtac.close();
            return dt;
        }


    }
}
