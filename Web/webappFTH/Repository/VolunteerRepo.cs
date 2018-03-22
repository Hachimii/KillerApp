using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webappFTH.Models;
using webappFTH.Interfaces;
using webappFTH.SqlContext;
using webappFTH.Controllers;

namespace webappFTH.Repository
{
    public class VolunteerRepo : IVolunteerContext
    {
        public void AddVolunteer(Volunteer vv)
        {
            //vv.Name = ;
            //vv.Address = ;
            //vv.Birthdate = ;
            //vv.City = ;
            //vv.Email = ;
            //vv.Experience = ;
            //vv.Username = ;
            //vv.Password = ;
        }

        public void Checkinput()
        {
            throw new NotImplementedException();
        }

        public void Checkpasswoord()
        {
            throw new NotImplementedException();
        }

        public void UpdateVolunteer(Volunteer V)
        {
            throw new NotImplementedException();
        }
    }
}