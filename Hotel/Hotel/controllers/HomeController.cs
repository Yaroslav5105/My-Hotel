using Hotel.interfaces;
using Hotel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.controllers
{
    public class HomeController : Controller
    {
        private readonly IAllRoom _RoomRep;
       

        public HomeController(IAllRoom RoomRep)
        {
            _RoomRep = RoomRep;  
        }
        public ViewResult Index()
        {
            var homeRooms = new HomeViewModel {
            favRoom = _RoomRep.getFavrooms
            };
            return View(homeRooms);
        }
    }
}
