using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace INV.Code
{
    class ClassTranslatingForms
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_translatingForms_add(
                                             int Id
                                           , int Screen_Id
                                           , string Screen_Name
                                           , string Form
                                           , string Tab
                                           , string Item_Name
                                           , string Arabic_Name
                                           , string English_Name
                                           //Created By & Created Date
                                           , string Created_By
                                           , DateTime Created_Date
                                              )
             {
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@Id", Id);
            para[1] = new SqlParameter("@Screen_Id", Screen_Id);
            para[2] = new SqlParameter("@Form", Form);
            para[3] = new SqlParameter("@Tab", Tab);
            para[4] = new SqlParameter("@Screen_Name", Screen_Name);
            para[5] = new SqlParameter("@Item_Name", Item_Name);
            para[6] = new SqlParameter("@Arabic_Name", Arabic_Name);
            para[7] = new SqlParameter("@English_Name", English_Name);
            //Created By & Created Date
            para[8] = new SqlParameter("@Created_By", Created_By);
            para[9] = new SqlParameter("@Created_Date", Created_Date);
            para[10] = new SqlParameter("@check", "a");

            dtac.open();
            dtac.ExcutCommand("mng_translatingForms", para);
            dtac.close();
             }


        public void mng_translatingForms_Update(
                                             int Id
                                           , int Screen_Id
                                           , string Screen_Name
                                           , string Form
                                           , string Tab
                                           , string Item_Name
                                           , string Arabic_Name
                                           , string English_Name
                                           //Created By & Created Date
                                           , string Created_By
                                           , DateTime Created_Date)
        {
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@Id", Id);
            para[1] = new SqlParameter("@Screen_Id", Screen_Id);
            para[2] = new SqlParameter("@Form", Form);
            para[3] = new SqlParameter("@Tab", Tab);
            para[4] = new SqlParameter("@Screen_Name", Screen_Name);
            para[5] = new SqlParameter("@Item_Name", Item_Name);
            para[6] = new SqlParameter("@Arabic_Name", Arabic_Name);
            para[7] = new SqlParameter("@English_Name", English_Name);
            //Created By & Created Date
            para[8] = new SqlParameter("@Created_By", Created_By);
            para[9] = new SqlParameter("@Created_Date", Created_Date);
            para[10] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_translatingForms", para);
            dtac.close();
        }
        //الحذف
        public void mng_translatingForms_Del(int Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Id", Id);

            dtac.open();
            dtac.ExcutCommand("mng_translatingForms_Del", para);
            dtac.close();
        }
        //إظهار البيانات برقم الشاشة
        public DataTable ShowtranslatingForms(int Screen_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Screen_Id", Screen_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowtranslatingForms", para);
            dtac.close();
            return dt;
        }

        //إظهار البيانات برقم 
        public DataTable ShowtranslatingFormsbyID(int Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Id", Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowtranslatingFormsbyID", para);
            dtac.close();
            return dt;
        }
        //للحصول على رقم تسلسلي تلقائي للرقم  
        public DataTable Get_translatingFormsId()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_translatingFormsId", null);
            dtac.close();
            return dt;
        }

        public DataTable ShowAllTranslate(int Screen_Id, string Form)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Screen_Id", Screen_Id);
            para[1] = new SqlParameter("@Form", Form);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllTranslate", para);
            dtac.close();
            return dt;
            //DataTable dt = new DataTable();
            //dtac.open();
            //dt = dtac.Selectdata("ShowAllTranslate", null);
            //dtac.close();
            //return dt;
        }

        public DataTable ShowAllTranslateFields()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllTranslateFields", null);
            dtac.close();
            return dt;
        }
    }
}
