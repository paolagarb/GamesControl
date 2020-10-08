<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BibliotecaJogos.Autenticacao.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
            <br />
            <asp:TextBox ID="txtUsuario" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
            <br />
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click" />
            <br />
            <asp:Label ID="lblResposta" runat="server" Text=""></asp:Label>
        </div> 
    </form>
</body>
</html>
