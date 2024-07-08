using E02_EF6_PublishingCompany.Class;
using E02_EF6_PublishingCompany.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_EF6_PublishingCompany.Interfaces
{
    internal interface IBookRepository
    {
        void CreateBook(Book book, PublishingCompany publishingCompany, Genre genre, PublishingCompanyContext db);

        void ShowBook(PublishingCompanyContext db);
    }
}
