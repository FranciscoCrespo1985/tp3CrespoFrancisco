<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="Presentacion.Cliente" %>

<asp:Content  runat="server" ID="FormularioCliente" ContentPlaceHolderID="ContentPlaceHolder1">


    <div class="box box-info col-sm-9">
            <div class="input-group input-group-sm">
                <asp:textbox type="Text"  runat="server" class="form-control" id="inputDNI" placeholder="DNI"></asp:textbox>
                    <span class="input-group-btn">
                      
                      <asp:Button ID="btnIngresaDNI" runat="server" cssclass="btn btn-info btn-flat" Text="Validar" Onclieck="btnIngresarDNI"/>
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
                
                <div class="form-group">
                  <asp:label runat="server" class="col-sm-2 control-label">Email</asp:label>

                  <div class="">
                    <asp:textbox type="email"  runat="server" cssclass="form-control" id="inputEmail3" placeholder="Email"></asp:textbox>
                  </div>
                </div>
                <!-- Nombre-->
                <div class="row">
                    <div class="form-group col-sm-6">
                        <label class="control-label">Nombre</label>
                         
                        <asp:textbox runat="server" type="Text" cssclass="form-control" id="inputNombre" placeholder="Nombre"></asp:textbox>
                    
                    </div>
                    <div class="form-group col-sm-6 ">
                        <label class="control-label">Apellido</label>
                        
                        <asp:textbox runat="server" type="Text" cssclass="form-control" id="inputApellido" placeholder="Apellido"></asp:textbox>
                        
                    </div>
                </div>
                  <div class="row">
                    <div class="form-group col-sm-4">
                        <label class="control-label">Direccion</label>
                         
                        <asp:textbox runat="server" type="Text" cssclass="form-control" id="inputDireccion" placeholder="Direccion"></asp:textbox>
                    
                    </div>
                    <div class="form-group col-sm-4 ">
                        <label class="control-label">Ciudad</label>
                        
                        <asp:textbox runat="server" type="Text" class="form-control" id="inputCiudad" placeholder="Ciudad"></asp:textbox>
                        
                    </div>
                      <div class="form-group col-sm-4 ">
                        <label class="control-label">Codigo Postal</label>
                        
                        <asp:textbox runat="server" type="Text" class="form-control" id="inputlCodigoPostal" placeholder="Postal Code"></asp:textbox>
                        
                    </div>
                </div>
                
              </div>
              <!-- /.box-body -->
              <div class="box-footer">
                <button type="submit" class="btn btn-default">Cancel</button>
                 <asp:Button ID="btnCangear" runat="server" cssclass="btn bg-olive btn-block" Text="Cangear" OnClick="btnCangear"/>
              </div>
              <!-- /.box-footer -->
            
          </div>
















</asp:Content>