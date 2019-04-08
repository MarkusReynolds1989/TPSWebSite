 
Formatted HTML:
﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>
<!DOCTYPE html>
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
         <H2>
            Login
         </H2>
         <p>
            <asp:Label runat="server" Text = "Username: " CssClass="Labels"/>
            <asp:TextBox runat="server" ID = "txtUserName" CssClass="Inputs"/>
         </p>
         <p>
            <asp:Label runat="server" Text = "Password: " CssClass = "Labels"/>
            <asp:TextBox runat="server" ID= "txtPassword" CssClass = "Inputs"/>
         </p>
         <p>
            <asp:Button runat=server" Text="Login" OnButtonClick="OnButtonClick_Login"/>
         </p>
      </form>
      <br />
      <br />
      <br />
      <div id ="footer"></div>
   </body>
</html>
