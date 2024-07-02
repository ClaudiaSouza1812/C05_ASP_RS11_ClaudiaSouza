using D00_Utility;
using D01_EF6_DatabaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_EF6_DatabaseFirst
{
    public partial class Territories : ITerritoryRepository
    {
        public Territories()
        {
            TerritoryID = string.Empty;
            TerritoryDescription = string.Empty;
        }

        public void CreateTerritory(Territories territories, NorthwindEntities db, Region region)
        {
            RegionID = region.RegionID;
            
            TerritoryID = GenerateTerritoryId(db);

            TerritoryDescription = GetTerritoryDescription();
        }

        internal string GenerateTerritoryId(NorthwindEntities db)
        {
            string id = db.Territories.Max(t => t.TerritoryID);

            bool _ = int.TryParse(id, out int number);
            number++;

            return number.ToString();
        }

        internal string GetTerritoryDescription()
        { 
            Utility.WriteMessage("Enter the territory description: ");
            string territoryDescription = Console.ReadLine();

            return territoryDescription;
        }

        public void PrintTerritory(NorthwindEntities db)
        {
            var query = db.Territories.Select(t => t).OrderBy(t => t.TerritoryID);

            foreach (var territory in query)
            {
                Utility.WriteMessage($"Territory: {territory.TerritoryID} - {territory.TerritoryDescription} - {territory.RegionID}", "", "\n");
            }
        }
    }
}
