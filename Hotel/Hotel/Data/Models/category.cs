using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Data.Models
{
    public class category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string desc { set; get; }

        public List <room> room { set; get; }

    }
}
