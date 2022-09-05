using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class ClassInvoiceSetting
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_Invoice_Setting_add(
                                  int User_Id

                                , int invoice_id

                                , int VAT_status

                                , int VAT_percent

                                , int Inv_Add

                                , int inv_update  

                                , int inv_delete  

                                , int inv_search  

                                , int inv_plus  

                                , int inv_mins
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[13];
            para[0] = new SqlParameter("@User_Id", User_Id);
            para[1] = new SqlParameter("@invoice_id", invoice_id);
            para[2] = new SqlParameter("@VAT_status", VAT_status);
            para[3] = new SqlParameter("@VAT_percent", VAT_percent);
            para[4] = new SqlParameter("@Inv_Add", Inv_Add);
            para[5] = new SqlParameter("@inv_update", inv_update);
            para[6] = new SqlParameter("@inv_delete", inv_delete);
            para[7] = new SqlParameter("@inv_search", inv_search);
            para[8] = new SqlParameter("@inv_plus", inv_plus);
            para[9] = new SqlParameter("@inv_mins", inv_mins);
            //Created By & Created Date
            para[10] = new SqlParameter("@Created_By", Created_By);
            para[11] = new SqlParameter("@Created_Date", Created_Date);
            para[12] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_Invoice_Setting", para);
            dtac.close();
        }

        //التعديل
        public void mng_Invoice_Setting_Update(
                                             int User_Id

                                            , int invoice_id

                                            , int VAT_status

                                            , int VAT_percent

                                            , int Inv_Add

                                            , int inv_update

                                            , int inv_delete

                                            , int inv_search

                                            , int inv_plus

                                            , int inv_mins
                                        //Created By & Created Date
                                        , string Created_By
                                        , DateTime Created_Date

           )
        {
            SqlParameter[] para = new SqlParameter[13];
            para[0] = new SqlParameter("@User_Id", User_Id);
            para[1] = new SqlParameter("@invoice_id", invoice_id);
            para[2] = new SqlParameter("@VAT_status", VAT_status);
            para[3] = new SqlParameter("@VAT_percent", VAT_percent);
            para[4] = new SqlParameter("@Inv_Add", Inv_Add);
            para[5] = new SqlParameter("@inv_update", inv_update);
            para[6] = new SqlParameter("@inv_delete", inv_delete);
            para[7] = new SqlParameter("@inv_search", inv_search);
            para[8] = new SqlParameter("@inv_plus", inv_plus);
            para[9] = new SqlParameter("@inv_mins", inv_mins);
            //Created By & Created Date
            para[10] = new SqlParameter("@Created_By", Created_By);
            para[11] = new SqlParameter("@Created_Date", Created_Date);
            para[12] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_Invoice_Setting", para);
            dtac.close();
        }



        //الحذف
        public void mng_Invoice_SettingDel(int User_Id)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@User_Id", User_Id);

            dtac.open();
            dtac.ExcutCommand("mng_Invoice_SettingDel", para);
            dtac.close();
        }
    }
}
