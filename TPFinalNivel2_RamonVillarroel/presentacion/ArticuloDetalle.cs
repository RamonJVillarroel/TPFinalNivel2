using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using utilitarios;
using dominio;
namespace presentacion
{
    public partial class ArticuloDetalle : Form
    {

        private Articulo articuloDetalle = null;
        public ArticuloDetalle(Articulo articulo)
        {
            InitializeComponent();
            articuloDetalle = articulo;
            txtNombre.Text = articulo.NombreArticulo;
            txtCodArt.Text = articulo.CodArticulo;
            txtDes.Text = articulo.Descripcion;
            txtdiner.Text = articulo.Precio.ToString();
            txtMar.Text = articulo.Marca.NombreMarca;
            txtCate.Text = articulo.Categoria.NombreCategoria;
            util utilitarios = new util();
            utilitarios.CargarImagen(pboxDetalle, articulo.Imagen);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {   
            try
            {
                articuloDetalle.CodArticulo = txtCodArt.Text;
                articuloDetalle.NombreArticulo= txtNombre.Text;
                articuloDetalle.Descripcion =txtDes.Text;
                articuloDetalle.Precio = decimal.Parse(txtdiner.Text);
                articuloDetalle.Imagen = pboxDetalle.ImageLocation;
                ArticuloVentana ArticuloEditor = new ArticuloVentana(articuloDetalle);
                ArticuloEditor.ShowDialog();
                Close();
            }
            catch (Exception ex) { throw ex; }
          
       

        }
      
    }
}
