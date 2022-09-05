using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassQuantity_Units
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        //إضافه
        public void mng_Quantity_Units_add(
                                          int Unit_No  
                                        , string Unit_Name  
                                        , string Item_No
                                        , decimal Packaging
                                        , string Notes 
                                        , int Defualt
                                        , string Unit_Name_Eng
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
                                                           )
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@Unit_No", Unit_No);
            para[1] = new SqlParameter("@Unit_Name", Unit_Name);
            para[2] = new SqlParameter("@Item_No", Item_No);
            para[3] = new SqlParameter("@Packaging", Packaging);
            para[4] = new SqlParameter("@Notes", Notes);
            para[5] = new SqlParameter("@Defualt", Defualt);
            para[6] = new SqlParameter("@Unit_Name_Eng", Unit_Name_Eng);
            //Created By & Created Date
            para[7] = new SqlParameter("@Created_By", Created_By);
            para[8] = new SqlParameter("@Created_Date", Created_Date);
            para[9] = new SqlParameter("@check", "a");

            dtac.open();
            dtac.ExcutCommand("mng_Quantity_Units", para);
            dtac.close();
        }
        //تعديل
        public void mng_Quantity_Units_Update(
                                          int Unit_No
                                        , string Unit_Name
                                        , string Item_No
                                        , decimal Packaging
                                        , string Notes
                                        , int Defualt
                                        , string Unit_Name_Eng
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
                                                           )
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@Unit_No", Unit_No);
            para[1] = new SqlParameter("@Unit_Name", Unit_Name);
            para[2] = new SqlParameter("@Item_No", Item_No);
            para[3] = new SqlParameter("@Packaging", Packaging);
            para[4] = new SqlParameter("@Notes", Notes);
            para[5] = new SqlParameter("@Defualt", Defualt);
            para[6] = new SqlParameter("@Unit_Name_Eng", Unit_Name_Eng);
            //Created By & Created Date
            para[7] = new SqlParameter("@Created_By", Created_By);
            para[8] = new SqlParameter("@Created_Date", Created_Date);
            para[9] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_Quantity_Units", para);
            dtac.close();
        }
        //الحذف
        public void mng_Quantity_UnitsDel(int Unit_No)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Unit_No", Unit_No);

            dtac.open();
            dtac.ExcutCommand("mng_Quantity_UnitsDel", para);
            dtac.close();
        }
        //لإظهار الوحدات وفقا لرقم الصنف
        public DataTable ShowQuantity_Units(string item_No)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Item_No", item_No);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowQuantity_Units", para);
            dtac.close();
            return dt;
        }

        //لإظهار الوحدات وفقاً لرقم الوحده
        public DataTable Show_QuantityUnits(int Unit_No)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Unit_No", Unit_No);
          ;

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_QuantityUnits", para);
            dtac.close();
            return dt;
        }

        //للحصول على الارقام تسلسليه
        public DataTable Get_Unit_No()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Unit_No", null);
            dtac.close();
            return dt;
        }

        public DataTable ShowQuantity_UnitsDef(string item_No/*, string Unit_Name*/)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Item_No", item_No);
            //para[1] = new SqlParameter("@Unit_Name", Unit_Name);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowQuantity_UnitsDef", para);
            dtac.close();
            return dt;
        }


        public DataTable GetPackging(string pro_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@pro_id", pro_id);
         

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetPackging", para);
            dtac.close();
            return dt;
        }
    }
}
