using E02_EF6_Library.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_EF6_Library.Context
{
    internal class PublishingCompanyContext : DbContext
    {
        public PublishingCompanyContext() : base("LibraryEntitiesCS")
        { 
        
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }

        public virtual DbSet<PublishingCompany> PublishingCompanies { get; set; }
        public virtual DbSet<Book> Books { get; set; }
    }
}
