using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E02_EF6_PublishingCompany.Interfaces;
using E02_EF6_PublishingCompany.Context;
using D00_Utility;
using System.Data.Common;

namespace E02_EF6_PublishingCompany.Class
{
    internal class Book : IBookRepository
    {
        #region Scalar Properties

        public int BookId { get; set; }
        public int PublishingCompanyId { get; set; }
        public int GenreId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(100, ErrorMessage = "Limite de 100 caracteres")]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(13, ErrorMessage = "Limite de 13 caracteres.")]
        public string ISBN { get; set; }

        #endregion

        #region Navigation Properties
        // Relationship: Book 1 - 1 PublishingCompany
        // Relationship: Book 1 - 1 Genre
        public virtual PublishingCompany PublishingCompany { get; set; }
        public virtual Genre Genre { get; set; }

        #endregion

        #region Methods and Functions

        public void CreateBook(Book book, PublishingCompany publishingCompany, Genre genre, PublishingCompanyContext db)
        {
            #region Publishing Company

            int publishingCompanyId = AddPublishingCompany(publishingCompany, db);

            if (publishingCompanyId == 0)
            {
                return;
            }

            book.PublishingCompanyId = publishingCompanyId;

            #endregion

            #region Genre

            int genreId = AddGenre(genre, db);

            if (genreId == 0)
            {
                return;
            }

            book.GenreId = genreId;

            #endregion

            #region Title

            string title = AddTitle();

            if (title == null)
            {
                return;
            }

            book.Title = title;

            #endregion

            #region ISBN

            string isbn = AddIsbn();

            if (isbn == null)
            {
                return;
            }

            book.ISBN = isbn;

            #endregion

            #region Add to Database

            db.Books.Add(book);

            db.SaveChanges();

            #endregion

        }

        public int AddPublishingCompany(PublishingCompany publishingCompany, PublishingCompanyContext db)
        {
            do
            {
                Console.Clear();
                Utility.WriteTitle("Create Book", "", "\n\n");
                Utility.WriteMessage("Publishing Companies ids: ", "", "\n");

                publishingCompany.ShowPublishingCompany(db);

                Utility.WriteMessage("Enter the ID of the publishing company: ", "", "");

                bool isPublishing = int.TryParse(Console.ReadLine(), out int publishingCompanyId);

                if (!isPublishing || !db.PublishingCompanies.Any(p => p.PublishingCompanyId == publishingCompanyId))
                {
                    Utility.WriteMessage("Invalid ID", "", "\n");
                }
                else
                {
                    return publishingCompanyId;
                }
            } while (Utility.KeepGoing());

            return 0;
        }

        public int AddGenre(Genre genre, PublishingCompanyContext db)
        {
            do
            {
                Console.Clear();
                Utility.WriteTitle("Create Book", "", "\n\n");
                Utility.WriteMessage("Genre ids: ", "", "\n");

                genre.ShowGenre(db);

                Utility.WriteMessage("Enter the ID of the genre: ", "", "");

                bool isGenre = int.TryParse(Console.ReadLine(), out int genreId);

                if (!isGenre || !db.Genres.Any(g => g.GenreId == genreId))
                {
                    Utility.WriteMessage("Invalid ID", "", "\n");
                }
                else
                {
                    return genreId;
                }
            } while (Utility.KeepGoing());
            
            return 0;
        }

        public string AddTitle()
        {
            do
            {
                Console.Clear();
                Utility.WriteTitle("Create Book", "", "\n\n");
                Utility.WriteMessage("Enter the title of the book: ", "", "");

                string title = Console.ReadLine();

                if (string.IsNullOrEmpty(title))
                {
                    Utility.WriteMessage("Invalid title", "", "\n");
                }
                else
                {
                    return title;
                }
            } while (Utility.KeepGoing());
            
            return null;

        }

        public string AddIsbn()
        {
            do
            {
                Console.Clear();
                Utility.WriteTitle("Create Book", "", "\n\n");
                Utility.WriteMessage("Enter the ISBN of the book: ", "", "");

                string isbn = Console.ReadLine();

                if (string.IsNullOrEmpty(isbn))
                {
                    Utility.WriteMessage("Invalid ISBN", "", "\n");
                }
                else
                {
                    return isbn;
                }

            } while (Utility.KeepGoing());

            return null;
        }



        public void ShowBook(PublishingCompanyContext db)
        {
            var query = db.Books.Select(b => b).OrderBy(b => b.BookId);

            foreach (var item in query)
            {
                Utility.WriteMessage($"Book: {item.BookId} - {item.Title} - {item.ISBN} - {item.PublishingCompany.PublishingCompanyName} - {item.Genre.GenreName}", "", "\n");
            }
        }

        #endregion

    }
}
