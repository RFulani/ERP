using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WECPOFLogic;
using static System.Net.Mime.MediaTypeNames;

namespace INV.Code
{
    class ClassAtt0
    {

        Code.DataAccessLayer dtac = new DataAccessLayer();
        Code.DB_HR dhr = new DB_HR();

        public void mng_Att_0_add(
                                     //  DateTime Att_from
                                     //, DateTime Att_to

                                     int PIN

                                  , DateTime Date
                                  , DateTime Time
                                  , String AM_PM
                               //Created By & Created Date
                               , string Created_By
                               , DateTime Created_Date



                                                           )
        {
            SqlParameter[] para = new SqlParameter[7];

            //para[0] = new SqlParameter("@Att_from", Att_from);
            //para[1] = new SqlParameter("@Att_to", Att_to);

            para[0] = new SqlParameter("@PIN", PIN);
            para[1] = new SqlParameter("@Date", Date);
            para[2] = new SqlParameter("@Time", Time);
            para[3] = new SqlParameter("@AM_PM", AM_PM);
            //Created By & Created Date
            para[4] = new SqlParameter("@Created_By", Created_By);
            para[5] = new SqlParameter("@Created_Date", Created_Date);
            para[6] = new SqlParameter("@check", "a");




            dtac.open();
            dtac.ExcutCommand("mng_Att_0", para);
            dtac.close();
        }

        public void mng_Att_0_addAll(
                                  //  DateTime Att_from
                                  //, DateTime Att_to

                                   int PIN
                                  , DateTime Date
                                  , DateTime Time
                                  , String AM_PM
                               //Created By & Created Date
                               , string Created_By
                               , DateTime Created_Date
                                                          )
        {
            SqlParameter[] para = new SqlParameter[7];

            //para[0] = new SqlParameter("@Att_from", Att_from);
            //para[1] = new SqlParameter("@Att_to", Att_to);

            para[0] = new SqlParameter("@PIN", PIN);
            para[1] = new SqlParameter("@Date", Date);
            para[2] = new SqlParameter("@Time", Time);
            para[3] = new SqlParameter("@AM_PM", AM_PM);
            //Created By & Created Date
            para[4] = new SqlParameter("@Created_By", Created_By);
            para[5] = new SqlParameter("@Created_Date", Created_Date);
            para[6] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Att_0", para);
            dtac.close();
        }



        public DataTable ShowEmpByBranch(int branch_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@branch_id", branch_id);
            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("ShowEmpByBranch", para);
            dtac.close();
            return dtemp;
        }


        //الحذف
        public void mng_Att_0_Del(DateTime Att_from, DateTime Att_to, int PIN)


        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@Att_from", Att_from);
            para[1] = new SqlParameter("@Att_to", Att_to);
            para[2] = new SqlParameter("@PIN", PIN);
            dtac.open();
            dtac.ExcutCommand("mng_Att_0_Del", para);
            dtac.close();
        }


        //الحذف
        public void mng_Att_0_ALL_Del(DateTime Att_from, DateTime Att_to)


        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Att_from", Att_from);
            para[1] = new SqlParameter("@Att_to", Att_to);
           
            dtac.open();
            dtac.ExcutCommand("mng_Att_0_ALL_Del", para);
            dtac.close();
        }

        //للبحث
        public DataTable SearchAtt_0(string SearchAtt_0)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@SearchAtt_0", SearchAtt_0);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchAtt_0", para);
            dtac.close();
            return dt;
        }




        public DataTable AttEmpOfOrgenalTable(int emp_id, DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@from", from);
            para[2] = new SqlParameter("@to", to);
           ;

            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dhr.SelectdataHR("AttEmpOfOrgenalTable", para);
            dtac.close();
            return dtemp;
        }

        public DataTable AttEmpOfOrgenalTableForAll( DateTime from, DateTime to)
        {
            SqlParameter[] para = new SqlParameter[2];
           
            para[0] = new SqlParameter("@from", from);
            para[1] = new SqlParameter("@to", to);
            ;

            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dhr.SelectdataHR("AttEmpOfOrgenalTableForAll", para);
            dtac.close();
            return dtemp;
        }
    }

    
}
