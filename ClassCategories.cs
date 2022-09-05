using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassCategories
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_Categories_add(
                                    int Category_Id
                                  , string Category_Name
                                  , string Category_Type
                                  , int MainCat_Id
                                  //Created By & Created Date
                                  , string Created_By
                                  , DateTime Created_Date
                                                           )
        {
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@Category_Id", Category_Id);
            para[1] = new SqlParameter("@Category_Name", Category_Name);
            para[2] = new SqlParameter("@Category_Type", Category_Type);
            para[3] = new SqlParameter("@MainCat_Id", MainCat_Id);
            //Created By & Created Date
            para[4] = new SqlParameter("@Created_By", Created_By);
            para[5] = new SqlParameter("@Created_Date", Created_Date);
            para[6] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Categories", para);
            dtac.close();
        }

        public void mng_Categories_Update(
                                    int Category_Id
                                  , string Category_Name
                                  , string Category_Type
                                  , int MainCat_Id
                                  //Created By & Created Date
                                  , string Created_By
                                  , DateTime Created_Date
                                                           )
        {
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@Category_Id", Category_Id);
            para[1] = new SqlParameter("@Category_Name", Category_Name);
            para[2] = new SqlParameter("@Category_Type", Category_Type);
            para[3] = new SqlParameter("@MainCat_Id", MainCat_Id);
            //Created By & Created Date
            para[4] = new SqlParameter("@Created_By", Created_By);
            para[5] = new SqlParameter("@Created_Date", Created_Date);
            para[6] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_Categories", para);
            dtac.close();
        }
        //الحذف
        public void mng_CategoriesDel(int Category_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Category_Id", Category_Id);

            dtac.open();
            dtac.ExcutCommand("mng_CategoriesDel", para);
            dtac.close();
        }

    }
}
