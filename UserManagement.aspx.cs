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
        grdViewUsers.DataSource = myDataSet.Tables["tblUserAccess"];
        //the datagrid
        grdViewUsers.DataBind();
    }
    protected void OnButtonClick_AddUser(object sender, EventArgs e)
    {
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        string SecurityLevel = DropDownList1.SelectedValue;
        if (TPS.App_Code.clsDataLayer.SaveUser(Server.MapPath("TPS.accdb"), UserName, Password, SecurityLevel))
        {
            error.Text = "Successfully added user";
            BindData();
        }
        else
        {
            error.Text = "Plese fill out all fields";
        }
    }

    
}