<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginClient.aspx.cs" Inherits="Client.LoginClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" type="text/css" href="css.css">
</head>
<body class="body">
    <div id="logincontainer">
        <form id="form1" runat="server">
            <div>
                <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
                <asp:TextBox ID="txtBoxUsername" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblPassword" runat="server" Text="Password:" Style="margin-top: 20px;"></asp:Label>
                <asp:TextBox ID="txtBoxPassword" runat="server" Style="margin-top: 8px;"></asp:TextBox>
                <br />
                <asp:Button ID="btnCreateUser" runat="server" Text="SignUp" Style="margin-top: 10px; margin-left:105px; float:left;"/>
                <asp:Button ID="btnLogin" runat="server" Text="Login" Style="margin-top: 10px; margin-right:57px; float:right;"/>
            </div>
        </form>
    </div>
</body>
</html>