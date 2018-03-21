using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webappFTH.Controllers;
using webappFTH.Interfaces;
using webappFTH.Repository;
using webappFTH.SqlContext;

namespace webappFTH.Models
{
    public class Project
    {
        public string Name { get;}
        public string Functions { get;}
        public int Minimumspots { get;}
        public string Date { get;}
    }
}