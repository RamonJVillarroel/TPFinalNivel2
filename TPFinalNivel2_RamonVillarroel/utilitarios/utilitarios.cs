using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace utilitarios
{
    public class util
    {
        public void CargarImagen(PictureBox pictureBox, string imagen)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(imagen))
                {
                    pictureBox.Load(imagen);
                }
                else
                {
                    pictureBox.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQDCXek_M1agTePOBcSZfP1O9qobtNXYz4OVg&s");
                }
            }
            catch (Exception)
            {
                pictureBox.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQDCXek_M1agTePOBcSZfP1O9qobtNXYz4OVg&s");
            }
        }

        public void EliminadorColumnas(DataGridView dataGrid, string columna)
        {
            dataGrid.Columns[columna].Visible = false;
        }

  
    }
}
