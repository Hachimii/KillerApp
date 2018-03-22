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
            
            string connectionString = "Server=mssql.fhict.local;Database=dbi383927;User Id=dbi383927;Password=YourChoosenPassword";

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
            catch (SqlException)
            {

                return false;
            }
        }

    }
}

