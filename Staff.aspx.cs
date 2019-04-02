using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Staff : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
        {
            //btnAddStaff.Attributes.Add("onclick", "return false;");
            //how do we get btnAddStaff to work on click after the validation?
            dsStaff myDataSet = new dsStaff();
            myDataSet = TPS.App_Code.clsDataLayer.GetStaff(Server.MapPath("TPS.accdb"));
            //set the datagrid to datasource based on table
            grdViewStaff.DataSource = myDataSet.Tables["tblStaffMember"];
            //the datagrid
            grdViewStaff.DataBind();
        }

        protected void btnAddStaff_Click(object sender, EventArgs e)
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
}

