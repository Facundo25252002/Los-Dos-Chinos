
namespace Los_Dos_Chinos
{
    partial class Actualizar_Stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_Stock));
            System.Windows.Forms.Label idarticuloLabel;
            System.Windows.Forms.Label detalleLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label idproveedorLabel;
            System.Windows.Forms.Label stockLabel;
            this.sUPERCHINODataSet = new Los_Dos_Chinos.SUPERCHINODataSet();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloTableAdapter = new Los_Dos_Chinos.SUPERCHINODataSetTableAdapters.articuloTableAdapter();
            this.tableAdapterManager = new Los_Dos_Chinos.SUPERCHINODataSetTableAdapters.TableAdapterManager();
            this.articuloBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.articuloBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.articuloDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idarticuloTextBox = new System.Windows.Forms.TextBox();
            this.detalleTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.idproveedorTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            idarticuloLabel = new System.Windows.Forms.Label();
            detalleLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            idproveedorLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sUPERCHINODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingNavigator)).BeginInit();
            this.articuloBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articuloDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sUPERCHINODataSet
            // 
            this.sUPERCHINODataSet.DataSetName = "SUPERCHINODataSet";
            this.sUPERCHINODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "articulo";
            this.articuloBindingSource.DataSource = this.sUPERCHINODataSet;
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.articuloTableAdapter = this.articuloTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.proveedorTableAdapter = null;
            this.tableAdapterManager.transaccionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Los_Dos_Chinos.SUPERCHINODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            this.tableAdapterManager.ventaTableAdapter = null;
            // 
            // articuloBindingNavigator
            // 
            this.articuloBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.articuloBindingNavigator.BindingSource = this.articuloBindingSource;
            this.articuloBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.articuloBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.articuloBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.articuloBindingNavigatorSaveItem});
            this.articuloBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.articuloBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.articuloBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.articuloBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.articuloBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.articuloBindingNavigator.Name = "articuloBindingNavigator";
            this.articuloBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.articuloBindingNavigator.Size = new System.Drawing.Size(917, 25);
            this.articuloBindingNavigator.TabIndex = 0;
            this.articuloBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // articuloBindingNavigatorSaveItem
            // 
            this.articuloBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.articuloBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("articuloBindingNavigatorSaveItem.Image")));
            this.articuloBindingNavigatorSaveItem.Name = "articuloBindingNavigatorSaveItem";
            this.articuloBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.articuloBindingNavigatorSaveItem.Text = "Guardar datos";
            this.articuloBindingNavigatorSaveItem.Click += new System.EventHandler(this.articuloBindingNavigatorSaveItem_Click);
            // 
            // articuloDataGridView
            // 
            this.articuloDataGridView.AutoGenerateColumns = false;
            this.articuloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articuloDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.articuloDataGridView.DataSource = this.articuloBindingSource;
            this.articuloDataGridView.Location = new System.Drawing.Point(302, 68);
            this.articuloDataGridView.Name = "articuloDataGridView";
            this.articuloDataGridView.Size = new System.Drawing.Size(546, 266);
            this.articuloDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idarticulo";
            this.dataGridViewTextBoxColumn1.HeaderText = "idarticulo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "detalle";
            this.dataGridViewTextBoxColumn2.HeaderText = "detalle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn3.HeaderText = "precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idproveedor";
            this.dataGridViewTextBoxColumn4.HeaderText = "idproveedor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "stock";
            this.dataGridViewTextBoxColumn5.HeaderText = "stock";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // idarticuloLabel
            // 
            idarticuloLabel.AutoSize = true;
            idarticuloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idarticuloLabel.Location = new System.Drawing.Point(12, 109);
            idarticuloLabel.Name = "idarticuloLabel";
            idarticuloLabel.Size = new System.Drawing.Size(77, 16);
            idarticuloLabel.TabIndex = 2;
            idarticuloLabel.Text = "idArticulo:";
            // 
            // idarticuloTextBox
            // 
            this.idarticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloBindingSource, "idarticulo", true));
            this.idarticuloTextBox.Location = new System.Drawing.Point(120, 109);
            this.idarticuloTextBox.Name = "idarticuloTextBox";
            this.idarticuloTextBox.Size = new System.Drawing.Size(147, 20);
            this.idarticuloTextBox.TabIndex = 3;
            // 
            // detalleLabel
            // 
            detalleLabel.AutoSize = true;
            detalleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            detalleLabel.Location = new System.Drawing.Point(12, 145);
            detalleLabel.Name = "detalleLabel";
            detalleLabel.Size = new System.Drawing.Size(62, 16);
            detalleLabel.TabIndex = 4;
            detalleLabel.Text = "Detalle:";
            // 
            // detalleTextBox
            // 
            this.detalleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloBindingSource, "detalle", true));
            this.detalleTextBox.Location = new System.Drawing.Point(120, 145);
            this.detalleTextBox.Name = "detalleTextBox";
            this.detalleTextBox.Size = new System.Drawing.Size(147, 20);
            this.detalleTextBox.TabIndex = 5;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(12, 187);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(57, 16);
            precioLabel.TabIndex = 6;
            precioLabel.Text = "Precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloBindingSource, "precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(120, 187);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(147, 20);
            this.precioTextBox.TabIndex = 7;
            // 
            // idproveedorLabel
            // 
            idproveedorLabel.AutoSize = true;
            idproveedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idproveedorLabel.Location = new System.Drawing.Point(12, 230);
            idproveedorLabel.Name = "idproveedorLabel";
            idproveedorLabel.Size = new System.Drawing.Size(98, 16);
            idproveedorLabel.TabIndex = 8;
            idproveedorLabel.Text = "idProveedor:";
            // 
            // idproveedorTextBox
            // 
            this.idproveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloBindingSource, "idproveedor", true));
            this.idproveedorTextBox.Location = new System.Drawing.Point(120, 230);
            this.idproveedorTextBox.Name = "idproveedorTextBox";
            this.idproveedorTextBox.Size = new System.Drawing.Size(147, 20);
            this.idproveedorTextBox.TabIndex = 9;
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockLabel.Location = new System.Drawing.Point(12, 273);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(51, 16);
            stockLabel.TabIndex = 10;
            stockLabel.Text = "Stock:";
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloBindingSource, "stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(120, 273);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(147, 20);
            this.stockTextBox.TabIndex = 11;
            // 
            // Actualizar_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(917, 366);
            this.Controls.Add(idarticuloLabel);
            this.Controls.Add(this.idarticuloTextBox);
            this.Controls.Add(detalleLabel);
            this.Controls.Add(this.detalleTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(idproveedorLabel);
            this.Controls.Add(this.idproveedorTextBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.articuloDataGridView);
            this.Controls.Add(this.articuloBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Actualizar_Stock";
            this.Text = "Actualizar Stock";
            this.Load += new System.EventHandler(this.Actualizar_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sUPERCHINODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingNavigator)).EndInit();
            this.articuloBindingNavigator.ResumeLayout(false);
            this.articuloBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articuloDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SUPERCHINODataSet sUPERCHINODataSet;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private SUPERCHINODataSetTableAdapters.articuloTableAdapter articuloTableAdapter;
        private SUPERCHINODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator articuloBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton articuloBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView articuloDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox idarticuloTextBox;
        private System.Windows.Forms.TextBox detalleTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox idproveedorTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
    }
}