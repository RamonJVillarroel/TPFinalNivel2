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
            this.pboxArticulo = new System.Windows.Forms.PictureBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.expDetalle = new System.Windows.Forms.Label();
            this.toolNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxArticulo)).BeginInit();
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
            this.toolNavegacion.Location = new System.Drawing.Point(572, 0);
            this.toolNavegacion.Name = "toolNavegacion";
            this.toolNavegacion.Size = new System.Drawing.Size(24, 262);
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
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 50);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(280, 168);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pboxArticulo
            // 
            this.pboxArticulo.Location = new System.Drawing.Point(298, 50);
            this.pboxArticulo.Name = "pboxArticulo";
            this.pboxArticulo.Size = new System.Drawing.Size(265, 168);
            this.pboxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxArticulo.TabIndex = 2;
            this.pboxArticulo.TabStop = false;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(35, 21);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 3;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // expDetalle
            // 
            this.expDetalle.AutoSize = true;
            this.expDetalle.Location = new System.Drawing.Point(116, 26);
            this.expDetalle.Name = "expDetalle";
            this.expDetalle.Size = new System.Drawing.Size(213, 13);
            this.expDetalle.TabIndex = 4;
            this.expDetalle.Text = "Permite ver el detalle de la fila seleccionada";
            // 
            // CatalogoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(596, 262);
            this.Controls.Add(this.expDetalle);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.pboxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.toolNavegacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatalogoApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo App";
            this.Load += new System.EventHandler(this.CatalogoApp_Load);
            this.toolNavegacion.ResumeLayout(false);
            this.toolNavegacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolNuevoArticulo;
        private System.Windows.Forms.ToolStrip toolNavegacion;
        private System.Windows.Forms.ToolStripButton toolBusqueda;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pboxArticulo;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label expDetalle;
    }
}

