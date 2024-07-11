using D00_Utility;
using E02_EF6_PublishingCompany_v1.Context;
using E02_EF6_PublishingCompany_v1.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_EF6_PublishingCompany_v1.Class
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

        public void CreatePublishingCompany(PublishingCompany publishingCompany, PublishingCompanyContext db)
        {
            Utility.WriteTitle("Create Publishing Company", "", "\n\n"); 

            Utility.WriteMessage("Enter the name of the publishing company: ", "", "");

            publishingCompany.PublishingCompanyName = Console.ReadLine();

            db.PublishingCompanies.Add(publishingCompany);
            db.SaveChanges();
        }

        public void ShowPublishingCompany(PublishingCompanyContext db)
        {
            var query = db.PublishingCompanies.Select(p => p).OrderBy(p => p.PublishingCompanyId);

            foreach (var publishing in query)
            {
                Utility.WriteMessage($"Publishing Company: {publishing.PublishingCompanyId} - {publishing.PublishingCompanyName}", "", "\n");
            }
        }

        #endregion

    }
}
