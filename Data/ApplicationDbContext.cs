using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ua_acm_website.Models;

namespace ua_acm_website.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Member { get; set; }

        public DbSet<Meeting> Meeting { get; set; }

        public DbSet<Recruiter> Recruiter { get; set; }

        public DbSet<CodingResource> CodingResource { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

    }
}
