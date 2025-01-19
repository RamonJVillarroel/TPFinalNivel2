using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilitarios
{
    public class caracteres
    {
        public bool ValidadorCaracteres(string cadena)
        {
            if (cadena == "ArticuloDescricion")
            {
                if (cadena.ToString().Length > 150) { 
                    return true;
                }
            }
                return false;
        }
    }
}
