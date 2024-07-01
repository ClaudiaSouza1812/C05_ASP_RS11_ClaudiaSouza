using D00_Utility;
using D02_EF6_CodeFirst.Context;
using D02_EF6_CodeFirst.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// When the database doesn't exist, use the Code First approach
// Using the Code First approach, the database is created based on the classes
namespace D02_EF6_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            // Declare and instantiate a new BlogContext object, which is a subclass of DbContext
            using (var db = new BlogContext())
            {
                // Side '1' of the relationship
                #region Blog 
                
                // Create and save a new Blog
                Blog blog = new Blog();

                blog.Name = "Blog 1";

                db.Blogs.Add(blog);
                db.SaveChanges();

                // Select all Blogs from the database
                var query01 = db.Blogs.Select(b => b).OrderBy(b => b.BlogId);

                // Display all Blogs from the database
                Utility.WriteTitle("Blogs", "", "\n\n");

                foreach (var item in query01)
                {
                    Utility.WriteMessage($"Blog: {item.BlogId} - {item.Name}", "", "\n");
                }
                
                #endregion

                // Side 'N' of the relationship
                #region Post

                // Create and save two new Posts

                Post post01 = new Post();
                post01.BlogId = 1;
                post01.Title = "Post 00001";
                post01.Content = "Content 00001";
                post01.Date = DateTime.Now;

                Post post02 = new Post();
                post02.BlogId = 1;
                post02.Title = "Post 00002";
                post02.Content = "Content 00002";
                post02.Date = DateTime.Now;

                db.Posts.Add(post01);
                db.Posts.Add(post02);
                db.SaveChanges();

                
                // Select all Posts from the database
                var query02 = db.Posts.Select(p => p).OrderBy(p => p.PostId);

                // Display all Posts from the database
                foreach (var post in query02)
                {
                    Utility.WriteMessage($"Post: {post.PostId} - {post.BlogId} - {post.Title} - {post.Content} - {post.Date}", "", "\n");
                }

                

                #endregion
            }


            Utility.TerminateConsole();
        }
    }
}
