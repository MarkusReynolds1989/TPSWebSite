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
    protected void OnButtonClick_Login(object sender, EventArgs e)
    {
        try
        {
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            TPS.App_Code.clsDataLayer.VerifyUser(Server.MapPath("TPS.accdb"), UserName, Password);
        }
        catch (NullReferenceException)
        {
            error.Text = "Please fill out all forms";
        }
    }
}
