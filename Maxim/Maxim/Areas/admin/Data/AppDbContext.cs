using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Maxim.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Maxim.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Maxim.Models.Service> Service { get; set; }
        public DbSet<Maxim.Models.CustomUser> CustomUsers { get; set; }
    }
}
