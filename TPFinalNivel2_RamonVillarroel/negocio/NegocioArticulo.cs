using dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class NegocioArticulo
    {
        public List<Articulo> listarArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try {
                string consulta = "SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.IdCategoria, a.IdMarca, a.ImagenUrl, a.Precio, m.Descripcion as marca, c.Descripcion as categoria FROM ARTICULOS AS a inner join CATEGORIAS as c on a.IdCategoria= c.Id inner join MARCAS as m on a.IdMarca= m.Id;";
                datos.nuevaConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = (int)datos.Lector["Id"];
                    aux.CodArticulo = (int)datos.Lector["Codico"];
                    aux.NombreArticulo = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector ["Descripcion"];
                    aux.Imagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (int)datos.Lector["precio"];
                    Categoria categoria = new Categoria();
                    aux.categoria.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.categoria.NombreCategoria = (string)datos.Lector["categoria"];
                    Marca marca = new Marca();
                    aux.Marca.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.Marca.NombreMarca = (string)datos.Lector["marca"];
                    articulos.Add(aux);
                }
                return articulos;
            }
            catch(Exception ex) { throw ex; } 


           
        }


    }
}
