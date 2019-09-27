using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiAddressBook.Models
{

    using System.ComponentModel.DataAnnotations;
    public enum TypeContact
    {
        telephone,
        email,
        facebook,
        instagram,
        linkedin
    }
    public class Book
    {
        [Key]
        public int bookID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public TypeContact type { get; set; }
        [Required]
        public string contact { get; set; }

    }
}