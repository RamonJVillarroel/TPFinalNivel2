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
            this.toolEliminar = new System.Windows.Forms.ToolStripButton();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pboxArticulo = new System.Windows.Forms.PictureBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.expDetalle = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarMPrecio = new System.Windows.Forms.Button();
            this.lbPrecioMayor = new System.Windows.Forms.Label();
            this.lbPrecioMenor = new System.Windows.Forms.Label();
            this.btnPrecioMenor = new System.Windows.Forms.Button();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
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
            this.toolEliminar});
            this.toolNavegacion.Location = new System.Drawing.Point(518, 0);
            this.toolNavegacion.Name = "toolNavegacion";
            this.toolNavegacion.Size = new System.Drawing.Size(24, 330);
            this.toolNavegacion.TabIndex = 6;
            this.toolNavegacion.Text = "Menu";
            // 
            // toolEliminar
            // 
            this.toolEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolEliminar.Image")));
            this.toolEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEliminar.Name = "toolEliminar";
            this.toolEliminar.Size = new System.Drawing.Size(21, 20);
            this.toolEliminar.Text = "Elimina el articulo";
            this.toolEliminar.Click += new System.EventHandler(this.toolEliminar_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(35, 50);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(280, 200);
            this.dgvArticulos.TabIndex = 10;
            this.dgvArticulos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvArticulos_CellFormatting);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pboxArticulo
            // 
            this.pboxArticulo.Location = new System.Drawing.Point(321, 50);
            this.pboxArticulo.Name = "pboxArticulo";
            this.pboxArticulo.Size = new System.Drawing.Size(164, 200);
            this.pboxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxArticulo.TabIndex = 2;
            this.pboxArticulo.TabStop = false;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(35, 21);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 0;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // expDetalle
            // 
            this.expDetalle.AutoSize = true;
            this.expDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDetalle.Location = new System.Drawing.Point(116, 26);
            this.expDetalle.Name = "expDetalle";
            this.expDetalle.Size = new System.Drawing.Size(271, 16);
            this.expDetalle.TabIndex = 11;
            this.expDetalle.Text = "Permite ver el detalle de la fila seleccionada";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(301, 255);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(146, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Busqueda rapida por nombre, junta 3 letras";
            // 
            // btnBuscarMPrecio
            // 
            this.btnBuscarMPrecio.Location = new System.Drawing.Point(220, 278);
            this.btnBuscarMPrecio.Name = "btnBuscarMPrecio";
            this.btnBuscarMPrecio.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMPrecio.TabIndex = 2;
            this.btnBuscarMPrecio.Text = "Buscar";
            this.btnBuscarMPrecio.UseVisualStyleBackColor = true;
            this.btnBuscarMPrecio.Click += new System.EventHandler(this.btnBuscarMPrecio_Click);
            // 
            // lbPrecioMayor
            // 
            this.lbPrecioMayor.AutoSize = true;
            this.lbPrecioMayor.Location = new System.Drawing.Point(32, 283);
            this.lbPrecioMayor.Name = "lbPrecioMayor";
            this.lbPrecioMayor.Size = new System.Drawing.Size(179, 13);
            this.lbPrecioMayor.TabIndex = 8;
            this.lbPrecioMayor.Text = "Busca por precios mayores a 10.000";
            // 
            // lbPrecioMenor
            // 
            this.lbPrecioMenor.AutoSize = true;
            this.lbPrecioMenor.Location = new System.Drawing.Point(32, 307);
            this.lbPrecioMenor.Name = "lbPrecioMenor";
            this.lbPrecioMenor.Size = new System.Drawing.Size(180, 13);
            this.lbPrecioMenor.TabIndex = 9;
            this.lbPrecioMenor.Text = "Busca por precios menores a 10.000";
            // 
            // btnPrecioMenor
            // 
            this.btnPrecioMenor.Location = new System.Drawing.Point(220, 302);
            this.btnPrecioMenor.Name = "btnPrecioMenor";
            this.btnPrecioMenor.Size = new System.Drawing.Size(75, 23);
            this.btnPrecioMenor.TabIndex = 3;
            this.btnPrecioMenor.Text = "Buscar";
            this.btnPrecioMenor.UseVisualStyleBackColor = true;
            this.btnPrecioMenor.Click += new System.EventHandler(this.btnPrecioMenor_Click);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(298, 283);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(96, 13);
            this.lbCategoria.TabIndex = 12;
            this.lbCategoria.Text = "Categoria a buscar";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(301, 297);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 4;
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Location = new System.Drawing.Point(428, 295);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCategoria.TabIndex = 5;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargar.Location = new System.Drawing.Point(440, 0);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(75, 23);
            this.btnRecargar.TabIndex = 13;
            this.btnRecargar.Text = "RecargarApp";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // CatalogoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(542, 330);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.btnPrecioMenor);
            this.Controls.Add(this.lbPrecioMenor);
            this.Controls.Add(this.lbPrecioMayor);
            this.Controls.Add(this.btnBuscarMPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.expDetalle);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.pboxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.toolNavegacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pboxArticulo;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label expDetalle;
        private System.Windows.Forms.ToolStripButton toolEliminar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarMPrecio;
        private System.Windows.Forms.Label lbPrecioMayor;
        private System.Windows.Forms.Label lbPrecioMenor;
        private System.Windows.Forms.Button btnPrecioMenor;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.Button btnRecargar;
    }
}

