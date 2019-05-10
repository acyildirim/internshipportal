using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipPortal.Models
{
    public class Job
    {
        public int Id { get; set; }
        [Required]
        
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Description { get; set; }
        public Location location { get; set; }
        public Category Category { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }
    }

    public enum Location
    {
        Istanbul,
        Ankara,
        Izmir,
        Antalya
    }

    public enum Category
    {
        Software,
        Health,
        Electric,
        Industry
    }
}
