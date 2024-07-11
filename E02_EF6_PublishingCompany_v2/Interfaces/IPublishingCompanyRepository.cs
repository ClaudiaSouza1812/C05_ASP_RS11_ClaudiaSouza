using E02_EF6_PublishingCompany_v2.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E02_EF6_PublishingCompany_v2.Context;

namespace E02_EF6_PublishingCompany_v2.Interfaces
{
    internal interface IPublishingCompanyRepository
    {
        void CreatePublishingCompany(PublishingCompany publishingCompany, PublishingCompanyContext db);

        void ShowPublishingCompany(PublishingCompanyContext db);
    }
}
