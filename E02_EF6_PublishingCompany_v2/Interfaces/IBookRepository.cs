using E02_EF6_PublishingCompany_v2.Class;
using E02_EF6_PublishingCompany_v2.Context;

namespace E02_EF6_PublishingCompany_v2.Interfaces
{
    internal interface IBookRepository
    {
        void CreateBook(Book book, PublishingCompany publishingCompany, Genre genre, PublishingCompanyContext db);

        void ShowBook(PublishingCompanyContext db);
    }
}
