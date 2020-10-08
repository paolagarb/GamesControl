<%@ Page Title="" Language="C#" MasterPageFile="~/Jogos/MasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroEdicaoJogo.aspx.cs" Inherits="BibliotecaJogos.Jogos.CadastroEdicaoJogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form>
        <div class="form-group">
            <label for="TxtTitulo">Título</label>
            <asp:TextBox ID="TxtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail">Valor Pago</label>
            <asp:TextBox ID="TxtValor" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail">Data Compra</label>
            <asp:TextBox ID="TxtCompra" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail">Imagem</label>
            <asp:FileUpload ID="FileUploadImage" runat="server" CssClass="form-control" />
        </div>
        <div class="form-group">
            <label for="exampleInputEmail">Gênero</label>
            <asp:DropDownList ID="DdlGenero" runat="server" DataValueField="Id" DataTextField="Descricao" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail">Editor</label>
            <asp:DropDownList ID="DdlEditor" runat="server" DataValueField="Id" DataTextField="Nome" CssClass="form-control"></asp:DropDownList>
        </div>
        <asp:Button ID="BtnGravar" runat="server" Text="Gravar" CssClass="btn btn-primary" />
    </form>
</asp:Content>
