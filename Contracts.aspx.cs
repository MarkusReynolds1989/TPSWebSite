using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contracts : System.Web.UI.Page
{
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
        dsStaffRequest myDataSet = new dsStaffRequest();
        myDataSet = TPS.App_Code.clsDataLayer.AccessStaffRequests(Server.MapPath("TPS.accdb"));
        //set the datagrid to datasource based on table
        grdViewStaffRequests.DataSource = myDataSet.Tables["tblStaffRequest"];
        //the datagrid
        grdViewStaffRequests.DataBind();
    }
    protected void BindDataContracts()
    {
        dsContracts myDataSet = new dsContracts();
        myDataSet = TPS.App_Code.clsDataLayer.AccessContracts(Server.MapPath("TPS.accdb"));
        //set the datagrid to datasource based on table
        grdViewContracts.DataSource = myDataSet.Tables["tblContract"];
        //the datagrid
        grdViewContracts.DataBind();
    }

}