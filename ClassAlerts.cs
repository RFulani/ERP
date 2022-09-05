using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INV.Code
{
    class ClassAlerts
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();

        public DataTable ShowDocs_Dates( DateTime expire_date, DateTime expire_date1)
        {
            SqlParameter[] para = new SqlParameter[2];
            
            para[0] = new SqlParameter("@expire_date", expire_date);
            para[1] = new SqlParameter("@expire_date1", expire_date1);
            DataTable dtemp = new DataTable();
            dtac.open();
            dtemp = dtac.Selectdata("ShowDocs_Dates", para);
            dtac.close();
            return dtemp;
        }

        public DataTable ShowCardType()
        {
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("ShowCardType", null);
            dtac.close();
            return dt;
        }

        internal DataTable ShowDocs_Dates(int emp_id, DataGridViewTextBoxColumn expire_date)
        {
            throw new NotImplementedException();
        }
    }
}
