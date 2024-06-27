using D00_Utility;
using D02_EF6_CodeFirst.Context;
using D02_EF6_CodeFirst.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_EF6_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            using (var db = new BlogContext())
            {
                // Lado 1
                #region Blog 

                // Create and save a new Blog
                Blog blog = new Blog();

                blog.Name = "Blog 1";

                db.Blogs.Add(blog);

                db.SaveChanges();

                // Display all Blogs from the database

                var query01 = db.Blogs.Select(b => b).OrderBy(b => b.BlogId);

                Utility.WriteTitle("Blogs", "", "\n\n");

                foreach (var item in query01)
                {
                    Utility.WriteMessage($"Blog: {item.BlogId} - {item.Name}", "", "\n");
                }

                #endregion

                #region Post

                // Lado N

                // Create and save a new Post

                // Display all Posts from the database

                #endregion
            }


            Utility.TerminateConsole();
        }
    }
}
