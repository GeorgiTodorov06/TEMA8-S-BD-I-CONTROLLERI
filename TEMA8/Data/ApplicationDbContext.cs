using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Diagnostics;
using TEMA8.Models;
using System;

namespace TEMA8.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<PhoneList> PhoneLists { get; set; }
        public DbSet<PhoneEntry> PhoneEntries { get; set; }
    }
}
