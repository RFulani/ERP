using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassBanks_To_Branches
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_Banks_To_Branches_add(
                                     int Bank_id
                                    , int brn_id
                                  //Created By & Created Date
                                  , string Created_By
                                  , DateTime Created_Date

                                                           )
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@Bank_id", Bank_id);
            para[1] = new SqlParameter("@brn_id", brn_id);
            //Created By & Created Date
            para[2] = new SqlParameter("@Created_By", Created_By);
            para[3] = new SqlParameter("@Created_Date", Created_Date);
            para[4] = new SqlParameter("@check", "a");


            dtac.open();
            dtac.ExcutCommand("mng_Banks_To_Branches", para);
            dtac.close();
        }


        public void mng_Banks_To_Branches_Update(
                                    int Bank_id
                                  , int brn_id
                                  //Created By & Created Date
                                  , string Created_By
                                  , DateTime Created_Date
                                                           )
        {

            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@Bank_id", Bank_id);
            para[1] = new SqlParameter("@brn_id", brn_id);
            //Created By & Created Date
            para[2] = new SqlParameter("@Created_By", Created_By);
            para[3] = new SqlParameter("@Created_Date", Created_Date);
            para[4] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_Banks_To_Branches", para);
            dtac.close();
        }
        //الحذف
        public void mng_Banks_To_BranchesDel(int Bank_id, int brn_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Bank_id", Bank_id);
            para[1] = new SqlParameter("@brn_id", brn_id);

            dtac.open();
            dtac.ExcutCommand("mng_Banks_To_BranchesDel", para);
            dtac.close();
        }

        public DataTable showBanksAndBranch(int Bank_id, int brn_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Bank_id", Bank_id);
            para[1] = new SqlParameter("@brn_id", brn_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("showBanksAndBranch", para);
            dtac.close();
            return dt;
        }
        

    }
}
