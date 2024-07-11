using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E02_EF6_PublishingCompany_v2.Interfaces;
using E02_EF6_PublishingCompany_v2.Context;
using D00_Utility;
using System.Data.Common;

namespace E02_EF6_PublishingCompany_v2.Class
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
            book.Title = "SyFy Story 01";

            book.ISBN = "isbn0001";

            book.PublishingCompanyId = publishingCompany.PublishingCompanyId;

            book.GenreId = genre.GenreId;

            db.Books.Add(book);

            db.SaveChanges();
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
