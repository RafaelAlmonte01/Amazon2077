using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon2077.Models
{
    public class ProductosBL
    {
        ProductosMET _mET = new ProductosMET();


        public int AgregarProducto(ProductosEn pEN)
        {

            return _mET.AgregarProducto(pEN);
        
        }

        public List<ProductosEn> ConsultarProductos()
        {

            return _mET.ConsultarProductos();
        
        }


    }
}
