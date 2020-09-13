using Microsoft.EntityFrameworkCore;
using Mimir.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimir.Data.Context
{
    public class MirmirContext : DbContext
    {

        public MirmirContext() 
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

           public DbSet<DocumentTag> DocumentTags { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = Mirmir");
            }
        }
    }
}
