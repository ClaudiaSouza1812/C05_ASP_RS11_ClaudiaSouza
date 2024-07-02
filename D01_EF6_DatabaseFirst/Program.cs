using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
using D01_EF6_DatabaseFirst;

// When the database already exists, use the Database First approach
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

                region.CreateRegion(region, db);
                
                db.Region.Add(region);

                var count01 = db.SaveChanges();

                Utility.WriteMessage($"{count01} nova(s) região(ões) gravada(s)", "", "\n\n");

                region.PrintRegion(db);

                #endregion

                #region New territory

                Territories territories = new Territories();

                territories.CreateTerritory(territories, db, region);
                
                db.Territories.Add(territories);

                var count02 = db.SaveChanges();

                Utility.WriteMessage($"{count02} novo(s) territorio(s) gravado(s)", "\n", "\n\n");

                territories.PrintTerritory(db);

                #endregion



                Utility.TerminateConsole();
            }
        }
    }
}
