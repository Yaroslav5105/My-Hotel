using Hotel.Data.Models;
using Hotel.interfaces;
using Hotel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.controllers
{
    public class RoomsController : Controller {

        private readonly IAllRoom _allRooms;
        private readonly IRoomCategory _allcategories;

        public RoomsController(IAllRoom iAllRooms, IRoomCategory iRoomCat)
        {
            _allRooms = iAllRooms;
            _allcategories = iRoomCat ;
        }

        [Route("rooms/List")]
        [Route("rooms/List/ {category}")]


        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<room> rooms = null;
            string RoommCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                rooms = _allRooms.rooms.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("Стандарт", category, StringComparison.OrdinalIgnoreCase))
                {
                    rooms = _allRooms.rooms.Where(i => i.Category.categoryName.Equals("Вип номер")).OrderBy(i => i.id);
                    RoommCategory = "Вип номер";
                }
                else  if(string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    rooms = _allRooms.rooms.Where(i => i.Category.categoryName.Equals("Стандарт")).OrderBy(i => i.id);
                    RoommCategory = "Стандарт";
                }

                RoommCategory = _category;

                
            }
            var roomobj = new RoomsListViewModel
            {
                allRooms = rooms,
                RoommCategory = RoommCategory
            };

            ViewBag.Title = "Страницы с комнатами";
            
            return View(roomobj);
        }

    }
}
