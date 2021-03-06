﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Accounts_Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Details</title>
    <script src="../../../Style/js/bootstrap.min.js"></script>
    <link href="../../../Style/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../../Style/StyleSheet.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.1/css/font-awesome.min.css" />
    <style>
        body {
            background-image: url(<%= Page.ResolveUrl("~/Image/1.jpg") %>);
            position: absolute;
            width: 100%;
            height: 100%;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="row main" style="margin-top: 15px;">
            <div class="main-login main-center">
                <form class="form-horizontal" runat="server">

                    <!-- Wrong UID warning -->
                    <asp:Panel ID="pnlDN" runat="server" CssClass="alert alert-danger alert-dismissable fade in" Visible="false">
                        <strong>Incorrect user ID!</strong>
                    </asp:Panel>

                    <!-- Header -->
                    <fieldset>
                        <legend>Personal Infomation</legend>
                    </fieldset>

                    <!-- FName -->
                    <div class="form-group">
                        <label for="name" class="cols-sm-2 control-label">First Name&nbsp; </label>
                        <asp:RequiredFieldValidator ID="rqfFN" runat="server" ControlToValidate="txtFN" ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="DN"></asp:RequiredFieldValidator>
                        &nbsp;<div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                                <asp:TextBox CssClass="form-control" runat="server" ID="txtFN" placeholder="Enter first Name" />
                            </div>
                        </div>
                    </div>

                    <!-- LName -->
                    <div class="form-group">
                        <label for="name" class="cols-sm-2 control-label">
                            Last Name
                        <asp:RequiredFieldValidator ID="rqfLN" runat="server" ControlToValidate="txtLN" ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="DN"></asp:RequiredFieldValidator>
                        </label>
                        &nbsp;<div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                                <asp:TextBox CssClass="form-control" runat="server" ID="txtLN" placeholder="Enter last Name" />
                            </div>
                        </div>
                    </div>

                    <!-- Phone -->
                    <div class="form-group">
                        <label for="phone" class="cols-sm-2 control-label">
                            Phone
                        <asp:RequiredFieldValidator ID="rqfUser" runat="server" ControlToValidate="txtPhone" ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="DN"></asp:RequiredFieldValidator>
                        </label>
                        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPhone" ErrorMessage="Incorrect format" ForeColor="Red" ValidationExpression="\(?\d+\)?[-.\s]?\d+[-.\s]?\d+" ValidationGroup="DN"></asp:RegularExpressionValidator>
                        <div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-phone fa" aria-hidden="true"></i></span>
                                <asp:TextBox CssClass="form-control" runat="server" ID="txtPhone" placeholder="Enter Phone" />
                            </div>
                        </div>
                    </div>

                    <!-- Address -->
                    <div class="form-group">
                        <label for="address" class="cols-sm-2 control-label">
                            Address
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAddr" ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="DN"></asp:RequiredFieldValidator>
                        </label>
                        &nbsp;<div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-home fa" aria-hidden="true"></i></span>
                                <asp:TextBox CssClass="form-control" runat="server" ID="txtAddr" placeholder="Enter Address" />
                            </div>
                        </div>
                    </div>

                    <!-- Funtional buttons -->
                    <div class="form-group">
                        <asp:Button ID="btnTao" OnClick="btnTao_Click" class="btn btn-primary btn-lg btn-block login-button" runat="server" Text="Register" ValidationGroup="DN" />
                    </div>

                    <div class="login-register">
                        <a href="../NewAccount">Back</a>
                    </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
