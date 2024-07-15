using D00_Utility;
using E02_EF6_PublishingCompany_v2.Context;
using E02_EF6_PublishingCompany_v2.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace E02_EF6_PublishingCompany_v2.Class
{
    internal class Genre : IGenreRepository
    {
        #region Scalar Properties

        public int GenreId { get; set; }

        [Required]
        [Column("Genre", TypeName = "nvarchar")]
        [StringLength(50, ErrorMessage = "Limite de 50 caracteres")]
        public string GenreName { get; set; }

        #endregion

        #region Navigation Properties

        // Relationship: Genre 1 - N Book
        public virtual ICollection<Book> Book { get; set; }

        #endregion

        #region Methods and Functions

        public void CreateGenre(PublishingCompanyContext db)
        {
            string[] genres = {"Drama", "Terror"};

            foreach (string genreName in genres)
            {
                Genre genre = new Genre();
                genre.GenreName = genreName;
                db.Genres.Add(genre);
            }

            db.SaveChanges();
        }

        public void ShowGenre(PublishingCompanyContext db)
        {
            var query = db.Genres.Select(g => g).OrderBy(g => g.GenreId);

            foreach (var genre in query)
            {
                Utility.WriteMessage($"Genre: {genre.GenreId} - {genre.GenreName}", "", "\n");
            }
        }

        #endregion
    }
}
