<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfileAdmin.aspx.cs" Inherits="Client.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administrer profil</title>
    <link rel="stylesheet" type="text/css" href="css.css" />

    <link href="//netdna.bootstrapcdn.com/bootstrap/3.0.2/css/bootstrap.min.css" rel="stylesheet" />
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.0.2/js/bootstrap.min.js"></script>
</head>
<body class="body">
    <form id="form1" runat="server" class="form-horizontal">
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
                            <asp:Label ID="navProgress" runat="server"></asp:Label></a>
                        </li>
                        <li><a href="CreateLogs.aspx">
                            <asp:Label ID="navEntry" runat="server"></asp:Label></a></li>
                        <li><a href="#">
                            <asp:Label ID="navAch" runat="server"></asp:Label></a></li>
                        <li><a href="#">
                            <asp:Label ID="navStatistics" runat="server"></asp:Label></a></li>
                        <li class="active"><a href="#"><span class="glyphicon glyphicon-wrench"></span></a></li>
                    </ul>

                </div>
                <div class="mainWindow">
                    <h3>Administrer profil</h3>
                    <br />


                    <div class="form-group">
                        <label for="inputEmail3" class="col-sm-3 control-label">Select title</label>
                        <div class="col-sm-4">
                            <select class="form-control">
                                <option>Brute</option>
                                <option>Athlete</option>
                                <option>Meat Planet</option>
                            </select><br />
                        </div>
                    </div>

                    Select visibility
                <div class="form-group">
                    <label for="inputEmail3" class="col-sm-3 control-label">Name</label>
                    <div class="col-sm-4">
                        <select class="form-control">
                            <option>Everyone</option>
                            <option>Only friends</option>
                            <option>None</option>
                        </select>
                    </div>
                </div>

                    <div class="form-group">
                        <label for="inputEmail3" class="col-sm-3 control-label">Age</label>
                        <div class="col-sm-4">
                            <select class="form-control">
                                <option>Everyone</option>
                                <option>Only friends</option>
                                <option>None</option>
                            </select>
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="inputEmail3" class="col-sm-3 control-label">Height</label>
                        <div class="col-sm-4">
                            <select class="form-control">
                                <option>Everyone</option>
                                <option>Only friends</option>
                                <option>None</option>
                            </select>
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="inputEmail3" class="col-sm-3 control-label">Weight</label>
                        <div class="col-sm-4">
                            <select class="form-control">
                                <option>Everyone</option>
                                <option>Only friends</option>
                                <option>None</option>
                            </select>
                        </div>
                    </div>
                    <br />
                    Change email<br />
                    confirm new email<br />
                    <br />
                    change password<br />
                    confirm password<br />
                    
                    Save
                    Reset account   
                    Delete account
                </div>
            </div>
        </div>

    </form>
</body>
</html>
