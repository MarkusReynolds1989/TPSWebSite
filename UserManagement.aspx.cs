//UserManagement Code TPS Website
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

public partial class UserManagement : System.Web.UI.Page
{
    private string UserID { get; set; }

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
    protected void OnSelectedIndexChanged(object sender, EventArgs e)
    {
        UserID = grdViewUsers.SelectedRow.Cells[3].Text;
        error.Text = UserID;
    }

    protected void OnRowDeleting(object sender, EventArgs e)
    {
        //Add try catch so user can't press this before select button
        //Catch System.NullReferenceException
        try
        {
            UserID= grdViewUsers.SelectedRow.Cells[3].Text;
            if (TPS.App_Code.clsDataLayer.DeleteUser(Server.MapPath("TPS.accdb"), UserID))
            {
                error.Text = "Successfully deleted user";
                BindData();
            }
            else
            {
                error.Text = "Failed to delete user";
            }
        }
        catch (NullReferenceException)
        {
            error.Text = "Select a row first";
        }
    }


}