using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ///Setup access level, code in other file
    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        {
            // Add your comments here
            dsUserAccess dsUserAccess;

            string SecurityLevel;
  
            dsUserAccess = TPS.App_Code.clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.accdb"),
            Login1.UserName, Login1.Password);

            if (dsUserAccess.tblUserAccess.Count < 1)
            {
                e.Authenticated = false;
                return;
            }
          
            SecurityLevel = dsUserAccess.tblUserAccess[0].SecurityLevel.ToString();
         
            switch (SecurityLevel)
            {
                case "A":
                   
                    e.Authenticated = true;
                    Session["SecurityLevel"] = "0";
                    break;
                case "U":
               
                    e.Authenticated = true;
                    Session["SecurityLevel"] = "1";
                    break;
                default:
                    e.Authenticated = false;
                    break;
            }
        }
    }
}
