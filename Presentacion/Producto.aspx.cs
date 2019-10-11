using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Producto : System.Web.UI.Page
    {
        public List<Dominio.Producto> listaProductos;
        
        
        public void Page_Load(object sender, EventArgs e)
        {
            

            ProductoNegocio negocio = new ProductoNegocio();
            listaProductos = negocio.listar();
        }

        public void btnIngresar_Click(object sender, EventArgs e)
        {


            
            /* if (user.Equals(userName) && password.Equals(passName))
             {
                 Response.Write("<script>alert('USUARIO CORRECTO')</script>");
             }
             else { Response.Write("<script>alert('USUARIO INCORRECTO')</script>"); }*/

        }
    }
}