using D01_EF6_DatabaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D01_EF6_DatabaseFirst;
using D00_Utility;

namespace D01_EF6_DatabaseFirst
{
    public partial class Region : IRegionRepository
    {
        public void CreateRegion(Region region, NorthwindEntities db)
        {
            region.RegionID = GenerateRegionId(db);

            region.RegionDescription = GetRegionDescription();
        }

        internal int GenerateRegionId(NorthwindEntities db)
        {
            int id = db.Region.Max(r => r.RegionID);
            id++;

            return id;
        }

        internal string GetRegionDescription()
        {
            Utility.WriteMessage("Enter the region description: ");
            string regionDescription = Console.ReadLine();

            return regionDescription;
        }


        public void PrintRegion(NorthwindEntities db)
        {
            var query = db.Region.Select(r => r).OrderBy(r => r.RegionID);

            foreach (var region in query)
            {
                Utility.WriteMessage($"Region: {region.RegionID}, {region.RegionDescription}", "", "\n");
            }
        }
    }
}
