using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_EF6_DatabaseFirst.Interfaces
{
    internal interface ITerritoryRepository
    {
        void CreateTerritory(Territories territories, NorthwindEntities db);

        void PrintTerritory(NorthwindEntities db);
    }
}
