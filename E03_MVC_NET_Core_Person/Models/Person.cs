using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_MVC_NET_Core_Person.Models
{
    // Defines the Person class, which will be used to store information about a person, and will allow other objects of the same type to inherit it
    public class Person
    {
        // todo: use notation to control the table fields
        // FirstName: mandatory, error message, nvarchar(30)
        // LastName: nvarchar(30)
        // Age: [0,150]
        // all fields with name presentation
        #region Properties
        [Key]
        [DisplayName("Person ID")]
        public int PersonId { get; set; }

        [Required(ErrorMessage = "The field 'Name' is mandatory.")]
        [Column(TypeName = "nvarchar")]
        [StringLength(30, ErrorMessage = "Limit of 30 characters")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30, ErrorMessage = "Limit of 30 characters")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Range(0 , 150, ErrorMessage = "The age must be between 0 and 150.")]
        public int Age { get; set; }
        #endregion

        #region Constructor

        public Person()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Age = 0;
        }


        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        #endregion

    }
}
