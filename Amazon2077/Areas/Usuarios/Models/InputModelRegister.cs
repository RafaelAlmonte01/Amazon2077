using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon2077.Areas.Usuarios.Models
{
    public class InputModelRegister
    {


        [Required (ErrorMessage = "Este Campo es obligatorio.") ]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este Campo es obligatorio.")]
        public string Apellido { get; set; }

        public string NID { get; set; }



    }
}
