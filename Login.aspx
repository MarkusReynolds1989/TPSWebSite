<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!--Login Form Code TPS Website
//Programmed by: Markus Reynolds
//3/31/2019
//Open source avaiable under GNU License
//A GNU License should be included in the documentation for this code but you can also find it online
-->
<!DOCTYPE html>
<meta name="viewport" content="width=device-width, initial-scale=1">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <!-- Main Css Sheet -->
    <link rel="stylesheet" type="text/css" href="CSS/main.css" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script>
        //Add the header and footer bars
        $(function () {
            $("#footer").load("addons/footer.html");
        });
         //Use Built in Validation
    </script>
</head>
<body>
    <form id="lgn" runat="server">
        <img class="Logo" src="images/TPS_Logo_Small.jpg" />
        &nbsp;
        <br />
        <br />
        <br />
        <h2>Login
        </h2>
        <p>
            <asp:Login runat="server" ID="Login1" CssClass="Inputs" OnAuthenticate="Login1_Authenticate" DestinationPageUrl="~/Index.aspx" />
        </p>
        <p>
            <asp:Label runat="server" ID="error" CssClass="Error" />
        </p>
    </form>
    <br />
    <br />
    <br />
    <div id="footer"></div>
</body>
</html>
