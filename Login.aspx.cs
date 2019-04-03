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

    }
    protected void OnButtonClick_btnAddStaff(object sender, EventArgs e)
    {
        //Eddie, check this out and let me know what you think
        //We need to get the information from the currently selected row and pass it to
        //The staffrequest table to build it, we can use this as a base and hack it
        //Get the currently selected row using the SelectedRow property.
        GridViewRow row = dgCustomer.SelectedRow;

        // And you respective cell's value
        TextBox1.Text = row.Cells[1].Text
}
