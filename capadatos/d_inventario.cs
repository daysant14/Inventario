using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaentidad;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace capadatos
{
    public class d_inventario
    {


        SqlConnection cn;
        private static d_inventario instance;
        private d_inventario()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);
            cn.Open();
        }

        //Metodo stactico de la instancia 
        public static d_inventario getInstance()
        {
            if (instance == null)
            {

                instance = new d_inventario();
            }

            return instance;
        }



        public DataTable D_listado()
        {


            SqlCommand cmd = new SqlCommand("sp_listar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }


        public DataTable BuscarDatosPorNombre(string nombreCliente)
        {
            DataTable dt = new DataTable();


            try
            {
                //cn.Open();

                using (SqlCommand cmd = new SqlCommand("sp_BuscarDatosPorNombre", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombreCliente", nombreCliente);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
            }


            return dt;
        }





        /* public DataTable D_listado()
         {
             SqlConnection cns = new SqlConnection("server= DESKTOP-L9P4EIJ; Integrated Security=true;Database= Inventario;uid=sa;pwd=D4y3LY123456");
             {
                 cn.Open();

                 SqlCommand cmd = new SqlCommand("sp_listar", cns);
                 cmd.CommandType = CommandType.StoredProcedure;
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);

                 return dt;
             }
         }*/





        /* public DataTable D_listado()
         {
             SqlCommand cmd = new SqlCommand("sp_listar", cn);
             cmd.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             da.Fill(dt);
             return dt;
         }*/





        public DataTable ObtenerProductosMasVendidos()
        {
            string consulta = @"
        SELECT TOP 10
            p.nombredeproducto AS Producto,
            SUM(i.cantidad) AS TotalVendido
        FROM
            inventario i
        INNER JOIN
            producto p ON i.productoid = p.idpl
        GROUP BY
            p.nombredeproducto
        ORDER BY
            TotalVendido DESC;
    ";


            DataTable dt = new DataTable();

            try
            {
                // cn.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    dt.Load(cmd.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción
            }

            return dt;

        }



        /*public DataTable ObtenerProductosMasVendidos()
        {
            string consulta = @"
        SELECT TOP 10
            p.nombredeproducto AS Producto,
            SUM(i.cantidad) AS TotalVendido
        FROM
            inventario i
        INNER JOIN
            producto p ON i.productoid = p.idpl
        GROUP BY
            p.nombredeproducto
        ORDER BY
            TotalVendido DESC;
    ";

            using (SqlCommand cmd = new SqlCommand(consulta, cn))
            {
                cn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cn.Close();

                return dt;
            }
        }*/








        public void InsertarDatosEnInventario(
    string nombreCliente,
    string apellidoCliente,
    string numeroCliente,
    string nombreProducto,
    decimal precioProducto,
    string numeroDeStockProducto,
    DateTime fechaDeCompra,
    int cantidad)
        {

            // cn.Open();
            // Crear un nuevo objeto SqlCommand con el nombre del procedimiento almacenado "InsertarDatosEnInventario" y la conexión "cn".
            SqlCommand cmd = new SqlCommand("InsertarDatosEnInventario", cn);

            // Establecer el tipo de comando como un procedimiento almacenado.
            cmd.CommandType = CommandType.StoredProcedure;

            // Agregar los parámetros necesarios para la inserción.
            cmd.Parameters.Add(new SqlParameter("@nombreCliente", SqlDbType.VarChar, 50)).Value = nombreCliente;
            cmd.Parameters.Add(new SqlParameter("@apellidoCliente", SqlDbType.VarChar, 50)).Value = apellidoCliente;
            cmd.Parameters.Add(new SqlParameter("@numeroCliente", SqlDbType.VarChar, 50)).Value = numeroCliente;
            cmd.Parameters.Add(new SqlParameter("@nombreProducto", SqlDbType.VarChar, 50)).Value = nombreProducto;
            cmd.Parameters.Add(new SqlParameter("@precioProducto", SqlDbType.Decimal)).Value = precioProducto;
            cmd.Parameters.Add(new SqlParameter("@numeroDeStockProducto", SqlDbType.VarChar, 50)).Value = numeroDeStockProducto;
            cmd.Parameters.Add(new SqlParameter("@fechaDeCompra", SqlDbType.DateTime)).Value = fechaDeCompra;
            cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int)).Value = cantidad;

            // Abrir la conexión antes de ejecutar el comando.
            //cn.Open();

            // Ejecutar el comando para realizar la inserción.
            cmd.ExecuteNonQuery();

            // Cerrar la conexión después de ejecutar el comando.
            // cn.Close();

        }

        // METODO DE BORRADO DE DATOS

        public void BorrarClienteYProductos(int clienteID)
        {

            using (SqlCommand cmd = new SqlCommand("BorrarClienteYProductosRelacionados", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@clienteID", SqlDbType.Int)).Value = clienteID;

                //  cn.Open();
                cmd.ExecuteNonQuery();

            }




        }

        //MODIFICAR DATOS
        public void ModificarDatos(int idCliente, string nombreCliente, string apellidoCliente, string numeroCliente,
           int idProducto, string nombreProducto, decimal precioProducto, string numeroDeStockProducto,
           int idInventario, int clienteId, int productoId, int cantidad)
        {


            using (SqlCommand cmd = new SqlCommand("ModificarDatosCompletos", cn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                cmd.Parameters.AddWithValue("@nombreCliente", nombreCliente);
                cmd.Parameters.AddWithValue("@apellidoCliente", apellidoCliente);
                cmd.Parameters.AddWithValue("@numeroCliente", numeroCliente);

                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                cmd.Parameters.AddWithValue("@nombreProducto", nombreProducto);
                cmd.Parameters.AddWithValue("@precioProducto", precioProducto);
                cmd.Parameters.AddWithValue("@numeroDeStockProducto", numeroDeStockProducto);

                cmd.Parameters.AddWithValue("@idInventario", idInventario);
                cmd.Parameters.AddWithValue("@clienteId", clienteId);
                cmd.Parameters.AddWithValue("@productoId", productoId);

                cmd.Parameters.AddWithValue("@cantidad", cantidad);

                // cn.Open();
                cmd.ExecuteNonQuery();

            }




        }









        //LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL




        /*SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);
        private static d_inventario instance;
        private d_inventario()
        {
        }

        //Metodo stactico de la instancia 
        public static d_inventario getInstance()
        {
            if (instance == null)
            {

                instance = new d_inventario();
            }

            return instance;
        }



        public DataTable D_listado()
        {
            using (SqlConnection cns = new SqlConnection("Data Source = DESKTOP-L9P4EIJ; Initial Catalog = Inventario; Integrated Security = false;Database= Inventario;uid=sa;pwd=D4y3LY123456"))
            {
                cns.Open();

                SqlCommand cmd = new SqlCommand("sp_listar", cns);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }








         public DataTable D_listado()
         {
             SqlConnection cns = new SqlConnection("server= DESKTOP-L9P4EIJ; Integrated Security=true;Database= Inventario;uid=sa;pwd=D4y3LY123456");
             {
                 cn.Open();

                 SqlCommand cmd = new SqlCommand("sp_listar", cns);
                 cmd.CommandType = CommandType.StoredProcedure;
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);

                 return dt;
             }
         }





        / public DataTable D_listado()
         {
             SqlCommand cmd = new SqlCommand("sp_listar", cn);
             cmd.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             da.Fill(dt);
             return dt;
         }





   



         public DataTable ObtenerProductosMasVendidos()
         {
             string consulta = @"
         SELECT TOP 10
             p.nombredeproducto AS Producto,
             SUM(i.cantidad) AS TotalVendido
         FROM
             inventario i
         INNER JOIN
             producto p ON i.productoid = p.idpl
         GROUP BY
             p.nombredeproducto
         ORDER BY
             TotalVendido DESC;
     ";

             using (SqlCommand cmd = new SqlCommand(consulta, cn))
             {
                 cn.Open();
                 DataTable dt = new DataTable();
                 dt.Load(cmd.ExecuteReader());
                 cn.Close();

                 return dt;
             }
         }








          public void InsertarDatosEnInventario(
      string nombreCliente,
      string apellidoCliente,
      string numeroCliente,
      string nombreProducto,
      decimal precioProducto,
      string numeroDeStockProducto,
      DateTime fechaDeCompra,
      int cantidad)
          {
              using (cn)
              {
                  cn.Open();
                  // Crear un nuevo objeto SqlCommand con el nombre del procedimiento almacenado "InsertarDatosEnInventario" y la conexión "cn".
                  SqlCommand cmd = new SqlCommand("InsertarDatosEnInventario", cn);

                  // Establecer el tipo de comando como un procedimiento almacenado.
                  cmd.CommandType = CommandType.StoredProcedure;

                  // Agregar los parámetros necesarios para la inserción.
                  cmd.Parameters.Add(new SqlParameter("@nombreCliente", SqlDbType.VarChar, 50)).Value = nombreCliente;
                  cmd.Parameters.Add(new SqlParameter("@apellidoCliente", SqlDbType.VarChar, 50)).Value = apellidoCliente;
                  cmd.Parameters.Add(new SqlParameter("@numeroCliente", SqlDbType.VarChar, 50)).Value = numeroCliente;
                  cmd.Parameters.Add(new SqlParameter("@nombreProducto", SqlDbType.VarChar, 50)).Value = nombreProducto;
                  cmd.Parameters.Add(new SqlParameter("@precioProducto", SqlDbType.Decimal)).Value = precioProducto;
                  cmd.Parameters.Add(new SqlParameter("@numeroDeStockProducto", SqlDbType.VarChar, 50)).Value = numeroDeStockProducto;
                  cmd.Parameters.Add(new SqlParameter("@fechaDeCompra", SqlDbType.DateTime)).Value = fechaDeCompra;
                  cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int)).Value = cantidad;

                  // Abrir la conexión antes de ejecutar el comando.
                  //cn.Open();

                  // Ejecutar el comando para realizar la inserción.
                  cmd.ExecuteNonQuery();

                  // Cerrar la conexión después de ejecutar el comando.
                  cn.Close();
              }
          }

          // METODO DE BORRADO DE DATOS

          public void BorrarClienteYProductos(int clienteID)
          {
              using (cn)
              {
                  using (SqlCommand cmd = new SqlCommand("BorrarClienteYProductosRelacionados", cn))
                  {
                      cmd.CommandType = CommandType.StoredProcedure;
                      cmd.Parameters.Add(new SqlParameter("@clienteID", SqlDbType.Int)).Value = clienteID;

                      cn.Open();
                      cmd.ExecuteNonQuery();

                  }
              }



          }

          //MODIFICAR DATOS
          public void ModificarDatos(int idCliente, string nombreCliente, string apellidoCliente, string numeroCliente,
             int idProducto, string nombreProducto, decimal precioProducto, string numeroDeStockProducto,
             int idInventario, int clienteId, int productoId, int cantidad)
          {
              using (cn)
              {

                  using (SqlCommand cmd = new SqlCommand("ModificarDatosCompletos", cn))
                  {
                      cmd.CommandType = System.Data.CommandType.StoredProcedure;
                      cmd.Parameters.AddWithValue("@idCliente", idCliente);
                      cmd.Parameters.AddWithValue("@nombreCliente", nombreCliente);
                      cmd.Parameters.AddWithValue("@apellidoCliente", apellidoCliente);
                      cmd.Parameters.AddWithValue("@numeroCliente", numeroCliente);

                      cmd.Parameters.AddWithValue("@idProducto", idProducto);
                      cmd.Parameters.AddWithValue("@nombreProducto", nombreProducto);
                      cmd.Parameters.AddWithValue("@precioProducto", precioProducto);
                      cmd.Parameters.AddWithValue("@numeroDeStockProducto", numeroDeStockProducto);

                      cmd.Parameters.AddWithValue("@idInventario", idInventario);
                      cmd.Parameters.AddWithValue("@clienteId", clienteId);
                      cmd.Parameters.AddWithValue("@productoId", productoId);

                      cmd.Parameters.AddWithValue("@cantidad", cantidad);

                      cn.Open();
                      cmd.ExecuteNonQuery();

                  }
              }



          }

          public DataTable BuscarDatosPorNombre(string nombreCliente)
          {
              DataTable dt = new DataTable();

              using (cn)
              {
                  try
                  {
                      cn.Open();

                      using (SqlCommand cmd = new SqlCommand("sp_BuscarDatosPorNombre", cn))
                      {
                          cmd.CommandType = CommandType.StoredProcedure;
                          cmd.Parameters.AddWithValue("@nombreCliente", nombreCliente);

                          SqlDataAdapter da = new SqlDataAdapter(cmd);
                          da.Fill(dt);
                      }
                  }
                  catch (Exception ex)
                  {
                      Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                  }
              }

              return dt;
          }*/

    }





}

















    





