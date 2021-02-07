﻿using Hotel.Data.Models;

using Hotel.interfaces;
using Hotel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.controllers
{
    public class HotelRoomController : Controller
    {
        private  IAllRoom _RoomRep;
        private readonly HotelRoom _HotelRoom;

        public HotelRoomController(IAllRoom RoomRep , HotelRoom HotelRoom)
        {
            _RoomRep = RoomRep;
            _HotelRoom = HotelRoom;
        }
        public ViewResult Index()
        {
            var items = _HotelRoom.getHotelItems();
            _HotelRoom.listHotelItem = items;
            var obj = new HotelRoomViewModel
            {
                HotelRoom = _HotelRoom
            };
            return View(obj);
        }

        public RedirectToActionResult AddToRoom(int id)
        {
            var item = _RoomRep.rooms.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _HotelRoom.AddToRoom(item);
            }
            return RedirectToAction("Index");
        }
    }
}
