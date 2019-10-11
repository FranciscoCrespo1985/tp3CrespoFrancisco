﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dominio;
using AccesoADatos;

namespace Negocio
{
    public class VoucherNegocio
    {
        public List<Voucher> listar() 
        {

            List<Voucher> lista = new List<Voucher>();
            Voucher aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("SELECT v.Id,v.CodigoVoucher,v.Estado,isnull(v.IdCliente,-1),isnull(v.IdProducto,-1),isnull(v.FechaRegistro,-1) FROM Vouchers as v where v.idproducto is null and v.idcliente is null");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Voucher();
                    aux.Id = datos.lector.GetInt64(0);
                    aux.CodigoVoucher = datos.lector.GetString(1);
                    aux.Estado = datos.lector.GetBoolean(2);     
                
                    aux.IdCliente = datos.lector.GetInt64(3);
                   
                      
                   aux.IdProducto = datos.lector.GetInt64(4); 
                    aux.FechaRegistro = datos.lector.GetDateTime(5);
                    lista.Add(aux);

                }
                return lista;
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
        
        }

        public void update(long idcliente, long idProducto, long idVoucher)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("update vouchers set idcliente =@IdCliente,idproducto=@IdProducto where id = @id");
                datos.agregarParametro("@IdCliente", idcliente);
                datos.agregarParametro("@IdProducto", idProducto);
                datos.agregarParametro("@id", idVoucher);
                datos.ejecutarAccion();
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
        }
    }
}
