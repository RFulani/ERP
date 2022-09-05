using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassDependents
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_dependents_Add(
                                     int emp_id
                                   , int dependent_No
                                   , string dependent_Name_ar  
                                   , string dependent_Name_en  
                                   , string relationship  
                                   , string dependent_Id 
                                   , DateTime dependent_DOB
                                   , string Created_By
                                   , DateTime Created_Date
                                        )
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@dependent_No", dependent_No);
            para[2] = new SqlParameter("@dependent_Name_ar", dependent_Name_ar);
            para[3] = new SqlParameter("@dependent_Name_en", dependent_Name_en);
            para[4] = new SqlParameter("@relationship", relationship);
            para[5] = new SqlParameter("@dependent_Id", dependent_Id);
            para[6] = new SqlParameter("@dependent_DOB", dependent_DOB);
            para[7] = new SqlParameter("@Created_By", Created_By);
            para[8] = new SqlParameter("@Created_Date", Created_Date);
            para[9] = new SqlParameter("@check", "a");

            dtac.open();
            dtac.ExcutCommand("mng_dependents", para);
            dtac.close();

        }

        public void mng_dependents_Update(
                                    int emp_id
                                   , int dependent_No
                                   , string dependent_Name_ar
                                   , string dependent_Name_en
                                   , string relationship
                                   , string dependent_Id
                                   , DateTime dependent_DOB
                                   , string Created_By
                                   , DateTime Created_Date
                                        )
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@dependent_No", dependent_No);
            para[2] = new SqlParameter("@dependent_Name_ar", dependent_Name_ar);
            para[3] = new SqlParameter("@dependent_Name_en", dependent_Name_en);
            para[4] = new SqlParameter("@relationship", relationship);
            para[5] = new SqlParameter("@dependent_Id", dependent_Id);
            para[6] = new SqlParameter("@dependent_DOB", dependent_DOB);
            para[7] = new SqlParameter("@Created_By", Created_By);
            para[8] = new SqlParameter("@Created_Date", Created_Date);
            para[9] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_dependents", para);
            dtac.close();


        }
        public void mng_dependens_UpdateEmpId(int emp_id, int oldEmpid)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@check", "e");
            para[2] = new SqlParameter("@oldEmpid", oldEmpid);

            dtac.open();
            dtac.ExcutCommand("mng_dependents", para);
            dtac.close();


        }
        //حذف مستند
        public void mng_dependentsDel(int dependent_No)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@dependent_No", dependent_No);

            dtac.open();
            dtac.ExcutCommand("mng_dependentsDel", para);
            dtac.close();


        }
        //التحقق من رقم الخاص بالمرافق
        public DataTable Checkdep_ByNo(int dependent_No)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@dependent_No", dependent_No);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Checkdep_ByNo", para);
            dtac.close();
            return dt;
        }
        //التحقق من هزية المرافق
        public DataTable Checkdep_ByCardID(string dependent_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@dependent_Id", dependent_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Checkdep_ByCardID", para);
            dtac.close();
            return dt;
        }
        //إظهار بيانات المرافقين بالرقم الخاص بالمرافقين
        public DataTable SearchDepById(int dependent_No)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@dependent_No", dependent_No);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchDepById", para);
            dtac.close();
            return dt;
        }
        //إظهار وبحث بيانات المرافقين بالرقم الوظيفي
        public DataTable SearchDependents(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchDependents", para);
            dtac.close();
            return dt;
        }
        //تسلسل الأرقام الخاصة بالمرافقين
        public DataTable Get_dependents_No()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_dependents_No", null);
            dtac.close();
            return dt;
        }
    }
}
