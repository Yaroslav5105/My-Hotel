using Hotel.Data.interfaces;
using Hotel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {

        private readonly AppDBContent appDBContent;
        private readonly HotelRoom hotelRoom;
        public OrdersRepository(AppDBContent appDBContent , HotelRoom hotelRoom)
        {
            this.appDBContent = appDBContent;
            this.hotelRoom = hotelRoom;
        }
        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();

            var items = hotelRoom.listHotelItem;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail() {
                    RoomId = el.room.id,
                    orderId = order.id,
                    price =el.room.price

                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
