using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon2077.Areas.Usuarios.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Amazon2077.Areas.Usuarios.Pages.Cuenta
{
    public class RegistrarModel : PageModel
    {
        public void OnGet()
        {
        }
        [BindProperty]

        public InputModel Input { get; set; }

        public class InputModel : InputModelRegister 
        {
            public IFormFile AvatarImage { get; set; }

        }
    }
}

