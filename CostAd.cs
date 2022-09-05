using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class CostAd
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_additionalCost(int inv_id,
                                       string cost_name,
                                       double cost_val,
                                        //Created By & Created Date
                                         string Created_By,
                                         DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@inv_id", inv_id);
            para[1] = new SqlParameter("@cost_name", cost_name);
            para[2] = new SqlParameter("@cost_val", cost_val);
            //Created By & Created Date
            para[3] = new SqlParameter("@Created_By", Created_By);
            para[4] = new SqlParameter("@Created_Date", Created_Date);

            dtac.open();
            dtac.ExcutCommand("mng_additionalCost", para);
            dtac.close();
        }
        public void mng_additionalCost_del(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", inv_id);
            

            dtac.open();
            dtac.ExcutCommand("mng_additionalCost_del", para);
            dtac.close();
        }
        public DataTable Search_additionalCost_id(int inv_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@inv_id", inv_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Search_additionalCost_id", para);
            dtac.close();
            return dt;
        }


    }
}
