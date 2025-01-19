namespace presentacion
{
    partial class CatalogoApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoApp));
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolNuevoArticulo = new System.Windows.Forms.ToolStripButton();
            this.toolNavegacion = new System.Windows.Forms.ToolStrip();
            this.toolBusqueda = new System.Windows.Forms.ToolStripButton();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.toolNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(21, 6);
            // 
            // toolNuevoArticulo
            // 
            this.toolNuevoArticulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNuevoArticulo.Image = ((System.Drawing.Image)(resources.GetObject("toolNuevoArticulo.Image")));
            this.toolNuevoArticulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNuevoArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.toolNuevoArticulo.Name = "toolNuevoArticulo";
            this.toolNuevoArticulo.Size = new System.Drawing.Size(21, 20);
            this.toolNuevoArticulo.Text = "Nuevo Articulo";
            this.toolNuevoArticulo.Click += new System.EventHandler(this.toolNuevoArticulo_Click);
            // 
            // toolNavegacion
            // 
            this.toolNavegacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolNavegacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolNuevoArticulo,
            this.toolBusqueda});
            this.toolNavegacion.Location = new System.Drawing.Point(712, 0);
            this.toolNavegacion.Name = "toolNavegacion";
            this.toolNavegacion.Size = new System.Drawing.Size(24, 320);
            this.toolNavegacion.TabIndex = 0;
            this.toolNavegacion.Text = "Menu";
            // 
            // toolBusqueda
            // 
            this.toolBusqueda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("toolBusqueda.Image")));
            this.toolBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBusqueda.Margin = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.toolBusqueda.Name = "toolBusqueda";
            this.toolBusqueda.Size = new System.Drawing.Size(21, 20);
            this.toolBusqueda.Text = "Nueva Busqueda";
            this.toolBusqueda.Click += new System.EventHandler(this.toolBusqueda_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(-2, 25);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(711, 150);
            this.dgvArticulos.TabIndex = 1;
            // 
            // CatalogoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(736, 320);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.toolNavegacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatalogoApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo App";
            this.toolNavegacion.ResumeLayout(false);
            this.toolNavegacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolNuevoArticulo;
        private System.Windows.Forms.ToolStrip toolNavegacion;
        private System.Windows.Forms.ToolStripButton toolBusqueda;
        private System.Windows.Forms.DataGridView dgvArticulos;
    }
}

