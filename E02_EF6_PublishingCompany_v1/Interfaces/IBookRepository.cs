using E02_EF6_PublishingCompany_v1.Class;
using E02_EF6_PublishingCompany_v1.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_EF6_PublishingCompany_v1.Interfaces
{
    internal interface IBookRepository
    {
        void CreateBook(Book book, PublishingCompany publishingCompany, Genre genre, PublishingCompanyContext db);

        void ShowBook(PublishingCompanyContext db);
    }
}
