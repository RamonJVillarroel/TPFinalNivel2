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
        public ArticuloVentana()
        {
            InitializeComponent();
            cargarCategoria();
            cargarMarca();
        }
        public ArticuloVentana(Articulo articulo)
        {
            InitializeComponent();
            cargarCategoria();
            cargarMarca();
            this.articulo = articulo;
            txtNombreArt.Text = articulo.NombreArticulo;
            txtCodArt.Text = articulo.CodArticulo;
            txtDescripcion.Text = articulo.Descripcion;
            txtPrecio.Text=articulo.Precio.ToString();
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
                articulo.CodArticulo = txtCodArt.Text;
                articulo.NombreArticulo = txtNombreArt.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = int.Parse(txtPrecio.Text);  
                articulo.Imagen= txtImg.Text;
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
            catch (Exception ex) { throw ex; }
            

        }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
