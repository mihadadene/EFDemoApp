using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDataAccessLibrary.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        [Required]
        [MaxLength(50)]            
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }
        public List<Address> Adresses { get; set; } = new List<Address>();
        public List<Email> EmailAdress { get; set; } = new List<Email>();
       

    }
}
