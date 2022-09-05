using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace INV.Code
{
    class ClassCars
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        //الأضافة
        public void mng_cars_add(
            int car_No,
            string OwnerName,
            string registration_plate_No,
            string make,
            string type,
            int year,
            string color,
            string VIN,
            string note,
            byte[] image1,
            byte[] image2,
            byte[] image3,
            byte[] image4,
            string serial_number,
            decimal CarValue,
            int CarSpeedometer,
            string InsuranceNo,
            //Created By & Created Date
            string Created_By,
            DateTime Created_Date
            )
        {
            SqlParameter[] para = new SqlParameter[20];
            para[0] = new SqlParameter("@car_No", car_No);
            para[1] = new SqlParameter("@OwnerName", OwnerName);
            para[2] = new SqlParameter("@registration_plate_No", registration_plate_No);
            para[3] = new SqlParameter("@make", make);
            para[4] = new SqlParameter("@type", type);
            para[5] = new SqlParameter("@year", year);
            para[6] = new SqlParameter("@color", color);
            para[7] = new SqlParameter("@VIN", VIN);
            para[8] = new SqlParameter("@note", note);
            para[9] = new SqlParameter("@image1", image1);
            para[10] = new SqlParameter("@image2", image2);
            para[11] = new SqlParameter("@image3", image3);
            para[12] = new SqlParameter("@image4", image4);
            para[13] = new SqlParameter("@serial_number", serial_number);
            para[14] = new SqlParameter("@CarValue", CarValue);
            para[15] = new SqlParameter("@CarSpeedometer", CarSpeedometer);
            para[16] = new SqlParameter("@InsuranceNo", InsuranceNo);
            //Created By & Created Date
            para[17] = new SqlParameter("@Created_By", Created_By);
            para[18] = new SqlParameter("@Created_Date", Created_Date);
            para[19] = new SqlParameter("@check", "a");



            dtac.open();
            dtac.ExcutCommand("mng_cars", para);
            dtac.close();
        }

        //التعديل
        public void mng_cars_Update(
           int car_No,
             string OwnerName,
          string registration_plate_No,
         string make,
          string type,
          int year,
          string color,
          string VIN,
          string note,
          byte[] image1,
          byte[] image2,
          byte[] image3,
          byte[] image4,
          string serial_number,
          decimal CarValue,
          int CarSpeedometer,
           string InsuranceNo,
          //Created By & Created Date
           string Created_By,
           DateTime Created_Date

           )
        {
            SqlParameter[] para = new SqlParameter[20];
            para[0] = new SqlParameter("@car_No", car_No);
            para[1] = new SqlParameter("@OwnerName", OwnerName);
            para[2] = new SqlParameter("@registration_plate_No", registration_plate_No);
            para[3] = new SqlParameter("@make", make);
            para[4] = new SqlParameter("@type", type);
            para[5] = new SqlParameter("@year", year);
            para[6] = new SqlParameter("@color", color);
            para[7] = new SqlParameter("@VIN", VIN);
            para[8] = new SqlParameter("@note", note);
            para[9] = new SqlParameter("@image1", image1);
            para[10] = new SqlParameter("@image2", image2);
            para[11] = new SqlParameter("@image3", image3);
            para[12] = new SqlParameter("@image4", image4);
            para[13] = new SqlParameter("@serial_number", serial_number);
            para[14] = new SqlParameter("@CarValue", CarValue);
            para[15] = new SqlParameter("@CarSpeedometer", CarSpeedometer);
            para[16] = new SqlParameter("@InsuranceNo", InsuranceNo);
            //Created By & Created Date
            para[17] = new SqlParameter("@Created_By", Created_By);
            para[18] = new SqlParameter("@Created_Date", Created_Date);
            para[19] = new SqlParameter("@check", "u");



            dtac.open();
            dtac.ExcutCommand("mng_cars", para);
            dtac.close();
        }



        //الحذف
        public void mng_cars_Del(int car_No)


        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@car_No", car_No);

            dtac.open();
            dtac.ExcutCommand("mng_carsDel", para);
            dtac.close();
        }


        public DataTable ShowCars(int car_No)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@car_No", car_No);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowCars", para);
            dtac.close();
            return dt;
        }

        public DataTable SearchCars(string search)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@search", search);
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("SearchCars", para);
            dtac.close();
            return dt;
        }

        public DataTable Get_CarId()
        {

            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("Cars_id", null);
            dtac.close();
            return dt;
        }
    }


 
}
