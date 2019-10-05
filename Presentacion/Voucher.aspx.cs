﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
namespace Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        VoucherNegocio negocio;
        List<Voucher> vouchers;
        protected void Page_Load(object sender, EventArgs e)
        {
            negocio = new VoucherNegocio();
            vouchers = negocio.listar(); 
            dgvVouchers.DataSource = vouchers;
            dgvVouchers.DataBind();
            

            // if (!IsPostBack)
            //   txtTextbox.Text = "Bienvenide";

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoVoucher.Text;
            
            if (vouchers.Any(item => item.CodigoVoucher == codigo))
            {
                Response.Write("# alert(<% = codigo %>)");
            }
          
           /* if (user.Equals(userName) && password.Equals(passName))
            {
                Response.Write("<script>alert('USUARIO CORRECTO')</script>");
            }
            else { Response.Write("<script>alert('USUARIO INCORRECTO')</script>"); }*/

        }
    }
}