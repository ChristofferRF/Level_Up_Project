﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfileAdmin.aspx.cs" Inherits="Client.WebForm2" %>

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
                    <i>
                        <asp:Label ID="AdmNameLbl" runat="server"></asp:Label>
                    </i>
                    <br />
                    <b>
                        <asp:Label ID="userInfoAge" runat="server"></asp:Label></b>
                    <br />
                    <i>
                        <asp:Label ID="AdmAgeLbl" runat="server"></asp:Label>
                    </i>
                    <br />
                    <b>
                        <asp:Label ID="userInfoHeight" runat="server"></asp:Label></b>
                    <br />

                    <i>
                        <asp:Label ID="AdmHeightLbl" runat="server"></asp:Label>
                    </i>
                    <br />
                    <b>
                        <asp:Label ID="userInfoWeight" runat="server"></asp:Label></b>
                    <br />
                    <i>
                        <asp:Label ID="AdmWeightLbl" runat="server"></asp:Label>
                    </i>
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
                        <li class="active"><a href="#">
                            <span class="glyphicon glyphicon-cog"></span></a>
                        </li>
                    </ul>

                </div>
                <div class="mainWindow">
                    <div class="adminHeadline">
                        <h4>Administrer profil</h4>
                    </div>


                    <div class="adminBox">
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-4 control-label">Vælg Titel</label>
                            <div class="col-sm-5">
                                <select class="form-control">
                                    <option>Brute</option>
                                    <option>Athlete</option>
                                    <option>Meat Planet</option>
                                </select>
                            </div>
                        </div>
                    </div>

                    <div class="adminBox">
                        <br />
                        <b>Vælg dine informationers synlighed</b><br />
                        <br />
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-4 control-label">Name</label>
                            <div class="col-sm-5">
                                <select class="form-control">
                                    <option>Alle</option>
                                    <option>Kun Venner</option>
                                    <option>Ingen</option>
                                </select>
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-4 control-label">Alder</label>
                            <div class="col-sm-5">
                                <select class="form-control">
                                    <option>Alle</option>
                                    <option>Kun Venner</option>
                                    <option>Ingen</option>
                                </select>
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-4 control-label">Height</label>
                            <div class="col-sm-5">
                                <select class="form-control">
                                    <option>Alle</option>
                                    <option>Kun Venner</option>
                                    <option>Ingen</option>
                                </select>
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-4 control-label">Weight</label>
                            <div class="col-sm-5">
                                <select class="form-control">
                                    <option>Alle</option>
                                    <option>Kun Venner</option>
                                    <option>Ingen</option>
                                </select>
                            </div>
                        </div>
                    </div>
                    <br />


                    <b>Change e-mail</b><br />
                    <div class="adminBox">
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-4 control-label">Ændre e-mail</label>
                            <div class="col-sm-5">
                                <input class="form-control" placeholder="Enter new email" />
                            </div>
                        </div>
                    </div>
                    <br />

                    <b>Change password</b><br />
                    <div class="adminBox">
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-4 control-label">Nuværende kodeord</label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtBoxPW1" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-4 control-label">Nyt kodeord</label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtBoxPW2" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-4 control-label">Gentag Nyt kodeord</label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtBoxPW3" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                    </div>
                    <div class="adminBox">
                        <asp:Button ID="Button1" runat="server" Text="Save all changes" OnClick="btnSave_Click" class="btn btn-primary" />

                        <button type="button" class="btn btn-danger">Nulstil Konto</button>

                        <button type="button" class="btn btn-danger">Slet Konto</button>
                        <br /><br />
                    </div>
            </div>
        </div>

    </form>
</body>
</html>