using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E02_EF6_Library
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





            Utility.TerminateConsole();
        }
    }
}
