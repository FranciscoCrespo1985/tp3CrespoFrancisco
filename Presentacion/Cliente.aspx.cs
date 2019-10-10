using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Cliente : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int idprod = Convert.ToInt32(Request.QueryString["idprod"]);
            Session["CodigoProducto" + Session.SessionID]=idprod;

            string email = inputEmail3.Text;

        }
        protected void btnIngresarDNI(object sender, EventArgs e) {

          
          
        
        }
    }
}