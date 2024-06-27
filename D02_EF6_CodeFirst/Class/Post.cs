using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_EF6_CodeFirst.Class
{
    internal class Post
    {
        #region Properties

        // Scalar properties allow the entity to store simple values

        public int PostId { get; set; } // PK
        public int BlogId { get; set; } // FK
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }


        // Navigation properties hold other entities that are related to this entity

        public virtual Blog Blog { get; set; }

        #endregion
    }
}
