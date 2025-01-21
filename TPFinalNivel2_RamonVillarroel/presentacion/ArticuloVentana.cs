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
            
        }
    }
}
