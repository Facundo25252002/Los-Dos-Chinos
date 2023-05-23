
namespace Los_Dos_Chinos
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionControl = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionStock = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.camToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionCam = new System.Windows.Forms.ToolStripMenuItem();
            this.generarCodigoDeBarrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoDeBarrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.camToolStripMenuItem,
            this.generarCodigoDeBarrasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(667, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcionControl,
            this.OpcionProveedores});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // OpcionControl
            // 
            this.OpcionControl.BackColor = System.Drawing.SystemColors.Highlight;
            this.OpcionControl.Image = ((System.Drawing.Image)(resources.GetObject("OpcionControl.Image")));
            this.OpcionControl.Name = "OpcionControl";
            this.OpcionControl.Size = new System.Drawing.Size(228, 22);
            this.OpcionControl.Text = "Control de Usuarios";
            this.OpcionControl.Click += new System.EventHandler(this.OpcionControl_Click);
            // 
            // OpcionProveedores
            // 
            this.OpcionProveedores.BackColor = System.Drawing.SystemColors.Highlight;
            this.OpcionProveedores.Image = ((System.Drawing.Image)(resources.GetObject("OpcionProveedores.Image")));
            this.OpcionProveedores.Name = "OpcionProveedores";
            this.OpcionProveedores.Size = new System.Drawing.Size(228, 22);
            this.OpcionProveedores.Text = "Proveedores";
            this.OpcionProveedores.Click += new System.EventHandler(this.OpcionProveedores_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue;
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcionStock,
            this.OpcionVentas});
            this.inventarioToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // OpcionStock
            // 
            this.OpcionStock.BackColor = System.Drawing.SystemColors.Highlight;
            this.OpcionStock.Image = ((System.Drawing.Image)(resources.GetObject("OpcionStock.Image")));
            this.OpcionStock.Name = "OpcionStock";
            this.OpcionStock.Size = new System.Drawing.Size(127, 22);
            this.OpcionStock.Text = "Stock";
            this.OpcionStock.Click += new System.EventHandler(this.OpcionStock_Click);
            // 
            // OpcionVentas
            // 
            this.OpcionVentas.BackColor = System.Drawing.SystemColors.Highlight;
            this.OpcionVentas.Image = ((System.Drawing.Image)(resources.GetObject("OpcionVentas.Image")));
            this.OpcionVentas.Name = "OpcionVentas";
            this.OpcionVentas.Size = new System.Drawing.Size(127, 22);
            this.OpcionVentas.Text = "Ventas";
            this.OpcionVentas.Click += new System.EventHandler(this.OpcionVentas_Click);
            // 
            // camToolStripMenuItem
            // 
            this.camToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue;
            this.camToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcionCam});
            this.camToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camToolStripMenuItem.Name = "camToolStripMenuItem";
            this.camToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.camToolStripMenuItem.Text = "Cam";
            // 
            // OpcionCam
            // 
            this.OpcionCam.BackColor = System.Drawing.SystemColors.Highlight;
            this.OpcionCam.Image = ((System.Drawing.Image)(resources.GetObject("OpcionCam.Image")));
            this.OpcionCam.Name = "OpcionCam";
            this.OpcionCam.Size = new System.Drawing.Size(180, 22);
            this.OpcionCam.Text = "Camara";
            this.OpcionCam.Click += new System.EventHandler(this.OpcionCam_Click);
            // 
            // generarCodigoDeBarrasToolStripMenuItem
            // 
            this.generarCodigoDeBarrasToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue;
            this.generarCodigoDeBarrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codigoDeBarrasToolStripMenuItem});
            this.generarCodigoDeBarrasToolStripMenuItem.Name = "generarCodigoDeBarrasToolStripMenuItem";
            this.generarCodigoDeBarrasToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.generarCodigoDeBarrasToolStripMenuItem.Text = "Generar Codigo";
            // 
            // codigoDeBarrasToolStripMenuItem
            // 
            this.codigoDeBarrasToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.codigoDeBarrasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.codigoDeBarrasToolStripMenuItem.Name = "codigoDeBarrasToolStripMenuItem";
            this.codigoDeBarrasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codigoDeBarrasToolStripMenuItem.Text = "Codigo De Barras";
            this.codigoDeBarrasToolStripMenuItem.Click += new System.EventHandler(this.codigoDeBarrasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue;
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcionSalir});
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // OpcionSalir
            // 
            this.OpcionSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.OpcionSalir.Image = ((System.Drawing.Image)(resources.GetObject("OpcionSalir.Image")));
            this.OpcionSalir.Name = "OpcionSalir";
            this.OpcionSalir.Size = new System.Drawing.Size(110, 22);
            this.OpcionSalir.Text = "Salir";
            this.OpcionSalir.Click += new System.EventHandler(this.OpcionSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion de Sistema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Menu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(667, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpcionControl;
        private System.Windows.Forms.ToolStripMenuItem OpcionProveedores;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpcionStock;
        private System.Windows.Forms.ToolStripMenuItem OpcionVentas;
        private System.Windows.Forms.ToolStripMenuItem camToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpcionCam;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpcionSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem generarCodigoDeBarrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoDeBarrasToolStripMenuItem;
    }
}