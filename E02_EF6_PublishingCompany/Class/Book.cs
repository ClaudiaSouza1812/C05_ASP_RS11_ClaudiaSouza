using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_EF6_PublishingCompany.Class
{
    internal class Book
    {
        #region Scalar Properties

        public int BookId { get; set; }
        public int PublishingCompanyId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(100, ErrorMessage = "Limite de 100 caracteres")]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(13, ErrorMessage = "Limite de 13 caracteres.")]
        public string ISBN { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50, ErrorMessage = "Limite de 50 caracteres.")]
        public string Type { get; set; }

        #endregion

        #region Navigation Properties
        // Relationship: Book 1 - 1 PublishingCompany
        public virtual PublishingCompany PublishingCompany { get; set; }

        #endregion

        

        

    }
}
