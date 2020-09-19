using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ParcialAdrianaSalmon.Controllers
{
    public class DataContext:DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ParcialAdrianaSalmon.Controllers.Country> Countries { get; set; }
    }
}