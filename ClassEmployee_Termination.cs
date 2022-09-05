using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassEmployee_Termination
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_Employee_Termination_add(
                                           int Termination_id
                                         , DateTime Termination_date
                                         , string Termination_reason
                                         , string Termination_Other
                                         , string Termination_Notes
                                         , int emp_id 
					                     , string empName_ar
                                         , string emp_Nationality
                                         , string emp_positionname
                                         , string contract_type
                                         , DateTime start_contract  
                                         , DateTime end_contract
                                         , DateTime Termination_lastday
                                         //Created By & Created Date
                                         , string Created_By
                                         , DateTime Created_Date

                                                           )
        {
            SqlParameter[] para = new SqlParameter[16];
            para[0] = new SqlParameter("@Termination_id", Termination_id);
            para[1] = new SqlParameter("@Termination_date", Termination_date);
            para[2] = new SqlParameter("@Termination_reason", Termination_reason);
            para[3] = new SqlParameter("@Termination_Other", Termination_Other);
            para[4] = new SqlParameter("@Termination_Notes", Termination_Notes);
            para[5] = new SqlParameter("@emp_id", emp_id);
            para[6] = new SqlParameter("@empName_ar", empName_ar);
            para[7] = new SqlParameter("@emp_Nationality", emp_Nationality);
            para[8] = new SqlParameter("@emp_positionname", emp_positionname);
            para[9] = new SqlParameter("@contract_type", contract_type);
            para[10] = new SqlParameter("@start_contract", start_contract);
            para[11] = new SqlParameter("@end_contract", end_contract);
            para[12] = new SqlParameter("@Termination_lastday", Termination_lastday);
            //Created By & Created Date
            para[13] = new SqlParameter("@Created_By", Created_By);
            para[14] = new SqlParameter("@Created_Date", Created_Date);
            para[15] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Termination", para);
            dtac.close();
        }
        public void mng_Employee_Termination_Update(
                                           int Termination_id
                                         , DateTime Termination_date
                                         , string Termination_reason
                                         , string Termination_Other
                                         , string Termination_Notes
                                         , int emp_id
                                         , string empName_ar
                                         , string emp_Nationality
                                         , string emp_positionname
                                         , string contract_type
                                         , DateTime start_contract
                                         , DateTime end_contract
                                         , DateTime Termination_lastday
                                         //Created By & Created Date
                                         , string Created_By
                                         , DateTime Created_Date

                                                           )
        {

            SqlParameter[] para = new SqlParameter[16];
            para[0] = new SqlParameter("@Termination_id", Termination_id);
            para[1] = new SqlParameter("@Termination_date", Termination_date);
            para[2] = new SqlParameter("@Termination_reason", Termination_reason);
            para[3] = new SqlParameter("@Termination_Other", Termination_Other);
            para[4] = new SqlParameter("@Termination_Notes", Termination_Notes);
            para[5] = new SqlParameter("@emp_id", emp_id);
            para[6] = new SqlParameter("@empName_ar", empName_ar);
            para[7] = new SqlParameter("@emp_Nationality", emp_Nationality);
            para[8] = new SqlParameter("@emp_positionname", emp_positionname);
            para[9] = new SqlParameter("@contract_type", contract_type);
            para[10] = new SqlParameter("@start_contract", start_contract);
            para[11] = new SqlParameter("@end_contract", end_contract);
            para[12] = new SqlParameter("@Termination_lastday", Termination_lastday);
            //Created By & Created Date
            para[13] = new SqlParameter("@Created_By", Created_By);
            para[14] = new SqlParameter("@Created_Date", Created_Date);
            para[15] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Termination", para);
            dtac.close();
        }

        //الحذف
        public void mng_TerminationDel(int Termination_id)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Termination_id", Termination_id);
           

            dtac.open();
            dtac.ExcutCommand("mng_TerminationDel", para);
            dtac.close();
        }

        public DataTable Get_TerminationId()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_TerminationId", null);
            dtac.close();
            return dt;
        }

        //للبحث
        public DataTable SearchTermination(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchTermination", para);
            dtac.close();
            return dt;
        }

        // إظهار جميع السجلات للبحث
        public DataTable ShowTermination(int Termination_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Termination_id", Termination_id);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowTermination", para);
            dtac.close();
            return dt;
        }

    }
}
