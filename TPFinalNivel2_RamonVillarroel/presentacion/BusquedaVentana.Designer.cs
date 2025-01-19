namespace presentacion
{
    partial class BusquedaVentana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaVentana));
            this.menuBusqueda = new System.Windows.Forms.MenuStrip();
            this.BusquedaNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.cdcdcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdcdccdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdcdcToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBusqueda
            // 
            this.menuBusqueda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BusquedaNombre,
            this.cdcdcToolStripMenuItem,
            this.cdcdccdToolStripMenuItem,
            this.cdcdcToolStripMenuItem1});
            this.menuBusqueda.Location = new System.Drawing.Point(0, 0);
            this.menuBusqueda.Name = "menuBusqueda";
            this.menuBusqueda.Size = new System.Drawing.Size(260, 24);
            this.menuBusqueda.TabIndex = 0;
            this.menuBusqueda.Text = "BusquedaMenu";
            // 
            // BusquedaNombre
            // 
            this.BusquedaNombre.Name = "BusquedaNombre";
            this.BusquedaNombre.Size = new System.Drawing.Size(120, 20);
            this.BusquedaNombre.Text = "Buscar por nombre";
            this.BusquedaNombre.DoubleClick += new System.EventHandler(this.BusquedaNombre_DoubleClick);
            // 
            // cdcdcToolStripMenuItem
            // 
            this.cdcdcToolStripMenuItem.Name = "cdcdcToolStripMenuItem";
            this.cdcdcToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.cdcdcToolStripMenuItem.Text = "Busqueda Avanzada";
            // 
            // cdcdccdToolStripMenuItem
            // 
            this.cdcdccdToolStripMenuItem.Name = "cdcdccdToolStripMenuItem";
            this.cdcdccdToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.cdcdccdToolStripMenuItem.Text = "cdcdccd";
            // 
            // cdcdcToolStripMenuItem1
            // 
            this.cdcdcToolStripMenuItem1.Name = "cdcdcToolStripMenuItem1";
            this.cdcdcToolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.cdcdcToolStripMenuItem1.Text = "cdcdc";
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(260, 284);
            this.Controls.Add(this.menuBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBusqueda;
            this.Name = "Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda";
            this.menuBusqueda.ResumeLayout(false);
            this.menuBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBusqueda;
        private System.Windows.Forms.ToolStripMenuItem BusquedaNombre;
        private System.Windows.Forms.ToolStripMenuItem cdcdcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cdcdccdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cdcdcToolStripMenuItem1;
    }
}