using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_EF6_Library.Class
{
    internal class PublishingCompany
    {
        #region Properties

        public int PublishingCompanyId { get; set; }
        public string PublishingCompanyName { get; set; }

        public virtual ICollection<Book> Book { get; set; }


        #endregion
    }
}
