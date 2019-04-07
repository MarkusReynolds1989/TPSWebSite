using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Staff : System.Web.UI.Page
{
    string MemberID;

    protected void Page_Load(object sender, EventArgs e)
    {
        dsStaff myDataSet = new dsStaff();
        myDataSet = TPS.App_Code.clsDataLayer.AccessStaff(Server.MapPath("TPS.accdb"));
        //set the datagrid to datasource based on table
        grdViewStaff.DataSource = myDataSet.Tables["tblStaffMember"];
        //the datagrid
        grdViewStaff.DataBind();
    }

    protected void AddStaff(object sender, EventArgs e)
    {
        //collect the text as variables
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string EduLevel = drpEduLevel.SelectedValue;
        string Experience = txtExperience.Text;
        string Salary = txtSalary.Text;
        //savestaff is a boolean to make sure our query is good
        if (TPS.App_Code.clsDataLayer.SaveStaff(Server.MapPath("TPS.accdb"), FirstName, LastName, EduLevel, Experience, Salary))
        {
            error.Text = "Successfully added staff member.";
            //bind the data so it displays after user enters
            grdViewStaff.DataBind();
        }
        else
        {
            error.Text = "Failed to add staff member.";
        }
    }

    //This section now works, it's still not updating the information correctly
    protected void OnSelectedIndexChanged(object sender, EventArgs e)
    {
        MemberID = grdViewStaff.SelectedRow.Cells[3].Text;
        error.Text = MemberID;
    }

    protected void OnRowDeleting(object sender, EventArgs e)
    {
        //Add try catch so user can't press this before select button
        //Catch System.NullReferenceException
        try
        {
            MemberID = grdViewStaff.SelectedRow.Cells[3].Text;
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
        catch (NullReferenceException)
        {
            error.Text = "Select a row first";
        }
    }
    protected void OnRowEditing(object sender, EventArgs e)
    {
        try
        {
            error.Text = "TEst";
        }
        catch (RowCancelingEdit)
        {

        }
    }

    protected void RowCancelingEdit(object sender, EventArgs e)
    {

    }
    
    protected void OnRowUpdating(object sender, EventArgs e)
    {

    }
}



