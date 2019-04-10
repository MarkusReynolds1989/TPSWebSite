<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffRequest.aspx.cs" Inherits="StaffRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staffing Request</title>
    <link rel ="stylesheet" type ="text/css" href="CSS/main.css" />
    <script src ="Scripts/jquery-3.3.1.min.js"></script>
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
    <div id ="header"></div>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton ID="btnHome" runat="server" ImageUrl="images/TPS_Logo_Small.jpg" PostBackUrl="~/Index.aspx" CssClass="Logo" />
&nbsp;<br />
            <img src ="images/staffingrequest.jpg" class="Icons" />
            <br />
            <h1>Staffing Request</h1>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Experience:" CssClass ="Labels"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtExperience" runat="server" CssClass ="Inputs"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label3" runat="server" Text="Education:" CssClass ="Labels"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtEducation" runat="server" CssClass ="Inputs"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Salary:" CssClass ="Labels"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtSalary" runat="server" CssClass ="Inputs"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Location:" CssClass ="Labels"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtLocation" runat="server" CssClass ="Inputs"></asp:TextBox>
            </p>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="OnButtonClick_btnSearch" />
            <br />
            <p>
                <asp:Label ID ="error" runat="server" CssClass="Error" ></asp:Label>
            </p>
            <h3>
                Your Results:
            </h3>
            <p>
                <asp:GridView runat="server" ID="grdViewSearch" CssClass="Grid" OnSelectedIndexChanged="OnSelectedIndexChanged"
                    OnRowCommand="grdViewSearch_RowCommand">
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                        <asp:ButtonField ButtonType="Button" HeaderText="Add Staff to Request" ShowHeader="True" Text="Add" CommandName="AddStaff" />
                    </Columns>
                </asp:GridView>
            </p>
            <h3>
                Your Request:
            </h3>
            <p>
                <asp:GridView runat="server" ID="grdViewRequest" CssClass="Grid">
                </asp:GridView>
           </p>
            <p>
                <asp:Button ID ="btnAdd" runat ="server" Text="Add Staff Request" OnClick="OnButtonClick_AddStaffRequest" />
            </p>
        </div>
    </form>
    <div id ="footer"></div>
</body>
</html>
