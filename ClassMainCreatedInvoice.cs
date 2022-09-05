using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassMainCreatedInvoice
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_Main_Create_Invocie_add(
                                      int Create_Invoice_Id  /*رقم إنشاء الموظف*/
                                    , string CreatingInvoice_Type
                                    //Created By & Created Date
                                    , string Created_By
                                    , DateTime Created_Date

                                                           )
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);
            para[1] = new SqlParameter("@CreatingInvoice_Type", CreatingInvoice_Type);
            //Created By & Created Date
            para[2] = new SqlParameter("@Created_By", Created_By);
            para[3] = new SqlParameter("@Created_Date", Created_Date);
            para[4] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Main_Create_Invocie", para);
            dtac.close();
        }


        public void mng_Main_Create_Invocie_Update(
                                      int Create_Invoice_Id  /*رقم إنشاء الموظف*/
                                    , string CreatingInvoice_Type
                                    //Created By & Created Date
                                    , string Created_By
                                    , DateTime Created_Date

                                                           )
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@Create_Invoice_Id", Create_Invoice_Id);
            para[1] = new SqlParameter("@CreatingInvoice_Type", CreatingInvoice_Type);
            //Created By & Created Date
            para[2] = new SqlParameter("@Created_By", Created_By);
            para[3] = new SqlParameter("@Created_Date", Created_Date);
            para[4] = new SqlParameter("@check", "u");

            dtac.open();
            dtac.ExcutCommand("mng_Main_Create_Invocie", para);
            dtac.close();
        }
    }
}
