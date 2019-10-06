using System;
using System.Collections.Generic;
using System.Text;
using Dominio;
using AccesoADatos;

namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> listar()
        {
            List<Producto> lista = new List<Producto>();
            Producto aux;
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("select p.id,p.titulo,p.descripcion,p.urlimagen from productos as p");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Producto();
                    aux.Id = datos.lector.GetInt64(0);
                    aux.Titulo = datos.lector.GetString(1);
                    aux.Descripcion = datos.lector.GetString(2);
                    aux.URLImagen = datos.lector.GetString(3);
                    lista.Add(aux);
                }
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();
                datos = null;
            }

            return lista;
        }
       

       









    }
}
