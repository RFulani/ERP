using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace INV.Code
{
    class Class_ProUnit
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_Pro_Unit_add(
            int Qun_id
           , string pro_id  
           , string pro_name
           , string pro_unit_Ar
           , string pro_unit_Eng
           , decimal Pro_Unit_Num  
           , int Unit_L
           , string Notes
            //Created By & Created Date
            ,string Created_By
            ,DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@Qun_id", Qun_id);
            para[1] = new SqlParameter("@pro_id", pro_id);
            para[2] = new SqlParameter("@pro_name", pro_name);
            para[3] = new SqlParameter("@pro_unit_Ar", pro_unit_Ar);
            para[4] = new SqlParameter("@pro_unit_Eng", pro_unit_Eng);
            para[5] = new SqlParameter("@Pro_Unit_Num", Pro_Unit_Num);
            para[6] = new SqlParameter("@Unit_L", Unit_L);
            para[7] = new SqlParameter("@Notes", Notes);
            //Created By & Created Date
            para[8] = new SqlParameter("@Created_By", Created_By);
            para[9] = new SqlParameter("@Created_Date", Created_Date);
            para[10] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Pro_Unit", para);
            dtac.close();
        }

        //التعديل
        public void mng_Pro_Unit_Update(
            int Qun_id
           , string pro_id
           , string pro_name
           , string pro_unit_Ar
           , string pro_unit_Eng
           , decimal Pro_Unit_Num
           , int Unit_L
           , string Notes
            //Created By & Created Date
            , string Created_By
            , DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@Qun_id", Qun_id);
            para[1] = new SqlParameter("@pro_id", pro_id);
            para[2] = new SqlParameter("@pro_name", pro_name);
            para[3] = new SqlParameter("@pro_unit_Ar", pro_unit_Ar);
            para[4] = new SqlParameter("@pro_unit_Eng", pro_unit_Eng);
            para[5] = new SqlParameter("@Pro_Unit_Num", Pro_Unit_Num);
            para[6] = new SqlParameter("@Unit_L", Unit_L);
            para[7] = new SqlParameter("@Notes", Notes);
            //Created By & Created Date
            para[8] = new SqlParameter("@Created_By", Created_By);
            para[9] = new SqlParameter("@Created_Date", Created_Date);
            para[10] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_Pro_Unit", para);
            dtac.close();
        }

        //الحذف
        public void mng_Pro_Unit_Del(int Qun_id, string pro_id)


        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Qun_id", Qun_id);
            para[1] = new SqlParameter("@pro_id", pro_id);
            
             

            dtac.open();
            dtac.ExcutCommand("mng_Pro_UnitDel", para);
            dtac.close();
        }

        public DataTable Show_UnitQty_Pro( string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@pro_id", pro_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_UnitQty_Pro", para);
            dtac.close();
            return dt;

        }

        public DataTable Show_UnitQty_ProUnit(int Qun_id , string pro_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Qun_id", Qun_id);
            para[1] = new SqlParameter("@pro_id", pro_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_UnitQty_ProUnit", para);
            dtac.close();
            return dt;

        }
        public DataTable Qun_id()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Qun_id", null);
            dtac.close();
            return dt;
        }
    }
}
