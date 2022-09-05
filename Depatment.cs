using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class Depatment
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void Add_dep(int dep_id,
            int brn_id,
            string dep_name,
                        //Created By & Created Date
             string Created_By,
            DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[6];

            para[0] = new SqlParameter("@dep_id", dep_id);
            para[1] = new SqlParameter("@dep_name", dep_name);
            para[2] = new SqlParameter("@brn_id", brn_id);
            //Created By & Created Date
            para[3] = new SqlParameter("@Created_By", Created_By);
            para[4] = new SqlParameter("@Created_Date", Created_Date);
            para[5] = new SqlParameter("@check", "a");
            dtac.open();
            dtac.ExcutCommand("mng_dep", para);
            dtac.close();
        }
        public void Update_dep(int dep_id,
            int brn_id,
            string dep_name,
             //Created By & Created Date
             string Created_By,
            DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[6];

            para[0] = new SqlParameter("@dep_id", dep_id);
            para[1] = new SqlParameter("@dep_name", dep_name);
            para[2] = new SqlParameter("@brn_id", brn_id);
            //Created By & Created Date
            para[3] = new SqlParameter("@Created_By", Created_By);
            para[4] = new SqlParameter("@Created_Date", Created_Date);
            para[5] = new SqlParameter("@check", "u");
            dtac.open();
            dtac.ExcutCommand("mng_dep", para);
            dtac.close();
        }
        public void Del_dep(int dep_id,int brn_id, string dep_name)
        {
            SqlParameter[] para = new SqlParameter[4];

            para[0] = new SqlParameter("@dep_id", dep_id);
            para[1] = new SqlParameter("@dep_name", dep_name);
            para[2] = new SqlParameter("@brn_id", brn_id);
            para[3] = new SqlParameter("@check", "d");
            dtac.open();
            dtac.ExcutCommand("mng_dep", para);
            dtac.close();
        }

        public DataTable Check_iddep(int dep_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@dep_id", dep_id);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Check_iddep", para);
            dtac.close();
            return dt;
        }
        public DataTable Check_depBybrnId(int brn_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@brn_id", brn_id);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Check_depBybrnId", para);
            dtac.close();
            return dt;
        }

        public DataTable Check_dep(int dep_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@dep_id", dep_id);


            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Check_dep", para);
            dtac.close();
            return dt;
        }
        public DataTable Show_dep()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_dep", null);
            dtac.close();
            return dt;
        }


        public void mng_depDel(int dep_id, int brn_id)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@dep_id", dep_id);
            para[1] = new SqlParameter("@brn_id", brn_id);
            
            dtac.open();
            dtac.ExcutCommand("mng_depDel", para);
            dtac.close();
        }
    }
}
