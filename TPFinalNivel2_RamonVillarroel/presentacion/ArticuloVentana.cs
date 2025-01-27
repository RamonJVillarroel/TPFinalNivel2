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
        private Articulo articulo = null;
        private util utilitario = new util();
        //Ventana para nueva carga de productos
        public ArticuloVentana()
        {
            InitializeComponent();
            cargarCategoria();
            cargarMarca();
        }
        //Sobrecar de la clase, para editar un articulo
        public ArticuloVentana(Articulo articulo)
        {
            InitializeComponent();
            cargarCategoria();
            cargarMarca();
            txtNombreArt.Text = articulo.NombreArticulo;
            txtCodArt.Text = articulo.CodArticulo;
            txtDescripcion.Text = articulo.Descripcion;
            string precio = Math.Truncate(articulo.Precio).ToString();
            txtPrecio.Text=precio;
            txtImg.Text = articulo.Imagen;
            cbxMarca.Text = articulo.Marca.NombreMarca;
            cbxCategoria.Text = articulo.Categoria.NombreCategoria;
            Text = "Actualizar Articulo";
            btnEnviar.Text = "Actualizar";
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
            NegocioArticulo negocioArticulo = new NegocioArticulo();

            try
            {

                if (articulo == null)
                    articulo = new Articulo();

                articulo.CodArticulo = utilitario.ValidadorCadena50caracteres(txtCodArt.Text);
                articulo.NombreArticulo = utilitario.ValidadorCadena50caracteres(txtNombreArt.Text);
                articulo.Descripcion = utilitario.ValidadorCadena150caracteres(txtDescripcion.Text);
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Imagen = utilitario.ValidadorCadena1000caracteres(txtImg.Text);
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;


                if (articulo.IdArticulo != 0)
                {
                    negocioArticulo.EditarArticulo(articulo);
                    MessageBox.Show("Articulo Modificado!");
                }
                else
                {
                    negocioArticulo.NuevoArticulo(articulo);
                    MessageBox.Show("Nuevo Articulo Agregado!");
                }
                Close();
            }
            catch (Exception ) {  
            }



        }
        //carga categorias
        private void cargarCategoria(string categoriaSeleccionada = null)
        {
            try
            {
                NegocioCategoria categoriaNegocio = new NegocioCategoria();
                cbxCategoria.DataSource = categoriaNegocio.ListarCategoria();
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DisplayMember = "NombreCategoria";
                if (!string.IsNullOrEmpty(categoriaSeleccionada))
                {
                    cbxCategoria.SelectedValue = categoriaSeleccionada; 
                }
            }
            catch (Exception)
            {
                utilitario.MensajeError();
            }
        }
        //carga de marcas
        private void cargarMarca(string marcaSeleccionada = null)
        {
            try
            {
                NegocioMarca marcaNegocio = new NegocioMarca();
                cbxMarca.DataSource = marcaNegocio.ListarMarcas();
                cbxMarca.ValueMember = "IdMarca"; 
                cbxMarca.DisplayMember = "NombreMarca";
                if (!string.IsNullOrEmpty(marcaSeleccionada))
                {
                    cbxMarca.SelectedValue = marcaSeleccionada;
                }
            }
            catch (Exception )
            {
                utilitario.MensajeError();
            }
        }
    }
}
