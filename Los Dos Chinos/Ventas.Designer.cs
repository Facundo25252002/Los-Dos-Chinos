
namespace Los_Dos_Chinos
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            System.Windows.Forms.Label idventaLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label montoLabel;
            System.Windows.Forms.Label idusuarioLabel;
            this.sUPERCHINODataSet = new Los_Dos_Chinos.SUPERCHINODataSet();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaTableAdapter = new Los_Dos_Chinos.SUPERCHINODataSetTableAdapters.ventaTableAdapter();
            this.tableAdapterManager = new Los_Dos_Chinos.SUPERCHINODataSetTableAdapters.TableAdapterManager();
            this.ventaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ventaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ventaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idventaTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.idusuarioTextBox = new System.Windows.Forms.TextBox();
            idventaLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();
            idusuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sUPERCHINODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingNavigator)).BeginInit();
            this.ventaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sUPERCHINODataSet
            // 
            this.sUPERCHINODataSet.DataSetName = "SUPERCHINODataSet";
            this.sUPERCHINODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "venta";
            this.ventaBindingSource.DataSource = this.sUPERCHINODataSet;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.articuloTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.proveedorTableAdapter = null;
            this.tableAdapterManager.transaccionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Los_Dos_Chinos.SUPERCHINODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            this.tableAdapterManager.ventaTableAdapter = this.ventaTableAdapter;
            // 
            // ventaBindingNavigator
            // 
            this.ventaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ventaBindingNavigator.BindingSource = this.ventaBindingSource;
            this.ventaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ventaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ventaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ventaBindingNavigatorSaveItem});
            this.ventaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ventaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ventaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ventaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ventaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ventaBindingNavigator.Name = "ventaBindingNavigator";
            this.ventaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ventaBindingNavigator.Size = new System.Drawing.Size(807, 25);
            this.ventaBindingNavigator.TabIndex = 0;
            this.ventaBindingNavigator.Text = "bindingNavigator1";
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
            // ventaBindingNavigatorSaveItem
            // 
            this.ventaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ventaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ventaBindingNavigatorSaveItem.Image")));
            this.ventaBindingNavigatorSaveItem.Name = "ventaBindingNavigatorSaveItem";
            this.ventaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ventaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.ventaBindingNavigatorSaveItem.Click += new System.EventHandler(this.ventaBindingNavigatorSaveItem_Click);
            // 
            // ventaDataGridView
            // 
            this.ventaDataGridView.AutoGenerateColumns = false;
            this.ventaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ventaDataGridView.DataSource = this.ventaBindingSource;
            this.ventaDataGridView.Location = new System.Drawing.Point(326, 80);
            this.ventaDataGridView.Name = "ventaDataGridView";
            this.ventaDataGridView.Size = new System.Drawing.Size(449, 220);
            this.ventaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idventa";
            this.dataGridViewTextBoxColumn1.HeaderText = "idventa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "monto";
            this.dataGridViewTextBoxColumn3.HeaderText = "monto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idusuario";
            this.dataGridViewTextBoxColumn4.HeaderText = "idusuario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // idventaLabel
            // 
            idventaLabel.AutoSize = true;
            idventaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idventaLabel.Location = new System.Drawing.Point(12, 127);
            idventaLabel.Name = "idventaLabel";
            idventaLabel.Size = new System.Drawing.Size(65, 16);
            idventaLabel.TabIndex = 2;
            idventaLabel.Text = "IdVenta:";
            // 
            // idventaTextBox
            // 
            this.idventaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "idventa", true));
            this.idventaTextBox.Location = new System.Drawing.Point(106, 123);
            this.idventaTextBox.Name = "idventaTextBox";
            this.idventaTextBox.Size = new System.Drawing.Size(200, 20);
            this.idventaTextBox.TabIndex = 3;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(12, 154);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(55, 16);
            fechaLabel.TabIndex = 4;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventaBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(106, 150);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 5;
            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            montoLabel.Location = new System.Drawing.Point(12, 179);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(54, 16);
            montoLabel.TabIndex = 6;
            montoLabel.Text = "Monto:";
            // 
            // montoTextBox
            // 
            this.montoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "monto", true));
            this.montoTextBox.Location = new System.Drawing.Point(106, 176);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(200, 20);
            this.montoTextBox.TabIndex = 7;
            // 
            // idusuarioLabel
            // 
            idusuarioLabel.AutoSize = true;
            idusuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idusuarioLabel.Location = new System.Drawing.Point(12, 205);
            idusuarioLabel.Name = "idusuarioLabel";
            idusuarioLabel.Size = new System.Drawing.Size(79, 16);
            idusuarioLabel.TabIndex = 8;
            idusuarioLabel.Text = "IdUsuario:";
            // 
            // idusuarioTextBox
            // 
            this.idusuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "idusuario", true));
            this.idusuarioTextBox.Location = new System.Drawing.Point(106, 205);
            this.idusuarioTextBox.Name = "idusuarioTextBox";
            this.idusuarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.idusuarioTextBox.TabIndex = 9;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(idventaLabel);
            this.Controls.Add(this.idventaTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(montoLabel);
            this.Controls.Add(this.montoTextBox);
            this.Controls.Add(idusuarioLabel);
            this.Controls.Add(this.idusuarioTextBox);
            this.Controls.Add(this.ventaDataGridView);
            this.Controls.Add(this.ventaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sUPERCHINODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingNavigator)).EndInit();
            this.ventaBindingNavigator.ResumeLayout(false);
            this.ventaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SUPERCHINODataSet sUPERCHINODataSet;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private SUPERCHINODataSetTableAdapters.ventaTableAdapter ventaTableAdapter;
        private SUPERCHINODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ventaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ventaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ventaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox idventaTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.TextBox idusuarioTextBox;
    }
}