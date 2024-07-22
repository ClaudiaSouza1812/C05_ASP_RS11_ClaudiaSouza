using D00_Utility;
using E02_EF6_PublishingCompany_v2.Context;
using E02_EF6_PublishingCompany_v2.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace E02_EF6_PublishingCompany_v2.Class
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

        public void CreatePublishingCompany(PublishingCompanyContext db)
        {
            string[] publishingCompanies = { "Editora 01", "Editora 02", "Editora 03" };

            try
            {
                var dbCompanyNames = db.PublishingCompanies.Select(p => p.PublishingCompanyName).ToHashSet(StringComparer.OrdinalIgnoreCase);

                var newPublishingCompanies = publishingCompanies
                    .Where(name => !dbCompanyNames.Contains(name))
                    .Select(name => new PublishingCompany { PublishingCompanyName = name }).ToHashSet();

                if (newPublishingCompanies.Any())
                {
                    db.PublishingCompanies.AddRange(newPublishingCompanies);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Utility.WriteMessage($"Error: {ex.Message}", "", "\n");
            }
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
