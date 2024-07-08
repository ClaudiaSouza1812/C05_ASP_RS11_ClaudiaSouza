namespace E02_EF6_PublishingCompany.Migrations
{
    using D00_Utility;
    using E02_EF6_PublishingCompany.Class;
    using E02_EF6_PublishingCompany.Context;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PublishingCompanyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PublishingCompanyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            Utility.SetUnicodeConsole();

            using (var db = new PublishingCompanyContext())
            {

                #region PublishingCompany

                PublishingCompany publishingCompany = new PublishingCompany();

                publishingCompany.CreatePublishingCompany(publishingCompany, db);

                publishingCompany.ShowPublishingCompany(db);

                #endregion

                #region Genre
                
                Genre genre = new Genre();

                genre.CreateGenre(genre, db);

                genre.ShowGenre(db);
                
                #endregion

                #region Book
                /*
                Book book = new Book();
                book.BookId = 1;
                book.PublishingCompanyId = 1;
                book.GenreId = 1;
                book.Title = "Livro 1";
                book.ISBN = "123456";

                db.Books.Add(book);
                db.SaveChanges();
                */
                var query02 = db.Books.Select(b => b).OrderBy(b => b.BookId);

                foreach (var item in query02)
                {
                    Utility.WriteMessage($"Book: {item.BookId} - {item.Title} - {item.ISBN} - {item.PublishingCompany.PublishingCompanyName} - {item.Genre.GenreName}", "", "\n");
                }

                #endregion



            }

            Utility.TerminateConsole();

        }
    }
}
