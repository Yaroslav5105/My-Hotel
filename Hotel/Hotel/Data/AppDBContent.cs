using Hotel.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Data
{
    public class AppDBContent : DbContext {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) {
      
        }

        public DbSet<room> Room { get; set; }        
        public DbSet<User> User { get; set; }
        public DbSet<category> Category { get; set; }
        public DbSet<HotelRoomItem> HotelRoomItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        

    }
}

