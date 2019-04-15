//Contracts Code TPS Website
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

public partial class Contracts : System.Web.UI.Page
{
    private static string ContractID { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindDataStaffRequest();
            BindDataContracts();
        }
    }

    protected void BindDataStaffRequest()
    {
        dsStaffRequest myDataSet = TPS.App_Code.clsDataLayer.AccessStaffRequests(Server.MapPath("TPS.accdb"));
        //set the datagrid to datasource based on table
        grdViewStaffRequests.DataSource = myDataSet.Tables["tblStaffRequest"];
        //the datagrid
        grdViewStaffRequests.DataBind();
    }

    protected void BindDataContracts()
    {
        dsContracts myDataSet = TPS.App_Code.clsDataLayer.AccessContracts(Server.MapPath("TPS.accdb"));
        //set the datagrid to datasource based on table
        grdViewContracts.DataSource = myDataSet.Tables["tblContract"];
        //the datagrid
        grdViewContracts.DataBind();
    }

    protected void btnAddRequest_Click(object sender, EventArgs e)
    {
        try
        {
            string RequestID = txtRequestID.Text;
            if (TPS.App_Code.clsDataLayer.ApproveRequest(Server.MapPath("TPS.accdb"), RequestID))
            {
                error.Text = "Successfully approved";
                if (TPS.App_Code.clsDataLayer.DeleteRequest(Server.MapPath("TPS.accdb"), RequestID))
                {
                    BindDataStaffRequest();
                    BindDataContracts();
                }
            }
            else
            {
                error.Text = "Failed to approve";
            }
        }
        catch (NullReferenceException)
        {
            error.Text = "Please input request ID";
        }
    }
    protected void OnSelectedIndexChanged(object sender, EventArgs e)
    {
        ContractID = grdViewContracts.SelectedRow.Cells[2].Text;
    }

    protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //Add try catch so user can't press this before select button
        //Catch System.NullReferenceException
        try
        {
            ContractID = grdViewContracts.SelectedRow.Cells[2].Text;
            if (TPS.App_Code.clsDataLayer.DeleteContract(Server.MapPath("TPS.accdb"), ContractID))
            {
                error.Text = "Successfully deleted contract";
                BindDataContracts();
            }
            else
            {
                error.Text = "Failed to delete contract";
            }
        }
        catch (NullReferenceException)
        {
            error.Text = "Select a row first";
        }
    }

    protected void btnDenyRequest_Click(object sender, EventArgs e)
    {
        string RequestID = txtRequestID.Text;
        if (TPS.App_Code.clsDataLayer.DeleteRequest(Server.MapPath("TPS.accdb"), RequestID)){
            error.Text = "Request denied successfully.";
            BindDataStaffRequest();
        }
        else
        {
            error.Text = "Failed to deny";
        }
    }
}
