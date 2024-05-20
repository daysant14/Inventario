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
    public partial class borrarinventario : Form
    {
        //d_inventario operacionesBD = new d_inventario();

        //OperacionesBD operacionesBD = new OperacionesBD();
        //d_inventario acceso = new d_inventario();
        d_inventario acceso = d_inventario.getInstance();

        public borrarinventario()
        {
            InitializeComponent();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnocultar_Click(object sender, EventArgs e)
        {
           this.WindowState=FormWindowState.Minimized;  
        }

        private void disminuir1_Click(object sender, EventArgs e)
        {
            //comando para minimizar la pagina
            this.WindowState = FormWindowState.Normal;
            disminuir2.Visible = false;
            aumentar2.Visible = true;
        }

        private void aumentar2_Click(object sender, EventArgs e)
        {
            //comando para maximixzar la pagina
            this.WindowState = FormWindowState.Maximized;
            aumentar2.Visible = false;
            disminuir2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int clienteID = int.Parse(borrarcliente.Text);
          
            acceso.BorrarClienteYProductos(clienteID);

            if (Application.OpenForms["inventario"] is inventario inventarioForm)
            {
                inventarioForm.RefrescarDataGridViewDesdeOtroFormulario();
            }

            // Cierra el formulario actual
            this.Close();

            MessageBox.Show("Cliente y productos relacionados borrados exitosamente.");
        }
    }
}
