using E02_EF6_PublishingCompany_v2.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_EF6_PublishingCompany_v2.Context
{
    internal class PublishingCompanyContext : DbContext
    {
        public PublishingCompanyContext() : base("PublishingCompanyCS")
        { 
        
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }

        public virtual DbSet<PublishingCompany> PublishingCompanies { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
    }
}
