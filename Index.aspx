<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!--Index Form Code TPS Website
//Programmed by: Markus Reynolds
//3/31/2019
//Open source avaiable under GNU License
//A GNU License should be included in the documentation for this code but you can also find it online
-->
<!DOCTYPE html>
<meta name="viewport" content="width=device-width, initial-scale=1">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/main.css" />
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
    <title>Index</title>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script>
        //Add the header and footer bars
        $(function () {
            $("#header").load("addons/header.html");
            $("#footer").load("addons/footer.html");
        });
        //No Validation needed
        //  test
    </script>
</head>
<body>
    <div id="header"></div>
    <form id="frmIndex" runat="server">
        <div id="Main">
            <asp:ImageButton ID="btnHome" runat="server" ImageUrl="images/TPS_Logo_Small.jpg" PostBackUrl="~/Index.aspx" CssClass="Logo" />
            <br />
            <header class="w3-container">
                <h1>Navigation</h1>
            </header>
            <div class="w3-container">
                <header class="w3-container">
                    <h3>User Management</h3>
                </header>
                <asp:ImageButton ID="btnUser" runat="server" ImageUrl="~/images/user.png" CssClass="Icons  w3-card-4" PostBackUrl="~/UserManagement.aspx" Visible="False" />
            </div>
            <div class="w3-container">
                <header class="w3-container">
                    <h3>Staff Management</h3>
                </header>
                <asp:ImageButton ID="btnStaff" runat="server" CssClass="Icons w3-card-4" ImageUrl="~/images/staff.jpg" PostBackUrl="~/Staff.aspx" Visible="False" />
            </div>
            <div class="w3-container">
                <header class="w3-container">
                    <h3>Contract Management</h3>
                </header>
                <asp:ImageButton ID="btnContracts" runat="server" CssClass="Icons  w3-card-4" ImageUrl="~/images/contract.png" PostBackUrl="~/Contracts.aspx" Visible="False" />
            </div>
            <div class="w3-container">
                <header class="w3-container">
                    <h3>Staff Requests</h3>
                </header>
                <asp:ImageButton ID="btnStaffRequest" runat="server" CssClass="Icons  w3-card-4" ImageUrl="~/images/staffingrequest.jpg" PostBackUrl="~/StaffRequest.aspx" Visible="False" />
            </div>

            <div class="w3-container">
                <header class="w3-container">
                    <h3>Staff Portal</h3>
                </header>
                <asp:ImageButton ID="btnStaffPortal" runat="server" CssClass="Icons  w3-card-4" ImageUrl="~/images/staffportal.jpg" PostBackUrl="~/StaffPortal.aspx" />
            </div>
        </div>
    </form>
    <div id="footer"></div>
</body>
</html>
