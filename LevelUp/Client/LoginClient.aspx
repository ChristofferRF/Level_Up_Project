<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginClient.aspx.cs" Inherits="Client.LoginClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" type="text/css" href="css.css">
    
    <link href="//netdna.bootstrapcdn.com/bootstrap/3.0.2/css/bootstrap.min.css" rel="stylesheet" />
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.0.2/js/bootstrap.min.js"></script>
</head>
<body class="body" style="padding-top:120px;">
        <form id="form1" runat="server">
            <div id="logincontainer" class="container" style="width:300px">
                <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
                <asp:TextBox ID="txtBoxUsername" runat="server" class="form-control" placeholder="indtast brugernavn"></asp:TextBox>
                <br />
                <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
                <asp:TextBox ID="txtBoxPassword" runat="server" class="form-control" placeholder="indtast kodeord"></asp:TextBox>
                <br />
                    <asp:Button ID="btnCreateUser" runat="server" Text="SignUp" class="btn btn-primary" style="margin-left:131px"/>
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" class="btn btn-primary" style="margin-left:2px"/>
                </div>
        </form>
</body>
</html>