using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Los_Dos_Chinos
{
    public partial class MenuOperador : Form
    {
        public MenuOperador()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void OpcionControl_Click(object sender, EventArgs e)
        {
            Control_de_usuarios opcion2 = new Control_de_usuarios();
            opcion2.Show();
            
        }

        private void OpcionProveedores_Click(object sender, EventArgs e)
        {
            Proveedores opcion3 = new Proveedores();
            opcion3.Show();
            
        }

        private void OpcionStock_Click(object sender, EventArgs e)
        {
            Vista_Stock opcion10 = new Vista_Stock();
            opcion10.Show();
            
        }

        private void OpcionVentas_Click(object sender, EventArgs e)
        {
            Ventas opcion5 = new Ventas();
            opcion5.Show();
            
        }

        private void OpcionCam_Click(object sender, EventArgs e)
        {
            Cam_Vigilancia opcion6 = new Cam_Vigilancia();
            opcion6.Show();
            
        }

        private void OpcionSalir_Click(object sender, EventArgs e)
        {
             Login opcion7 = new Login();
            opcion7.Show();
            this.Hide();
        }   
    }
}
