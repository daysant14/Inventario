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
namespace capapresentacion
{
    public partial class Agregar_inventario : Form
    {
        d_inventario acceso = d_inventario.getInstance();
        //d_inventario acceso = new d_inventario();
        public Agregar_inventario()
        {
            InitializeComponent();
        } 



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_inventario_Load(object sender, EventArgs e)
        {

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnocultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
          
        }

        private void aumentar_Click(object sender, EventArgs e)
        {
            //comando para maximixzar la pagina
            this.WindowState = FormWindowState.Maximized;
            aumentar1.Visible = false;
            disminuir1.Visible = true;
        }

        private void disminuir_Click(object sender, EventArgs e)
        {
            //comando para minimizar la pagina
            this.WindowState = FormWindowState.Normal;
            disminuir1.Visible = false;
            aumentar1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados en las cajas de texto
            string nombreCliente = namecliente.Text;
            string apellidoCliente = apellidocliente.Text;
            string NumeroCliente= numbercliente.Text;
            string NombreProducto = producto.Text;
            decimal precioProducto = decimal.Parse(precio.Text);
            string NumeroDeStockProducto = stork.Text;
            int cantidad = int.Parse(cantida.Text);

                 



            // Llamar al método InsertarDatos para insertar los datos en la base de datos
           acceso.InsertarDatosEnInventario(nombreCliente, apellidoCliente, NumeroCliente,
           NombreProducto, precioProducto, NumeroDeStockProducto, DateTime.Now, cantidad);

            namecliente.Clear();
            apellidocliente.Clear();
            numbercliente.Clear();
            producto.Clear();
            precio.Clear();
            stork.Clear();
            cantida.Clear();



            MessageBox.Show("Se han guardado los datos");
            if (Application.OpenForms["inventario"] is inventario inventarioForm)
            {
                inventarioForm.RefrescarDataGridViewDesdeOtroFormulario();
            }

            // Cierra el formulario actual
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del elemento a borrar (por ejemplo, de una caja de texto)
            /*string nombre = namecliente.Text;

            // Llamar al método BorrarDatoPorNombre para borrar el elemento por nombre
            objinventario.BorrarDatoPorNombre(nombre);
            namecliente.Clear();
            apellidocliente.Clear();
            numbercliente.Clear();
            producto.Clear();
            precio.Clear();
            datecompra.Clear();
            cantida.Clear();*/
          

        }
    }
}
