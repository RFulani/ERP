using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace INV.Code
{
    class ClassDocument
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_document_Add(
                                        int emp_id
                                        , string doc_id
                                        , string doc_name
                                        , DateTime issue_date
                                        , DateTime expire_date

                                        , byte[] doc_image
                                       //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
                                        )
        {
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@doc_id", doc_id);
            para[2] = new SqlParameter("@doc_name", doc_name);
            para[3] = new SqlParameter("@issue_date", issue_date);
            para[4] = new SqlParameter("@expire_date", expire_date);
            para[5] = new SqlParameter("@doc_image", doc_image);
            //Created By & Created Date
            para[6] = new SqlParameter("@Created_By", Created_By);
            para[7] = new SqlParameter("@Created_Date", Created_Date);
            para[8] = new SqlParameter("@check", "a");

            dtac.open();
            dtac.ExcutCommand("mng_document", para);
            dtac.close();


        }
        public void mng_document_Update(
                                          int emp_id
                                        , string doc_id
                                        , string doc_name
                                        , DateTime issue_date
                                        , DateTime expire_date
                                        , byte[] doc_image
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
                                        )
        {
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@doc_id", doc_id);
            para[2] = new SqlParameter("@doc_name", doc_name);
            para[3] = new SqlParameter("@issue_date", issue_date);
            para[4] = new SqlParameter("@expire_date", expire_date);
            para[5] = new SqlParameter("@doc_image", doc_image);
            //Created By & Created Date
            para[6] = new SqlParameter("@Created_By", Created_By);
            para[7] = new SqlParameter("@Created_Date", Created_Date);
            para[8] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_document", para);
            dtac.close();


        }
        public void mng_document_UpdateEmpId(int emp_id, int oldEmpid)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@check", "e");
            para[2] = new SqlParameter("@oldEmpid", oldEmpid);

            dtac.open();
            dtac.ExcutCommand("mng_document", para);
            dtac.close();


        }
        //حذف مستند
        public void DelDocById(string doc_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@doc_id", doc_id);

            dtac.open();
            dtac.ExcutCommand("DelDocById", para);
            dtac.close();


        }
        public DataTable SearchDocuments(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchDocuments", para);
            dtac.close();
            return dt;
        }
        public DataTable SearchDocById(string doc_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@doc_id", doc_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchDocById", para);
            dtac.close();
            return dt;
        }
        public DataTable Checkdoc_ById(string doc_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@doc_id", doc_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Checkdoc_ById", para);
            dtac.close();
            return dt;
        }

        internal DataTable Checkdoc_ById(DataGridViewColumn dataGridViewColumn)
        {
            throw new NotImplementedException();
        }
    }

}
