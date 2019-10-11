using System;
using System.Collections.Generic;
using AccesoADatos;
using Dominio;
using System.Net;
using System.Net.Mail;
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

        public void update(Cliente aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("update Clientes set nombre =@nombre,apellido=@apellido,email=@email,direccion=@direccion,ciudad=@ciudad,codigopostal=@codigopostal where id = @id");
                datos.agregarParametro("@nombre", aux.Nombre);
                datos.agregarParametro("@apellido", aux.Apellido);
                datos.agregarParametro("@email", aux.Email);
                datos.agregarParametro("@direccion", aux.Direccion);
                datos.agregarParametro("@ciudad", aux.Ciudad);
                datos.agregarParametro("@codigopostal", aux.CodigoPostal);
                datos.agregarParametro("@id", aux.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex) {
                throw ex;            
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }

            
        }
        public void insertar(Cliente aux) {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("insert into clientes(dni,nombre,apellido,email,direccion,ciudad,codigopostal,fecharegistro) values (@dni,@nombre,@apellido,@email,@direccion,@ciudad,@codigopostal,getdate())");
                datos.agregarParametro("@nombre", aux.Nombre);
                datos.agregarParametro("@apellido", aux.Apellido);
                datos.agregarParametro("@dni", aux.DNI);
                datos.agregarParametro("@email", aux.Email);
                datos.agregarParametro("@direccion", aux.Direccion);
                datos.agregarParametro("@ciudad", aux.Ciudad);
                datos.agregarParametro("@codigopostal", aux.CodigoPostal);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                datos.cerrarConexion();
                datos = null;
            }
        
        }

        public long Contar()
        {
            AccesoDatos datos = new AccesoDatos();
            Int32 count;
            try
            {
                datos.setearQuery("SELECT COUNT(*) FROM clientes");
                datos.conexion.Open();
                count = (Int32)datos.comando.ExecuteScalar();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
                
            }
            return count;
        }

        public void EnviarMail(Cliente aux, long idProducto, long idVoucher)
        {
            var fromAddress = new MailAddress("francisco.crespo@axsis.com.ar", "VoucherMania");
            var toAddress = new MailAddress("gpacomail@gmail.com", "Francisco");
            const string fromPassword = "Francisco_2018";
            const string subject = "Vouchermania Por Francisco Crespo Utn Programaicon 3";
            string body = "Gracias por participar VoucherMania";

            var smtp = new SmtpClient
            {
                Host = "mail.axsis.com.ar",
                Port = 25,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),


            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
