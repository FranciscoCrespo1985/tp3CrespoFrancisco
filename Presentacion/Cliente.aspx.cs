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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            aux = new Dominio.Cliente();
            int idprod = Convert.ToInt32(Request.QueryString["idprod"]);
            Session["CodigoProducto" + Session.SessionID]=idprod;
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
                }
                else
                {
                    vaciarCampos();

                    inputEmail.Enabled = true;
                    inputCiudad.Enabled = true;
                    inputApellido.Enabled = true;
                    inputCodigoPostal.Enabled = true;
                    inputNombre.Enabled = true;
                    inputDireccion.Enabled = true;
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

        protected void btnCangear(object sender, EventArgs e) {


        }
    }
}