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

    protected void Page_Load(object sender, EventArgs e)
        {
        if (!Page.IsPostBack)
        {
            dsStaff myDataSet = new dsStaff();
            myDataSet = TPS.App_Code.clsDataLayer.AccessStaff(Server.MapPath("TPS.accdb"));
            //set the datagrid to datasource based on table
            grdViewStaff.DataSource = myDataSet.Tables["tblStaffMember"];
            //the datagrid
        }
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

    protected void grdViewStaff_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = grdViewStaff.SelectedRow;
        string MemberID = row.Cells[1].Text;
        //this works, we just need to find out how to the get the selected row
        if (TPS.App_Code.clsDataLayer.DeleteStaff(Server.MapPath("TPS.accdb"),MemberID))
        {
            error.Text = "Successful delete";
            grdViewStaff.DataBind();
        }
        else
        {
            error.Text = "Delete Failed";
        }
    }
}



