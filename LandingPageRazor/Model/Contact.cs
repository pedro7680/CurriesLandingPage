using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LandingPageRazor.Model
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string EmailAddress { get; set; }
    }
}
