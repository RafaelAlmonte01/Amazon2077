using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Amazon2077.Models
{
    public class ProductosMET
    {
        IDbConnection _MyConn = DBcommon.conexion();

        //Metodo Agregar

        public int AgregarProducto(ProductosEn pEN)
        {
            _MyConn.Open();
            SqlCommand _Command = new SqlCommand("AgregarProductos", _MyConn as SqlConnection);
            _Command.CommandType = CommandType.StoredProcedure;
            _Command.Parameters.Add(new SqlParameter("@Nombre", pEN.Nombre));
            _Command.Parameters.Add(new SqlParameter("@Descripcion", pEN.Descripcion));
            _Command.Parameters.Add(new SqlParameter("@Imagen", pEN.Imagen));
            _Command.Parameters.Add(new SqlParameter("@Precio", pEN.Precio));
            int Resultado = _Command.ExecuteNonQuery();
            _MyConn.Close();
            return Resultado;

        }

        //Metodo Consultar

        public List<ProductosEn> ConsultarProductos()
        {
            _MyConn.Open();
            SqlCommand _command = new SqlCommand("ConsultarProductos", _MyConn as SqlConnection);
            _command.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _command.ExecuteReader();
            List<ProductosEn> _lista = new List<ProductosEn>();
            while (_reader.Read())
            {
                ProductosEn pEN = new ProductosEn();
                pEN.PID= _reader.GetInt64(0);
                pEN.Nombre = _reader.GetString(1);
                pEN.Descripcion = _reader.GetString(2);
                pEN.Imagen = _reader.GetString(3);
                pEN.Precio = _reader.GetDecimal(4);

                _lista.Add(pEN);
            }
            _MyConn.Close();
            return _lista;
        
        }
        
    }
}
