﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel ="stylesheet" type ="text/css" href="CSS/main.css" />
    <title>Index</title>
    <script src ="Scripts/jquery-3.3.1.min.js"></script>
    <script>
        //Add the header and footer bars
        $(function () {
            $("#header").load("addons/header.html");
            $("#footer").load("addons/footer.html");
        });
        //No Validation needed
    </script>
</head>
<body style="height: 859px; width: 1792px">
    <div id ="header"></div>
    <form id="frmIndex" runat="server">
        <div id ="Main" style= "height: 832px; width: 1765px; margin-bottom: 61px;">
            <asp:ImageButton ID="btnHome" runat="server" ImageUrl="images/TPS_Logo_Small.jpg" PostBackUrl="~/Index.aspx" CssClass="Logo" />
&nbsp;<h1>Navigation</h1>
            <p>
                <asp:ImageButton ID="btnUser" runat="server" ImageUrl="~/images/user.png" Width="61px" CssClass="Icons" PostBackUrl="~/UserManagement.aspx" />
                &nbsp;<asp:HyperLink ID="lnkUserManagement" runat="server" Text="User Management"></asp:HyperLink>
            </p>
            
            <p>
                <asp:ImageButton ID="btnStaff" runat="server" CssClass="Icons"  ImageUrl="~/images/staff.jpg" PostBackUrl="~/Staff.aspx" />
            &nbsp;<asp:HyperLink ID="lnkStaff" runat="server" Text="Staff"></asp:HyperLink>
            </p>

            <p>
                <asp:ImageButton ID="btnContracts" runat="server" CssClass="Icons"  ImageUrl="~/images/contract.png" PostBackUrl="~/Contracts.aspx" />
            &nbsp;<asp:HyperLink ID="lnkContracts" runat="server" Text="Contracts"></asp:HyperLink>
            </p>

            <p>
                <asp:ImageButton ID="imgStaffRequest" runat="server" CssClass="Icons"  ImageUrl="~/images/staffingrequest.jpg" PostBackUrl="~/StaffingRequest.aspx" />
            &nbsp;<asp:HyperLink ID="lnkStaffRequest" runat="server" Text="Staff Request"></asp:HyperLink>
            </p>
            
            <p>
                <asp:ImageButton ID="imgStaffRequestList" runat="server" CssClass="Icons" ImageUrl="~/images/staffrequestlist.png" PostBackUrl="~/StaffingRequest.aspx" />
                &nbsp;<asp:HyperLink ID ="lnkStaffRequestList" runat="server" Text="Staff Request List"></asp:HyperLink>            
            </p>
            <p>
                <asp:ImageButton ID="imgStaffPortal" runat="server" CssClass="Icons" ImageURL="~/images/staff.jpg" Height="50px" PostBackUrl="~/StaffPortal.aspx" />
                &nbsp;<asp:HyperLink ID ="HyperLink1" runat="server" Text="Staff Portal"></asp:HyperLink>            
            </p>
        </div>
    </form>
    <div id ="footer"></div>
</body>
</html>