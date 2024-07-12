namespace E02_EF6_PublishingCompany_v2.Migrations
{
    using E02_EF6_PublishingCompany_v2.Class;
    using E02_EF6_PublishingCompany_v2.Context;
    using System.Data.Entity.Migrations;

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

                Book book = new Book();

                book.CreateBook(book, publishingCompany, genre, db);

                book.ShowBook(db);

                #endregion

            }

        }
    }
}
