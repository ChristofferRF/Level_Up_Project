﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Client.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Opret bruger</title>
    <link rel="stylesheet" type="text/css" href="css.css" />

    <link href="//netdna.bootstrapcdn.com/bootstrap/3.0.2/css/bootstrap.min.css" rel="stylesheet" />
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.0.2/js/bootstrap.min.js"></script>
</head>
<body class="body">

    
    <form id="form1" runat="server">

        <div class="createUserBox">

            <h4>Oprettelse af ny bruger</h4>
            <asp:Label ID="lblSelectedUsername" runat="server"></asp:Label>
            <asp:TextBox ID="selectedUsername" runat="server" CssClass="form-control" placeholder="Vælg dit brugernavn"></asp:TextBox><br />

            <asp:Label ID="lblSelectedPassword" runat="server"></asp:Label>
            <asp:TextBox ID="selectedPassword" runat="server" CssClass="form-control" placeholder="Vælg et kodeord" type="password"></asp:TextBox><br />

            <asp:Label ID="lblConfirmPassword" runat="server"></asp:Label>
            <asp:TextBox ID="confirmPassword" runat="server" CssClass="form-control" placeholder="Bekræft dit kodeord" type="password"></asp:TextBox>
            <br />


            <b>Indtast venligst dine oplysninger:</b><br />
            <asp:Label ID="lblUsername" runat="server"></asp:Label>
            <asp:TextBox ID="userName" runat="server" CssClass="form-control" placeholder="Indtast dit navn"></asp:TextBox><br />
            
            <asp:Label ID="lblUserage" runat="server"></asp:Label>
            <asp:TextBox ID="userAge" runat="server" CssClass="form-control" placeholder="Indtast din alder"></asp:TextBox><br />
            
            <asp:Label ID="lblUserheight" runat="server"></asp:Label><br />
            <asp:TextBox ID="userHeight" runat="server" CssClass="form-control" placeholder="Indtast din højde i cm, f.eks. 175"></asp:TextBox><br />
            
            <asp:Label ID="lblUserweight" runat="server"></asp:Label><br />
            <asp:TextBox ID="userWeight" runat="server" CssClass="form-control" placeholder="Indtast din vægt i kg f.eks. 82"></asp:TextBox><br />

            <asp:Button OnClick="CreateUser_Click" ID="createUserButton" runat="server" CssClass="btn btn-success"/>
        </div>
    </form>
</body>
</html>
