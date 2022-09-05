using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
   
    class ClassPro_Setting
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_pro_setting_add(
                                      int emp_id  /*رقم المستخدم او الموظف*/
                                    , string emp_name  /*إسم المستخدم او الموظف*/
                                    , int pro_details  /*تفاصيل المنتج*/
                                    , int Cost  /*التكلفه*/
                                    , int Qyt  /*الكميه*/
                                    , int Offers_Add  /*العروض- إضافه*/
                                    , int Offers_Update  /*العروض- تعديل*/
                                    , int Offers_Show  /*العروض- العرض*/
                                    , int Offers_Del  /*العروض- الحذف*/
                                    , int Offers_stop  /*العروض- إيقاف العرض*/
                                    , int Offers_Active  /*العروض- تفعيل العرض*/
                                    , int Offers_dgv  /*العروض- dgv*/
                                    , int Others  /*أخرى*/
                                    //Created By & Created Date
                                    , string Created_By
                                    , DateTime Created_Date
                       

                                                           )
        {
            SqlParameter[] para = new SqlParameter[16];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@emp_name", emp_name);
            para[2] = new SqlParameter("@pro_details", pro_details);
            para[3] = new SqlParameter("@Cost", Cost);
            para[4] = new SqlParameter("@Qyt", Qyt);
            para[5] = new SqlParameter("@Offers_Add", Offers_Add);
            para[6] = new SqlParameter("@Offers_Update", Offers_Update);
            para[7] = new SqlParameter("@Offers_Show", Offers_Show);
            para[8] = new SqlParameter("@Offers_Del", Offers_Del);
            para[9] = new SqlParameter("@Offers_stop", Offers_stop);
            para[10] = new SqlParameter("@Offers_Active", Offers_Active);
            para[11] = new SqlParameter("@Offers_dgv", Offers_dgv);
            para[12] = new SqlParameter("@Others", Others);
            //Created By & Created Date
            para[13] = new SqlParameter("@Created_By", Created_By);
            para[14] = new SqlParameter("@Created_Date", Created_Date);
            para[15] = new SqlParameter("@check", "a");


            dtac.open();
            dtac.ExcutCommand("mng_pro_setting", para);
            dtac.close();
        }


        public void mng_pro_setting_Update(
                                      int emp_id  /*رقم المستخدم او الموظف*/
                                    , string emp_name  /*إسم المستخدم او الموظف*/
                                    , int pro_details  /*تفاصيل المنتج*/
                                    , int Cost  /*التكلفه*/
                                    , int Qyt  /*الكميه*/
                                    , int Offers_Add  /*العروض- إضافه*/
                                    , int Offers_Update  /*العروض- تعديل*/
                                    , int Offers_Show  /*العروض- العرض*/
                                    , int Offers_Del  /*العروض- الحذف*/
                                    , int Offers_stop  /*العروض- إيقاف العرض*/
                                    , int Offers_Active  /*العروض- تفعيل العرض*/
                                    , int Offers_dgv  /*العروض- dgv*/
                                    , int Others  /*أخرى*/
                                    //Created By & Created Date
                                    , string Created_By
                                    , DateTime Created_Date


                                                           )
        {
            SqlParameter[] para = new SqlParameter[16];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@emp_name", emp_name);
            para[2] = new SqlParameter("@pro_details", pro_details);
            para[3] = new SqlParameter("@Cost", Cost);
            para[4] = new SqlParameter("@Qyt", Qyt);
            para[5] = new SqlParameter("@Offers_Add", Offers_Add);
            para[6] = new SqlParameter("@Offers_Update", Offers_Update);
            para[7] = new SqlParameter("@Offers_Show", Offers_Show);
            para[8] = new SqlParameter("@Offers_Del", Offers_Del);
            para[9] = new SqlParameter("@Offers_stop", Offers_stop);
            para[10] = new SqlParameter("@Offers_Active", Offers_Active);
            para[11] = new SqlParameter("@Offers_dgv", Offers_dgv);
            para[12] = new SqlParameter("@Others", Others);
            //Created By & Created Date
            para[13] = new SqlParameter("@Created_By", Created_By);
            para[14] = new SqlParameter("@Created_Date", Created_Date);
            para[15] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_pro_setting", para);
            dtac.close();
        }
        //الحذف
        public void mng_pro_settingDel(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);

            dtac.open();
            dtac.ExcutCommand("mng_pro_settingDel", para);
            dtac.close();
        }

        public DataTable ShowPro_setting(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowPro_setting", para);
            dtac.close();
            return dt;
        }

        public DataTable ShowPro_settingDGV(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowPro_settingDGV", para);
            dtac.close();
            return dt;
        }

        //لإظهار جميع الحقول 
        public DataTable ShowAllPro_setting()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllPro_setting", null);
            dtac.close();
            return dt;
        }
    }
}
