using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_EF6_AdventureWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Utility.SetUnicodeConsole();

            using (var db = new AdventureWorks2019Entities())
            {
                /*
                // create new category
                // list categories before adding new category
                // add category
                // Save new category
                // list updated categories
                #region New Category
                
                ProductCategory category = new ProductCategory();
                
                var query01 = db.ProductCategory.Select(r => r).OrderBy(r => r.ProductCategoryID);

                foreach (var item in query01)
                {
                    Utility.WriteMessage($"{item.ProductCategoryID}, {item.Name}, {item.rowguid}, {item.ModifiedDate}", "", "\n");
                }

                category.Name = "Games"; ;
                category.rowguid = Guid.NewGuid();
                category.ModifiedDate = DateTime.Now;

                db.ProductCategory.Add(category);

                var count01 = db.SaveChanges();

                Utility.WriteMessage($"{count01} nova(s) categoria(s) gravada(s)", "", "\n\n");
                
                var query02 = db.ProductCategory.Select(r => r).OrderBy(r => r.ProductCategoryID);

                foreach (var item in query02)
                {
                    Utility.WriteMessage($"{item.ProductCategoryID}, {item.Name}, {item.rowguid}, {item.ModifiedDate}", "", "\n");
                }

                Utility.PauseConsole();
                #endregion
                */
                #region New Subcategory
                // create new subcategory
                // list subcategories before adding new subcategory
                // add subcategory
                // Save new subcategory
                // list updated subcategories

                ProductSubcategory subcategory = new ProductSubcategory();
                
                var query03 = db.ProductSubcategory.Select(t => t).OrderBy(t => t.ProductSubcategoryID);

                foreach (var item in query03)
                {
                    Utility.WriteMessage($"{item.ProductSubcategoryID}, {item.Name}, {item.ProductCategoryID}, {item.rowguid}, {item.ModifiedDate}", "", "\n");
                }

                subcategory.Name = "Board Games";
                subcategory.ProductCategoryID = 5;  
                subcategory.rowguid = Guid.NewGuid();
                subcategory.ModifiedDate = DateTime.Now;

                db.ProductSubcategory.Add(subcategory);
                var count02 = db.SaveChanges();

                Utility.WriteMessage($"{count02} nova(s) subcategoria(s) gravada(s)", "\n", "\n\n");
                
                var query04 = db.ProductSubcategory.Select(t => t).OrderBy(t => t.ProductSubcategoryID);

                foreach (var item in query04) 
                {
                    Utility.WriteMessage($"{item.ProductSubcategoryID}, {item.Name}, {item.ProductCategoryID}, {item.rowguid}, {item.ModifiedDate}", "", "\n");
                }

                #endregion

                Utility.TerminateConsole();
            }
        }
    }
}
