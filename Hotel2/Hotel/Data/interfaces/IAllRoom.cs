using Hotel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.interfaces
{
    public interface IAllRoom
    {
        IEnumerable<room> rooms { get;  }
        IEnumerable<room> getFavrooms { get; }
        room getObjectRoom (int roomId);
    }
}
