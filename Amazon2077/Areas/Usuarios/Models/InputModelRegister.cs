using Amazon2077.Areas.Usuarios.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon2077.Areas.Usuarios.Models
{
    
        [Table("Usuarios")]
        public class InputModelRegister
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int NID { get; set; }
            [Required(ErrorMessage = "El Campo NID es obligatorio.")]


            public string Nombre { get; set; }
            [Required(ErrorMessage = "El Campo Nombre es obligatorio.")]


            public string Apellido { get; set; }
            [Required(ErrorMessage = "El Campo Apellido es obligatorio.")]


            [DataType(DataType.PhoneNumber)]
            public string NumeroDeTelefono { get; set; }
            [Required(ErrorMessage = "El Campo Telefono es obligatorio.")]


            [EmailAddress]
            public string Email { get; set; }
            [Required(ErrorMessage = "El Campo Correo Electronico es obligatorio.")]

            [Display(Name = "Contraseña")]
            [StringLength(100, ErrorMessage = "El numero de caracteres de {0} debe ser al menos {2}", MinimumLength = 6)]
            public string Contraseña { get; set; }
            [Required(ErrorMessage = "El Campo Contraseña es obligatorio.")]

            public TipoUsuario Tipo { get; set; }

        public InputModel Input { get; set; }

        public class InputModel : InputModelRegister
        {
            public IFormFile AvatarImage { get; set; }
            [TempData]
            public string ErrorMessage { get; set; }

        }


    }
}



