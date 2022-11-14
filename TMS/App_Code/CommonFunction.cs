using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using TMS.App_Code;

namespace TMS.App_Code
{
    class CommonFunction 
    {
        public string ConString=null;
        public string ConstringServer=null;
        public SqlConnection Con;
        private SqlDataAdapter adp;
        private SqlDataReader Dreader;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataSet ds;
        public CommonFunction()
        {
            try
            {
                LocalDatabaseCredential();

            }
            catch(Exception ex)
            {
                MessageBox.Show("please check Database Connection!! "+"'"+ex.Message+"'", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }
        //Function to read AppConfig file for Connection String
        public void LocalDatabaseCredential()
        {
            ConString = ConfigurationManager.ConnectionStrings["constr"].ToString();
            Con = new SqlConnection(ConString);
            Con.Open();
            Global.ConnectedServerName = Con.DataSource;
            Global.connecteddatabasename = Con.Database;
            Global.dbname = Global.connecteddatabasename;

        }
        //Check User Existence from UserDetail Table
        public DataTable checkuserexistence(string username, string password)
        {
            if (Con.State == ConnectionState.Closed)
            { Con.Open(); }
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string selectcmd;
            DataSet ds=new DataSet();
            selectcmd = "Select RoleName,Roleid,Isadmin from Userdetails where userid='" + username + "' and password='" + password + "'";
            cmd = new SqlCommand(selectcmd, Con);
            adapter.SelectCommand = cmd;
            adapter.Fill(ds);
            return ds.Tables[0];
        }
        public void CloseConnection()
        {
            Con.Close();
        }
        public void OpenConnection()
        {
            if(Con.State==ConnectionState.Closed)
            { Con.Open(); }
        }
            
        
    }
}
