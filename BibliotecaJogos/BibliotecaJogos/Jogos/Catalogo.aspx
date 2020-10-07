<%@ Page Title="" Language="C#" MasterPageFile="~/Jogos/MasterPage.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="BibliotecaJogos.Jogos.Catalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Content/Jogos/catalogo.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Repeater ID="RepeaterJogos" runat="server">
        <ItemTemplate>
            <div class="jogo">
                <div class="capa-jogo">
                </div>
                <div class="nome-jogo">
                </div>
            </div>

        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
