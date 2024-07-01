using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_EF6_Library.Class
{
    internal class Book
    {
        public int BookId { get; set; }
        public int PublishingCompanyId { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }

        public virtual PublishingCompany PublishingCompany { get; set; }

    }
}
