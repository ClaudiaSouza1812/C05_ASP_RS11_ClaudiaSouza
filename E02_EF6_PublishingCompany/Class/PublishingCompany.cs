using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_EF6_PublishingCompany.Class
{
    internal class PublishingCompany
    {
        #region Scalar Properties

        public int PublishingCompanyId { get; set; }
        
        [Required]
        [Column("Publisher", TypeName = "nvarchar")]
        [StringLength(50)]
        public string PublishingCompanyName { get; set; }

        #endregion

        #region Navigation Properties   

        // Relationship: PublishingCompany 1 - N Book
        public virtual ICollection<Book> Book { get; set; }

        #endregion
    }
}
