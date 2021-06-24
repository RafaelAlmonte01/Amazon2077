using Amazon2077.Areas.Usuarios.Models;
using Amazon2077.Controllers;
using Amazon2077.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon2077.Areas.Usuarios.Controllers
{
    [Area("Usuarios")]
    public class UsersHomeController : Controller
    {
      
            private readonly ILogger<UsersHomeController> _logger;
            private readonly dbUsuarioContext _db;

            public UsersHomeController(ILogger<UsersHomeController> logger, dbUsuarioContext db)
            {
                _logger = logger;
                _db = db;
            }

        public IActionResult Users()
        {
            var Usuarios = _db.Usuarios;
            return View(Usuarios);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Registrar(InputModelRegister input)

        {
            if (ModelState.IsValid)
            {
                _db.Usuarios.Add(input);
                _db.SaveChanges();

                return RedirectToAction("Users");
            }
            return View(input);
        }

        public IActionResult Modificar(int id)
        {
            var output = _db.Usuarios.Find(id);
            return View(output);
        }

        [HttpPost]
        public IActionResult Modificar(InputModelRegister input)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(input).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Users");

            }
            return View(input);
        }

        public IActionResult Eliminar(int id)
        {
            var output = _db.Usuarios.Find(id);
            return View(output);
        }

        [HttpPost]
        public IActionResult Eliminar(InputModelRegister input)
        {
            _db.Entry(input).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _db.SaveChanges();
            return RedirectToAction("Users");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }

