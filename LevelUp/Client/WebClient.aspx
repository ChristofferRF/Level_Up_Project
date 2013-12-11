<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebClient.aspx.cs" Inherits="Client.WebClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Training Log</title>
    <link rel="stylesheet" type="text/css" href="css.css"/>

    <link href="//netdna.bootstrapcdn.com/bootstrap/3.0.2/css/bootstrap.min.css" rel="stylesheet" />
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.0.2/js/bootstrap.min.js"></script>
</head>
<body class="body">
    <form id="form1" runat="server">
        <div class="container">
            <div class="logBox">
                <asp:Label ID="ExcerciseLabel" runat="server"></asp:Label><br />
                <asp:TextBox ID="excerciseTextBox" runat="server" class="form-control"></asp:TextBox>
                <br />
                <asp:Label ID="DistanceLabel" runat="server"></asp:Label><br />
                <asp:TextBox ID="distanceTextBox" runat="server" class="form-control"></asp:TextBox>
                <br />
                <asp:Label ID="TimeLabel" runat="server"></asp:Label><br />
                <asp:TextBox ID="HoursTextBox" runat="server" class="timeInput" placeholder="Hours"></asp:TextBox>
                :
            <asp:TextBox ID="MinutesTextBox" runat="server" class="timeInput" placeholder="Minutes"></asp:TextBox>
                : 
            <asp:TextBox ID="SecondsTextBox" runat="server" class="timeInput" placeholder="Seconds"></asp:TextBox>
                <br />
                <br />

                <asp:Button OnClick="CreateLog_Click" ID="CreateLogButton" runat="server" class="btn btn-primary" />
                <!--<asp:Button ID Text-->
            </div>

            <!--The Rewards Box -->
            <div class="rewardBox">
                <asp:Label ID="RewardsLabel" runat="server"></asp:Label>
                <br />
                <asp:TextBox ID="RewardOutput" Textmode="MultiLine" Width="100%" Height="100%" runat="server"></asp:TextBox>
            </div>
           
            <div class="logHistory">
                <asp:Label ID="LogsLabel" runat="server"></asp:Label>
                <br />-
                <asp:ListView ID="LogsListView" runat="server"></asp:ListView>
            </div>
        </div>
    </form>
</body>
</html>
