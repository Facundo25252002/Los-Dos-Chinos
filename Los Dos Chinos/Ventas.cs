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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void ventaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.ventaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sUPERCHINODataSet);

            }
            catch {

                MessageBox.Show("Complete todos los campos , Por favor ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sUPERCHINODataSet.venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.sUPERCHINODataSet.venta);

        }
    }
}
