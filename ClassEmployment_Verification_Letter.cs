using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace INV.Code
{
    class ClassEmployment_Verification_Letter
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_Employment_Verification_Letter_add(
                                                            int EVL_Id
                                                            , DateTime EVL_Date
                                                             , string EVL_SendTo
                                                             , int Emp_ID
                                                              , string EVL_Notes
                                                               , string EVL_empName
                                                                , string EVL_Nationality
                                                                  , string EVL_CardId
                                                                    , DateTime EVL_StartingWork
                                                                     , string EVL_positionName
                                                                     , decimal EVL_totalSalary
                                                                    , DateTime EVL_ExpiredLetter
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
                                                           )
        {
            SqlParameter[] para = new SqlParameter[15];
            para[0] = new SqlParameter("@EVL_Id", EVL_Id);
            para[1] = new SqlParameter("@EVL_Date", EVL_Date);
            para[2] = new SqlParameter("@EVL_SendTo", EVL_SendTo);
            para[3] = new SqlParameter("@Emp_ID", Emp_ID);
            para[4] = new SqlParameter("@EVL_Notes", EVL_Notes);
            para[5] = new SqlParameter("@EVL_empName", EVL_empName);
            para[6] = new SqlParameter("@EVL_Nationality", EVL_Nationality);
            para[7] = new SqlParameter("@EVL_CardId", EVL_CardId);
            para[8] = new SqlParameter("@EVL_StartingWork", EVL_StartingWork);
            para[9] = new SqlParameter("@EVL_positionName", EVL_positionName);
            para[10] = new SqlParameter("@EVL_totalSalary", EVL_totalSalary);
            para[11] = new SqlParameter("@EVL_ExpiredLetter", EVL_ExpiredLetter);
            //Created By & Created Date
            para[12] = new SqlParameter("@Created_By", Created_By);
            para[13] = new SqlParameter("@Created_Date", Created_Date);
            para[14] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Employment_Verification_Letter", para);
            dtac.close();
        }

        //التعديل
        public void mng_Employment_Verification_Letter_Update(
                                                        int EVL_Id
                                                            , DateTime EVL_Date
                                                             ,string EVL_SendTo
                                                             , int Emp_ID
                                                              , string EVL_Notes
                                                               , string EVL_empName
                                                                ,string  EVL_Nationality
                                                                  , string EVL_CardId
                                                                    ,DateTime EVL_StartingWork
                                                                     , string EVL_positionName
                                                                     , decimal EVL_totalSalary
                                                                     ,DateTime EVL_ExpiredLetter
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date

           )
        {
            SqlParameter[] para = new SqlParameter[15];
            para[0] = new SqlParameter("@EVL_Id", EVL_Id);
            para[1] = new SqlParameter("@EVL_Date", EVL_Date);
            para[2] = new SqlParameter("@EVL_SendTo", EVL_SendTo);
            para[3] = new SqlParameter("@Emp_ID", Emp_ID);
            para[4] = new SqlParameter("@EVL_Notes", EVL_Notes);
            para[5] = new SqlParameter("@EVL_empName", EVL_empName);
            para[6] = new SqlParameter("@EVL_Nationality", EVL_Nationality);
            para[7] = new SqlParameter("@EVL_CardId", EVL_CardId);
            para[8] = new SqlParameter("@EVL_StartingWork", EVL_StartingWork);
            para[9] = new SqlParameter("@EVL_positionName", EVL_positionName);
            para[10] = new SqlParameter("@EVL_totalSalary", EVL_totalSalary);
            para[11] = new SqlParameter("@EVL_ExpiredLetter", EVL_ExpiredLetter);
            //Created By & Created Date
            para[12] = new SqlParameter("@Created_By", Created_By);
            para[13] = new SqlParameter("@Created_Date", Created_Date);
            para[14] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Employment_Verification_Letter", para);
            dtac.close();
        }



        //الحذف
        public void mng_Employment_Verification_LetterDel(int EVL_Id)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@EVL_Id", EVL_Id);

            dtac.open();
            dtac.ExcutCommand("mng_Employment_Verification_LetterDel", para);
            dtac.close();
        }


        public DataTable ShowEVL(int EVL_Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@EVL_Id", EVL_Id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowEVL", para);
            dtac.close();
            return dt;
        }
        public DataTable Get_Employment_Verification_Letter()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_Employment_Verification_Letter", null);
            dtac.close();
            return dt;
        }
        public DataTable SearchEmployment_Verification_Letter(string searchEVL)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@searchEVL", searchEVL);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchEmployment_Verification_Letter", para);
            dtac.close();
            return dt;
        }

    }
    }
