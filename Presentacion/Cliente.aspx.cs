using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class Cliente : System.Web.UI.Page
    {
        List<Dominio.Cliente> clientes;
        ClienteNegocio negocioCliente = new ClienteNegocio();
        Dominio.Cliente aux;
        long idprod;
        bool update = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            aux = new Dominio.Cliente();
            idprod = Convert.ToInt64(Request.QueryString["idprod"]);
            Session["CodigoProducto" + Session.SessionID] = idprod;
            clientes = negocioCliente.listar();
            string email = inputEmail.Text;


            inputEmail.Enabled = false;
            inputCiudad.Enabled = false;
            inputApellido.Enabled = false;
            inputCodigoPostal.Enabled = false;
            inputNombre.Enabled = false;
            inputDireccion.Enabled = false;



        }
        protected void btnIngresarDNI(object sender, EventArgs e) {
            int auxDNI;
            bool success = Int32.TryParse(inputDNI.Text, out auxDNI );
            success = ((auxDNI.ToString().Length) > 4 && (auxDNI.ToString().Length) < 10) && (success == true) ? true : false;
            if (success)
            {
                aux = clientes.Find(item => item.DNI == Int32.Parse(inputDNI.Text));
                if (aux != null)
                {
                    completarFormulario(aux);
                    inputEmail.Enabled = true;
                    inputCiudad.Enabled = true;
                    inputApellido.Enabled = true;
                    inputCodigoPostal.Enabled = true;
                    inputNombre.Enabled = true;
                    inputDireccion.Enabled = true;
                    inputDNI.Enabled = false;
                    update = true;
                }
                else
                {
                    vaciarCampos();
                    inputDNI.Enabled = false;
                    inputEmail.Enabled = true;
                    inputCiudad.Enabled = true;
                    inputApellido.Enabled = true;
                    inputCodigoPostal.Enabled = true;
                    inputNombre.Enabled = true;
                    inputDireccion.Enabled = true;
                    update = false;
                }
            }else{
                inputDNI.Text = "Debe ingresar un dni";
                inputEmail.Enabled = false;
                inputCiudad.Enabled = false;
                inputApellido.Enabled = false;
                inputCodigoPostal.Enabled = false;
                inputNombre.Enabled = false;
                inputDireccion.Enabled = false;
            }


            

        }

        private void vaciarCampos()
        {
           
            inputNombre.Text = "";
            inputApellido.Text = "";
            inputEmail.Text = "";
            inputDireccion.Text = "";
            inputCiudad.Text = "";
            inputCodigoPostal.Text = "";
        }

        private void completarFormulario(Dominio.Cliente aux)
        {
            //    aux.Id;
            inputDNI.Text = aux.DNI.ToString();
            inputNombre.Text = aux.Nombre;
            inputApellido.Text =aux.Apellido;
            inputEmail.Text = aux.Email;
            inputDireccion.Text= aux.Direccion;
            inputCiudad.Text = aux.Ciudad;
            inputCodigoPostal.Text = aux.CodigoPostal;          

        }

        protected void btnCangear(object sender, EventArgs e) 
        {
            aux = clientes.Find(item => item.DNI == Int32.Parse(inputDNI.Text));
            long idcliente;
            VoucherNegocio voucherNegocio = new VoucherNegocio();
            if (aux!=null)
            {
                aux.Apellido = inputApellido.Text;
                aux.Nombre = inputNombre.Text;
                aux.Email = inputEmail.Text;
                aux.Direccion = inputDireccion.Text;
                aux.Ciudad = inputCiudad.Text;
                aux.CodigoPostal = inputCodigoPostal.Text;
                negocioCliente.update(aux);
                idcliente = aux.Id;
            }
            else {
                aux = new Dominio.Cliente();
                aux.DNI = Int32.Parse(inputDNI.Text);
                aux.Apellido = inputApellido.Text;
                aux.Nombre = inputNombre.Text;
                aux.Email = inputEmail.Text;
                aux.Direccion = inputDireccion.Text;
                aux.Ciudad = inputCiudad.Text;
                aux.CodigoPostal = inputCodigoPostal.Text;
                negocioCliente.insertar(aux);
                idcliente = negocioCliente.Contar();
            }
            voucherNegocio.update(idcliente,(long)Session["CodigoProducto" + Session.SessionID], (long)Session["CodigoVoucher" + Session.SessionID]);
            negocioCliente.EnviarMail(aux,(long) Session["CodigoProducto" + Session.SessionID], (long)Session["CodigoVoucher" + Session.SessionID]);
            Response.Redirect("success.aspx");


        }
    }
}