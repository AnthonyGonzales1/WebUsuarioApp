<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebConsultUsuario.aspx.cs" Inherits="WebUsuarioApp.Consultas.WebConsultUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    <!-- Page Head -->
    <div class="row">
        <div class="text-center">
            <div class="col-md-12">
                <h1 class="page-header">Consulta Usuarios </h1>
            </div>
        </div>
    </div>
    <%--Componentes--%>
    <div class="form-group">
        <div class="col-md-12">
            <asp:Label ID="BuscarLabel" For="BuscarTexBox" runat="server" Font-Bold="True" Text="Buscar por:"></asp:Label>
        </div>
        <div class="col-md-2 col-sm-2 col-xs-3">
            <asp:DropDownList ID="CamposDropDownList" runat="server" CssClass="form-control" class="btn btn-primary dropdown-toggle">
                <asp:ListItem>Seleccionar...</asp:ListItem>
                <asp:ListItem>UsuarioId</asp:ListItem>
                <asp:ListItem>Nombres</asp:ListItem>
                <asp:ListItem>Email</asp:ListItem>
            </asp:DropDownList>
            <
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="tFiltro" runat="server" CssClass="form-control input-sm"></asp:TextBox>
        </div>
        <div class="col-md-4">
            <asp:Button ID="bBuscar" runat="server" CssClass="form-control" Text="Buscar" />
        </div>
    </div>

    <%--GRID--%>
    <div class="col-md-12">
        <asp:GridView ID="DatosGridView"
            runat="server"
            class="table table-condensed table-bordered table-responsive"
            CellPadding="4" ForeColor="#333333" GridLines="None">

            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:HyperLinkField ControlStyle-ForeColor="blue"
                    DataNavigateUrlFields="UsuarioId"
                    DataNavigateUrlFormatString="~/Registros/WebFormUsuario.aspx?Id={0}"
                    Text="Editar"></asp:HyperLinkField>
            </Columns>
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:GridView>

    </div>
</asp:Content>
