 
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
         <h2Login
         </h2>
         <p>
            <asp:Login runat="server" ID="Login1" CssClass="Inputs" Login1_Authenticate="Login1_Authenticate" DestinationPageUrl="~/Index.aspx"/>
         </p>
      </form>
      <br />
      <br />
      <br />
      <div id ="footer"></div>
   </body>
</html>
