using D01_EF6_DatabaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D01_EF6_DatabaseFirst;
using D00_Utility;

namespace D01_EF6_DatabaseFirst.Classes
{
    internal class Region : IRegionRepository
    {
        public void CreateRegion(D01_EF6_DatabaseFirst.Region region, NorthwindEntities db)
        {
            int id = db.Region.Max(r => r.RegionID);
            region.RegionID =  id++;

            
        }

        internal string GetRegionDescription()
        {
            Utility.WriteMessage("Enter the region description: ");
            string regionDescription = Console.ReadLine();

            return regionDescription;

        }


        public void PrintRegion(NorthwindEntities db)
        {
            throw new NotImplementedException();
        }
    }
}
