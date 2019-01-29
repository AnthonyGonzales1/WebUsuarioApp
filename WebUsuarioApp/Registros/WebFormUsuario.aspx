<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormUsuario.aspx.cs" Inherits="WebUsuarioApp.Registros.WebFormUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="text-center">
            <div class="col-md-12">
                <h1 class="page-header">Usuarios </h1>

                <asp:Label ID="Label1" runat="server" Text="Usuario ID"></asp:Label>
                <asp:TextBox ID="tUsuarioID" runat="server"></asp:TextBox>
                <asp:Button ID="bBuscar" runat="server" Text="Buscar" />
                <br>
                Nombres<asp:TextBox ID="tNombres" CssClass="form-control" runat="server"></asp:TextBox>
                <br>
                Email<asp:TextBox ID="tEmail" CssClass="form-control" runat="server"></asp:TextBox>
                <br>
                Clave<asp:TextBox ID="tClave" CssClass="form-control" runat="server"></asp:TextBox>
                <br>
                Confirmar Clave<asp:TextBox ID="tConfirmarClave" CssClass="form-control" runat="server"></asp:TextBox>
                <br />
                <asp:ValidationSummary ID="SumaryValidation" runat="server" CssClass=" alert alert-danger" DisplayMode="BulletList" EnableClientScript="True" Font-Bold="False" ForeColor="red" ShowSummary="true" />
                <br />
                <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
                <br>
                <asp:Button ID="bNuevo" runat="server" Text="Nuevo" />
                <asp:Button ID="bGuardar" runat="server" Text="Guardar" />
                <asp:Button ID="bEliminar" runat="server" Text="Eliminar" />
            </div>
        </div>
    </div>
</asp:Content>
