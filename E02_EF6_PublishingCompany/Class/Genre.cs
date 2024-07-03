using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E02_EF6_PublishingCompany.Class
{
    internal class Genre
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
    }
}
