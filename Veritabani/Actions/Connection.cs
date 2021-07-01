using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL.Actions
{
    public class Connection
    {
        private static Connection dbInstance;
        static string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=" + Application.StartupPath + "\\School.mdf; Integrated Security = True;";
        private readonly SqlConnection conn = new SqlConnection(connStr);
        private Connection() { }

        public static Connection getDbInstance()
        {
            if (dbInstance == null)
            {
                dbInstance = new Connection();
            }
            return dbInstance;
        }
        public SqlConnection GetDBConnection()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return conn;
        }



    }
}
