using capaentidad;
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
using System.IO;


namespace capapresentacion
{
    public partial class inventario : Form
    {
        //d_inventario acceso = d_inventario.getInstance();
        //d_inventario acceso = new d_inventario();
        d_inventario acceso = d_inventario.getInstance();
        public void RefrescarDataGridViewDesdeOtroFormulario()
        {
            ListarEmpleado(); // Vuelve a cargar los datos desde la base de datos y actualiza el DataGridView.
        }

        public inventario(int adm)
        {
            InitializeComponent();

            if (adm!=0)
            {

            }
        }


        public inventario()
        {
            InitializeComponent();
            borrarin.Enabled = false;   
            modificarin.Enabled= false; 
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            ListarEmpleado();



        }
        e_inventario objentidad = new e_inventario();
        n_inventario objnegocio = new n_inventario();
        void ListarEmpleado()
        {
            DataTable dt
            = objnegocio.N_listado();
            dataGridView1.DataSource = dt;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            //comando para minimizar la pagina
            this.WindowState = FormWindowState.Normal;
            btnminimizar.Visible = false;
            mazimizar.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //comando para maximixzar la pagina
            this.WindowState = FormWindowState.Maximized;
            mazimizar.Visible = false;
            btnminimizar.Visible = true;
        }

        private void btnocultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombreCliente = buscar2.Text; // Obtén el nombre del cliente desde tu control

            DataTable dt = acceso.BuscarDatosPorNombre(nombreCliente);

            // Asigna el DataTable a un control DataGridView o ListBox, etc.
            dataGridView1.DataSource = dt;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form dy = new modificar_producto();
            dy.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form dy = new Agregar_inventario();
            dy.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form dy = new Productos();
            dy.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form dy = new reportedeventas();
            dy.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form dy = new borrarinventario();
            dy.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form dy = new inventario();
            dy.ShowDialog();
        }
    }
}
