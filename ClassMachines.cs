using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace INV.Code
{
    class ClassMachines
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();


        //الأضافة
        public void mng_Machines_add(
                                       int Machine_id,
                                       string Machine_code,
                                       string Machine_Name,
                                       DateTime Machine_Date,
                                       string Machine_Country,
                                       string Machine_Description,
                                       byte[] Machine_image,
                                       //Created By & Created Date
                                       string Created_By,
                                       DateTime Created_Date
                                     )
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@Machine_id", Machine_id);
            para[1] = new SqlParameter("@Machine_code", Machine_code);
            para[2] = new SqlParameter("@Machine_Name", Machine_Name);
            para[3] = new SqlParameter("@Machine_Date", Machine_Date);
            para[4] = new SqlParameter("@Machine_Country", Machine_Country);
            para[5] = new SqlParameter("@Machine_Description", Machine_Description);
            para[6] = new SqlParameter("@Machine_image", Machine_image);
            //Created By & Created Date
            para[7] = new SqlParameter("@Created_By", Created_By);
            para[8] = new SqlParameter("@Created_Date", Created_Date);
            para[9] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Machines", para);
            dtac.close();
        }

        //التعديل
        public void mng_Machines_Update(
                                       int Machine_id,
                                       string Machine_code,
                                       string Machine_Name,
                                       DateTime Machine_Date,
                                       string Machine_Country,
                                       string Machine_Description,
                                       byte[] Machine_image,
                                       //Created By & Created Date
                                       string Created_By,
                                       DateTime Created_Date
                                     )
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@Machine_id", Machine_id);
            para[1] = new SqlParameter("@Machine_code", Machine_code);
            para[2] = new SqlParameter("@Machine_Name", Machine_Name);
            para[3] = new SqlParameter("@Machine_Date", Machine_Date);
            para[4] = new SqlParameter("@Machine_Country", Machine_Country);
            para[5] = new SqlParameter("@Machine_Description", Machine_Description);
            para[6] = new SqlParameter("@Machine_image", Machine_image);
            //Created By & Created Date
            para[7] = new SqlParameter("@Created_By", Created_By);
            para[8] = new SqlParameter("@Created_Date", Created_Date);
            para[9] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_Machines", para);
            dtac.close();
        }

        //الحذف
        public void mng_MachinesDel(int Machine_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Machine_id", Machine_id);

            dtac.open();
            dtac.ExcutCommand("mng_MachinesDel", para);
            dtac.close();
        }
        //إظهار الالات وفقا لرقم الاله
        public DataTable ShowMachines(int Machine_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Machine_id", Machine_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowMachines", para);
            dtac.close();
            return dt;
        }
        //بحث 
        public DataTable SearchMachines(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchMachines", para);
            dtac.close();
            return dt;
        }
        //للحصول على الارقام تسلسليه
        public DataTable Get_Machinesid()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Machinesid", null);
            dtac.close();
            return dt;
        }
    }
}
