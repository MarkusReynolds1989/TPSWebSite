//StaffRequest Code TPS Website
//Programmed by: Markus Reynolds
//3/31/2019
//Open source avaiable under GNU License
//A GNU License should be included in the documentation for this code but you can also find it online
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class StaffRequest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindDataSearch();
            BindDataRequests();
            error.Text = "";
        }
    }
    private static string StaffID1 { get; set; }
    private static string StaffID2 { get; set; }
    private static string StaffID3 { get; set; }

    protected void BindDataRequests()
    {
        dsStaffRequest myDataSet = new dsStaffRequest();
        myDataSet = TPS.App_Code.clsDataLayer.AccessStaffRequests(Server.MapPath("TPS.accdb"));
        //set the datagrid to datasource based on table
        grdViewRequest.DataSource = myDataSet.Tables["tblStaffRequest"];
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

    protected void OnSelectedIndexChanged(object sender, EventArgs e)
    {
        BindDataRequests();
        BindDataSearch();
    }

    protected void grdViewSearch_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "AddStaff")
            {
                if (StaffID3 == null || StaffID3.Trim() == "")
                {
                    GridViewRow row = grdViewSearch.SelectedRow;
                    StaffID3 = grdViewSearch.SelectedRow.Cells[2].Text;
                }
                else if (StaffID2 == null || StaffID2.Trim() == "")
                {
                    GridViewRow row = grdViewSearch.SelectedRow;
                    StaffID2 = grdViewSearch.SelectedRow.Cells[2].Text;
                }
                else if (StaffID1 == null || StaffID1.Trim() == "")
                {
                    GridViewRow row = grdViewSearch.SelectedRow;
                    StaffID1 = grdViewSearch.SelectedRow.Cells[2].Text;
                }
                else
                {
                    error.Text = "You have already selected : " + StaffID1 + ", " + StaffID2+ ", " + StaffID3;
                }
            }
        }
        catch (NullReferenceException)
        {
            error.Text = "Select staff first";
        }
    }


    protected void OnButtonClick_AddStaffRequest(object sender, EventArgs e)
    {
        try
        {
            if (TPS.App_Code.clsDataLayer.SaveStaffRequest(Server.MapPath("TPS.accdb"), StaffID1, StaffID2, StaffID3))
            {
                error.Text = "Successfully added request for approval.";
                BindDataRequests();
                BindDataSearch();
                StaffID1 = "";
                StaffID2 = "";
                StaffID3 = "";
                if(TPS.App_Code.clsBusinessLayer.SendEmail("markusreynolds1989@gmail.com", "marsatreus@gmail.com",null,null,"New Request","New Staff Request waiting, you have 48 hours to decide."))
                {

                }
                else
                {
                    error.Text = "Failed to send message.";
                }
            }
            else
            {
                error.Text = "Failed to add request.";
            }
        }
        catch (NullReferenceException)
        {
            error.Text = "Select row first";
        }
    }

    protected void OnButtonClick_btnSearch(object sender, EventArgs e)
    {
        try
        {
            string Experience = txtExperience.Text;
            string Edulevel = txtEducation.Text;
            string Salary = txtSalary.Text;
            string Location = txtLocation.Text;
            dsStaff myDataSet = new dsStaff();
            myDataSet = TPS.App_Code.clsDataLayer.SearchStaff(Server.MapPath("TPS.accdb"), Experience, Edulevel, Salary,Location);
            grdViewSearch.DataSource = myDataSet.Tables["tblStaffMember"];
            grdViewSearch.DataBind();
        }
        catch (NullReferenceException)
        {
            error.Text = "Please complete search field properly.";
        }
    }
}

