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
    string StaffID1;
    string StaffID2;
    string StaffID3;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindDataSearch();
            BindDataRequests();
        }
    }

    protected void BindDataRequests()
    {
        dsStaffRequest myDataSet = new dsStaffRequest();
        myDataSet = TPS.App_Code.clsDataLayer.AccessStaffRequests(Server.MapPath("TPS.accdb"));
        //set the datagrid to datasource based on table
        grdViewSearch.DataSource = myDataSet.Tables["tblStaffRequest"];
        //the datagrid
        grdViewRequest.DataBind();
    }
    protected void BindDataSearch()
    {
        dsStaff myDataSet = new dsStaff();
        myDataSet = TPS.App_Code.clsDataLayer.AccessStaff(Server.MapPath("TPS.accdb"));
        //set the datagrid to datasource based on table
        grdViewSearch.DataSource = myDataSet.Tables["tblStaffMember"];
        //the datagrid
        grdViewSearch.DataBind();
    }

    protected void OnRowEvent_SelectRow(object sender, EventArgs e)
    {
        GridViewRow row = grdViewSearch.SelectedRow;
        StaffID1 = row.Cells[1].Text;
        StaffID2 = row.Cells[2].Text;
        StaffID3 = row.Cells[3].Text;
    }


    protected void OnButtonClick_AddStaff(object sender, EventArgs e)
    {
        if (TPS.App_Code.clsDataLayer.SaveStaffRequest(Server.MapPath("TPS.accdb"), StaffID1, StaffID2, StaffID3))
        {
            error.Text = "Successfully added";
            BindDataRequests();
            BindDataSearch();
        }
        else
        {
            error.Text = "Failed to add";
        }
    }

    protected void OnButtonClick_btnSearch(object sender, EventArgs e)
    {
        string Experience = txtExperience.Text;
        dsStaff myDataSet = new dsStaff();
        myDataSet = TPS.App_Code.clsDataLayer.SearchStaff(Server.MapPath("TPS.accdb"), Experience, null, null, null);
        grdViewSearch.DataSource = myDataSet.Tables["tblStaffMember"];
        grdViewSearch.DataBind();
    }
}

