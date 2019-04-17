<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contracts.aspx.cs" Inherits="Contracts" %>

<!--Contracts Form Code TPS Website
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
    <title>Contracts</title>
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
<!-- This is the contract form that will show the contract database -->
<body>
    <div id="header"></div>
    <form id="frmContracts" runat="server">
        <p>
            <asp:ImageButton ID="btnHome" runat="server" ImageUrl="images/TPS_Logo_Small.jpg" PostBackUrl="~/Index.aspx" CssClass="Logo" />
        </p>
        <div id="Form">
            <p>
                <img src="images/contract.png" class="Icons" />
            </p>

            <h1>Requests List
            </h1>
            <p>
                <asp:GridView ID="grdViewStaffRequests" runat="server" CssClass="w3-table-all w3-card-4" CellPadding="4" ForeColor="#333333" GridLines="None">
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
            <p>
                <asp:Label runat="server" Text="RequestID" CssClass="Labels" />
                <asp:TextBox runat="server" ID="txtRequestID" CssClass="Inputs" />
            </p>
            <p>
                <asp:Button runat="server" ID="btnAddRequest" Text="Approve Contract" OnClick="btnAddRequest_Click" />
                <asp:Button runat="server" ID="btnDenyRequest" Text="Deny Contract" OnClick="btnDenyRequest_Click" />
            </p>
            <p>
                <asp:Label runat="server" ID="error" CssClass="Error" />
            </p>
            <h2>Approved Contracts
            </h2>
            <p>
                <asp:GridView ID="grdViewContracts" runat="server" CssClass="w3-table-all w3-card-4" CellPadding="4" ForeColor="#333333" GridLines="None"
                    OnSelectedIndexChanged="OnSelectedIndexChanged" OnRowDeleting="OnRowDeleting">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                        <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                    </Columns>
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
