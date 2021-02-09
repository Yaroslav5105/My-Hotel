using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Models
{
    public class SignContext : DbContext
    {
        
        public DbSet<User> Users { get; set; }
        public SignContext(DbContextOptions<SignContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

