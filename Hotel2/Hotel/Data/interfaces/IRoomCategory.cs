using Hotel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.interfaces
{
    public interface IRoomCategory
    {
        IEnumerable<category> Allcategories { get; }

    }
}
