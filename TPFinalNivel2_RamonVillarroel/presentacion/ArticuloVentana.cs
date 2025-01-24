using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utilitarios;
using negocio;
using dominio;
namespace presentacion
{
    public partial class ArticuloVentana : Form
    {
        
        public ArticuloVentana()
        {
            InitializeComponent();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            util utilitarios = new util();
            utilitarios.CargarImagen(pboxImgArt, txtImg.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           var resultado = MessageBox.Show("Seguro quieres salir?", "Advertencia ⚠️", MessageBoxButtons.YesNo);

            if ( resultado==DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
           
            util utilitarios = new util();
           
            try
            {
                //if (articulo == null)
                //    articulo = new Articulo();
                NegocioArticulo negocio = new NegocioArticulo();
                articulo.CodArticulo = txtCodArt.Text;
                articulo.NombreArticulo = txtNombreArt.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = int.Parse(txtPrecio.Text);  
                articulo.Imagen= txtImg.Text;
                //Marca Marca = new Marca();
                //  articulo.Marca = (Marca)cbxMarca.SelectedItem;
                //articulo.Marca = (Marca)15;
                //Categoria Categoria = new Categoria();  
                // articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                negocio.NuevoArticulo(articulo);
                MessageBox.Show("ARTICULO CARGADO");
                Close();
            }catch (Exception ex) { throw ex; }
            

        }

       
    }
}
