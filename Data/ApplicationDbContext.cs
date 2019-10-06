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

        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Point> Points { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<PointType> PointTypes { get; set; }
    }
}
