using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    class ClassTrack
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();


        //الأضافة
        public void mng_track_add(
                                
                                 int Track_id,
                                 string Form_Name,
                                 string order_id,
                                string order_name,
                                 string Action,
                                 string Action_By,
                                 DateTime Action_Date
                                     )
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@Track_id", Track_id);
            para[1] = new SqlParameter("@Form_Name", Form_Name);
            para[2] = new SqlParameter("@order_id", order_id);
            para[3] = new SqlParameter("@order_name", order_name);
            para[4] = new SqlParameter("@Action", Action);
            para[5] = new SqlParameter("@Action_By", Action_By);
            para[6] = new SqlParameter("@Action_Date", Action_Date);
            para[7] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_track", para);
            dtac.close();
        }

        //للحصول على الارقام تسلسليه
        public DataTable Get_Trackid()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Trackid", null);
            dtac.close();
            return dt;
        }
    }
}
