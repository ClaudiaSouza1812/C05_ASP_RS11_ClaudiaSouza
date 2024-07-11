using E02_EF6_PublishingCompany_v1.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E02_EF6_PublishingCompany_v1.Context;

namespace E02_EF6_PublishingCompany_v1.Interfaces
{
    internal interface IPublishingCompanyRepository
    {
        void CreatePublishingCompany(PublishingCompany publishingCompany, PublishingCompanyContext db);

        void ShowPublishingCompany(PublishingCompanyContext db);
    }
}
