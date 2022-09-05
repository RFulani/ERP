using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassLetter
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_Letter_add(
                                    int Letter_No
                                  , DateTime Letter_date
                                  , String Letter_text
                                  , String Notes
                                  //Created By & Created Date
                                  , string Created_By
                                  , DateTime Created_Date


                                                           )
        {
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@Letter_No", Letter_No);
            para[1] = new SqlParameter("@Letter_date", Letter_date);
            para[2] = new SqlParameter("@Letter_text", Letter_text);
            para[3] = new SqlParameter("@Notes", Notes);
            //Created By & Created Date
            para[4] = new SqlParameter("@Created_By", Created_By);
            para[5] = new SqlParameter("@Created_Date", Created_Date);

            para[6] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Letter", para);
            dtac.close();
        }


        public void mng_Letter_Update(
                                    int Letter_No

                        , DateTime Letter_date

                    , String Letter_text

                        , String Notes
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
                                                           )
        {


            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@Letter_No", Letter_No);
            para[1] = new SqlParameter("@Letter_date", Letter_date);
            para[2] = new SqlParameter("@Letter_text", Letter_text);
            para[3] = new SqlParameter("@Notes", Notes);
            //Created By & Created Date
            para[4] = new SqlParameter("@Created_By", Created_By);
            para[5] = new SqlParameter("@Created_Date", Created_Date);
            para[6] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_Letter", para);
            dtac.close();
        }
        //الحذف
        public void mng_LetterDel(int Letter_No)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Letter_No", Letter_No);

            dtac.open();
            dtac.ExcutCommand("mng_LetterDel", para);
            dtac.close();
        }

        //للبحث
        public DataTable SearchLetters(string searchLe)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@searchLe", searchLe);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchLetters", para);
            dtac.close();
            return dt;
        }

        // إظهار جميع السجلات للبحث
        public DataTable ShowLetters(int Letter_No)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Letter_No", Letter_No);

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowLetters", para);
            dtac.close();
            return dt;
        }


        public DataTable Get_Letters_Id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Letters_Id", null);
            dtac.close();
            return dt;
        }
    }
}
