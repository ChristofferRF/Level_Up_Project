<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebClient.aspx.cs" Inherits="Client.WebClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Training Log</title>
    <link rel="stylesheet" type="text/css" href="css.css">

    <link href="//netdna.bootstrapcdn.com/bootstrap/3.0.2/css/bootstrap.min.css" rel="stylesheet" />
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.0.2/js/bootstrap.min.js"></script>
</head>
<body class="body">
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label ID="ExcerciseLabel" Text="Aktivitet" runat="server"></asp:Label>
            <asp:TextBox ID="excerciseTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="DistanceLabel" Text="Distance" runat="server"></asp:Label>
            <asp:TextBox ID="distanceTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Tid" Text="Tid" runat="server"></asp:Label>
            <asp:TextBox ID="TimeTextBox" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
