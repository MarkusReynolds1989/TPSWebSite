<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contracts.aspx.cs" Inherits="Contracts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel ="stylesheet" type ="text/css" href="CSS/main.css" />
    <title>Contracts</title>
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
    <!-- This is the contract form that will show the contract database -->
<body>
    <div id ="header"></div>
    <form id="frmContracts" runat="server">
    <p>
        <asp:ImageButton ID="btnHome" runat="server" ImageUrl="images/TPS_Logo_Small.jpg" PostBackUrl="~/Index.aspx" CssClass="Logo" />
&nbsp;</p>
        <div id ="Form">   
            <p>
                <img src ="images/contract.png" class ="Icons"/>
            </p>
            
           <h1>
               Requests List
            </h1>
            <p>
                <asp:GridView ID="grdViewStaffRequests" runat="server" CssClass="Grid"/>
            </p>
            <p>
                <asp:Label runat="server" Text="RequestID" CssClass="Labels"/>
                <asp:TextBox runat="server" ID="txtRequestID" CssClass="Inputs"/>
            </p>
            <p>
                <asp:Button runat="server" ID="btnAddRequest" Text="Approve Contract" OnClick="btnAddRequest_Click" />
            </p>
            <p>
                <asp:Label ID="error" runat="server" CssClass="Error"></asp:Label>
            </p>
            <h2> 
                Approved Contracts
            </h2>
            <p>
            <asp:GridView ID ="grdViewContracts" runat="server" CssClass="Grid" />
            </p>
        </div>
    </form>
    <div id ="footer"></div>
    </body>
</html>
