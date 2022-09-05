using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    class emp1
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void mng_Emp_add(
    int emp_id,
    string emp_cardid,
	string emp_cardtype ,
    int emp_cardtype_id,
    string emp_namear,
	string emp_nameenglish,
	string emp_Nationality,
	string emp_gendertype,
	string emp_religion ,
	DateTime emp_dob,
	string emp_maritalstatus ,
	int emp_noofdepended ,
    string Qualification ,
	string education_detailsen,
	int education_typeid ,
    string education_detailsar ,
	DateTime year_graduationfinish ,
	string gosi_no,
	string ministry_no ,
	string border_no,
	string emp_positionname,
	
    string branch_name,
	int branch_id ,
    string depart_name,
	int depart_id,
    string visa_no,
	string contract_type,
	int contractype_id,
    DateTime start_contract,
    DateTime end_contract,
    DateTime start_work,
    string mobile_nosp,
	string mobile_work,
	string email_idsp,
	string email_idwork,
	string full_address,
    byte [] Emp_image,
    string emp_status,
    int emp_status_id,
            int Vac_Hours,
            int Vac_Days,
            int emp_id_Manager,
            string emp_namear_Manager,
            int User_Allowed,
            int User_Level_Id,
            string User_Level,
            string Password,
            int Building_No,
            string Unit_No,
            string Street_Name,
            string Neighborhood,
            string City,
            int Postal_Box,
            int Postal_Code,
           
            //Created By & Created Date
              string Created_By,
             DateTime Created_Date


                               )
        {
            SqlParameter[] para = new SqlParameter[57];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@emp_cardid", emp_cardid);
            para[2] = new SqlParameter("@emp_cardtype", emp_cardtype);
            para[3] = new SqlParameter("@emp_cardtype_id", emp_cardtype_id);
            para[4] = new SqlParameter("@emp_namear", emp_namear);
            para[5] = new SqlParameter("@emp_nameenglish", emp_nameenglish);
            para[6] = new SqlParameter("@emp_Nationality", emp_Nationality);
            para[7] = new SqlParameter("@emp_gendertype", emp_gendertype);
            para[8] = new SqlParameter("@emp_religion", emp_religion);
            para[9] = new SqlParameter("@emp_dob", emp_dob);
            para[10] = new SqlParameter("@emp_maritalstatus", emp_maritalstatus);
            para[11] = new SqlParameter("@emp_noofdepended", emp_noofdepended);
            para[12] = new SqlParameter("Qualification", Qualification);
            para[13] = new SqlParameter("@education_detailsen", education_detailsen);
            para[14] = new SqlParameter("@education_typeid", education_typeid);
            para[15] = new SqlParameter("@education_detailsar", education_detailsar);
            para[16] = new SqlParameter("@year_graduationfinish", year_graduationfinish);
            para[17] = new SqlParameter("@gosi_no", gosi_no);
            para[18] = new SqlParameter("@ministry_no", ministry_no);
            para[19] = new SqlParameter("@border_no", border_no);
            para[20] = new SqlParameter("@emp_positionname", emp_positionname);
            para[21] = new SqlParameter("@branch_name", branch_name);
            para[22] = new SqlParameter("@branch_id", branch_id);
            para[23] = new SqlParameter("@depart_name", depart_name);
            para[24] = new SqlParameter("@depart_id", depart_id);
            para[25] = new SqlParameter("@visa_no", visa_no);
            para[26] = new SqlParameter("@contract_type", contract_type);
            para[27] = new SqlParameter("@contractype_id", contractype_id);
            para[28] = new SqlParameter("@start_contract", start_contract);
            para[29] = new SqlParameter("@end_contract", end_contract);
            para[30] = new SqlParameter("@start_work", start_work);
            para[31] = new SqlParameter("@mobile_nosp", mobile_nosp);
            para[32] = new SqlParameter("@mobile_work", mobile_work);
            para[33] = new SqlParameter("@email_idsp", email_idsp);
            para[34] = new SqlParameter("@email_idwork", email_idwork);
            para[35] = new SqlParameter("@full_address", full_address);
            para[36] = new SqlParameter("@Emp_image", Emp_image);
            para[37] = new SqlParameter("@emp_status", emp_status);
            para[38] = new SqlParameter("@emp_status_id", emp_status_id);
            para[39] = new SqlParameter("@Vac_Hours", Vac_Hours);
            para[40] = new SqlParameter("@Vac_Days", Vac_Days);
            para[41] = new SqlParameter("@emp_id_Manager", emp_id_Manager);
            para[42] = new SqlParameter("@emp_namear_Manager", emp_namear_Manager);
            para[43] = new SqlParameter("@User_Allowed", User_Allowed);
            para[44] = new SqlParameter("@User_Level_Id", User_Level_Id);
            para[45] = new SqlParameter("@User_Level", User_Level);
            para[46] = new SqlParameter("@Password", Password);
            para[47] = new SqlParameter("@Building_No", Building_No);
            para[48] = new SqlParameter("@Unit_No", Unit_No);
            para[49] = new SqlParameter("@Street_Name", Street_Name);
            para[50] = new SqlParameter("@Neighborhood", Neighborhood);
            para[51] = new SqlParameter("@City", City);
            para[52] = new SqlParameter("@Postal_Box", Postal_Box);
            para[53] = new SqlParameter("@Postal_Code", Postal_Code);
           

            //Created By & Created Date
            para[54] = new SqlParameter("@Created_By", Created_By);
            para[55] = new SqlParameter("@Created_Date", Created_Date);

            para[56] = new SqlParameter("@check", "a");


            dtac.open();
            dtac.ExcutCommand("mng_emp", para);
            dtac.close();
        }

        public void mng_Emp_Update(
  int emp_id,
    string emp_cardid,
    string emp_cardtype,
    int emp_cardtype_id,
    string emp_namear,
    string emp_nameenglish,
    string emp_Nationality,
    string emp_gendertype,
    string emp_religion,
    DateTime emp_dob,
    string emp_maritalstatus,
    int emp_noofdepended,
    string Qualification,
    string education_detailsen,
    int education_typeid,
    string education_detailsar,
    DateTime year_graduationfinish,
    string gosi_no,
    string ministry_no,
    string border_no,
    string emp_positionname,
    string branch_name,
    int branch_id,
    string depart_name,
    int depart_id,
    string visa_no,
    string contract_type,
    int contractype_id,
    DateTime start_contract,
    DateTime end_contract,
    DateTime start_work,
    string mobile_nosp,
    string mobile_work,
    string email_idsp,
    string email_idwork,
    string full_address,
    byte[] Emp_image,
    string emp_status,
    int emp_status_id,
            int Vac_Hours,
            int Vac_Days,
            int emp_id_Manager,
            string emp_namear_Manager,
            int User_Allowed,
            int User_Level_Id,
            string User_Level,
             string Password,
                         int Building_No,
            string Unit_No,
            string Street_Name,
            string Neighborhood,
            string City,
            int Postal_Box,
            int Postal_Code,
            

                               //Created By & Created Date
                                string Created_By,
                                DateTime Created_Date,
     int oldEmp_id

                               )
        {
            SqlParameter[] para = new SqlParameter[58];
            para[0] = new SqlParameter("@emp_id", emp_id);
            para[1] = new SqlParameter("@emp_cardid", emp_cardid);
            para[2] = new SqlParameter("@emp_cardtype", emp_cardtype);
            para[3] = new SqlParameter("@emp_cardtype_id", emp_cardtype_id);
            para[4] = new SqlParameter("@emp_namear", emp_namear);
            para[5] = new SqlParameter("@emp_nameenglish", emp_nameenglish);
            para[6] = new SqlParameter("@emp_Nationality", emp_Nationality);
            para[7] = new SqlParameter("@emp_gendertype", emp_gendertype);
            para[8] = new SqlParameter("@emp_religion", emp_religion);
            para[9] = new SqlParameter("@emp_dob", emp_dob);
            para[10] = new SqlParameter("@emp_maritalstatus", emp_maritalstatus);
            para[11] = new SqlParameter("@emp_noofdepended", emp_noofdepended);
            para[12] = new SqlParameter("Qualification", Qualification);
            para[13] = new SqlParameter("@education_detailsen", education_detailsen);
            para[14] = new SqlParameter("@education_typeid", education_typeid);
            para[15] = new SqlParameter("@education_detailsar", education_detailsar);
            para[16] = new SqlParameter("@year_graduationfinish", year_graduationfinish);
            para[17] = new SqlParameter("@gosi_no", gosi_no);
            para[18] = new SqlParameter("@ministry_no", ministry_no);
            para[19] = new SqlParameter("@border_no", border_no);
            para[20] = new SqlParameter("@emp_positionname", emp_positionname);
            para[21] = new SqlParameter("@branch_name", branch_name);
            para[22] = new SqlParameter("@branch_id", branch_id);
            para[23] = new SqlParameter("@depart_name", depart_name);
            para[24] = new SqlParameter("@depart_id", depart_id);
            para[25] = new SqlParameter("@visa_no", visa_no);
            para[26] = new SqlParameter("@contract_type", contract_type);
            para[27] = new SqlParameter("@contractype_id", contractype_id);
            para[28] = new SqlParameter("@start_contract", start_contract);
            para[29] = new SqlParameter("@end_contract", end_contract);
            para[30] = new SqlParameter("@start_work", start_work);
            para[31] = new SqlParameter("@mobile_nosp", mobile_nosp);
            para[32] = new SqlParameter("@mobile_work", mobile_work);
            para[33] = new SqlParameter("@email_idsp", email_idsp);
            para[34] = new SqlParameter("@email_idwork", email_idwork);
            para[35] = new SqlParameter("@full_address", full_address);
            para[36] = new SqlParameter("@Emp_image", Emp_image);
            para[37] = new SqlParameter("@emp_status", emp_status);
            para[38] = new SqlParameter("@emp_status_id", emp_status_id);
            para[39] = new SqlParameter("@Vac_Hours", Vac_Hours);
            para[40] = new SqlParameter("@Vac_Days", Vac_Days);
            para[41] = new SqlParameter("@emp_id_Manager", emp_id_Manager);
            para[42] = new SqlParameter("@emp_namear_Manager", emp_namear_Manager);
            para[43] = new SqlParameter("@User_Allowed", User_Allowed);
            para[44] = new SqlParameter("@User_Level_Id", User_Level_Id);
            para[45] = new SqlParameter("@User_Level", User_Level);
            para[46] = new SqlParameter("@Password", Password);
            para[47] = new SqlParameter("@Building_No", Building_No);
            para[48] = new SqlParameter("@Unit_No", Unit_No);
            para[49] = new SqlParameter("@Street_Name", Street_Name);
            para[50] = new SqlParameter("@Neighborhood", Neighborhood);
            para[51] = new SqlParameter("@City", City);
            para[52] = new SqlParameter("@Postal_Box", Postal_Box);
            para[53] = new SqlParameter("@Postal_Code", Postal_Code);
            

            //Created By & Created Date
            para[54] = new SqlParameter("@Created_By", Created_By);
            para[55] = new SqlParameter("@Created_Date", Created_Date);
            para[56] = new SqlParameter("@check", "u");
            para[57] = new SqlParameter("@oldEmp_id", oldEmp_id);


            dtac.open();
            dtac.ExcutCommand("mng_emp", para);
            dtac.close();
        }



        public void mng_Emp_Del(int emp_id)
    
                            
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
           
            dtac.open();
            dtac.ExcutCommand("mng_empDel", para);
            dtac.close();
        }

        public DataTable Get_EmpId()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("emp_id", null);
            dtac.close();
            return dt;
        }

        public DataTable CheckEmp_ById(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("CheckEmp_ById", para);
            dtac.close();
            return dt;
        }
        //بواسطه رقم الهوية
        public DataTable CheckEmp_ByCardId(string emp_cardid)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_cardid", emp_cardid);
            //para[1] = new SqlParameter("@emp_id", emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("CheckEmp_ByCardId", para);
            dtac.close();
            return dt;
        }
        public DataTable GetEmpForEVL(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetEmpForEVL", para);
            dtac.close();
            return dt;
        }

        public DataTable SearchEmp(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchEmp", para);
            dtac.close();
            return dt;
        }

        public DataTable GetEmpForEVR(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetEmpForEVR", para);
            dtac.close();
            return dt;
        }
        public DataTable ShowAllVacByEmpId(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowAllVacByEmpId", para);
            dtac.close();
            return dt;
        }
        public DataTable GetEmpForSett(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetEmpForSett", para);
            dtac.close();
            return dt;
        }
        public DataTable GetEmpForIcreasing(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("GetEmpForIcreasing", para);
            dtac.close();
            return dt;
        }
        public DataTable CheckEmpStatus(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
          
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("CheckEmpStatus", para);
            dtac.close();
            return dt;
        }


        public DataTable ShowEmpForPrint(int emp_id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@emp_id", emp_id);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowEmpForPrint", para);
            dtac.close();
            return dt;
        }
    }
}
