using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Code
{
    class DB
    {
        Code.DataAccessLayer dtac = new DataAccessLayer();
        public void BackUpDB(string dataname, string path, string backname)
        {
            SqlParameter[] para = new SqlParameter[3];

            para[0] = new SqlParameter("@dataname", dataname);
            para[1] = new SqlParameter("@path", path);
            para[2] = new SqlParameter("@backname", backname);
            dtac.open();
            dtac.ExcutCommand("BackUpDB", para);
            dtac.close();
        }
        public DataTable AllDataBase()
        {
            
            DataTable dt = new DataTable();
            dtac.open();
            dt = dtac.Selectdata("AllDataBase", null);
            dtac.close();
            return dt;
        }
    }
}
