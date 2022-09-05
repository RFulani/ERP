using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassCostCenter
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_CostCenter_add(
                                    int CostCenter_Id
                                  , string CostCenter_Name
                                  , int Branch_Id
                                  , string Branch_Name
                                  //Created By & Created Date
                                  , string Created_By
                                  , DateTime Created_Date


                                                           )
        {
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@CostCenter_Id", CostCenter_Id);
            para[1] = new SqlParameter("@CostCenter_Name", CostCenter_Name);
            para[2] = new SqlParameter("@Branch_Id", Branch_Id);
            para[3] = new SqlParameter("@Branch_Name", Branch_Name);
            //Created By & Created Date
            para[4] = new SqlParameter("@Created_By", Created_By);
            para[5] = new SqlParameter("@Created_Date", Created_Date);
            para[6] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_CostCenter", para);
            dtac.close();
        }


        public void mng_CostCenter_Update(
                                    int CostCenter_Id
                                  , string CostCenter_Name
                                  , int Branch_Id
                                  , string Branch_Name
                                  //Created By & Created Date
                                  , string Created_By
                                  , DateTime Created_Date


                                                           )
        {
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@CostCenter_Id", CostCenter_Id);
            para[1] = new SqlParameter("@CostCenter_Name", CostCenter_Name);
            para[2] = new SqlParameter("@Branch_Id", Branch_Id);
            para[3] = new SqlParameter("@Branch_Name", Branch_Name);
            //Created By & Created Date
            para[4] = new SqlParameter("@Created_By", Created_By);
            para[5] = new SqlParameter("@Created_Date", Created_Date);
            para[6] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_CostCenter", para);
            dtac.close();
        }
        //الحذف
        public void mng_CostCenterDel(int CostCenter_Id)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@CostCenter_Id", CostCenter_Id);

            dtac.open();
            dtac.ExcutCommand("mng_CostCenterDel", para);
            dtac.close();
        }

        //للبحث
        public DataTable SearchCostCenter(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchCostCenter", para);
            dtac.close();
            return dt;
        }

        // إظهار جميع السجلات للبحث
        public DataTable ShowCostCenter(int CostCenter_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@CostCenter_Id", CostCenter_Id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowCostCenter", para);
            dtac.close();
            return dt;
        }

        public DataTable Get_CostCenter_Id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_CostCenter_Id", null);
            dtac.close();
            return dt;
        }

        //إظهار جميع البيانات في الداتا جريد
        public DataTable ShowAllCostCenter()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllCostCenter", null);
            dtac.close();
            return dt;
        }
    }
}
