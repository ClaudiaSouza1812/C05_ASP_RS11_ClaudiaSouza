using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D01_EF6_DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindEntities())
            {

                #region New region

                Region region = new Region();

                // ToDo MRS: add id automatically

                region.RegionID = 5;
                region.RegionDescription = "North";

                db.Region.Add(region);

                var count01 = db.SaveChanges();

                Utility.WriteMessage($"{count01} nova(s) região(ões) gravada(s)", "", "\n\n");

                var query01 = db.Region.Select(r => r).OrderBy(r => r.RegionID);

                foreach (var item in query01)
                {
                    Utility.WriteMessage($"{item.RegionID}, {item.RegionDescription}", "", "\n");
                }

                #endregion

                #region New territory

                Territories territories = new Territories();

                territories.TerritoryID = "00001";
                territories.TerritoryDescription = "Espinho";

                // ToDo MRS: this must be the id of the region created above
                territories.RegionID = 5;

                db.Territories.Add(territories);

                var count02 = db.SaveChanges();

                Utility.WriteMessage($"{count02} novo(s) territorio(s) gravado(s)", "\n", "\n\n");

                var query02 = db.Territories.Select(t => t).OrderBy(t => t.TerritoryID);

                foreach (var item in query02)
                {
                    Utility.WriteMessage($"{item.TerritoryID}, {item.TerritoryDescription}, {item.RegionID}", "", "\n");
                }

                #endregion



                Utility.TerminateConsole();
            }
        }
    }
}
