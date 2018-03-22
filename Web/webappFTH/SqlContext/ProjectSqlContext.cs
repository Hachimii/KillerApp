using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using webappFTH.Interfaces;
using webappFTH.Repository;
using webappFTH.Models;
using webappFTH.Controllers;



namespace webappFTH.SqlContext
{//https://github.com/Hachimii/KillerApp.git github link

    public class ProjectSqlContext: Database, IProjectContext
    {
        private List<Project> Pj = new List<Project>();

        string name;
        string functions;
        int minimumspot;
        string date;

        public ProjectSqlContext()
        {
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public void FilterProjects()
        {
            throw new NotImplementedException();
        }

        public List<Project> Projectnames()
        {
            Pj = new List<Project>();

            

            string query = "SELECT Name from Project";
            SqlCommand cmd = new SqlCommand(query, Connection);

            using (SqlDataReader Reader = cmd.ExecuteReader())

                while (Reader.Read())
                {
                    Project P = new Project();

                }

            return Pj;

        }

     
	}
    }
