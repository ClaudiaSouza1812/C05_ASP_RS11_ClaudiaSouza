using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_EF6_DatabaseFirst.Interfaces
{
    internal interface IRegionRepository
    {
        void CreateRegion(Region region, NorthwindEntities db);

        void PrintRegion(NorthwindEntities db);
    }
}
