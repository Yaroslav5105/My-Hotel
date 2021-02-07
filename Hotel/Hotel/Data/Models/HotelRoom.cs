using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Data.Models
{
    public class HotelRoom
    {
        private readonly AppDBContent appDBContent;
        public HotelRoom(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string HotelRoomId { get; set; }

        public List<HotelRoomItem> listHotelItem { get; set; }

        public static HotelRoom GetRoom(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDBContent>();
            string HotelRoomId = session.GetString("RoomId") ?? Guid.NewGuid().ToString();

            session.SetString("RoomId", HotelRoomId);
            return new HotelRoom(context) { HotelRoomId = HotelRoomId };
        }
        public void AddToRoom(room room)
        {
            appDBContent.HotelRoomItem.Add(new HotelRoomItem {
                HotelRoomId = HotelRoomId,
                room = room,
                price = room.price
            });
            appDBContent.SaveChanges();
        }
        public List<HotelRoomItem> getHotelItems()
        {
            return appDBContent.HotelRoomItem.Where(c => c.HotelRoomId == HotelRoomId).Include(s => s.room).ToList();
        }
    }
}

