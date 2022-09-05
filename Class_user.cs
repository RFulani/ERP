using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace INV.Code
{
    
    class Class_user
    {
       
        Code.DataAccessLayer dacc = new DataAccessLayer();
        public DataTable Getall_user()
        { DataTable dt = new DataTable();
            dacc.open();
            dt = dacc.Selectdata("Getall_user", null);
            dacc.close();
            return dt;
        }
        public DataTable Getall_user_login()
        {
            DataTable dt = new DataTable();
            dacc.open();
            dt = dacc.Selectdata("Getall_user_login", null);
            dacc.close();
            return dt;
        }

        public DataTable Check_user_type(string user_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            para[0].Value = user_id;

            DataTable dt = new DataTable();
            dacc.open();
            dt = dacc.Selectdata("Get_user_type", para);
            dacc.close();
            return dt;
        }
        public DataTable Check_user(string user_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            para[0].Value = user_id;
            
            DataTable dt = new DataTable();
            dacc.open();
            dt = dacc.Selectdata("check_user", para);
            dacc.close();
            return dt;
        }

        public void Add_user(string user_id,
                             string user_pass,
                             string user_name,
                             string user_type)
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            para[0].Value = user_id;
            para[1] = new SqlParameter("@user_name", SqlDbType.NVarChar, 100);
            para[1].Value = user_name;
            para[2] = new SqlParameter("@user_pass", SqlDbType.VarChar, 50);
            para[2].Value = user_pass;
            para[3] = new SqlParameter("@user_type", SqlDbType.VarChar, 50);
            para[3].Value = user_type;
            para[4] = new SqlParameter("@check", SqlDbType.NChar, 1);
            para[4].Value = "a";

            DataTable dt = new DataTable();
            dacc.open();
            dacc.ExcutCommand("AddUpdateDel_user", para);
            dacc.close();
           
        }
        public void Del_user(string user_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            para[0].Value = user_id;
           
            para[1] = new SqlParameter("@check", SqlDbType.NChar, 1);
            para[1].Value = "d";

            DataTable dt = new DataTable();
            dacc.open();
            dacc.ExcutCommand("AddUpdateDel_user", para);
            dacc.close();

        }
        public void updatepass_user(string user_id, string user_pass)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            para[0].Value = user_id;
           
            para[1] = new SqlParameter("@user_pass", SqlDbType.VarChar, 50);
            para[1].Value = user_pass;
          
            para[2] = new SqlParameter("@check", SqlDbType.NChar, 1);
            para[2].Value = "p";

            DataTable dt = new DataTable();
            dacc.open();
            dacc.ExcutCommand("AddUpdateDel_user", para);
            dacc.close();

        }


        Code.DataAccessLayer dtac = new DataAccessLayer();
        public DataTable SearchUsers_priv(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchUsers_priv", para);
            dtac.close();
            return dt;
        }

        public DataTable ShowUsers(String user_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@user_id", user_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowUsers", para);
            dtac.close();
            return dt;
        }


        public DataTable ShowUsers_id(String user_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@user_id", user_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowUsers_id", para);
            dtac.close();
            return dt;
        }


        public void UpdatingpassEMP(
                                  string emp_cardid,
                               
                                  string Password


                              )
        {
            SqlParameter[] para = new SqlParameter[2];


            para[0] = new SqlParameter("@emp_cardid", emp_cardid);
            para[1] = new SqlParameter("@Password", Password);
   


            dtac.open();
            dtac.ExcutCommand("UpdatingpassEMP", para);
            dtac.close();
        }
    }
}
