using Hotel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.ViewModels
{
    public class RoomsListViewModel
    {
        

        public IEnumerable<room> allRooms { get; set; }
        public string RoommCategory { get; set; }
    }
}
