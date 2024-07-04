using E02_EF6_PublishingCompany.Interfaces;
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
    internal class PublishingCompany : IPublishingCompanyRepository
    {
        #region Scalar Properties

        public int PublishingCompanyId { get; set; }
        
        [Required]
        [Column("Publisher", TypeName = "nvarchar")]
        [StringLength(50, ErrorMessage = "Limite de 50 caracteres")]
        public string PublishingCompanyName { get; set; }

        #endregion

        #region Navigation Properties   

        // Relationship: PublishingCompany 1 - N Book
        public virtual ICollection<Book> Book { get; set; }

        #endregion

        #region Methods

        public void CreatePublishingCompany(PublishingCompany publishingCompany)
        {
            
            PublishingCompany publishingCompany = new PublishingCompany();

            publishingCompany.PublishingCompanyName = "Editora 1";

            db.PublishingCompanies.Add(publishingCompany);
            db.SaveChanges();
                
        }

        public void ShowPublishingCompany()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
