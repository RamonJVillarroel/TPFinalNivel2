using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
namespace presentacion
{
    public partial class CatalogoApp : Form
    {
        private List<Articulo> listaArticulos;

        public CatalogoApp()
        {
            InitializeComponent();
        }

        private void toolNuevoArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            articulo.ShowDialog();
        }

        private void toolBusqueda_Click(object sender, EventArgs e)
        {
            Busqueda busqueda = new Busqueda(); 
            busqueda.ShowDialog();
        }

        private void cargarArticulos()
        {
            try
            {
                NegocioArticulo negocio = new NegocioArticulo();
                listaArticulos =negocio.listarArticulos();
                dgvDiscos.DataSource = listaDisco;
                //dgvDiscos.Columns["FechaLanzamiento"].Visible = false;
                dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
                pboxDisco.Load(listaDisco[0].UrlImagenTapa);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}
