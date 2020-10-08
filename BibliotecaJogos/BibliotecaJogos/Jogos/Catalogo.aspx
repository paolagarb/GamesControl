<%@ Page Title="" Language="C#" MasterPageFile="~/Jogos/MasterPage.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="BibliotecaJogos.Jogos.Catalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Content/Jogos/catalogo.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Catálogo de Jogos</h2>
    <hr />
    <asp:Repeater ID="RepeaterJogos" runat="server">
        <ItemTemplate>
            <div class="jogo">
                <div class="capa-jogo">
                    <img src="../Content/Imagens/<%# DataBinder.Eval(Container.DataItem, "Imagem") %>" alt="<%#DataBinder.Eval(Container.DataItem, "Titulo") %>"/>
                </div>
                <div class="nome-jogo">
                    <%# DataBinder.Eval(Container.DataItem,"Titulo") %>
                </div>
            </div>

        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
