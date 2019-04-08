using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserManagement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Eddie
        //Fill the gridView for Users here
        if (!IsPostBack)
        {
            BindData();
        }

    }
    protected void BindData()
    {
        dsUserAccess myDataSet = new dsUserAccess();
        myDataSet = TPS.App_Code.clsDataLayer.AccessUsers(Server.MapPath("TPS.accdb"));
        //set the datagrid to datasource based on table
        grdViewUsers.DataSource = myDataSet.Tables["tblStaffMember"];
        //the datagrid
        grdViewUsers.DataBind();
    }


    //Add the method for selecting here (TPS.App_Code.clsDatalayer.SaveUser(Server.MapPath("TPS.accdb")UserID,Password,etc)

    //add the method for deleting
    //Add method for updating
}