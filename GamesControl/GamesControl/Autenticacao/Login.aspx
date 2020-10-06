<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GamesControl.Autenticacao.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <title>Biblioteca de Jogos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Usuário: <br />
            <asp:TextBox ID="txtUsuario" runat="server" Width="135px"></asp:TextBox>
            <br />
            Senha: <br />
            <asp:TextBox ID="txtSenha" runat="server" Width="135px" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="BtnLogin" Text="Entrar" runat="server" OnClick="BtnLogin_Click" />
        </div>
    </form>
</body>
</html>
