<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffRequest.aspx.cs" Inherits="StaffRequest" %>

<!--StaffRequest Form Code TPS Website
//Programmed by: Markus Reynolds
//3/31/2019
//Open source avaiable under GNU License
//A GNU License should be included in the documentation for this code but you can also find it online
-->
<!DOCTYPE html>
<meta name="viewport" content="width=device-width, initial-scale=1">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staffing Request</title>
    <link rel="stylesheet" type="text/css" href="CSS/main.css" />
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script>
        //Add the header and footer bars
        $(function () {
            $("#header").load("addons/header.html");
            $("#footer").load("addons/footer.html");
        });
        function doValidation() {
            //Function Variable Scope
            let clientID;
            let type;
            let location;
            //Assignment
            clientID = $("#txtClientID").val();
            type = $("#txtType").val();
            location = $("#txtLocation").val();
            //Checks
            if (clientID == "" || clientID == REGEXNAME) {
                $("#error").text = "Please enter your ClientID";
            }
            else if (type == "" || type == REGEXNAME) {
                $("#error").text = "Please enter type";
            }
            else if (location == "" || location == REGEXNAME) {
                $("#error").text = "Please enter location";
            }
            else {
                $("#error").text = "";
            }
        }
    </script>
</head>
<body>
    <div id="header"></div>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton ID="btnHome" runat="server" ImageUrl="images/TPS_Logo_Small.jpg" PostBackUrl="~/Index.aspx" CssClass="Logo" />
            &nbsp;<br />
            <img src="images/staffingrequest.jpg" class="Icons" />
            <br />
            <h1>Staffing Request</h1>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Experience:" CssClass="Labels"></asp:Label>
                <asp:TextBox ID="txtExperience" runat="server" CssClass="Inputs"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label3" runat="server" Text="Education:" CssClass="Labels"></asp:Label>
                <asp:TextBox ID="txtEducation" runat="server" CssClass="Inputs"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Salary:" CssClass="Labels"></asp:Label>
                <asp:TextBox ID="txtSalary" runat="server" CssClass="Inputs"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Location:" CssClass="Labels"></asp:Label>
                <asp:TextBox ID="txtLocation" runat="server" CssClass="Inputs"></asp:TextBox>
            </p>

            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="OnButtonClick_btnSearch" />

            <br />
            <br />
            <br />
            <br />
            <br />
            <div class="w3-container w3-border w3-panel w3-pale-red">
                <p>
                    <asp:Label runat="server" ID="error"></asp:Label>
                </p>
            </div>
            <h3>Your Results:
            </h3>
            <p>
                <asp:GridView runat="server" ID="grdViewSearch" CssClass="w3-table-all w3-card-4" OnSelectedIndexChanged="OnSelectedIndexChanged"
                    OnRowCommand="grdViewSearch_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                        <asp:ButtonField ButtonType="Button" HeaderText="Add Staff to Request" ShowHeader="True" Text="Add" CommandName="AddStaff" />
                    </Columns>
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
            <h3>Your Request:
            </h3>
            <p>
                <asp:GridView runat="server" ID="grdViewRequest" CssClass="w3-table-all w3-card-4" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                <asp:Button ID="btnAdd" runat="server" Text="Add Staff Request" OnClick="OnButtonClick_AddStaffRequest" />
            </p>
        </div>
    </form>
    <div id="footer"></div>
</body>
</html>
