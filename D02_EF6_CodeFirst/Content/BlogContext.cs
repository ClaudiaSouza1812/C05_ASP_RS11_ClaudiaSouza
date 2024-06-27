using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using D02_EF6_CodeFirst.Class;

namespace D02_EF6_CodeFirst.Content
{
    internal class BlogContext : DbContext
    {
        public BlogContext() : base("BlogEntitiesCS")
        { 
            
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Post> Posts { get; set; }

    }
}
