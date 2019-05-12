using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipPortal.Models
{
    public class JobApplicant
    {
        public int ID { get; set; }
        public int JobID { get; set; }
        public string UserID{ get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Oluşturma Tarihi")]
        public DateTime CreatedTime { get; set; }

        public User  User { get; set; }



    }
}
