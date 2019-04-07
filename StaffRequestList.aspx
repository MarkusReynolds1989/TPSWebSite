﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffRequestList.aspx.cs" Inherits="StaffRequestList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Request List</title>
    <link rel="stylesheet" type="text/css" href="CSS/main.css" />
    <script src ="Scripts/jquery-3.3.1.min.js"></script>
    <script src ="Scripts/Globals.js"></script>
</head>
<body>
    <form id="frmStaff" runat="server">
        <div id ="Main">
            <p>
                <asp:ImageButton runat="server" ID ="btnHome" ImageURL="~/images/logo.bmp" PostBackURL="~/Index.aspx" CssClass ="Logo"/>
            </p>
            <p>
                <img src="images/staffrequestlist.png" class="Icons" />
            </p>
            <h1>
                Staffing Request List
            </h1>
            <p>
                <asp:GridView runat="server" ID="grdViewStaffRequestList" CssClass="Grid" 
                    OnSelectedIndexChanged="OnSelectedIndexChanged" OnRowDeleting="OnRowDeleting" OnRowUpdating="OnRowUpdating">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" ButtonType="Button"/>
                        <asp:CommandField ShowDeleteButton="True" ButtonType="Button"/>
                        <asp:CommandField ShowEditButton="True" ButtonType="Button"/>
                    </Columns>
                </asp:GridView>
            </p>
        </div>
    </form>
</body>
</html>
