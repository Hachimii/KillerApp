using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webappFTH.Controllers;
using webappFTH.Models;
using webappFTH.Repository;

namespace webappFTH.Interfaces
{
    public interface IVolunteerContext
    {
        void AddVolunteer(Volunteer V);
        void UpdateVolunteer(Volunteer V);
    }
}
