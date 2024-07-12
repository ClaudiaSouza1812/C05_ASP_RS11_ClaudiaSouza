using E02_EF6_PublishingCompany_v2.Class;
using E02_EF6_PublishingCompany_v2.Context;

namespace E02_EF6_PublishingCompany_v2.Interfaces
{
    internal interface IPublishingCompanyRepository
    {
        void CreatePublishingCompany(PublishingCompany publishingCompany, PublishingCompanyContext db);

        void ShowPublishingCompany(PublishingCompanyContext db);
    }
}
