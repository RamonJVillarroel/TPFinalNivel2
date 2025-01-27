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
        //variable de lista de articulos para ser usada varias veces
        private List<Articulo> articulos;
        //array de columnas para bloquear vista
        string[] artiListvista = { "IdArticulo", "Descripcion", "Imagen", "Precio", "Marca", "Categoria" };
        private util utilitario = new util();
        public CatalogoApp()
        {
            InitializeComponent();
        }
        //Boton para agregado de nuevos articulos
        private void toolNuevoArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloVentana articulo = new ArticuloVentana();
                articulo.ShowDialog();
                cargarArticulos();
            }
            catch (Exception) {
                utilitario.MensajeError();
            }
            
        }
        //funcion de recarga de articulos
        private void cargarArticulos()
        {
            try
            {
                NegocioArticulo negocio = new NegocioArticulo();
                articulos = negocio.ListarArticulos();
                dgvArticulos.DataSource = articulos;
                util utilitarios = new util();
                foreach (var artiList in artiListvista)
                {
                   utilitarios.EliminadorColumnas(dgvArticulos, artiList);
                }
            }
            catch (Exception)
            {
                utilitario.MensajeError();
            }
        }
    
        private void CatalogoApp_Load(object sender, EventArgs e)
        {
            cargarArticulos();
            categoriaDetalle();
        }
        //permite diferenciar la fila seleccionada de las demas y poder cargar cada imagen referente
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    Articulo ArticuloSeleccionado= (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    util utilitarios = new util();
                    utilitarios.CargarImagen(pboxArticulo, ArticuloSeleccionado.Imagen);
               
                }
            }catch (Exception){  utilitario.MensajeError(); }
            
        }
        //Boton para invocar a lña ventana de detalle
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
                }catch (Exception) { utilitario.MensajeError(); }


        }
        //Boton para eliminar Articulos
        private void toolEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        //Funcion que ejecuta la eliminacion del articulo
        private void eliminar(bool logico = false)
        {
            NegocioArticulo articuloNegocio = new NegocioArticulo();
            Articulo seleccionado;
            try
            {
                DialogResult result = MessageBox.Show("¿Quieres eliminar este activo? no se podra recuperar", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    articuloNegocio.eliminar(seleccionado.IdArticulo);
                    cargarArticulos();
                }

            }
            catch (Exception) { utilitario.MensajeError(); }

        }
        //Filtros
        //Por letras
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
             List<Articulo> listafiltrada;
            string busqueda = txtFiltro.Text;
            if (busqueda.Length >= 3)
            {
                listafiltrada = articulos.FindAll(a => a.NombreArticulo.ToUpper().Contains(busqueda.ToUpper()));
            }
            else
            {
                listafiltrada = articulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.Rows.Clear();
            dgvArticulos.DataSource = listafiltrada;
            util utilitarios = new util();
            foreach (var artiList in artiListvista)
            {
                utilitarios.EliminadorColumnas(dgvArticulos, artiList);
            }
            }
            catch (Exception) { utilitario.MensajeError(); }
         
        }
        //Por mayor precio, ordenado de mayor a menor
        private void btnBuscarMPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                dgvArticulos.DataSource = null;
                dgvArticulos.Rows.Clear();
                NegocioArticulo negocioArticulos = new NegocioArticulo();
                articulos = negocioArticulos.ListaMayorPrecio();
                dgvArticulos.DataSource = articulos;
                util utilitarios = new util();
                utilitarios.EliminadorColumnas(dgvArticulos, artiListvista[0]);
                utilitarios.EliminadorColumnas(dgvArticulos, artiListvista[1]);
                utilitarios.EliminadorColumnas(dgvArticulos, artiListvista[2]);
            }
            catch (Exception) { utilitario.MensajeError(); }
        }
        //Por menor precio, ordenado de menor a mayor entre el listado obtenido 
        private void btnPrecioMenor_Click(object sender, EventArgs e)
        {
            try
            {
                dgvArticulos.DataSource = null;
                dgvArticulos.Rows.Clear();
                NegocioArticulo negocioArticulos = new NegocioArticulo();
                articulos = negocioArticulos.ListaMenorPrecio();
                dgvArticulos.DataSource = articulos;
                util utilitarios = new util();
                utilitarios.EliminadorColumnas(dgvArticulos, artiListvista[0]);
                utilitarios.EliminadorColumnas(dgvArticulos, artiListvista[1]);
                utilitarios.EliminadorColumnas(dgvArticulos, artiListvista[2]);
            }
            catch (Exception) { utilitario.MensajeError(); }
        }

        //Carga de categorias para la busqueda
        private void categoriaDetalle()
        {
            try
            {
                NegocioCategoria negocioCategoria = new NegocioCategoria();
                cbxCategoria.DataSource = negocioCategoria.ListarCategoria();
            }
            catch (Exception) { utilitario.MensajeError(); }
        }
        //busqueda de categorias
        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
               
                string categoria= Convert.ToString(cbxCategoria.SelectedValue);
                NegocioArticulo negocioArticulos = new NegocioArticulo();
                articulos = negocioArticulos.ListaPorCategoria(categoria);
                if (articulos == null || !articulos.Any())
                {
                    MessageBox.Show("No se encontraron artículos para la categoría seleccionada. Cargando todos los artículos...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    articulos = negocioArticulos.ListarArticulos();
                }
                dgvArticulos.DataSource = articulos;
                
                util utilitarios = new util();
                utilitarios.EliminadorColumnas(dgvArticulos, artiListvista[0]);
                utilitarios.EliminadorColumnas(dgvArticulos, artiListvista[1]);
                utilitarios.EliminadorColumnas(dgvArticulos, artiListvista[2]);
            }
            catch (Exception) { utilitario.MensajeError(); }

        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvArticulos.DataSource = null;
                dgvArticulos.Rows.Clear();
                cargarArticulos();
            }
            catch (Exception ) { utilitario.MensajeError(); }
            
        }
        //Modificar la celda de precio
        private void dgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvArticulos.Columns[e.ColumnIndex].Name == "Precio" && e.Value != null)
            {
                e.Value = string.Format("{0:C2}", e.Value);
                e.FormattingApplied = true;
            }
        }
    }
}
