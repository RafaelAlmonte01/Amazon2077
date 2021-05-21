using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon2077.Areas.Usuarios.Controllers
{
    [Area("Usuarios")]
    public class UsersHomeController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
    }
}
