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
        private util utilitario = new util();
        //Ventana para visualizar el detalle de un articulo
        public ArticuloDetalle(Articulo articulo)
        {
            InitializeComponent();
            articuloDetalle = articulo;
            txtNombre.Text = articulo.NombreArticulo;
            txtCodArt.Text = articulo.CodArticulo;
            txtDes.Text = articulo.Descripcion;
            string precio =Math.Truncate(articulo.Precio).ToString(); 
            txtdiner.Text = precio;
            txtMar.Text = articulo.Marca.NombreMarca;
            txtCate.Text = articulo.Categoria.NombreCategoria;
            util utilitarios = new util();
            utilitarios.CargarImagen(pboxDetalle, articulo.Imagen);
        }
        //Si se quiere editar el articulo, se lo paso a la ventana de editar, que recibe el articulo en cuestion
        private void btnEditar_Click(object sender, EventArgs e)
        {   
            try
            {
                ArticuloVentana ArticuloEditor = new ArticuloVentana(articuloDetalle);
                ArticuloEditor.ShowDialog();
                Close();
            }
            catch (Exception ) { utilitario.MensajeError(); }
          
       

        }
      
    }
}
