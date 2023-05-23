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
    public partial class Vista_Stock : Form
    {
        public Vista_Stock()
        {
            InitializeComponent();
        }

        private void articuloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.articuloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sUPERCHINODataSet);

        }

        private void Actualizar_Stock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sUPERCHINODataSet.articulo' Puede moverla o quitarla según sea necesario.
            this.articuloTableAdapter.Fill(this.sUPERCHINODataSet.articulo);

        }
    }
}
