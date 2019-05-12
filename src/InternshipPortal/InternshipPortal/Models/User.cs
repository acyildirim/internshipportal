using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipPortal.Models
{
    public class User : IdentityUser
    {
        [Display(Name ="Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
