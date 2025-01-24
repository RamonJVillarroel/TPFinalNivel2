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
        public List<Articulo> ListarArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try {
                string consulta = "SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.IdCategoria as IdCategoria, a.IdMarca as IdMarca, a.ImagenUrl, a.Precio, m.Descripcion as marca, c.Descripcion as categoria FROM ARTICULOS AS a inner join CATEGORIAS as c on a.IdCategoria= c.Id inner join MARCAS as m on a.IdMarca= m.Id;";
                datos.nuevaConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.IdArticulo = (int)datos.Lector["Id"];
                    articulo.CodArticulo = (string)datos.Lector["Codigo"];
                    articulo.NombreArticulo = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector ["Descripcion"];
                    articulo.Imagen = (string)datos.Lector["ImagenUrl"];
                    articulo.Precio = (decimal)datos.Lector["Precio"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];
                    articulo.Categoria.NombreCategoria = (string)datos.Lector["categoria"];
                    articulo.Marca = new Marca();
                    articulo.Marca.IdMarca = (int)datos.Lector["IdMarca"];
                    articulo.Marca.NombreMarca = (string)datos.Lector["marca"];
                    articulos.Add(articulo);
                }  
                return articulos;
            }
            catch(Exception ex) { throw ex; 
            }
            finally
            {
                datos.terminarConexion();
            }
            
        }


        public void NuevoArticulo(Articulo NuevoArt)
        {
                 AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "insert into ARTICULOS( Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl,Precio) VALUES(@Codigo,@NombreArt,@Descripcion,2,1,@img,@Precio);";
              
                datos.Parametro("@Codigo", NuevoArt.CodArticulo);
                datos.Parametro("@NombreArt",NuevoArt.NombreArticulo);
                datos.Parametro("@Descripcion",NuevoArt.Descripcion);
                //datos.Parametro("@IdMarca",NuevoArt.Marca.IdMarca);
                //datos.Parametro("@IdCategoria",NuevoArt.Categoria.IdCategoria);
                datos.Parametro("@img",NuevoArt.Imagen);
                datos.Parametro("@Precio", NuevoArt.Precio);
                datos.nuevaConsulta(consulta);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                
                datos.terminarConexion();
            }
        }
                

    }
}
