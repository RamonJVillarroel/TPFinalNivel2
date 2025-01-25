using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;
using utilitarios;
namespace presentacion
{

    public partial class CatalogoApp : Form
    {
        private List<Articulo> articulos;
        public CatalogoApp()
        {
            InitializeComponent();
        }

        private void toolNuevoArticulo_Click(object sender, EventArgs e)
        {
            ArticuloVentana articulo = new ArticuloVentana();
            articulo.ShowDialog();
            cargarArticulos();
        }

        private void toolBusqueda_Click(object sender, EventArgs e)
        {
            BusquedaVentana busqueda = new BusquedaVentana(); 
            busqueda.ShowDialog();
        }

        private void cargarArticulos()
        {
            try
            {
                NegocioArticulo negocio = new NegocioArticulo();
                articulos = negocio.ListarArticulos();
                dgvArticulos.DataSource = articulos;
                //Modularizar esto  a una lista con un foreach, me parece que funcara
                string id = "IdArticulo";
                string Descripcion = "Descripcion";
                string Imagen = "Imagen";
                string Precio = "Precio";
                string Marca = "Marca";
                string Categoria = "Categoria";
                util utilitarios = new util();
                utilitarios.EliminadorColumnas(dgvArticulos, id);
                utilitarios.EliminadorColumnas(dgvArticulos, Descripcion);
                utilitarios.EliminadorColumnas(dgvArticulos, Imagen);
                utilitarios.EliminadorColumnas(dgvArticulos, Precio);
                utilitarios.EliminadorColumnas(dgvArticulos, Marca);
                utilitarios.EliminadorColumnas(dgvArticulos, Categoria);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    
        private void CatalogoApp_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo ArticuloSeleccionado= (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                util utilitarios = new util();
                utilitarios.CargarImagen(pboxArticulo, ArticuloSeleccionado.Imagen);
               
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
                try
                {
                if (dgvArticulos.CurrentRow != null)
                {
                    Articulo ArticuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    ArticuloDetalle articuloDetalle = new ArticuloDetalle(ArticuloSeleccionado);
                    articuloDetalle.ShowDialog();
                }
                }catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void eliminar(bool logico = false)
        {
            NegocioArticulo articuloNegocio = new NegocioArticulo();
            Articulo seleccionado;
            try
            {
                DialogResult result = MessageBox.Show("Quieres eliminar este activo?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    articuloNegocio.eliminar(seleccionado.IdArticulo);
                    cargarArticulos();
                }

            }
            catch (Exception ex) { throw ex; }

        }
    }
}
