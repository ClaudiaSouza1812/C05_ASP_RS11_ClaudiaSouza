using E02_EF6_PublishingCompany_v2.Class;
using E02_EF6_PublishingCompany_v2.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_EF6_PublishingCompany_v2.Interfaces
{
    internal interface IGenreRepository
    {
        void CreateGenre(Genre genre, PublishingCompanyContext db);

        void ShowGenre(PublishingCompanyContext db);
    }
}
