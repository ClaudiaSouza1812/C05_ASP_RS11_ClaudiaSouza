using E02_EF6_PublishingCompany.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E02_EF6_PublishingCompany.Context;

namespace E02_EF6_PublishingCompany.Interfaces
{
    internal interface IPublishingCompanyRepository
    {
        void CreatePublishingCompany(PublishingCompany publishingCompany, PublishingCompanyContext db);

        void ShowPublishingCompany(PublishingCompanyContext db);
    }
}
