using _02CapsulaMvc.Net.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02CapsulaMvc.Net.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<State> States { get; set; }

    }
}
