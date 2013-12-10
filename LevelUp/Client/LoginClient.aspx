<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginClient.aspx.cs" Inherits="Client.LoginClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" type="text/css" href="css.css" />

    <link href="//netdna.bootstrapcdn.com/bootstrap/3.0.2/css/bootstrap.min.css" rel="stylesheet" />
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.0.2/js/bootstrap.min.js"></script>
</head>
<body class="body">
    <form id="form1" runat="server">
        <div id="logincontainer" class="container" style="width: 300px">
            <asp:Label ID="lblUsername" runat="server"></asp:Label>
            <asp:TextBox ID="txtBoxUsername" runat="server" class="form-control" placeholder="Indtast brugernavn"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassword" runat="server"></asp:Label>
            <asp:TextBox ID="txtBoxPassword" runat="server" class="form-control" placeholder="Indtast kodeord" type="password"></asp:TextBox>
            <br />
            <asp:Button ID="btnCreateUser" runat="server" class="btn btn-primary" />
            <asp:Button ID="btnLogin" runat="server" Text="Log ind" OnClick="btnLogin_Click" class="btn btn-primary" />
        </div>
    </form>
</body>
</html>
