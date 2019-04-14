<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserManagement.aspx.cs" Inherits="UserManagement" %>
<!--UserManagement Form Code TPS Website
//Programmed by: Markus Reynolds
//3/31/2019
//Open source avaiable under GNU License
//A GNU License should be included in the documentation for this code but you can also find it online
-->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/main.css" />
    <title>User Management</title>
    <script src ="Scripts/jquery-3.3.1.min.js"></script>
    <script>
        //Add the header and footer bars
        $(function () {
            $("#header").load("addons/header.html");
            $("#footer").load("addons/footer.html");
        });
        function doValidation(){
            //Function Scope Variables
            let userName;
            let password;
            //Assignment
            firstName = $("#txtUserName").val();
            password = $("#txtPassword").val();
            //Test
            if (firstName == "" || REGEXNAME) {
                $("#error").text = "Please input a user name";
            }
            else if (password == "") {
                $("#error").text = "Please input a password";
            }
            else {
                $("#error").text = ""
            }
        }
    </script>
</head>
<body>
    <div id ="header"></div>
    <form id="frmUserManagement" runat="server">
        <div id ="Main">

            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/TPS_Logo_Small.jpg" PostBackUrl="~/Index.aspx" />
            <br />
            &nbsp;<img src="images/user.png" height="50" style="height: 86px; width: 92px" />
            <h1>User Management</h1>
            <h3>Add User</h3>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Name:" CssClass="Labels"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtUserName" runat="server" CssClass="Inputs"></asp:TextBox>
            </p>
            <p>
                &nbsp;<asp:Label ID="Label2" runat="server" CssClass="Labels" Text="Password: "></asp:Label>
                &nbsp;<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="Inputs"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label3" runat="server" Text="Access Code: "></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="Inputs">
                    <asp:ListItem Value ="0">Admin</asp:ListItem>
                    <asp:ListItem Value ="1">Manager</asp:ListItem>
                    <asp:ListItem Value ="2">Client</asp:ListItem>
                    <asp:ListItem Value="3">Staff</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                <asp:Label ID="error" runat="server" CssClass="Error" />
            </p>
            <p>
                <asp:Button ID="btnAddUser" runat="server" Text="Add" OnClick="OnButtonClick_AddUser" />
            </p>
            <h3>Current Users:</h3>
        </div>
        <div>
            <p>
                <asp:GridView ID="grdViewUsers" runat="server" CssClass="Grid" CellPadding="4" ForeColor="#333333" GridLines="None"
                    OnSelectedIndexChanged="OnSelectedIndexChanged" OnRowDeleting="OnRowDeleting" 
                    OnRowEditing="OnRowEditing"
                    OnRowCancelingEdit ="OnRowCancelingEdit" OnRowUpdating="OnRowUpdating">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
                        <asp:CommandField ShowEditButton="True" ButtonType="Button" />
                        <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
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
        </div>
    </form>
    <div id ="footer"></div>
</body>
</html>
