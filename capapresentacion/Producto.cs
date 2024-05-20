using capanegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capadatos;
using capanegocios;

namespace capapresentacion
{
    public partial class reportedeventas : Form
    {//d_inventario lilo = new d_inventario();
     //d_inventario lilo = d_inventario.getInstance();
     // d_inventario acceso = new d_inventario();
        d_inventario acceso = d_inventario.getInstance();
        public reportedeventas()
        {
            InitializeComponent();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimizar1_Click(object sender, EventArgs e)
        {
            //comando para maximixzar la pagina
            this.WindowState = FormWindowState.Maximized;
            mazimizar1.Visible = false;
            btnminimizar1.Visible = true;
        }

        private void mazimizar1_Click(object sender, EventArgs e)
        {
            //comando para minimizar la pagina
            this.WindowState = FormWindowState.Normal;
            btnminimizar1.Visible = false;
            mazimizar1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form dy = new inventario();
            dy.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportedeventas_Load(object sender, EventArgs e)
        {
            CargarProductosMasVendidos();

        }

        private void CargarProductosMasVendidos()
        {
            DataTable dtProductosMasVendidos = acceso.ObtenerProductosMasVendidos(); // Usar el método para obtener productos más vendidos

            dataGridView1.DataSource = dtProductosMasVendidos;
        }

        private void btnocultar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        /*private void CargarProductosMasVendidos()
        {
            // Llamamos a un método en la capa de Negocio para obtener los datos
            NegocioProductos negocio = new NegocioProductos();
            string[] productosMasVendidos = negocio.ObtenerProductosMasVendidos();

            // Limpia cualquier dato anterior en el DataGridView
            dataGridView1.Rows.Clear();

            // Agrega cada string al DataGridView
            foreach (string producto in productosMasVendidos)
            {
                dataGridView1.Rows.Add(producto); // Agrega directamente el string
            }
        }*/





        /*private void CargarProductosMasVendidos()
        {
            // Llamamos a un método en la capa de Negocio para obtener los datos
            NegocioProductos negocio = new NegocioProductos();
            string[] productosMasVendidos = negocio.ObtenerProductosMasVendidos();

            // Limpia cualquier dato anterior en el DataGridView
            dataGridView1.Rows.Clear();

            // Agrega cada fila de datos al DataGridView
            foreach (string[] producto in productosMasVendidos)
            {
                dataGridView1.Rows.Add(producto);
            }
        }*/











        //AQUI


        /*private void CargarProductosMasVendidos()
        {
            // Llamamos a un método en la capa de Negocio para obtener los datos
            NegocioProductos negocio = new NegocioProductos();
            string[] productosMasVendidos = negocio.ObtenerProductosMasVendidos();

            // Configuramos el DataGridView
            dataGridView1.Columns.Add("NombreProducto", "Nombre del Producto");
            dataGridView1.Columns.Add("CantidadVendida", "Cantidad Vendida");

            // Agregamos los datos al DataGridView
            foreach (string producto in productosMasVendidos)
            {
                string[] productoData = producto.Split(':');
                dataGridView1.Rows.Add(productoData[0], productoData[1]);
            }
        }*/

    }
}
