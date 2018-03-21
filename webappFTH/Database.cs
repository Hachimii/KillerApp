using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace webappFTH
{
    public class Database

    {
        public SqlConnection Connection;
        public string UserID;
        public string Password;
        public string DB;
        public string Server;

        public bool Openconnection()
        {
            Server = "mssql.fhict.local";
            DB = "dbi383927";
            UserID = "dbi383927";
            Password = "Huiswerk1-";
            string connectionString;
            connectionString = "Server =" + Server + ";" + "Database =" + DB + ";" + "User Id =" + UserID + ";" + "Password =" + Password + ";";

            Connection = new SqlConnection(connectionString);

            try
            {
                Connection.Open();
                return true;

            }
            catch (SqlException )
            {
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (SqlException )
            {

                return false;
            }
        }

    }
}

