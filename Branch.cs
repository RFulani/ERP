using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    
    class Branch
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void Add_Branch(int brn_id  
                             , string Company_Name_Ar  
                             , string Company_Name_Eng
                             , string brn_name_Ar
                             , string brn_name_Eng
                             , string Business_Activity_Ar
                             , string Business_Activity_Eng
                             , string brn_address_Ar
                             , string brn_address_Eng
                             , DateTime brn_date  
                             , byte[]  brn_logo   
                            //Created By & Created Date
                             , string Created_By
                             , DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[14];

            para[0] = new SqlParameter("@brn_id", brn_id);
            para[1] = new SqlParameter("@Company_Name_Ar", Company_Name_Ar);
            para[2] = new SqlParameter("@Company_Name_Eng", Company_Name_Eng);
            para[3] = new SqlParameter("@brn_name_Ar", brn_name_Ar);
            para[4] = new SqlParameter("@brn_name_Eng", brn_name_Eng);
            para[5] = new SqlParameter("@Business_Activity_Ar", Business_Activity_Ar);
            para[6] = new SqlParameter("@Business_Activity_Eng", Business_Activity_Eng);
            para[7] = new SqlParameter("@brn_address_Ar", brn_address_Ar);
            para[8] = new SqlParameter("@brn_address_Eng", brn_address_Eng);
            para[9] = new SqlParameter("@brn_date", brn_date);
            para[10] = new SqlParameter("@brn_logo", brn_logo);
            //Created By & Created Date
            para[11] = new SqlParameter("@Created_By", Created_By);
            para[12] = new SqlParameter("@Created_Date", Created_Date);
            para[13] = new SqlParameter("@check", "a");
            dtac.open();
            dtac.ExcutCommand("mng_brnch", para);
            dtac.close();
        }
        public void Update_Branch(int brn_id
                             , string Company_Name_Ar
                             , string Company_Name_Eng
                             , string brn_name_Ar
                             , string brn_name_Eng
                             , string Business_Activity_Ar
                             , string Business_Activity_Eng
                             , string brn_address_Ar
                             , string brn_address_Eng
                             , DateTime brn_date
                             , byte[] brn_logo
                             //Created By & Created Date
                             , string Created_By
                             , DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[14];

            para[0] = new SqlParameter("@brn_id", brn_id);
            para[1] = new SqlParameter("@Company_Name_Ar", Company_Name_Ar);
            para[2] = new SqlParameter("@Company_Name_Eng", Company_Name_Eng);
            para[3] = new SqlParameter("@brn_name_Ar", brn_name_Ar);
            para[4] = new SqlParameter("@brn_name_Eng", brn_name_Eng);
            para[5] = new SqlParameter("@Business_Activity_Ar", Business_Activity_Ar);
            para[6] = new SqlParameter("@Business_Activity_Eng", Business_Activity_Eng);
            para[7] = new SqlParameter("@brn_address_Ar", brn_address_Ar);
            para[8] = new SqlParameter("@brn_address_Eng", brn_address_Eng);
            para[9] = new SqlParameter("@brn_date", brn_date);
            para[10] = new SqlParameter("@brn_logo", brn_logo);
            //Created By & Created Date
            para[11] = new SqlParameter("@Created_By", Created_By);
            para[12] = new SqlParameter("@Created_Date", Created_Date);
            para[13] = new SqlParameter("@check", "u");
            dtac.open();
            dtac.ExcutCommand("mng_brnch", para);
            dtac.close();
        }
        public void Del_Branch(int brn_id)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@brn_id", brn_id);
        
            para[1] = new SqlParameter("@check", "d");
            dtac.open();
            dtac.ExcutCommand("mng_brnch", para);
            dtac.close();
        }
        public void mng_brnchDel(int brn_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@brn_id", brn_id);

            dtac.open();
            dtac.ExcutCommand("mng_brnchDel", para);
            dtac.close();
        }
        public DataTable Check_Branch(int brn_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@brn_id", brn_id);
            

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Check_idbranch", para);
            dtac.close();
            return dt;
        }
        
        public DataTable Show_branch()
        {
           
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_branch", null);
            dtac.close();
            return dt;
        }

        //البحث
        public DataTable SearchBranch(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchBranch", para);
            dtac.close();
            return dt;
        }

        //للحصول على الارقام تسلسليه
        public DataTable Get_Branchd()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Branchd", null);
            dtac.close();
            return dt;
        }
    }
}
