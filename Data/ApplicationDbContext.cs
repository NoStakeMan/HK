using System;
using System.Collections.Generic;
using System.Text;
using HK.EntityModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HK.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string> 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Requirement> Requirements { get; set; }
        public DbSet<Reward> Rewards { get; set; }

        public DbSet<Vote> Votes { get; set; }
    }
}
