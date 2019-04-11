﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffPortal.aspx.cs" Inherits="StaffPortal" %>
<!--StaffPortal Form Code TPS Website
//Programmed by: Markus Reynolds
//3/31/2019
//Open source avaiable under GNU License
//A GNU License should be included in the documentation for this code but you can also find it online
-->

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Portal</title>
   <link rel="stylesheet" type="text/css" href="CSS/main.css" />
    <script src ="Scripts/jquery-3.3.1.min.js"></script>
    <script>
        //Add the header and footer bars
        $(function () {
            $("#header").load("addons/header.html");
            $("#footer").load("addons/footer.html");
        });
        //No validation needed
    </script>
</head>
<body>
    <form id="frmStaffPortal" runat="server">
        <div id="header"></div>
        <div id="Main">
            <p>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/TPS_Logo_Small.jpg" PostBackUrl="~/Index.aspx" />
            </p>
            <p>
                <img src="images/staff.jpg" class="Icons" />
            </p>
            <h1>Staff Portal</h1>
            <p>
                <asp:Label runat="server" Text="Bio: " CssClass ="Labels"></asp:Label>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 &nbsp;<asp:TextBox runat ="server" CssClass ="Inputs" ID ="txtBio"></asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" Text="Availability: " CssClass ="Labels"></asp:Label>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 &nbsp;<asp:TextBox runat ="server" CssClass ="Inputs" ID ="textAvail"></asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" Text="Resume: " CssClass ="Labels"></asp:Label>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:FileUpload runat ="server" CssClass ="Buttons" ID ="fileupResume"></asp:FileUpload>
            </p>
            <p>
                <asp:Label runat="server" Text="Picture: " CssClass ="Labels"></asp:Label>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:FileUpload runat ="server" CssClass ="Buttons" ID ="fileupPicture"></asp:FileUpload>
            </p>
            <p>
                <asp:Label runat="server" Text="StaffID: " CssClass = "Labels"/>
                <asp:TextBox runat="server" ID="txtStaffID" CssClass="Inputs"/>
            </p>
            <p>
                <asp:Button runat ="server" Text="Update" ID="btnUpdate" OnClick="btnUpdate_OnButtonClick"/>
            </p>
            <p>
                <asp:Label runat="server" CssClass="Error" ID="error"></asp:Label>
            </p>
        </div>
    </form>
    <div id ="footer"></div>
</body>
</html>
