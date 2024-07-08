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
            Utility.WriteTitle("Create Book", "", "\n\n");

            publishingCompany.ShowPublishingCompany(db);

            Utility.WriteMessage("Enter the ID of the publishing company: ", "", "");

            bool isPublishing = int.TryParse(Console.ReadLine(), out int publishingCompanyId);





        }

        public void ShowBook(PublishingCompanyContext db)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
