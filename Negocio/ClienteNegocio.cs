using System;
using System.Collections.Generic;
using AccesoADatos;
using Dominio;
namespace Negocio
{
    public class ClienteNegocio
    {


        public List<Cliente> listar()
        {
            List<Cliente> lista = new List<Cliente>();
            Cliente aux;
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("select c.id,c.dni,c.nombre,c.apellido,c.email,c.direccion,c.ciudad,c.codigopostal,c.fecharegistro from clientes as c");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Cliente();
                    aux.Id = datos.lector.GetInt64(0);
                    aux.DNI = datos.lector.GetInt32(1);
                    aux.Nombre = datos.lector.GetString(2);
                    aux.Apellido = datos.lector.GetString(3);
                    aux.Email = datos.lector.GetString(4);
                    aux.Direccion = datos.lector.GetString(5);
                    aux.Ciudad = datos.lector.GetString(6);
                    aux.CodigoPostal = datos.lector.GetString(7);
                    aux.FechaReginstro = datos.lector.GetDateTime(8);
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
