using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace INV.Code
{
    class ClassGeneralDocument
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_General_Document_add(
                                               int G_doc_ID,
                                               DateTime G_doc_Date,
                                               String G_doc_Type,
                                               string G_doc_No,
                                               DateTime G_doc_IssueDate,
                                               DateTime G_doc_ExpireDate,
                                               string G_doc_Notes,
                                               byte[] G_doc_Image
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
                                            )


        {
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@G_doc_ID", G_doc_ID);
            para[1] = new SqlParameter("@G_doc_Date", G_doc_Date);
            para[2] = new SqlParameter("@G_doc_Type", G_doc_Type);
          
            para[3] = new SqlParameter("@G_doc_No", G_doc_No);
            para[4] = new SqlParameter("@G_doc_IssueDate", G_doc_IssueDate);
            para[5] = new SqlParameter("@G_doc_ExpireDate", G_doc_ExpireDate);
            para[6] = new SqlParameter("@G_doc_Notes", G_doc_Notes);
            para[7] = new SqlParameter("@G_doc_Image", G_doc_Image);
            //Created By & Created Date
            para[8] = new SqlParameter("@Created_By", Created_By);
            para[9] = new SqlParameter("@Created_Date", Created_Date);
            para[10] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_General_Document", para);
            dtac.close();
        }

        //التعديل
        public void mng_General_Document_Update(
                                               int G_doc_ID,
                                               DateTime G_doc_Date,
                                               String G_doc_Type,
                                          
                                               string G_doc_No,
                                               DateTime G_doc_IssueDate,
                                               DateTime G_doc_ExpireDate,
                                               string G_doc_Notes,
                                               byte[] G_doc_Image
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
           )
        {
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@G_doc_ID", G_doc_ID);
            para[1] = new SqlParameter("@G_doc_Date", G_doc_Date);
            para[2] = new SqlParameter("@G_doc_Type", G_doc_Type);
         
            para[3] = new SqlParameter("@G_doc_No", G_doc_No);
            para[4] = new SqlParameter("@G_doc_IssueDate", G_doc_IssueDate);
            para[5] = new SqlParameter("@G_doc_ExpireDate", G_doc_ExpireDate);
            para[6] = new SqlParameter("@G_doc_Notes", G_doc_Notes);
            para[7] = new SqlParameter("@G_doc_Image", G_doc_Image);
            //Created By & Created Date
            para[8] = new SqlParameter("@Created_By", Created_By);
            para[9] = new SqlParameter("@Created_Date", Created_Date);
            para[10] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_General_Document", para);
            dtac.close();
        }



        //الحذف
        public void mng_General_DocumentDel(int G_doc_ID)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@G_doc_ID", G_doc_ID);

            dtac.open();
            dtac.ExcutCommand("mng_General_DocumentDel", para);
            dtac.close();
        }
        public DataTable Get_General_Document_id()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("General_Document_id", null);
            dtac.close();
            return dt;
        }
        public DataTable ShowGdocs(int G_doc_ID)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@G_doc_ID", G_doc_ID);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowGdocs", para);
            dtac.close();
            return dt;
        }

        public DataTable ShowGdocsByDocNo(string G_doc_No)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@G_doc_No", G_doc_No);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowGdocsByDocNo", para);
            dtac.close();
            return dt;
        }

        public DataTable SearchGeneral_Document(string search1)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search1", search1);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchGeneral_Document", para);
            dtac.close();
            return dt;
        }
        public DataTable SearchGDocById(int G_doc_ID)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@G_doc_ID", G_doc_ID);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchGDocById", para);
            dtac.close();
            return dt;
        }
    }


}
