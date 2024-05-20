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
using capanegocios;



namespace capapresentacion
{
    public partial class Productos : Form
    {
       // d_inventario inventario= new d_inventario();
        public Productos()
        {
            InitializeComponent();
        }

        private void Agregar_Producto_Load(object sender, EventArgs e)
        {
            
        }
        e_inventario objentidad = new e_inventario();
        n_inventario objnegocio = new n_inventario();
        
        private void btnborrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            //comando para maximixzar la pagina
            this.WindowState = FormWindowState.Maximized;
            aumentar.Visible = false;
            disminuir.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //comando para minimizar la pagina
            this.WindowState = FormWindowState.Normal;
            disminuir.Visible = false;
            aumentar.Visible = true;
        }

        private void btnocultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mazimizar_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form dy = new inventario();
            dy.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form dy = new reportedeventas();
            dy.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            MessageBox.Show("Se han guardado los datos");
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

        }
    }
}
