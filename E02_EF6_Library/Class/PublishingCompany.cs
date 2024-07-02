using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_EF6_Library.Class
{
    internal class PublishingCompany
    {
        #region Properties

        public int PublishingCompanyId { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Publisher", TypeName = "nvarchar(50)")]
        public string PublishingCompanyName { get; set; }

        public virtual ICollection<Book> Book { get; set; }


        #endregion
    }
}
