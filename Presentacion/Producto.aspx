<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="Presentacion.Producto" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <div class="form-box" id="login-box">
            <div class="header">Ingresar Voucher</div>
            
                <div class="body bg-gray">
                    <div class="form-group">
                         <asp:TextBox ID="txtCodigoVoucher"  runat="server"  CssClass="form-control" placeholder="ingrese usuario"></asp:TextBox>
                    </div>
                </div>
                <div class="footer bg-gray">
                    <asp:Button ID="btnCangear" runat="server" cssclass="btn bg-olive btn-block" Text="Login" OnClick="btnIngresar_Click"/>
                </div>
        </div>

    
    
</asp:Content>