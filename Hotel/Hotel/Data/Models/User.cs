using System;
using System.Security.Claims;

namespace Hotel.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public static implicit operator User(ClaimsPrincipal v)
        {
            throw new NotImplementedException();
        }
    }
}
