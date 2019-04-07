using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contracts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Use AccessContracts() to fill the grdViewContracts table, managers can all share contracts
        //Use AccessStaffRequests() to fill the grdViewStaffRequests gridview
    }
    //add in two methods, both protected void
    //one method should be something like 
    //grdViewStaffRequest_OnRowDeny()
    //grdViewStaffRequest_OnRowApprove()

}