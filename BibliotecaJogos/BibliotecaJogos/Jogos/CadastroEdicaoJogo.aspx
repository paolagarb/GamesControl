<%@ Page Title="" Language="C#" MasterPageFile="~/Jogos/MasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroEdicaoJogo.aspx.cs" Inherits="BibliotecaJogos.Jogos.CadastroEdicaoJogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group">
        <label for="TxtTitulo">Título</label>
        <asp:RequiredFieldValidator ID="RfvTitulo" runat="server" ErrorMessage="Preencha o campo Título" ControlToValidate="TxtTitulo" Text="*"></asp:RequiredFieldValidator>
        <asp:TextBox ID="TxtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="TxtValor">Valor Pago</label>
        <asp:TextBox ID="TxtValor" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="TxtCompra">Data Compra</label>
        <asp:TextBox ID="TxtCompra" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="FileUploadImage">Imagem</label>
        <asp:FileUpload ID="FileUploadImage" runat="server" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label for="DdlGenero">Gênero</label>
        <asp:RequiredFieldValidator ID="RfvGenero" runat="server" ErrorMessage="Preencha o campo Gênero" ControlToValidate="DdlGenero" Text="*"></asp:RequiredFieldValidator>
        <asp:DropDownList ID="DdlGenero" runat="server" DataValueField="Id" DataTextField="Descricao" CssClass="form-control"></asp:DropDownList>
    </div>
    <div class="form-group">
        <label for="DdlEditor">Editor</label>
        <asp:RequiredFieldValidator ID="RfvEditor" runat="server" ErrorMessage="Preencha o campo Editor" ControlToValidate="DdlEditor" Text="*"></asp:RequiredFieldValidator>
        <asp:DropDownList ID="DdlEditor" runat="server" DataValueField="Id" DataTextField="Nome" CssClass="form-control"></asp:DropDownList>
    </div>
    <asp:ValidationSummary ID="valSum"
        DisplayMode="BulletList"
        ForeColor="Red"
        EnableClientScrip="true"
        HeaderText="Preencha os seguintes campos:"
        runat="server" />
    <br />
    <asp:Label ID="LblMsgErro" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="BtnGravar" runat="server" Text="Gravar" CssClass="btn btn-primary" OnClick="BtnGravar_Click" />
    <br />
    <a href="Catalogo.aspx">Voltar ao catálogo de jogos</a>
</asp:Content>
