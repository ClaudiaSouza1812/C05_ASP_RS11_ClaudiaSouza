using E02_EF6_PublishingCompany_v2.Class;
using E02_EF6_PublishingCompany_v2.Context;

namespace E02_EF6_PublishingCompany_v2.Interfaces
{
    internal interface IGenreRepository
    {
        void CreateGenre(Genre genre, PublishingCompanyContext db);

        void ShowGenre(PublishingCompanyContext db);
    }
}
