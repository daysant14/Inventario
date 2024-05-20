using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capadatos;
using capaentidad;
using System.Data;
using capadatos;
using static capadatos.d_inventario;

namespace capanegocios
{
    public class n_inventario
    {
        //d_inventario objdato = new d_inventario();
        // d_inventario acceso = d_inventario.getInstance();
        //d_inventario acceso = new d_inventario();
        d_inventario acceso = d_inventario.getInstance();
        public DataTable N_listado()
        {
            return acceso.D_listado();
        }

       
        
        //
      
    }


    //AQUI
   /*public class NegocioProductos
    {
        public string[] ObtenerProductosMasVendidos()
        {
            DatosProductos datos = new DatosProductos(); // Instancia de la capa de Datos
            return datos.ObtenerProductosMasVendidos(); // Llamada al método en la capa de Datos
        }
    }*/

        /* public class NegocioProductos
         {
             public string[] ObtenerProductosMasVendidos()
             {
                 DatosProductos datos = new DatosProductos();
                 return datos.ObtenerProductosMasVendidos();
             }
         }*/







    }
