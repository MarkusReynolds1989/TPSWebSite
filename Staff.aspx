<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff.aspx.cs" Inherits="Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        Staff
    </title>
    <link rel="stylesheet" type="text/css" href="CSS/main.css" />
    <script src ="Scripts/jquery-3.3.1.min.js"></script>
    <script src ="Scripts/Globals.js"></script>
    <script>
        //Add the header and footer bars
        $(function () {
            $("#header").load("addons/header.html");
            $("#footer").load("addons/footer.html");
        });
        //Use this commit
        //Generic validation function we will be using in all the forms
        function doValidation() {
            //Declare our variables for the function
            let firstName;
            let lastName;
            let salary;
            //regex variables to check the text
            //consider making these global
            //set the variables from the fields
            firstName = $("#txtFirstName").val();
            lastName = $("#txtLastName").val();
            salary = $("#txtSalary").val();
            //test to make sure all the fields are entered correctly
            if (firstName == "" || firstName == REGEXNAME) {
                $("#error").text("Please enter first name.");
            }
            else if (lastName == "" || lastName == REGEXNAME) {
                $("#error").text("Please enter last name.");
            }
            else if (salary == "" || salary == REGEXCURRENCY) {
                $("#error").text("Please enter salary");
            }
            else {
                $("#error").text("");
                return true;
            }
        }
    </script>

</head>
<body>
    <div id="header"></div>
    <form id="frmStaff" runat="server">
        <div id="Form">
            <p>
                <asp:ImageButton ID="imgHome" runat="server" ImageUrl="images/TPS_Logo_Small.jpg" PostBackUrl="~/Index.aspx" CssClass="Logo" />
&nbsp;</p>
            <p>
                <img src ="images/staff.jpg" class ="Icons" />
            </p>
            <h1>Staff</h1>
            <h2>Add Staff</h2>
            <p>
                <asp:Label runat="server" Text = "First Name: " CssClass ="Labels"></asp:Label>
                &nbsp; <asp:TextBox runat="server" CssClass ="Inputs" ID="txtFirstName" Height="22px"></asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" Text ="Last Name: " CssClass ="Labels"></asp:Label>
                &nbsp; <asp:TextBox runat="server" CssClass ="Inputs" ID ="txtLastName"></asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" Text ="Education Level: " CssClass ="Labels"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList runat="server" CssClass ="Inputs" ID ="drpEduLevel">
                    <asp:ListItem Value="High School">High School</asp:ListItem>
                    <asp:ListItem Value="Bachelor">Bachelor</asp:ListItem>
                    <asp:ListItem Value="Masters">Masters</asp:ListItem>
                    <asp:ListItem Value="Doctorate">Doctorate</asp:ListItem>
                    <asp:ListItem Value="Some College">Some College</asp:ListItem>
                </asp:DropDownList>
            </p>
             <p>
                 <asp:Label runat="server" Text ="Experience: " CssClass ="Labels"></asp:Label>
                &nbsp; <asp:TextBox runat="server" CssClass ="Inputs" ID ="txtExperience"></asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" Text ="Salary: " CssClass ="Labels"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" CssClass ="Inputs" ID ="txtSalary"></asp:TextBox>
            </p>
            <p>
                <asp:Button runat="server" Text="Add Staff" ID="btnAddStaff" OnClick ="btnAddStaff_Click" /> <!-- on client click is where the script runs -->
            </p>
            <p>
                <asp:Label runat ="server" ID ="error" CssClass ="Error"></asp:Label>
            </p>
            <h2>
                Current Staff:
            </h2>
            <p>
                <asp:GridView runat="server" ID="grdViewStaff" CssClass ="Grid" CellPadding="4" ForeColor="#333333" GridLines="None"
                    OnRowDeleting="grdViewStaff_RowDeleting">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
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