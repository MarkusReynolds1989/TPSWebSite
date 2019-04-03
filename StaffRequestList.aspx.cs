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
    protected void OnRowEvent_DeleteRow(object sender, EventArgs e)
    {
        GridViewRow row = dgStaffRequest.SelectedRow;
        // And you respective cell's value
        StaffID1 = row.Cells[1].Text;
    }
}
