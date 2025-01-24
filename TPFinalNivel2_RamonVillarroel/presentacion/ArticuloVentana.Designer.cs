namespace presentacion
{
    partial class ArticuloVentana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticuloVentana));
            this.lbCodArt = new System.Windows.Forms.Label();
            this.lbNombreArt = new System.Windows.Forms.Label();
            this.lbDescrip = new System.Windows.Forms.Label();
            this.lbImagen = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.pboxImgArt = new System.Windows.Forms.PictureBox();
            this.txtCodArt = new System.Windows.Forms.TextBox();
            this.txtNombreArt = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImgArt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodArt
            // 
            this.lbCodArt.AutoSize = true;
            this.lbCodArt.Location = new System.Drawing.Point(9, 26);
            this.lbCodArt.Name = "lbCodArt";
            this.lbCodArt.Size = new System.Drawing.Size(92, 13);
            this.lbCodArt.TabIndex = 7;
            this.lbCodArt.Text = "Codigo de articulo";
            // 
            // lbNombreArt
            // 
            this.lbNombreArt.AutoSize = true;
            this.lbNombreArt.Location = new System.Drawing.Point(9, 59);
            this.lbNombreArt.Name = "lbNombreArt";
            this.lbNombreArt.Size = new System.Drawing.Size(99, 13);
            this.lbNombreArt.TabIndex = 8;
            this.lbNombreArt.Text = "Nombre del Articulo";
            // 
            // lbDescrip
            // 
            this.lbDescrip.AutoSize = true;
            this.lbDescrip.Location = new System.Drawing.Point(9, 98);
            this.lbDescrip.Name = "lbDescrip";
            this.lbDescrip.Size = new System.Drawing.Size(63, 13);
            this.lbDescrip.TabIndex = 9;
            this.lbDescrip.Text = "Descripción";
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Location = new System.Drawing.Point(12, 146);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(42, 13);
            this.lbImagen.TabIndex = 10;
            this.lbImagen.Text = "Imagen";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(9, 197);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(37, 13);
            this.lbPrecio.TabIndex = 11;
            this.lbPrecio.Text = "Precio";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(12, 250);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 5;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(12, 307);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 6;
            // 
            // pboxImgArt
            // 
            this.pboxImgArt.Location = new System.Drawing.Point(164, 146);
            this.pboxImgArt.Name = "pboxImgArt";
            this.pboxImgArt.Size = new System.Drawing.Size(149, 182);
            this.pboxImgArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImgArt.TabIndex = 7;
            this.pboxImgArt.TabStop = false;
            // 
            // txtCodArt
            // 
            this.txtCodArt.Location = new System.Drawing.Point(164, 26);
            this.txtCodArt.Name = "txtCodArt";
            this.txtCodArt.Size = new System.Drawing.Size(149, 20);
            this.txtCodArt.TabIndex = 0;
            // 
            // txtNombreArt
            // 
            this.txtNombreArt.Location = new System.Drawing.Point(164, 52);
            this.txtNombreArt.Name = "txtNombreArt";
            this.txtNombreArt.Size = new System.Drawing.Size(149, 20);
            this.txtNombreArt.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(164, 82);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(149, 58);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.Text = "";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(58, 197);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // txtImg
            // 
            this.txtImg.Location = new System.Drawing.Point(58, 146);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(100, 20);
            this.txtImg.TabIndex = 3;
            this.txtImg.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(9, 234);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(52, 13);
            this.lbCategoria.TabIndex = 12;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(9, 291);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(37, 13);
            this.lbMarca.TabIndex = 13;
            this.lbMarca.Text = "Marca";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(83, 335);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 14;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(164, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ArticuloVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(325, 370);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.txtImg);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreArt);
            this.Controls.Add(this.txtCodArt);
            this.Controls.Add(this.pboxImgArt);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbImagen);
            this.Controls.Add(this.lbDescrip);
            this.Controls.Add(this.lbNombreArt);
            this.Controls.Add(this.lbCodArt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArticuloVentana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
          
            ((System.ComponentModel.ISupportInitialize)(this.pboxImgArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodArt;
        private System.Windows.Forms.Label lbNombreArt;
        private System.Windows.Forms.Label lbDescrip;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.PictureBox pboxImgArt;
        private System.Windows.Forms.TextBox txtCodArt;
        private System.Windows.Forms.TextBox txtNombreArt;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
    }
}