using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webappFTH.Models;
using webappFTH.Interfaces;
using webappFTH.Controllers;
using webappFTH.Repository;
using System.Data.SqlClient;


namespace webappFTH.SqlContext
{
    public class VolunteerSqlContext
    {

        Database db = new Database();
        
        public void AddVolunteer(Volunteer vv)
        {
            db.Openconnection();
            string query = "INSERT INTO Volunteer" + "(Name," + "Address," + "Birthdate," + "Experience," + "Phonenumber," + "Email," + "Username," + "Password," + "City)" + "VALUES" + "(@Name," + "@Address," + "@Birthdate," + "@Experience," + "@Phonenumber," + "@Email," + "@Username," + "@Password," + "@City)";
            SqlCommand Cmd = new SqlCommand(query);
            Cmd.Parameters.AddWithValue("@Name", vv.Name);
            Cmd.Parameters.AddWithValue("@Address", vv.Address);
            Cmd.Parameters.AddWithValue("@Birthdate", vv.Birthdate);
            Cmd.Parameters.AddWithValue("@Experience", vv.Experience);
            Cmd.Parameters.AddWithValue("@Phonenumber", vv.Phonenumber);
            Cmd.Parameters.AddWithValue("@Email", vv.Email);
            Cmd.Parameters.AddWithValue("@Username", vv.Username);
            Cmd.Parameters.AddWithValue("@Password", vv.Password);
            Cmd.Parameters.AddWithValue("@City", vv.City);

            Cmd.ExecuteScalar();

        }

   
        
    }
}