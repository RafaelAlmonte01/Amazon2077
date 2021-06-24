using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon2077.Models
{
    public class ProductosEn
    {
        public Int64 PID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string Imagen { get; set; }
        [Required]
        public decimal Precio { get; set; }
    }
}
