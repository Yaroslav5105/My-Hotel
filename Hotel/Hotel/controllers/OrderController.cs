using Hotel.Data.interfaces;
using Hotel.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly HotelRoom hotelRoom;
        public OrderController(IAllOrders allOrders, HotelRoom hotelRoom)
        {
            this.allOrders = allOrders;
            this.hotelRoom = hotelRoom;
        }
        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {

            hotelRoom.listHotelItem = hotelRoom.getHotelItems();

            if(hotelRoom.listHotelItem.Count == 0)
            {
                ModelState.AddModelError("", "у вас должны быть товары!");
            }

            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}
