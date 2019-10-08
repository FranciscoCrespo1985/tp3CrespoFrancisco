<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="Presentacion.Producto" %>

<asp:Content  runat="server" ID="ListaProducto" ContentPlaceHolderID="ContentPlaceHolder1">
     
    
    <div class="card-columns" style="margin-left: 10px; margin-right: 10px; margin-top:10px;">
       
        <% foreach (var item in listaProductos)
            { %>
        <div class="card">
            <img src="<% = item.URLImagen %>" class="card-img-top"alt="...">
            <div class="card-body">
                <h5 class="card-title"><% = item.Titulo %></h5>
                <p class="card-text"><% = item.Descripcion %></p>
            </div>
            <a class="btn btn-primary btn-block" href="Cliente.aspx?idprod=<% = item.Id.ToString() %>">Seleccionar</a>
            
        </div>
        <% } %>
    </div>

  
    
</asp:Content>