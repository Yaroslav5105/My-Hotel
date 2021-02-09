using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Hotel.controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return Content(User.Identity.Name);
        }
    }
}
