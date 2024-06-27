using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_EF6_CodeFirst.Class
{
    internal class Blog
    {
        #region Properties

        // Scalar properties allow the entity to store simple values

        public int BlogId { get; set; }
        public string Name { get; set; }


        // Navigation properties hold other entities that are related to this entity

        public virtual ICollection<Post> Post { get; set; }

        #endregion
    }
}
