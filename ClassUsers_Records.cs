using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    class ClassUsers_Records
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_Users_Records_add(
                        string User_Id  
						,string User_Name  
						,DateTime In_Date  
                        , DateTime Out_Date   
                        //Created By & Created Date
                        , string Created_By
                        , DateTime Created_Date


                              )
        {
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@User_Id", User_Id);
            para[1] = new SqlParameter("@User_Name", User_Name);
            para[2] = new SqlParameter("@In_Date", In_Date);
            para[3] = new SqlParameter("@Out_Date", Out_Date);
            //Created By & Created Date
            para[4] = new SqlParameter("@Created_By", Created_By);
            para[5] = new SqlParameter("@Created_Date", Created_Date);
            para[6] = new SqlParameter("@check", "a");


            dtac.open();
            dtac.ExcutCommand("mng_Users_Records", para);
            dtac.close();
        }
           public void mng_Users_Records_Update(
                        string User_Id
                        , string User_Name
                        , DateTime In_Date
                        , DateTime Out_Date
                        //Created By & Created Date
                        , string Created_By
                        , DateTime Created_Date

                               )
        {
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@User_Id", User_Id);
            para[1] = new SqlParameter("@User_Name", User_Name);
            para[2] = new SqlParameter("@In_Date", In_Date);
            para[3] = new SqlParameter("@Out_Date", Out_Date);
            //Created By & Created Date
            para[4] = new SqlParameter("@Created_By", Created_By);
            para[5] = new SqlParameter("@Created_Date", Created_Date);
            para[6] = new SqlParameter("@check", "u");
             


            dtac.open();
            dtac.ExcutCommand("mng_Users_Records", para);
            dtac.close();
        }
    }
}
