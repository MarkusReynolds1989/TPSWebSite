using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffRequestList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void OnSelectedIndexChanged(object sender, EventArgs e)
    {
        MemberID = grdViewStaff.SelectedRow.Cells[3].Text;
        error.Text = MemberID;
    }

    protected void OnRowDeleting(object sender, EventArgs e)
    {
        MemberID = grdViewStaff.SelectedRow.Cells[2].Text;
        if (TPS.App_Code.clsDataLayer.DeleteStaff(Server.MapPath("TPS.accdb"), MemberID))
        {
            error.Text = "Successfully delete staff";
            grdViewStaff.DataBind();
        }
        else
        {
            error.Text = "Failed to delete staff";
        }
    }
}
