using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PMAWCF
{
    public class PartnerDB : DbContext
    {
        public PartnerDB()
        {
            Database.SetInitializer<PartnerDB>(new PartnerDbInitializer());
        }
        public DbSet<Partner> Partners { get; set; }
    }
}