<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffPortal.aspx.cs" Inherits="StaffPortal" %>

<!--StaffPortal Form Code TPS Website
//Programmed by: Markus Reynolds
//3/31/2019
//Open source avaiable under GNU License
//A GNU License should be included in the documentation for this code but you can also find it online
-->

<!DOCTYPE html>
<meta name="viewport" content="width=device-width, initial-scale=1">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Portal</title>
    <link rel="stylesheet" type="text/css" href="CSS/main.css" />
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
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
                <img src="images/staffportal.jpg" class="Icons" />
            </p>
            <h1>Staff Portal</h1>
            <p>
                <asp:Label runat="server" Text="Bio: " CssClass="Labels"></asp:Label>
                <asp:TextBox runat="server" CssClass="Inputs" ID="txtBio"></asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" Text="Availability: " CssClass="Labels"></asp:Label>
                <asp:TextBox runat="server" CssClass="Inputs" ID="txtAvail"></asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" Text="Resume: " CssClass="Labels"></asp:Label>
                <asp:FileUpload runat="server" CssClass="Inputs" ID="fileupResume"></asp:FileUpload>
            </p>
            <p>
                <asp:Label runat="server" Text="Picture: " CssClass="Labels"></asp:Label>
                <asp:FileUpload runat="server" CssClass="Inputs" ID="fileupPicture"></asp:FileUpload>
            </p>
            <p>
                <asp:Label runat="server" Text="StaffID: " CssClass="Labels" />
                <asp:TextBox runat="server" ID="txtStaffID" CssClass="Inputs" />
            </p>
            <p>
                <asp:Button runat="server" Text="Update" ID="btnUpdate" OnClick="btnUpdate_OnButtonClick" />
            </p>
            <div class="w3-container w3-border w3-panel w3-pale-red">
                <p>
                    <asp:Label runat="server" ID="error"></asp:Label>
                </p>
            </div>
            <p>
                <asp:GridView runat="server" ID="grdViewStaffPortal" CssClass="w3-table-all w3-card-4"
                    CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </p>
        </div>
    </form>
    <div id="footer"></div>
</body>
</html>
