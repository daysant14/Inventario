using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capadatos;
using capaentidad;
using capanegocios;

namespace capapresentacion
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        private void p_inventario_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //comando para maximixzar la pagina
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            botonrestaurar.Visible = true;
        }

        private void barraloguin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonrestaurar_Click(object sender, EventArgs e)
        {
            //comando para minimizar la pagina
            this.WindowState = FormWindowState.Normal;
            botonrestaurar.Visible = false;
            btnmaximizar.Visible = true;
      
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void botondeacceso_Click(object sender, EventArgs e)
        {
           /* Form dy = new inventario();
            dy.ShowDialog();*/
           //d_inventario acceso = d_inventario.getInstance();    
            string nombre = usuario.Text;
            string pass = contraseña.Text;

            if (nombre.Equals("day") && pass.Equals("12345"))
            {
                inventario loguin = new inventario(1);
                loguin.Show();
                this.Hide();
            
            }
          


            if (nombre.Equals("lola") && pass.Equals("12345"))
            {
                inventario loguin = new inventario();
                loguin.Show();
                this.Hide();

            }
           
        }
    }
}
