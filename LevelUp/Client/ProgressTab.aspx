<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProgressTab.aspx.cs" Inherits="Client.ProgressTab" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile</title>
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
                    <b>Navn:<br />
                    </b>
                    <i>user input</i><br />
                    <b>Alder:<br />
                    </b>
                    <i>user input</i><br />
                    <b>Højde<br />
                    </b>
                    <i>user input</i><br />
                    <b>Vægt:</b><br />
                    <i>user input</i><br />

                </div>
            </div>

            <div class="pgRightPanel">
                <div class="header">
                    <ul class="nav nav-tabs">
                        <li class="active"><a href="#">Progress</a></li>
                        <li><a href="#">Achievements</a></li>
                        <li><a href="#">Statistics</a></li>
                        <li><a href="#">. . .</a></li>
                    </ul>

                </div>
                <div class="mainWindow">
                    <div class="overview">
                        <div class="overviewLeft">
                            <h3>Level:</h3>
                            <h3>Title:</h3>
                        </div>
                        <div class="overviewRight">
                            <h3>input</h3>
                            <h3>input</h3>
                        </div>
                    </div>

                    <div class="latest">
                        <div class="latestEntry">
                            Latest entry
                        </div>
                        <div class="latestAch">
                            Latest Achievement
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
