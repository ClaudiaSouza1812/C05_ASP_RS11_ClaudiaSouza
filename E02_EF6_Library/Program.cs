using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
using E02_EF6_PublishingCompany.Class;
using E02_EF6_PublishingCompany.Context;

namespace E02_EF6_PublishingCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                ----------
                Code First
                ----------
                Criar uma bd
                    Editora
                Tabelas
                    Editora: id, nome
                    Livro: id, isbn, titulo
                Cardinalidade
                    1 editora - n livros
                ToDo:
                Annotations
                Migrations

                Workflow
                1. Pastas
                2. Classes
                3. Connection string (App.config)
                4. DbContext
            */

            Utility.SetUnicodeConsole();

            using (var db = new PublishingCompanyContext())
            {
                #region PublishingCompany
                
                PublishingCompany publishingCompany = new PublishingCompany();

                publishingCompany.PublishingCompanyName = "Editora 1";

                db.PublishingCompanies.Add(publishingCompany);
                db.SaveChanges();
                
                var query01 = db.PublishingCompanies.Select(p => p).OrderBy(p => p.PublishingCompanyId);

                foreach (var publishing in query01)
                {
                    Utility.WriteMessage($"Publishing Company: {publishing.PublishingCompanyId} - {publishing.PublishingCompanyName}", "", "\n");
                }

                #endregion

                #region Book
                
                Book book = new Book();
                book.BookId = 1;
                book.PublishingCompanyId = 1;
                book.Title = "Livro 1";
                book.Isbn = "123456";

                db.Books.Add(book);
                db.SaveChanges();
                
                var query02 = db.Books.Select(b => b).OrderBy(b => b.BookId);

                foreach (var item in query02)
                {
                    Utility.WriteMessage($"Book: {item.BookId} - {item.PublishingCompany.PublishingCompanyName} - {item.Title} - {item.Isbn}", "", "\n");
                }

                #endregion

            }

            Utility.TerminateConsole();
        }
    }
}
