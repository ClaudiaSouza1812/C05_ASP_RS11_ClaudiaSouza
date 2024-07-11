﻿using E02_EF6_PublishingCompany_v1.Class;
using E02_EF6_PublishingCompany_v1.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_EF6_PublishingCompany_v1.Interfaces
{
    internal interface IGenreRepository
    {
        void CreateGenre(Genre genre, PublishingCompanyContext db);

        void ShowGenre(PublishingCompanyContext db);
    }
}