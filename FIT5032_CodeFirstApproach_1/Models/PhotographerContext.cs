using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FIT5032_CodeFirstApproach_1.Models
{
    public class PhotographerContext : DbContext
    {
        public PhotographerContext() 
            :base ("CodeFirstDemoDB")
        { }
        public DbSet<Photographer> Photographers { get; set; }
    }
}