using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public int RoomId { get; set; }
        public int price { get; set; }
        public virtual room room { get; set; }
        public virtual Order order { get; set; }
       
        
    }
}
