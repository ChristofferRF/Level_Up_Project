<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateLogs.aspx.cs" Inherits="Client.CreateLogs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Training Log</title>
    <link rel="stylesheet" type="text/css" href="css.css" />

    <link href="//netdna.bootstrapcdn.com/bootstrap/3.0.2/css/bootstrap.min.css" rel="stylesheet" />
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.0.2/js/bootstrap.min.js"></script>
</head>
<body class="body">
    <form id="form1" runat="server">
        <div class="progressTab">
            <div class="sidebar">

                <div class="userImg">
                    <img src="http://i.imgur.com/rzOnp.gif" alt="..." class="img-thumbnail" />
                </div>
                <div class="userInfo">
                    <b>
                        <asp:Label ID="userInfoName" runat="server"></asp:Label></b>
                    <br />
                    <i>user input</i>
                    <br />
                    <b>
                        <asp:Label ID="userInfoAge" runat="server"></asp:Label></b>
                    <br />
                    <i>user input</i>
                    <br />
                    <b>
                        <asp:Label ID="userInfoHeight" runat="server"></asp:Label></b>
                    <br />

                    <i>user input</i>
                    <br />
                    <b>
                        <asp:Label ID="userInfoWeight" runat="server"></asp:Label></b>
                    <br />
                    <i>user input</i>
                    <br />

                </div>
            </div>

            <div class="pgRightPanel">
                <div class="header">
                    <ul class="nav nav-tabs">
                        <li><a href="ProgressTab.aspx">
                            <asp:Label ID="navProgress" runat="server"></asp:Label></a></li>
                        <li class="active"><a href="#">
                            <asp:Label ID="navEntry" runat="server"></asp:Label></a></li>
                        <li><a href="#">
                            <asp:Label ID="navAch" runat="server"></asp:Label></a></li>
                        <li><a href="#">
                            <asp:Label ID="navStatistics" runat="server"></asp:Label></a></li>
                        <li><a href="#">. . .</a></li>
                    </ul>

                </div>
                <div class="mainWindow">
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
                        <asp:TextBox ID="RewardOutput" TextMode="MultiLine" Width="100%" Height="75%" runat="server"></asp:TextBox>
                    </div>

                    <div class="logHistory">
                        <b><asp:Label ID="LogsLabel" runat="server"></asp:Label></b>
                        <table class="table table-hover">
                            <tr>
                                <td><b><asp:Label ID="tableDate" runat="server"></asp:Label></b></td>
                                <td><b><asp:Label ID="tableActivity" runat="server"></asp:Label></b></td>
                                <td><b><asp:Label ID="tableDistance" runat="server"></asp:Label></b></td>
                                <td><b><asp:Label ID="tableTime" runat="server"></asp:Label></b></td>
                            </tr>
                            <tr>
                                <td>14/4</td>
                                <td>Went running</td>
                                <td>4 km</td>
                                <td>30 minutes</td>
                            </tr>
                            <tr>
                                <td>12/4</td>
                                <td>Went running</td>
                                <td>4 km</td>
                                <td>32 minutes</td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
