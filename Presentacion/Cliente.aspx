<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="Presentacion.Cliente" %>

<asp:Content  runat="server" ID="FormularioCliente" ContentPlaceHolderID="ContentPlaceHolder1">
   

    <div class="box box-info col-sm-9">
            <div class="input-group input-group-sm">
                <asp:textbox type="Text"  runat="server" class="form-control" id="inputDNI" placeholder="DNI"></asp:textbox>
                    <span class="input-group-btn">
                      
                      <asp:Button ID="btnIngresaDNI" runat="server" cssclass="btn btn-info btn-flat" Text="Validar" Onclick="btnIngresarDNI"/>
                    </span>
            </div>
        </div>

   <div class="box box-info col-sm-9">
            <div class="box-header with-border">
              <h3 class="box-title">Ingrese sus datos</h3>
            </div>
            <!-- /.box-header -->
            <!-- form start -->
              
              <div class="box-body">
                <!-- Email-->
                
                <div  id="groupEmail" class="form-group">
                  <asp:label runat="server" class="col-sm-2 control-label">Email</asp:label>

                  <div class="">
                    <asp:textbox type="email"  runat="server" cssclass="form-control" id="inputEmail" ClientIDMode="Static"  placeholder="Email"></asp:textbox>
                  </div>
                </div>
                <!-- Nombre-->
                <div class="row">
                    <div id="groupNombre"  class="form-group col-sm-6">
                        <label class="control-label">Nombre</label>
                         
                        <asp:textbox runat="server" type="Text" CssClass="form-control" id="inputNombre" ClientIDMode="Static" placeholder="Nombre" ></asp:textbox>
                    
                    </div>
                    <div id="groupApellido"class="form-group col-sm-6 ">
                        <label class="control-label">Apellido</label>
                        
                        <asp:textbox runat="server" type="Text" cssclass="form-control" id="inputApellido" ClientIDMode="Static" placeholder="Apellido"></asp:textbox>
                        
                    </div>
                </div>
                <div class="row">
                    <div id="groupDireccion"class="form-group col-sm-4">
                        <label class="control-label">Direccion</label>
                         
                        <asp:textbox runat="server" type="Text" cssclass="form-control" id="inputDireccion" ClientIDMode="Static" placeholder="Direccion"></asp:textbox>
                    
                    </div>
                    <div id="groupCiudad" class="form-group col-sm-4 ">
                        <label class="control-label">Ciudad</label>
                        
                        <asp:textbox runat="server" type="Text" class="form-control" id="inputCiudad" ClientIDMode="Static" placeholder="Ciudad"></asp:textbox>
                        
                    </div>
                    <div id="groupCodigoPostal" class="form-group col-sm-4 ">
                        <label class="control-label">Codigo Postal</label>
                        
                        <asp:textbox runat="server" type="Text" class="form-control" id="inputCodigoPostal" ClientIDMode="Static" placeholder="Postal Code"></asp:textbox>
                        
                    </div>
                </div>
                
             
              <!-- /.box-body -->
              <div class="box-footer">
                
                 <asp:Button ID="btncangear" runat="server"  OnClientClick="return validar()" cssclass="btn bg-olive btn-block" Text="Cangear"   OnClick="btnCangear"/>
              </div>
              <!-- /.box-footer -->
            
          </div>

        

       <script>
           function validar() {
               var email = document.getElementById("inputEmail").value;
               var nombre = document.getElementById("inputNombre").value;
               var apellido = document.getElementById("inputApellido").value;
               var direccion = document.getElementById("inputDireccion").value;
               var ciudad = document.getElementById("inputCiudad").value;
               var postal = document.getElementById("inputCodigoPostal").value;

               
               if (nombre === "") {

                   $("#groupNombre").addClass("has-error");

               }
               else {
                   $("#groupNombre").removeClass("has-error");
                   $("#groupNombre").addClass("has-success");
               }

               if (apellido === "") {
                   $("#groupApellido").addClass("has-error");
               }
               else
               {
                   $("#groupApellido").removeClass("has-error");
                   $("#groupApellido").addClass("has-success");
               }

               if (direccion === "") {
                   $("#groupDireccion").addClass("has-error");
               }
               else {
                   $("#groupDireccion").removeClass("has-error");
                   $("#groupDireccion").addClass("has-success");
               }

               if (ciudad === "") {
                   $("#groupCiudad").addClass("has-error");
               }
               else {
                   $("#groupCiudad").removeClass("has-error");
                   $("#groupCiudad").addClass("has-success");
               }
               if (postal === "") {
                   $("#groupCodigoPostal").addClass("has-error");
               }
               else {
                   $("#groupCodigoPostal").removeClass("has-error");
                   $("#groupCodigoPostal").addClass("has-success");
               }
               if (email === "") {
                   $("#groupEmail").addClass("has-error");
               }
               else {
                   $("#groupEmail").removeClass("has-error");
                   $("#groupEmail").addClass("has-success");
               }




               return false;
           }

        </script>      

</asp:Content>
