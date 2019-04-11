//Staff Code TPS Website
//Programmed by: Markus Reynolds
//3/31/2019
//Open source avaiable under GNU License
//A GNU License should be included in the documentation for this code but you can also find it online
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
        if (!Page.IsPostBack)
        {
            BindData();
        }
    }
    protected void BindData()
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
        try
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
                BindData();
            }
            else
            {
                error.Text = "Failed to add staff member.";
            }
        }
        catch (NullReferenceException)
        {
            error.Text = "Please fully complete the form";
        }
    }

    //This section now works, it's still not updating the information correctly
    protected void OnSelectedIndexChanged(object sender, EventArgs e)
    {
        MemberID = grdViewStaff.SelectedRow.Cells[3].Text;
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
                error.Text = "Successfully deleted staff";
                BindData();
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


    }

    protected void OnRowCancelingEdit(object sender, EventArgs e)
    {
        grdViewStaff.EditIndex = -1; //swicth back to default mode
        BindData(); // Rebind GridView to show the data in default mode
        error.Text = "";
    }

    protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {
            MemberID = grdViewStaff.SelectedRow.Cells[3].Text;
            string FirstName = grdViewStaff.SelectedRow.Cells[4].Text;
            string LastName = grdViewStaff.SelectedRow.Cells[5].Text;
            string EduLevel = grdViewStaff.SelectedRow.Cells[6].Text;
            string Experience = grdViewStaff.SelectedRow.Cells[7].Text;
            string Salary = grdViewStaff.SelectedRow.Cells[8].Text;
            if (TPS.App_Code.clsDataLayer.UpdateStaff(Server.MapPath("TPS.accdb"), MemberID, FirstName, LastName, EduLevel, Experience, Salary))
            {
                error.Text = "Successfully Updated";
                BindData();
                grdViewStaff.EditIndex = -1;
            }
            else
            {
                error.Text = "Update failed";
            }
        }

        catch (NullReferenceException)
        {
            error.Text = "Select first";
        }
    }
}



