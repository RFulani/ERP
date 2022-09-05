using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassEvaluation
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_Emp_Evaluation_add(
            int Eva_id
           , DateTime Eva_date 
           , int emp_id
           , String emp_name  
           , DateTime Eva_date_from  
           , DateTime Eva_date_to
           , int Eva_1
           , int Eva_2   
           , int Eva_3   
           , int Eva_4   
           , int Eva_5   
           , int Eva_6   
           , int Eva_7   
           , int Eva_8   
           , int Eva_9   
           , int Eva_10   
           , int Eva_11   
           , int Eva_12   
           , int Eva_13   
           , int Eva_14   
           , int Eva_15   
           , int Eva_16   
           , int Eva_17   
           , int Eva_18   
           , int Eva_19   
           , int Eva_20   
           , int Eva_total  
           , String Eva_General
           , String Notes
                               //Created By & Created Date
                               , string Created_By
                               , DateTime Created_Date

            )
        {
            SqlParameter[] para = new SqlParameter[32];
            para[0] = new SqlParameter("@Eva_id", Eva_id);
            para[1] = new SqlParameter("@Eva_date", Eva_date);
            para[2] = new SqlParameter("@emp_id", emp_id);
            para[3] = new SqlParameter("@emp_name", emp_name);
            para[4] = new SqlParameter("@Eva_date_from", Eva_date_from);
            para[5] = new SqlParameter("@Eva_date_to", Eva_date_to);
            para[6] = new SqlParameter("@Eva_1", Eva_1);
            para[7] = new SqlParameter("@Eva_2", Eva_2);
            para[8] = new SqlParameter("@Eva_3", Eva_3);
            para[9] = new SqlParameter("@Eva_4", Eva_4);
            para[10] = new SqlParameter("@Eva_5", Eva_5);
            para[11] = new SqlParameter("@Eva_6", Eva_6);
            para[12] = new SqlParameter("@Eva_7", Eva_7);
            para[13] = new SqlParameter("@Eva_8", Eva_8);
            para[14] = new SqlParameter("@Eva_9", Eva_9);
            para[15] = new SqlParameter("@Eva_10", Eva_10);
            para[16] = new SqlParameter("@Eva_11", Eva_11);
            para[17] = new SqlParameter("@Eva_12", Eva_12);
            para[18] = new SqlParameter("@Eva_13", Eva_13);
            para[19] = new SqlParameter("@Eva_14", Eva_14);
            para[20] = new SqlParameter("@Eva_15", Eva_15);
            para[21] = new SqlParameter("@Eva_16", Eva_16);
            para[22] = new SqlParameter("@Eva_17", Eva_17);
            para[23] = new SqlParameter("@Eva_18", Eva_18);
            para[24] = new SqlParameter("@Eva_19", Eva_19);
            para[25] = new SqlParameter("@Eva_20", Eva_20);
            para[26] = new SqlParameter("@Eva_total", Eva_total);
            para[27] = new SqlParameter("@Eva_General", Eva_General);
            para[28] = new SqlParameter("@Notes", Notes);
            //Created By & Created Date
            para[29] = new SqlParameter("@Created_By", Created_By);
            para[30] = new SqlParameter("@Created_Date", Created_Date);
            para[31] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Emp_Evaluation", para);
            dtac.close();
        }

        //التعديل
        public void mng_Emp_Evaluation_update(
            int Eva_id
           , DateTime Eva_date
           , int emp_id
           , String emp_name
           , DateTime Eva_date_from
           , DateTime Eva_date_to
           , int Eva_1
           , int Eva_2
           , int Eva_3
           , int Eva_4
           , int Eva_5
           , int Eva_6
           , int Eva_7
           , int Eva_8
           , int Eva_9
           , int Eva_10
           , int Eva_11
           , int Eva_12
           , int Eva_13
           , int Eva_14
           , int Eva_15
           , int Eva_16
           , int Eva_17
           , int Eva_18
           , int Eva_19
           , int Eva_20
           , int Eva_total
           , String Eva_General
           , String Notes
                               //Created By & Created Date
                               , string Created_By
                               , DateTime Created_Date

            )
        {
            SqlParameter[] para = new SqlParameter[32];
            para[0] = new SqlParameter("@Eva_id", Eva_id);
            para[1] = new SqlParameter("@Eva_date", Eva_date);
            para[2] = new SqlParameter("@emp_id", emp_id);
            para[3] = new SqlParameter("@emp_name", emp_name);
            para[4] = new SqlParameter("@Eva_date_from", Eva_date_from);
            para[5] = new SqlParameter("@Eva_date_to", Eva_date_to);
            para[6] = new SqlParameter("@Eva_1", Eva_1);
            para[7] = new SqlParameter("@Eva_2", Eva_2);
            para[8] = new SqlParameter("@Eva_3", Eva_3);
            para[9] = new SqlParameter("@Eva_4", Eva_4);
            para[10] = new SqlParameter("@Eva_5", Eva_5);
            para[11] = new SqlParameter("@Eva_6", Eva_6);
            para[12] = new SqlParameter("@Eva_7", Eva_7);
            para[13] = new SqlParameter("@Eva_8", Eva_8);
            para[14] = new SqlParameter("@Eva_9", Eva_9);
            para[15] = new SqlParameter("@Eva_10", Eva_10);
            para[16] = new SqlParameter("@Eva_11", Eva_11);
            para[17] = new SqlParameter("@Eva_12", Eva_12);
            para[18] = new SqlParameter("@Eva_13", Eva_13);
            para[19] = new SqlParameter("@Eva_14", Eva_14);
            para[20] = new SqlParameter("@Eva_15", Eva_15);
            para[21] = new SqlParameter("@Eva_16", Eva_16);
            para[22] = new SqlParameter("@Eva_17", Eva_17);
            para[23] = new SqlParameter("@Eva_18", Eva_18);
            para[24] = new SqlParameter("@Eva_19", Eva_19);
            para[25] = new SqlParameter("@Eva_20", Eva_20);
            para[26] = new SqlParameter("@Eva_total", Eva_total);
            para[27] = new SqlParameter("@Eva_General", Eva_General);
            para[28] = new SqlParameter("@Notes", Notes);
            //Created By & Created Date
            para[29] = new SqlParameter("@Created_By", Created_By);
            para[30] = new SqlParameter("@Created_Date", Created_Date);
            para[31] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Emp_Evaluation", para);
            dtac.close();
        }



        //الحذف
        public void mng_Emp_EvaluationDel(int Eva_id)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Eva_id", Eva_id);

            dtac.open();
            dtac.ExcutCommand("mng_Emp_EvaluationDel", para);
            dtac.close();
        }
        
        public DataTable Get_Emp_EvaluationId()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Emp_EvaluationId", null);
            dtac.close();
            return dt;
        }

        public DataTable SearchEmp_Evaluation(string searchEV)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@searchEV", searchEV);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchEmp_Evaluation", para);
            dtac.close();
            return dt;
        }

        // إظهار جميع السجلات للبحث
        public DataTable ShowEmp_Evaluation(int Eva_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Eva_id", Eva_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowEmp_Evaluation", para);
            dtac.close();
            return dt;
        }

    }
}
