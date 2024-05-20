using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capadatos;

namespace capapresentacion
{
    public partial class modificar_producto : Form
    {
        //d_inventario objainventario3 = new d_inventario();
        d_inventario acceso = d_inventario.getInstance();
       // d_inventario acceso = new d_inventario();
        public modificar_producto()
        {
            InitializeComponent();
        }

        private void maxi_Click(object sender, EventArgs e)
        {
            //comando para maximixzar la pagina
            this.WindowState = FormWindowState.Maximized;
            maxi.Visible = false;
            mini.Visible = true;
        }

        private void mini_Click(object sender, EventArgs e)
        {
            //comando para minimizar la pagina
            this.WindowState = FormWindowState.Normal;
            mini.Visible = false;
            maxi.Visible = true;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnocultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {






            // Obtener los valores ingresados en las cajas de texto
            int idCliente = int.Parse(idcliente1.Text);
            string nombreCliente = nameclient.Text;
            string apellidoCliente = apellidoclient.Text;
            string numeroCliente = clientnumber.Text;
            int idProducto = int.Parse(idproducto.Text);
            string nombreProducto = produ.Text;
            decimal precioProducto = decimal.Parse(preci0.Text);
            string numeroDeStockProducto = numstork.Text;
            int idInventario = int.Parse(idinventario.Text);
            int clienteId = int.Parse(idcliente20.Text);
            int productoId = int.Parse(idproducto.Text);
            int cantidad = int.Parse(cantid4.Text);

            

            acceso.ModificarDatos(idCliente, nombreCliente, apellidoCliente, numeroCliente,
               idProducto, nombreProducto, precioProducto, numeroDeStockProducto,
               idInventario, clienteId, productoId,  cantidad);

            idcliente1.Clear();
            nameclient.Clear();
            apellidoclient.Clear();
            clientnumber.Clear();
            idproducto.Clear(); 
            produ.Clear();
            preci0.Clear();
            numstork.Clear();
            idinventario.Clear();
            idcliente20.Clear();
            idproducto.Clear();
            cantid4.Clear();

            if (Application.OpenForms["inventario"] is inventario inventarioForm)
            {
                inventarioForm.RefrescarDataGridViewDesdeOtroFormulario();
            }

            // Cierra el formulario actual
            this.Close();


            MessageBox.Show("Modificación completa.");











            /* // Obtener los valores ingresados en las cajas de texto
             int idcliente2 = int.Parse(idcliente1.Text);
             string nombreCliente2 = nameclient.Text;
             string apellidoCliente2 = apellidoclient.Text;
             string NumeroCliente2 = clientnumber.Text;
             int idProducto = int.Parse(idproducto.Text);
             string NombreProducto2 = produ.Text;
             decimal precioProducto2 = decimal.Parse(preci0.Text);
             string NumeroDeStockProducto2 = numstork.Text;
             int idInventario = int.Parse(idinventario.Text);
             int idcliente3 = int.Parse(idcliente20.Text);
             int productoid = int.Parse(idproducto.Text);
             int cantidad2 = int.Parse(cantid4.Text);

             DateTime fechaDeCompra = dateTimePickerFechaDeCompra.Value;

             objainventario3.ModificarDatos(idcliente2, nombreCliente2, apellidoCliente2, NumeroCliente2,
                idProducto, NombreProducto2, precioProducto2, NumeroDeStockProducto2, idcliente2,
                idInventario, idcliente3, productoid, fechaDeCompra, cantidad2);

             Console.WriteLine("Modificación completa.");*/












            /*// Obtener los valores ingresados en las cajas de texto
            int idcliente2 = int.Parse(idcliente1.Text);
            string nombreCliente2 = nameclient.Text;
            string apellidoCliente2 = apellidoclient.Text;
            string NumeroCliente2 = clientnumber.Text;
            int idProducto = int.Parse(idproducto.Text);
            string NombreProducto2 = produ.Text;
            decimal precioProducto2 = decimal.Parse(preci0.Text);
            string NumeroDeStockProducto2 = numstork.Text;
            int idInventario= int.Parse(idinventario.Text);
            int idcliente3 = int.Parse(idcliente20.Text);
            int productoid= int.Parse(idproducto.Text); 
            int cantidad2= int.Parse(cantid4.Text);

            DateTime fechaDeCompra = dateTimePickerFechaDeCompra.Value;

            objainventario3.ModificarDatos(idcliente2, nombreCliente2, apellidoCliente2, NumeroCliente2,
           idProducto, NombreProducto2, precioProducto2, NumeroDeStockProducto2, idcliente2,
           idInventario, idcliente3, productoid, DateTime fechaDeCompra, cantidad2);

            Console.WriteLine("Modificación completa.");*/


        }

        private void modificar_producto_Load(object sender, EventArgs e)
        { 

        }
    }
}
