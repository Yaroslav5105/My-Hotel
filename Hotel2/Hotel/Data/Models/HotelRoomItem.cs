using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Data.Models
{
    public class HotelRoomItem
    {
        public int id { get; set; }
        public room room {get ; set;}
        public int price { get; set; }

        public string HotelRoomId { get; set; }
    }
}
