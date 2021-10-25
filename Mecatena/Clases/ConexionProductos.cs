using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace Mecatena.Clases
{
   
    //base de datos
    //referencias a los objetos de la tabla
    public class ConexionProductos
    {
        public int idproducto { get; set; }
        public string tipo { get; set; }
        public string cantidad { get; set; }
        public string descripcion { get; set; }
        public string precioUnitario { get; set; }
        public string total { get; set; }

        public ConexionProductos()
        {

        }


        public ConexionProductos(int idproducto, string tipo, string cantidad, string descripcion, string precioUnitario, string total)
        {
            this.idproducto = idproducto;
            this.tipo = tipo;
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.precioUnitario = precioUnitario;
            this.total = total;

        }

        public static int AltaProducto(MySqlConnection conexion, ConexionProductos conexionP)
        {
            int retorno = 0; 
            MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO productos_bd(tipo, cantidad, descripcion, precioUnitario, total) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", conexionP.tipo, conexionP.cantidad, conexionP.descripcion, conexionP.precioUnitario, conexionP.total ), conexion);
            retorno = comando.ExecuteNonQuery();
          
            return retorno; 
        }

        public static int CambioProducto(MySqlConnection conexion, ConexionProductos conexionP)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("UPDATE productos_bd SET tipo='{1}', cantidad='{2}', descripcion='{3}', precioUnitario='{4}', total='{5}' WHERE idproducto={0}", conexionP.idproducto, conexionP.tipo, conexionP.cantidad, conexionP.descripcion, conexionP.precioUnitario, conexionP.total), conexion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

      
        public static int BajaProducto(MySqlConnection conexion, int idprod)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("DELETE FROM productos_bd WHERE idproducto={0}", idprod), conexion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }



        public static List<ConexionProductos> Buscar(MySqlConnection conexion, string ptipo, string pcantidad, string pdescripcion, string pprecioUnitario, string ptotal)
        {
            List<ConexionProductos> lista = new List<ConexionProductos>();

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT idproducto, tipo, cantidad, descripcion, precioUnitario, total FROM productos_bd WHERE tipo LIKE ('%{0}%') AND cantidad LIKE ('%{0}%') AND descripcion LIKE ('%{0}%') AND precioUnitario LIKE ('%{0}%') AND total LIKE ('%{0}%')", ptipo, pcantidad, pdescripcion, pprecioUnitario, ptotal), conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ConexionProductos pproducto = new ConexionProductos();
                pproducto.idproducto = reader.GetInt32(0);
                pproducto.tipo = reader.GetString(1);
                pproducto.cantidad = reader.GetString(2);
                pproducto.descripcion = reader.GetString(3);
                pproducto.precioUnitario = reader.GetString(4);
                pproducto.total = reader.GetString(5);

                lista.Add(pproducto);

            }
            return lista;
        }

        public static List<ConexionProductos> MetodoBuscar(MySqlConnection conexion, string ptipo, string pcantidad, string pdescripcion, string pprecioUnitario, string ptotal)
        {
            List<ConexionProductos> lista = new List<ConexionProductos>();

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT idproducto, tipo, cantidad, descripcion, precioUnitario, total FROM productos_bd WHERE tipo LIKE ('%{0}%')", ptipo, pcantidad, pdescripcion, pprecioUnitario, ptotal), conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ConexionProductos pproducto = new ConexionProductos();
                pproducto.idproducto = reader.GetInt32(0);
                pproducto.tipo = reader.GetString(1);
                pproducto.cantidad = reader.GetString(2);
                pproducto.descripcion = reader.GetString(3);
                pproducto.precioUnitario = reader.GetString(4);
                pproducto.total = reader.GetString(5);

                lista.Add(pproducto);

            }
            return lista;
        }

        public static ConexionProductos obtenerProducto(MySqlConnection conexion, int pIdProducto)
        {
            ConexionProductos pproducto = new ConexionProductos();

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT idproducto, tipo, cantidad, descripcion, precioUnitario, total FROM productos_bd WHERE idproducto LIKE ('%{0}%')", pIdProducto), conexion);
            MySqlDataReader reader = comando.ExecuteReader();


            while (reader.Read())
            {
                pproducto.idproducto = reader.GetInt32(0);
                pproducto.tipo = reader.GetString(1);
                pproducto.cantidad = reader.GetString(2);
                pproducto.descripcion = reader.GetString(3);
                pproducto.precioUnitario = reader.GetString(4);
                pproducto.total = reader.GetString(5);

            }
            return pproducto;
        }

    }

}
