using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        // [Column(TypeName = "nvarchar(100)")] // versão 4.7.2
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(200)]
        public string Content { get; set; }
        public DateTime Date { get; set; }


        // Navigation properties hold other entities that are related to this entity

        public virtual Blog Blog { get; set; }

        #endregion
    }
}
