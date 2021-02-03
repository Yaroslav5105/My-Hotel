using Hotel.Data.Models;
using Hotel.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Data.Repository
{
    public class RoomRepository : IAllRoom
    {
        private readonly AppDBContent appDBContent;
        public RoomRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<room> rooms => appDBContent.Room.Include(c => c.Category);

        public IEnumerable<room> getFavrooms => appDBContent.Room.Where(p => p.isFavourite).Include(c => c.Category);

        public room getObjectRoom(int roomId) => appDBContent.Room.FirstOrDefault(p => p.id == roomId);
        
    }
}
