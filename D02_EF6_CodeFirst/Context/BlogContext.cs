using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using D02_EF6_CodeFirst.Class;

namespace D02_EF6_CodeFirst.Context
{
    internal class BlogContext : DbContext
    {
        // On the constructor, we specify the connection string name in app.config
        public BlogContext() : base("BlogEntitiesCS")
        { 
            
        }

        // Method executed when the model is created
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // deactivate the pluralization of table names
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Post> Posts { get; set; }

    }
}
