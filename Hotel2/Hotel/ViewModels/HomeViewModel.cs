using Hotel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<room> favRoom { get; set; }
    }
}
