//Index Code TPS Website
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

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //many elements should be hidden, depending on access level show the elements
        if (Session["SecurityLevel"] == "0")
        {
            btnUser.Visible = true;

            btnStaff.Visible = true;
            
            btnContracts.Visible = true;
            
            btnStaffRequest.Visible = true;
            
            btnStaffPortal.Visible = true;
            
        }
        else if (Session["SecurityLevel"] == "1")
        {
            btnUser.Visible = false;
            
            btnStaff.Visible = true;
            
            btnContracts.Visible = true;
            
            btnStaffRequest.Visible = false;
            
            btnStaffPortal.Visible = false;
            
        }
        else if (Session["SecurityLevel"] == "2")
        {
            btnUser.Visible = false;
            
            btnStaff.Visible = false;
            
            btnContracts.Visible = false;
            
            btnStaffRequest.Visible = true;
            
            btnStaffPortal.Visible = false;
            
        }
        else
        {
            btnUser.Visible = false;
            
            btnStaff.Visible = false;
            
            btnContracts.Visible = false;
            
            btnStaffRequest.Visible = false;
            
            btnStaffPortal.Visible = true;
            
        }

    }
}