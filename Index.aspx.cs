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
            lnkUserManagement.Visible = true;
            btnStaff.Visible = true;
            lnkStaff.Visible = true;
            btnContracts.Visible = true;
            lnkContracts.Visible = true;
            btnStaffRequest.Visible = true;
            lnkStaffRequest.Visible = true;
            btnStaffPortal.Visible = true;
            lnkStaffPortal.Visible = true;
        }
        else if (Session["SecurityLevel"] == "1")
        {
            btnUser.Visible = false;
            lnkUserManagement.Visible = false;
            btnStaff.Visible = true;
            lnkStaff.Visible = true;
            btnContracts.Visible = true;
            lnkContracts.Visible = true;
            btnStaffRequest.Visible = false;
            lnkStaffRequest.Visible = false;
            btnStaffPortal.Visible = false;
            lnkStaffPortal.Visible = false;
        }
        else if (Session["SecurityLevel"] == "2")
        {
            btnUser.Visible = false;
            lnkUserManagement.Visible = false;
            btnStaff.Visible = false;
            lnkStaff.Visible = false;
            btnContracts.Visible = false;
            lnkContracts.Visible = false;
            btnStaffRequest.Visible = true;
            lnkStaffRequest.Visible = true;
            btnStaffPortal.Visible = false;
            lnkStaffPortal.Visible = false;
        }
        else
        {
            btnUser.Visible = false;
            lnkUserManagement.Visible = false;
            btnStaff.Visible = false;
            lnkStaff.Visible = false;
            btnContracts.Visible = false;
            lnkContracts.Visible = false;
            btnStaffRequest.Visible = false;
            lnkStaffRequest.Visible = false;
            btnStaffPortal.Visible = true;
            lnkStaffPortal.Visible = true;
        }

    }
}