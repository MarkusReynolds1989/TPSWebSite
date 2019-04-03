using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Eddie, this page needs to open up with the client ID already known,
//I mean that it should be saved from the login and in use here
public partial class StaffRequest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void OnRowEvent_SelectRow(object sender, EventArgs e)
    {
        //Eddie, check this out and let me know what you think
        //We need to get the information from the currently selected row and pass it to
        //The staffrequest table to build it, we can use this as a base and hack it
        int StaffID1;
        int StaffID2;
        int StaffID3;
        //Get the currently selected row using the SelectedRow property.
        GridViewRow row = grdViewStaffRequest.SelectedRow;
        // And you respective cell's value
        StaffID1 = row.Cells[1].Text;
    }
    protected void OnButtonClick_btnAddStaff(object sender, EventArgs e)
    {
        AddStaffRequest(StaffID1,StaffID2,StaffID3);
    }
}
