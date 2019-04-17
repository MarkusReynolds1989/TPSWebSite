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
    <link rel ="stylesheet" type ="text/css" href="CSS/main.css" />
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
    <title>Index</title>
    <script src ="Scripts/jquery-3.3.1.min.js"></script>
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
<body style="height: 859px; width: 1792px">
    <div id ="header"></div>
    <form id="frmIndex" runat="server">
        <div id ="Main" style= "height: 832px; width: 1765px; margin-bottom: 61px;">
            <asp:ImageButton ID="btnHome" runat="server" ImageUrl="images/TPS_Logo_Small.jpg" PostBackUrl="~/Index.aspx" CssClass="Logo" />
&nbsp;<h1>Navigation</h1>
            <p>
                <asp:ImageButton ID="btnUser" runat="server" ImageUrl="~/images/user.png" Width="61px" CssClass="Icons" PostBackUrl="~/UserManagement.aspx" Visible="False" />
                &nbsp;<asp:HyperLink ID="lnkUserManagement" runat="server" Text="User Management" Visible="False"></asp:HyperLink>
            </p>
            
            <p>
                <asp:ImageButton ID="btnStaff" runat="server" CssClass="Icons"  ImageUrl="~/images/staff.jpg" PostBackUrl="~/Staff.aspx" Visible="False" />
            &nbsp;<asp:HyperLink ID="lnkStaff" runat="server" Text="Staff" Visible="False"></asp:HyperLink>
            </p>

            <p>
                <asp:ImageButton ID="btnContracts" runat="server" CssClass="Icons"  ImageUrl="~/images/contract.png" PostBackUrl="~/Contracts.aspx" Visible="False" />
            &nbsp;<asp:HyperLink ID="lnkContracts" runat="server" Text="Contracts" Visible="False"></asp:HyperLink>
            </p>

            <p>
                <asp:ImageButton ID="btnStaffRequest" runat="server" CssClass="Icons"  ImageUrl="~/images/staffingrequest.jpg" PostBackUrl="~/StaffRequest.aspx" Visible="False" />
            &nbsp;<asp:HyperLink ID="lnkStaffRequest" runat="server" Text="Staff Request" Visible="False"></asp:HyperLink>
            </p>
            
            <p>
                <asp:ImageButton ID="btnStaffPortal" runat="server" CssClass="Icons" ImageURL="~/images/staffportal.jpg"  PostBackUrl="~/StaffPortal.aspx" />
                &nbsp;<asp:HyperLink ID ="lnkStaffPortal" runat="server" Text="Staff Portal" NavigateUrl="~/StaffPortal.aspx"></asp:HyperLink>            
            </p>
        </div>
    </form>
    <div id ="footer"></div>
</body>
</html>
