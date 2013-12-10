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
                            <h3>18</h3>
                            <h3>Adept</h3>
                        </div>
                    </div>

                    <div class="filler">
                        
                    </div>

                    <div class="latest">
                        <div class="latestEntry">
                            <div class="latestHeader">
                                <h3 class="latestHeadline">Seneste Indslag</h3>
                            </div>
                            <div class="latestContent">
                                <div class="logEntryContent">
                                    <p><b>Running, 5km in 31 minutes</b> <i>14/4/13</i></p>
                                </div>
                                <div class="logEntryContent">
                                    <p><b>Running, 5km in 36 minutes</b> <i>12/4/13</i></p>
                                </div>
                                <div class="logEntryContent">
                                    <p><b>Running, 5km in 39 minutes</b> <i>10/4/13</i></p>
                                </div>
                            </div>
                        </div>

                        <div class="latestAch">
                            <div class="latestHeader">
                                <h3 class="latestHeadline">Seneste Bedrift</h3>
                            </div>
                            <div class="latestContentAch">
                                <b>Sheep Humper</b>
                                <div class="achImgContent">
                                    <img src="http://i.imgur.com/7Tzv4ht.png" alt="..." class="img-thumbnail" />
                                </div>
                                <p>Hump a sheep at least four times in a week</p>
                                <p><i>Achieved the April 4th, 2013</i></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
