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
namespace presentacion
{
    public partial class ArticuloDetalle : Form
    {
        
  
        public ArticuloDetalle(string detalleNombre, string detalleCodigo, string detalleDescripcion, decimal detallePrecio, string detalleMarca, string detalleCategoria, string img)
        {
            InitializeComponent();
            txtNombre.Text = detalleNombre;
            txtCodArt.Text = detalleCodigo;
            txtDes.Text = detalleDescripcion;
            txtdiner.Text = (detallePrecio).ToString();
            txtMar.Text = detalleMarca;
            txtCate.Text = detalleCategoria;
            util utilitarios = new util();
            utilitarios.CargarImagen(pboxDetalle, img);
        }
        

    }
}
