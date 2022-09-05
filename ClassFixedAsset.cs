using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace INV.Code
{
    class ClassFixedAsset
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_FixedAsset_add(
                                        int FixedAsset_id  
                                      , string FixedAsset_Type
                                      , string FixedAsset_Name_Ar  
                                      , string FixedAsset_Name_Eng 
                                      , string FixedAsset_Description  
                                      , decimal FixedAsset_CurrentPrice  
                                      , decimal FixedAsset_PurchasePrice  
                                      , string pur_id  
                                      , string Ref
                                      , byte[] FixedAsset_image
                                      , string ac_id
                                      , string Account_no
                                      , int Depreciation_type_id
                                      , string Depreciation_type
                                      , decimal Depreciation_rate
                                      //Created By & Created Date
                                      , string Created_By
                                      , DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[18];
            para[0] = new SqlParameter("@FixedAsset_id", FixedAsset_id);
            para[1] = new SqlParameter("@FixedAsset_Type", FixedAsset_Type);
            para[2] = new SqlParameter("@FixedAsset_Name_Ar", FixedAsset_Name_Ar);
            para[3] = new SqlParameter("@FixedAsset_Name_Eng", FixedAsset_Name_Eng);
            para[4] = new SqlParameter("@FixedAsset_Description", FixedAsset_Description);
            para[5] = new SqlParameter("@FixedAsset_CurrentPrice", FixedAsset_CurrentPrice);
            para[6] = new SqlParameter("@FixedAsset_PurchasePrice", FixedAsset_PurchasePrice);
            para[7] = new SqlParameter("@pur_id", pur_id);
            para[8] = new SqlParameter("@Ref", Ref);
            para[9] = new SqlParameter("@FixedAsset_image", FixedAsset_image);
            para[10] = new SqlParameter("@ac_id", ac_id);
            para[11] = new SqlParameter("@Account_no", Account_no);
            para[12] = new SqlParameter("@Depreciation_type_id", Depreciation_type_id);
            para[13] = new SqlParameter("@Depreciation_type", Depreciation_type);
            para[14] = new SqlParameter("@Depreciation_rate", Depreciation_rate);
            //Created By & Created Date
            para[15] = new SqlParameter("@Created_By", Created_By);
            para[16] = new SqlParameter("@Created_Date", Created_Date);
            para[17] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_FixedAsset", para);
            dtac.close();
        }

        //التعديل
        public void mng_FixedAsset_Update(
                                        int FixedAsset_id
                                      , string FixedAsset_Type
                                      , string FixedAsset_Name_Ar
                                      , string FixedAsset_Name_Eng
                                      , string FixedAsset_Description
                                      , decimal FixedAsset_CurrentPrice
                                      , decimal FixedAsset_PurchasePrice
                                      , string pur_id
                                      , string Ref
                                      , byte[] FixedAsset_image
                                      , string ac_id
                                      , string Account_no
                                      , int Depreciation_type_id
                                      , string Depreciation_type
                                      , decimal Depreciation_rate
                                      //Created By & Created Date
                                      , string Created_By
                                      , DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[18];
            para[0] = new SqlParameter("@FixedAsset_id", FixedAsset_id);
            para[1] = new SqlParameter("@FixedAsset_Type", FixedAsset_Type);
            para[2] = new SqlParameter("@FixedAsset_Name_Ar", FixedAsset_Name_Ar);
            para[3] = new SqlParameter("@FixedAsset_Name_Eng", FixedAsset_Name_Eng);
            para[4] = new SqlParameter("@FixedAsset_Description", FixedAsset_Description);
            para[5] = new SqlParameter("@FixedAsset_CurrentPrice", FixedAsset_CurrentPrice);
            para[6] = new SqlParameter("@FixedAsset_PurchasePrice", FixedAsset_PurchasePrice);
            para[7] = new SqlParameter("@pur_id", pur_id);
            para[8] = new SqlParameter("@Ref", Ref);
            para[9] = new SqlParameter("@FixedAsset_image", FixedAsset_image);
            para[10] = new SqlParameter("@ac_id", ac_id);
            para[11] = new SqlParameter("@Account_no", Account_no);
            para[12] = new SqlParameter("@Depreciation_type_id", Depreciation_type_id);
            para[13] = new SqlParameter("@Depreciation_type", Depreciation_type);
            para[14] = new SqlParameter("@Depreciation_rate", Depreciation_rate);
            //Created By & Created Date
            para[15] = new SqlParameter("@Created_By", Created_By);
            para[16] = new SqlParameter("@Created_Date", Created_Date);
            para[17] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_FixedAsset", para);
            dtac.close();
        }

        //الحذف
        public void mng_FixedAssetDel(int FixedAsset_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@FixedAsset_id", FixedAsset_id);

            dtac.open();
            dtac.ExcutCommand("mng_FixedAssetDel", para);
            dtac.close();
        }

        public DataTable ShowFixedAsset(int FixedAsset_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@FixedAsset_id", FixedAsset_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowFixedAsset", para);
            dtac.close();
            return dt;
        }
        public DataTable Get_FixedAssetId()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Get_FixedAssetId", null);
            dtac.close();
            return dt;
        }

        public DataTable Show_AllFixedAsset()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Show_AllFixedAsset", null);
            dtac.close();
            return dt;
        }
        //البحث
        public DataTable SearchFixedAsset(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchFixedAsset", para);
            dtac.close();
            return dt;
        }

    }
}
