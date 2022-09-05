using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace INV.Code
{
    class Customer
    {
        Code.DataAccessLayer dal = new Code.DataAccessLayer();
        public void addcus(
            int cus_id,
            string cus_name,
            string mobil,
            string email,
            string adres,
            string cus_comp,
            int sal_id,
            int cus_credit,
            string start_dat,
            string delev_sata,
            string act_prosh,
            string cus_pass,
            string branch_name,
            string Account_no,
            decimal TIN ,
            int Building_No ,
            string Unit_No,
            string Street_Name,
            string Neighborhood,
            string City,
            int Postal_Box,
            int Postal_Code,
            int Postal_Code_Add,
            int CSType,
            string comp_Eng,
            decimal cus_credit_amount,
             //Created By & Created Date
            string Created_By,
             DateTime Created_Date,
             //int CusorSup,
             int CusorSup_No,
            string ac_id,
            string Code_Cat_Id
           )
        {
            SqlParameter[] para = new SqlParameter[32];
            para[0] = new SqlParameter("@check", SqlDbType.Char, 1);
            para[0].Value = "a";
            para[1] = new SqlParameter("@cus_name", SqlDbType.NVarChar, 50);
            para[1].Value = cus_name;
            para[2] = new SqlParameter("@cus_mobile", SqlDbType.Char, 15);
            para[2].Value = mobil;
            para[3] = new SqlParameter("@cus_email", SqlDbType.NVarChar, 50);
            para[3].Value = email;
            para[4] = new SqlParameter("@cus_adress", SqlDbType.NVarChar, 100);
            para[4].Value = adres;
            para[5] = new SqlParameter("@cus_id", SqlDbType.Int);
            para[5].Value = cus_id;
            para[6] = new SqlParameter("@cus_comp", SqlDbType.NVarChar, 200);
            para[6].Value = cus_comp;
            para[7] = new SqlParameter("@sal_id", sal_id);
            para[8] = new SqlParameter("@cus_credit", cus_credit);
            para[9] = new SqlParameter("@start_dat", start_dat);
            para[10] = new SqlParameter("@delev_sata", delev_sata);
            para[11] = new SqlParameter("@act_prosh", act_prosh);
            para[12] = new SqlParameter("@cus_pass", cus_pass);
            para[13] = new SqlParameter("@branch_name", branch_name);
            para[14] = new SqlParameter("@Account_no", Account_no);
            para[15] = new SqlParameter("@TIN", TIN);
            para[16] = new SqlParameter("@Building_No", Building_No);
            para[17] = new SqlParameter("@Unit_No", Unit_No);
            para[18] = new SqlParameter("@Street_Name", Street_Name);
            para[19] = new SqlParameter("@Neighborhood", Neighborhood);
            para[20] = new SqlParameter("@City", City);
            para[21] = new SqlParameter("@Postal_Box", Postal_Box);
            para[22] = new SqlParameter("@Postal_Code", Postal_Code);
            para[23] = new SqlParameter("@Postal_Code_Add", Postal_Code_Add);
            para[24] = new SqlParameter("@CSType", CSType);
            para[25] = new SqlParameter("@comp_Eng", comp_Eng);
            para[26] = new SqlParameter("@cus_credit_amount", cus_credit_amount);
            //Created By & Created Date
            para[27] = new SqlParameter("@Created_By", Created_By);
            para[28] = new SqlParameter("@Created_Date", Created_Date);
            //para[29] = new SqlParameter("@CusorSup", CusorSup);
            para[29] = new SqlParameter("@CusorSup_No", CusorSup_No);
            para[30] = new SqlParameter("@ac_id", ac_id);
            para[31] = new SqlParameter("@Code_Cat_Id", Code_Cat_Id);
          
            dal.open();
            dal.ExcutCommand("addcus", para);
            dal.close();
        }
        public void updatecus(
            string cus_name,
            string mobil,
            string email,
            string adres,
            string cus_id,
            string cus_comp,
            int sal_id,
            int cus_credit,
            string start_dat,
            string delev_sata ,
            string act_prosh,
            string cus_pass,
            string branch_name,
            string Account_no,
            decimal TIN,
            int Building_No,
            string Unit_No,
            string Street_Name,
            string Neighborhood,
            string City,
            int Postal_Box,
            int Postal_Code,
            int Postal_Code_Add,
            int CSType,
            string comp_Eng,
            decimal cus_credit_amount,
            //Created By & Created Date
            string Created_By,
             DateTime Created_Date,
             //int CusorSup,
             int CusorSup_No,
             string ac_id,
             string Code_Cat_Id
            )
        {
            SqlParameter[] para = new SqlParameter[32];
            para[0] = new SqlParameter("@check", SqlDbType.Char, 1);
            para[0].Value = "u";
            para[1] = new SqlParameter("@cus_name", SqlDbType.NVarChar, 50);
            para[1].Value = cus_name;
            para[2] = new SqlParameter("@cus_mobile", SqlDbType.Char, 15);
            para[2].Value = mobil;
            para[3] = new SqlParameter("@cus_email", SqlDbType.NVarChar, 50);
            para[3].Value = email;
            para[4] = new SqlParameter("@cus_adress", SqlDbType.NVarChar, 100);
            para[4].Value = adres;
            para[5] = new SqlParameter("@cus_id", SqlDbType.Int);
            para[5].Value = cus_id;
            para[6] = new SqlParameter("@cus_comp", SqlDbType.NVarChar, 200);
            para[6].Value = cus_comp;
            para[7] = new SqlParameter("@sal_id", sal_id);
            para[8] = new SqlParameter("@cus_credit", cus_credit);
            para[9] = new SqlParameter("@start_dat", start_dat);
            para[10] = new SqlParameter("@delev_sata", delev_sata);
            para[11] = new SqlParameter("@act_prosh", act_prosh);
            para[12] = new SqlParameter("@cus_pass", cus_pass);
            para[13] = new SqlParameter("@branch_name", branch_name);
            para[14] = new SqlParameter("@Account_no", Account_no);
            para[15] = new SqlParameter("@TIN", TIN);
            para[16] = new SqlParameter("@Building_No", Building_No);
            para[17] = new SqlParameter("@Unit_No", Unit_No);
            para[18] = new SqlParameter("@Street_Name", Street_Name);
            para[19] = new SqlParameter("@Neighborhood", Neighborhood);
            para[20] = new SqlParameter("@City", City);
            para[21] = new SqlParameter("@Postal_Box", Postal_Box);
            para[22] = new SqlParameter("@Postal_Code", Postal_Code);
            para[23] = new SqlParameter("@Postal_Code_Add", Postal_Code_Add);
            para[24] = new SqlParameter("@CSType", CSType);
            para[25] = new SqlParameter("@comp_Eng", comp_Eng);
            para[26] = new SqlParameter("@cus_credit_amount", cus_credit_amount);
            //Created By & Created Date
            para[27] = new SqlParameter("@Created_By", Created_By);
            para[28] = new SqlParameter("@Created_Date", Created_Date);
            //para[29] = new SqlParameter("@CusorSup", CusorSup);
            para[29] = new SqlParameter("@CusorSup_No", CusorSup_No);
            para[30] = new SqlParameter("@ac_id", ac_id);
            para[31] = new SqlParameter("@Code_Cat_Id", Code_Cat_Id);
           

            dal.open();
            dal.ExcutCommand("addcus", para);
            dal.close();
        }

        public void cus_statBysal(int sal_id , string cus_stat)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@sal_id",sal_id );
            para[1] = new SqlParameter("@cus_stat",cus_stat);
            dal.open();
            dal.ExcutCommand("cus_statBysal", para);
            dal.close();
        }
        public void updatelinedate(int sal_id, string start_dat,string delev_sata)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@sal_id", sal_id);
            para[1] = new SqlParameter("@start_dat", start_dat);
            para[2] = new SqlParameter("@delev_sata", delev_sata);
            dal.open();
            dal.ExcutCommand("updatelinedate", para);
            dal.close();
        }
        public void cus_statBycus(int cus_id, string cus_stat)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@cus_id", cus_id);
            para[1] = new SqlParameter("@cus_stat", cus_stat);
            dal.open();
            dal.ExcutCommand("cus_statBycus", para);
            dal.close();
        }
        public void DelCus(int cus_id)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@check", SqlDbType.Char, 1);
            para[0].Value = "d";
            para[1] = new SqlParameter("@cus_id", SqlDbType.Int);
            para[1].Value = cus_id;
           
              dal.open();
                dal.ExcutCommand("addcus", para);
                dal.close();
               
           
        }

        public DataTable checkcus_inv(int cus_id)
        {
            SqlParameter[] para = new SqlParameter[1];
          
            para[0] = new SqlParameter("@cus_id", SqlDbType.Int);
            para[0].Value = cus_id;

            dal.open();
            DataTable dt = new DataTable();
          dt =  dal.Selectdata("checkcus_inv", para);
            dal.close();
            return dt;
        

        }

        public DataTable check_cus_id(string Account_no)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@Account_no", Account_no);
            

            dal.open();
            DataTable dt = new DataTable();
            dt = dal.Selectdata("check_id_cus", para);
            dal.close();
            return dt;


        }
        public DataTable all_cus_bysalman(int sal_man,double val)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@sal_man", sal_man);
            para[1] = new SqlParameter("@val", val);


            dal.open();
            DataTable dt = new DataTable();
            dt = dal.Selectdata("all_cus_bysalman", para);
            dal.close();
            return dt;


        }
        public DataTable ShowCus_bysal(int sal_id)
        {
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@sal_id", sal_id);
           
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.Selectdata("ShowCus_bysal", para);
            dal.close();
            return dt;


        }
        public DataTable cus_id()
        {

            DataTable dt = new DataTable();
            dal.open();
            dt = dal.Selectdata("cus_id", null);
            dal.close();
            return dt;
        }
        public DataTable all_cus(double val)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@val", val);

            DataTable dt = new DataTable();
            dal.open();
            dt = dal.Selectdata("all_cus", para);
            dal.close();
            return dt;
        }


        public DataTable ShowCus(int  cus_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@cus_id", cus_id);

            DataTable dt = new DataTable();
            dt = dal.Selectdata("show_cus", para);
            return dt;
        }
        public DataTable ShowCus_byname(string vrb_serch/*, int CSType*/)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@vrb_serch", vrb_serch);
            //para[1] = new SqlParameter("@CSType", CSType);


            DataTable dt = new DataTable();
            dal.open();
            dt = dal.Selectdata("ShowCus_byname", para);
            dal.close();
            return dt;
        }
        public DataTable ShowCus_byname_1(string vrb_serch, int CSType)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@vrb_serch", vrb_serch);
            para[1] = new SqlParameter("@CSType", CSType);


            DataTable dt = new DataTable();
            dal.open();
            dt = dal.Selectdata("ShowCus_byname_1", para);
            dal.close();
            return dt;
        }


        public DataTable CS_id(int CSType/*CusorSup*/)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@CSType", CSType/*CusorSup*/);

            DataTable dt = new DataTable();
            dal.open();
            dt = dal.Selectdata("CS_id", para);
            dal.close();
            return dt;
        }
    }
}
