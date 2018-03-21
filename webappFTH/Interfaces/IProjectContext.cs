using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webappFTH.Controllers;
using webappFTH.Models;
using webappFTH.SqlContext;

namespace webappFTH.Interfaces
{
    public interface IProjectContext
    {
        List<Project> Projectnames();

        void FilterProjects();

        void delete();
       


    }
}
