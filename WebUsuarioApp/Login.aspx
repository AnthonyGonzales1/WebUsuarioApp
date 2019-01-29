<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebUsuarioApp.WebFormLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="text-center">
            <div class="col-md-12">
                <h1 class="page-header">Login </h1>

                <br>
                <label for="inputEmail">Email address</label>
                <asp:TextBox ID="tUsuarios" runat="server"  CssClass="form-control" placeholder="Email"></asp:TextBox>

                <br>
                <label for="inputClave">Clave</label>
                <asp:TextBox ID="tClave" runat="server" CssClass="form-control" placeholder="Password" ></asp:TextBox> 
                <br>
                <asp:Button ID="bIniciar" runat="server" Text="Iniciar Secion" />
                <br>
            </div>
        </div>
    </div>
</asp:Content>
