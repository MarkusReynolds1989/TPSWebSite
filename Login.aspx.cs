//Login Code TPS Website
//Programmed by: Markus Reynolds
//3/31/2019
//Open source avaiable under GNU License
//A GNU License should be included in the documentation for this code but you can also find it online
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

            try
            {
                dsUserAccess = TPS.App_Code.clsDataLayer.VerifyUser(Server.MapPath("TPS.accdb"),
                Login1.UserName, Login1.Password);

                SecurityLevel = dsUserAccess.tblUserAccess[3].SecurityLevel.ToString();

                switch (SecurityLevel)
                {
                    case "0":
                        e.Authenticated = true;
                        Session["SecurityLevel"] = "0";
                        break;

                    case "1":

                        e.Authenticated = true;
                        Session["SecurityLevel"] = "1";
                        break;

                    case "2":
                        e.Authenticated = true;
                        Session["SecurityLevel"] = "2";
                        break;

                    case "3":
                        e.Authenticated = true;
                        Session["SecuirtyLevel"] = "3";
                        break;

                    default:
                        error.Text = "login failed";
                        e.Authenticated = false;
                        break;
                }
            }
            catch (NullReferenceException)
            {
                error.Text = "Incorrect login credintials.";
            }
        }
    }
}
