﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InternshipPortal.Models;

namespace InternshipPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<InternshipPortal.Models.Job> Job { get; set; }
        public DbSet<InternshipPortal.Models.JobApplicant> JobApplicant { get; set; }
    }
}
