using System;
using System.Security.Claims;
namespace Hotel.Data.Models
{
    public class room
    {
        public int id { set; get; }
        public string name { set; get; }
        public string shortDesc { set; get; }
        public string LongDEsc { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool isFavourite { set; get; }
        public bool available { set; get; }
        public int categoryID { set; get; }
        public virtual category Category { set; get; }
       
        public static implicit operator room(ClaimsPrincipal t)
        {
            throw new NotImplementedException();
        }

    }
}
